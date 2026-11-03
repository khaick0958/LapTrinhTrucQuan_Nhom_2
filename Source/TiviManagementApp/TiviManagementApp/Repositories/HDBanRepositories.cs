using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using TiviManagementApp.Data;
using TiviManagementApp.Models;

namespace TiviManagementApp.Repositories
{
    internal class HDBanRepositories
    {
        public List<NhanVienItem> GetAllNhanVien()
        {
            List<NhanVienItem> list = new List<NhanVienItem>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"
                    SELECT MaNV, HoTen
                    FROM NhanVien
                    ORDER BY HoTen";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new NhanVienItem
                            {
                                MaNV = reader["MaNV"].ToString(),
                                HoTen = reader["HoTen"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

        public List<KhachHangItem> GetAllKhachHang()
        {
            List<KhachHangItem> list = new List<KhachHangItem>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"
                    SELECT MaKhach, TenKhach
                    FROM KhachHang
                    ORDER BY TenKhach";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new KhachHangItem
                            {
                                MaKhach = reader["MaKhach"].ToString(),
                                TenKhach = reader["TenKhach"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

        public List<TiviBanItem> GetAllTiviConHang()
        {
            List<TiviBanItem> list = new List<TiviBanItem>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"
                    SELECT MaTivi, TenTivi, SoLuong, GiaBan
                    FROM Tivi
                    WHERE SoLuong > 0
                    ORDER BY TenTivi";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new TiviBanItem
                            {
                                MaTivi = reader["MaTivi"].ToString(),
                                TenTivi = reader["TenTivi"].ToString(),
                                SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                GiaBan = Convert.ToDecimal(reader["GiaBan"])
                            });
                        }
                    }
                }
            }

            return list;
        }

        public bool LuuHoaDonBan(
            string soHDB,
            string maNV,
            string maKhach,
            DateTime ngayBan,
            decimal thue,
            List<ChiTietBanTam> chiTietList)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlHoaDon = @"
                            INSERT INTO HoaDonBan
                                (SoHDB, MaNV, MaKhach, NgayBan, Thue, TongTien)
                            VALUES
                                (@SoHDB, @MaNV, @MaKhach, @NgayBan, @Thue, 0)";

                        using (SqlCommand cmd = new SqlCommand(
                            sqlHoaDon, conn, transaction))
                        {
                            cmd.Parameters.Add("@SoHDB", SqlDbType.VarChar, 15).Value = soHDB;
                            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar, 10).Value = maNV;
                            cmd.Parameters.Add("@MaKhach", SqlDbType.VarChar, 10).Value = maKhach;
                            cmd.Parameters.Add("@NgayBan", SqlDbType.Date).Value = ngayBan.Date;
                            cmd.Parameters.Add("@Thue", SqlDbType.Decimal).Value = thue;
                            cmd.Parameters["@Thue"].Precision = 5;
                            cmd.Parameters["@Thue"].Scale = 2;

                            cmd.ExecuteNonQuery();
                        }

                        foreach (ChiTietBanTam ct in chiTietList)
                        {
                            string sqlKiemTra = @"
                                SELECT SoLuong, GiaBan
                                FROM Tivi WITH (UPDLOCK, HOLDLOCK)
                                WHERE MaTivi = @MaTivi";

                            int soLuongTon;
                            decimal giaBan;

                            using (SqlCommand cmd = new SqlCommand(
                                sqlKiemTra, conn, transaction))
                            {
                                cmd.Parameters.Add("@MaTivi", SqlDbType.VarChar, 10).Value = ct.MaTivi;

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (!reader.Read())
                                        throw new Exception(
                                            "Không tìm thấy Tivi có mã " + ct.MaTivi);

                                    soLuongTon = Convert.ToInt32(reader["SoLuong"]);
                                    giaBan = Convert.ToDecimal(reader["GiaBan"]);
                                }
                            }

                            if (ct.SoLuong > soLuongTon)
                            {
                                throw new Exception(
                                    "Tivi " + ct.MaTivi +
                                    " chỉ còn " + soLuongTon + " chiếc trong kho.");
                            }

                            string sqlChiTiet = @"
                                INSERT INTO ChiTietHoaDonBan
                                    (SoHDB, MaTivi, SoLuong, DonGia, GiamGia)
                                VALUES
                                    (@SoHDB, @MaTivi, @SoLuong, @DonGia, 0)";

                            using (SqlCommand cmd = new SqlCommand(
                                sqlChiTiet, conn, transaction))
                            {
                                cmd.Parameters.Add("@SoHDB", SqlDbType.VarChar, 15).Value = soHDB;
                                cmd.Parameters.Add("@MaTivi", SqlDbType.VarChar, 10).Value = ct.MaTivi;
                                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ct.SoLuong;

                                SqlParameter donGiaParam =
                                    cmd.Parameters.Add("@DonGia", SqlDbType.Decimal);

                                donGiaParam.Precision = 18;
                                donGiaParam.Scale = 2;
                                donGiaParam.Value = giaBan;

                                cmd.ExecuteNonQuery();
                            }
                        }

                        string sqlTongTien = @"
                            UPDATE HoaDonBan
                            SET TongTien =
                            (
                                SELECT ISNULL(SUM(ThanhTien), 0)
                                FROM ChiTietHoaDonBan
                                WHERE SoHDB = @SoHDB
                            ) * (1 + @Thue / 100.0)
                            WHERE SoHDB = @SoHDB";

                        using (SqlCommand cmd = new SqlCommand(
                            sqlTongTien, conn, transaction))
                        {
                            cmd.Parameters.Add("@SoHDB", SqlDbType.VarChar, 15).Value = soHDB;

                            SqlParameter thueParam =
                                cmd.Parameters.Add("@Thue", SqlDbType.Decimal);

                            thueParam.Precision = 5;
                            thueParam.Scale = 2;
                            thueParam.Value = thue;

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
