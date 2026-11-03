using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TiviManagementApp.Data;
using TiviManagementApp.Models;

namespace TiviManagementApp.Repositories
{
    internal class HDNhapRepositories
    {
        public int GetTotalHDNs()
        {
            string sql = "SELECT COUNT(SoHDN) FROM HoaDonNhap;";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public List<HoaDonNhap> GetAll()
        {
            List<HoaDonNhap> danhSach = new List<HoaDonNhap>();

            string sql = @"
        SELECT
            hd.SoHDN,
            hd.MaNV,
            hd.MaNCC,
            hd.NgayNhap,
            hd.TongTien
        FROM HoaDonNhap hd
        INNER JOIN NhanVien nv ON hd.MaNV = nv.MaNV
        INNER JOIN NhaCungCap ncc ON hd.MaNCC = ncc.MaNCC
        ORDER BY hd.NgayNhap DESC;";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HoaDonNhap hdn = new HoaDonNhap
                        {
                            SoHDN = reader["SoHDN"].ToString() ?? "",
                            MaNV = reader["MaNV"].ToString() ?? "",
                            MaNCC = reader["MaNCC"].ToString() ?? "",
                            NgayNhap = Convert.ToDateTime(reader["NgayNhap"]),
                            TongTien = Convert.ToDecimal(reader["TongTien"])
                        };

                        danhSach.Add(hdn);
                    }
                }
            }

            return danhSach;
        }

        public List<CTHDNDetail> GetAllCTHDN()
        {
            List<CTHDNDetail> danhSach = new List<CTHDNDetail>();

            string sql = @"
        SELECT
            hd.SoHDN,
            hd.NgayNhap,
            ct.MaTivi,
            t.TenTivi,
            ct.SoLuong,
            ct.DonGia,
            ct.GiamGia,
            ct.ThanhTien
        FROM ChiTietHoaDonNhap ct
        INNER JOIN HoaDonNhap hd
            ON ct.SoHDN = hd.SoHDN
        INNER JOIN Tivi t
            ON ct.MaTivi = t.MaTivi
        ORDER BY hd.NgayNhap DESC, hd.SoHDN;";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CTHDNDetail item = new CTHDNDetail
                        {
                            SoHDN = reader["SoHDN"].ToString() ?? "",
                            NgayNhap = Convert.ToDateTime(reader["NgayNhap"]),
                            MaTivi = reader["MaTivi"].ToString() ?? "",
                            TenTivi = reader["TenTivi"].ToString() ?? "",
                            SoLuong = Convert.ToInt32(reader["SoLuong"]),
                            DonGia = Convert.ToDecimal(reader["DonGia"]),
                            GiamGia = Convert.ToDecimal(reader["GiamGia"]),
                            ThanhTien = Convert.ToDecimal(reader["ThanhTien"])
                        };

                        danhSach.Add(item);
                    }
                }
            }

            return danhSach;
        }

        public List<CTHDNDetail> SearchCTHDN(string? maTivi, int? soLuong)
        {
            List<CTHDNDetail> danhSach = new List<CTHDNDetail>();

            string sql = @"
        SELECT
            hd.SoHDN,
            hd.NgayNhap,
            ct.MaTivi,
            t.TenTivi,
            ct.SoLuong,
            ct.DonGia,
            ct.GiamGia,
            ct.ThanhTien
        FROM ChiTietHoaDonNhap ct
        INNER JOIN HoaDonNhap hd
            ON ct.SoHDN = hd.SoHDN
        INNER JOIN Tivi t
            ON ct.MaTivi = t.MaTivi
        WHERE
            (@MaTivi IS NULL OR @MaTivi = '' OR ct.MaTivi = @MaTivi)
            AND (@SoLuong IS NULL OR ct.SoLuong = @SoLuong)
        ORDER BY hd.NgayNhap DESC, hd.SoHDN;";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@MaTivi",
                        string.IsNullOrWhiteSpace(maTivi)
                            ? DBNull.Value
                            : maTivi.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@SoLuong",
                        soLuong.HasValue
                            ? soLuong.Value
                            : DBNull.Value
                    );

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CTHDNDetail item = new CTHDNDetail
                            {
                                SoHDN = reader["SoHDN"].ToString() ?? "",
                                NgayNhap = Convert.ToDateTime(reader["NgayNhap"]),
                                MaTivi = reader["MaTivi"].ToString() ?? "",
                                TenTivi = reader["TenTivi"].ToString() ?? "",
                                SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                DonGia = Convert.ToDecimal(reader["DonGia"]),
                                GiamGia = Convert.ToDecimal(reader["GiamGia"]),
                                ThanhTien = Convert.ToDecimal(reader["ThanhTien"])
                            };

                            danhSach.Add(item);
                        }
                    }
                }
            }

            return danhSach;
        }

        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> danhSach = new List<NhanVien>();

            string sql = @"
        SELECT MaNV, HoTen, GioiTinh, NgaySinh,
               DienThoai, DiaChi, MaCa, MaCV
        FROM NhanVien
        ORDER BY HoTen;";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NhanVien nv = new NhanVien
                        {
                            MaNV = reader["MaNV"].ToString() ?? "",
                            HoTen = reader["HoTen"].ToString() ?? "",
                            GioiTinh = reader["GioiTinh"] == DBNull.Value
                                ? null : reader["GioiTinh"].ToString(),
                            NgaySinh = reader["NgaySinh"] == DBNull.Value
                                ? null : Convert.ToDateTime(reader["NgaySinh"]),
                            DienThoai = reader["DienThoai"] == DBNull.Value
                                ? null : reader["DienThoai"].ToString(),
                            DiaChi = reader["DiaChi"] == DBNull.Value
                                ? null : reader["DiaChi"].ToString(),
                            MaCa = reader["MaCa"] == DBNull.Value
                                ? null : reader["MaCa"].ToString(),
                            MaCV = reader["MaCV"] == DBNull.Value
                                ? null : reader["MaCV"].ToString()
                        };

                        danhSach.Add(nv);
                    }
                }
            }

            return danhSach;
        }

        public List<NhaCungCap> GetAllNhaCungCap()
        {
            List<NhaCungCap> danhSach = new List<NhaCungCap>();

            string sql = @"
        SELECT MaNCC, TenNCC, DiaChi, DienThoai
        FROM NhaCungCap
        ORDER BY TenNCC;";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NhaCungCap ncc = new NhaCungCap
                        {
                            MaNCC = reader["MaNCC"].ToString() ?? "",
                            TenNCC = reader["TenNCC"].ToString() ?? "",
                            DiaChi = reader["DiaChi"] == DBNull.Value
                                ? null : reader["DiaChi"].ToString(),
                            DienThoai = reader["DienThoai"] == DBNull.Value
                                ? null : reader["DienThoai"].ToString()
                        };

                        danhSach.Add(ncc);
                    }
                }
            }

            return danhSach;
        }

        public ThongTinTiviGiaoDich? KiemTraTiviDaNhap(string maTivi)
        {
            string sql = @"
        SELECT TOP 1
            hd.MaNCC,
            t.GiaNhap
        FROM ChiTietHoaDonNhap ct
        INNER JOIN HoaDonNhap hd
            ON ct.SoHDN = hd.SoHDN
        INNER JOIN Tivi t
            ON ct.MaTivi = t.MaTivi
        WHERE ct.MaTivi = @MaTivi
        ORDER BY hd.NgayNhap DESC, hd.SoHDN DESC;";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaTivi", maTivi);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ThongTinTiviGiaoDich
                            {
                                MaNCC = reader["MaNCC"].ToString(),
                                GiaNhap = Convert.ToDecimal(reader["GiaNhap"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool LuuHoaDonNhap(
    string soHDN,
    string maNV,
    string maNCC,
    DateTime ngayNhap,
    List<ChiTietNhapTam> chiTietList)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlHoaDon = @"
                    INSERT INTO HoaDonNhap
                        (SoHDN, MaNV, MaNCC, NgayNhap, TongTien)
                    VALUES
                        (@SoHDN, @MaNV, @MaNCC, @NgayNhap, 0);";

                        using (SqlCommand cmd = new SqlCommand(
                            sqlHoaDon, conn, tran))
                        {
                            cmd.Parameters.Add(
                                "@SoHDN", SqlDbType.VarChar, 10).Value = soHDN;

                            cmd.Parameters.Add(
                                "@MaNV", SqlDbType.VarChar, 10).Value = maNV;

                            cmd.Parameters.Add(
                                "@MaNCC", SqlDbType.VarChar, 10).Value = maNCC;

                            cmd.Parameters.Add(
                                "@NgayNhap", SqlDbType.DateTime).Value = ngayNhap;

                            cmd.ExecuteNonQuery();
                        }

                        foreach (ChiTietNhapTam ct in chiTietList)
                        {
                            string sqlGiaNhap = @"
                        SELECT GiaNhap
                        FROM Tivi WITH (UPDLOCK, HOLDLOCK)
                        WHERE MaTivi = @MaTivi;";

                            decimal giaNhapHienTai;

                            using (SqlCommand cmd = new SqlCommand(
                                sqlGiaNhap, conn, tran))
                            {
                                cmd.Parameters.Add(
                                    "@MaTivi", SqlDbType.VarChar, 10).Value =
                                    ct.MaTivi;

                                object result = cmd.ExecuteScalar();

                                if (result == null || result == DBNull.Value)
                                {
                                    throw new Exception(
                                        $"Không tìm thấy Tivi {ct.MaTivi}.");
                                }

                                giaNhapHienTai = Convert.ToDecimal(result);
                            }

                            string sqlDaNhap = @"
                        SELECT COUNT(*)
                        FROM ChiTietHoaDonNhap
                        WHERE MaTivi = @MaTivi;";

                            int daNhap;

                            using (SqlCommand cmd = new SqlCommand(
                                sqlDaNhap, conn, tran))
                            {
                                cmd.Parameters.Add(
                                    "@MaTivi", SqlDbType.VarChar, 10).Value =
                                    ct.MaTivi;

                                daNhap = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            if (daNhap > 0 || giaNhapHienTai > 0)
                            {
                                if (ct.DonGia != giaNhapHienTai)
                                {
                                    throw new Exception(
                                        $"Tivi {ct.MaTivi} có giá nhập cố định " +
                                        $"{giaNhapHienTai:N0} đ. " +
                                        "Đơn giá trên hóa đơn không khớp.");
                                }
                            }

                            string sqlChiTiet = @"
                        INSERT INTO ChiTietHoaDonNhap
                            (SoHDN, MaTivi, SoLuong, DonGia, GiamGia)
                        VALUES
                            (@SoHDN, @MaTivi, @SoLuong, @DonGia, @GiamGia);";

                            using (SqlCommand cmd = new SqlCommand(
                                sqlChiTiet, conn, tran))
                            {
                                cmd.Parameters.Add(
                                    "@SoHDN", SqlDbType.VarChar, 10).Value = soHDN;

                                cmd.Parameters.Add(
                                    "@MaTivi", SqlDbType.VarChar, 10).Value =
                                    ct.MaTivi;

                                cmd.Parameters.Add(
                                    "@SoLuong", SqlDbType.Int).Value = ct.SoLuong;

                                SqlParameter pDonGia = cmd.Parameters.Add(
                                    "@DonGia", SqlDbType.Decimal);
                                pDonGia.Precision = 18;
                                pDonGia.Scale = 2;
                                pDonGia.Value = ct.DonGia;

                                SqlParameter pGiamGia = cmd.Parameters.Add(
                                    "@GiamGia", SqlDbType.Decimal);
                                pGiamGia.Precision = 5;
                                pGiamGia.Scale = 2;
                                pGiamGia.Value = ct.GiamGia;

                                cmd.ExecuteNonQuery();
                            }

                            if (daNhap == 0 && giaNhapHienTai == 0)
                            {
                                string sqlCapNhatGia = @"
                            UPDATE Tivi
                            SET GiaNhap = @DonGia
                            WHERE MaTivi = @MaTivi
                              AND GiaNhap = 0;";

                                using (SqlCommand cmd = new SqlCommand(
                                    sqlCapNhatGia, conn, tran))
                                {
                                    cmd.Parameters.Add(
                                        "@MaTivi", SqlDbType.VarChar, 10).Value =
                                        ct.MaTivi;

                                    SqlParameter p = cmd.Parameters.Add(
                                        "@DonGia", SqlDbType.Decimal);
                                    p.Precision = 18;
                                    p.Scale = 2;
                                    p.Value = ct.DonGia;

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        tran.Commit();
                        return true;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
