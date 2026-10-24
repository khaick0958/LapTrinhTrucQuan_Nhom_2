using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TiviManagementApp.Data;
using TiviManagementApp.Models;

namespace TiviManagementApp.Repositories
{
    internal class TiviRepositories
    {
        public List<Tivi> GetAll()
        {
            List<Tivi> danhSach = new List<Tivi>();

            string sql = @"SELECT * FROM Tivi";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Tivi tv = new Tivi
                        {
                            MaTivi = dataReader["MaTivi"].ToString(),
                            TenTivi = dataReader["TenTivi"].ToString(),
                            MaHang = dataReader["MaHang"].ToString(),
                            SoLuong = Convert.ToInt32(dataReader["SoLuong"]),
                            GiaNhap = Convert.ToDecimal(dataReader["GiaNhap"]),
                            GiaBan = Convert.ToDecimal(dataReader["GiaBan"]),
                            ThoiGianBaoHanhThang = Convert.ToInt32(dataReader["ThoiGianBaoHanhThang"])
                        };

                        danhSach.Add(tv);
                    }
                }
            }

            return danhSach;
        }

        public Tivi SearchByID(string id)
        {
            string sql = "SELECT * FROM Tivi WHERE MaTivi = @id";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            return new Tivi
                            {
                                MaTivi = dataReader["MaTivi"].ToString(),
                                TenTivi = dataReader["TenTivi"].ToString(),
                                MaHang = dataReader["MaHang"].ToString(),
                                MaMau = dataReader["MaMau"].ToString(),
                                MaCo = dataReader["MaCo"].ToString(),
                                MaKieu = dataReader["MaKieu"].ToString(),
                                MaManHinh = dataReader["MaManHinh"].ToString(),
                                MaNuoc = dataReader["MaNuoc"].ToString(),
                                SoLuong = Convert.ToInt32(dataReader["SoLuong"]),
                                GiaNhap = Convert.ToDecimal(dataReader["GiaNhap"]),
                                GiaBan = Convert.ToDecimal(dataReader["GiaBan"]),
                                ThoiGianBaoHanhThang = Convert.ToInt32(dataReader["ThoiGianBaoHanhThang"]),
                                Anh = dataReader["Anh"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public TiviDetail? GetDetailByID(string maTivi)
        {
            string sql = @"
                            SELECT
                                t.MaTivi,
                                t.TenTivi,
                                hsx.TenHang AS TenHang,
                                kd.TenKieu AS TenKieu,
                                ms.TenMau AS TenMau,
                                mh.TenManHinh AS TenManHinh,
                                cm.KichThuocInch AS KichThuocInch,
                                nsx.TenNuoc AS TenNuoc,
                                t.SoLuong,
                                t.GiaNhap,
                                t.GiaBan,
                                t.ThoiGianBaoHanhThang,
                                t.Anh
                            FROM Tivi t
                            LEFT JOIN HangSanXuat hsx ON t.MaHang = hsx.MaHang
                            LEFT JOIN KieuDang kd ON t.MaKieu = kd.MaKieu
                            LEFT JOIN MauSac ms ON t.MaMau = ms.MaMau
                            LEFT JOIN ManHinh mh ON t.MaManHinh = mh.MaManHinh
                            LEFT JOIN CoManHinh cm ON t.MaCo = cm.MaCo
                            LEFT JOIN NuocSanXuat nsx ON t.MaNuoc = nsx.MaNuoc
                            WHERE t.MaTivi = @MaTivi;";

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
                            return new TiviDetail
                            {
                                MaTivi = reader["MaTivi"].ToString() ?? "",
                                TenTivi = reader["TenTivi"].ToString() ?? "",

                                TenHang = reader["TenHang"].ToString() ?? "",
                                TenKieu = reader["TenKieu"].ToString() ?? "",
                                TenMau = reader["TenMau"].ToString() ?? "",
                                TenManHinh = reader["TenManHinh"].ToString() ?? "",
                                CoManHinh = Convert.ToInt32(reader["KichThuocInch"]),
                                TenNuoc = reader["TenNuoc"].ToString() ?? "",

                                SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                GiaNhap = Convert.ToDecimal(reader["GiaNhap"]),
                                GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                                ThoiGianBaoHanhThang =
                                    Convert.ToInt32(reader["ThoiGianBaoHanhThang"]),

                                Anh = reader["Anh"] == DBNull.Value
                                    ? null
                                    : reader["Anh"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public int GetTotalTivis()
        {
            string sql = "SELECT ISNULL(SUM(SoLuong), 0) FROM Tivi";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public List<MauSac> GetAllColors()
        {
            List<MauSac> danhSach = new List<MauSac>();
            string sql = "SELECT MaMau, TenMau FROM MauSac";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new MauSac
                        {
                            MaMau = reader["MaMau"].ToString() ?? "",
                            TenMau = reader["TenMau"].ToString() ?? ""
                        });
                    }
                }
            }

            return danhSach;
        }

        public List<HangSanXuat> GetAllBranches()
        {
            List<HangSanXuat> danhSach = new List<HangSanXuat>();
            string sql = "SELECT MaHang, TenHang FROM HangSanXuat";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new HangSanXuat
                        {
                            MaHang = reader["MaHang"].ToString() ?? "",
                            TenHang = reader["TenHang"].ToString() ?? ""
                        });
                    }
                }
            }

            return danhSach;
        }

        public List<ManHinh> GetAllScreens()
        {
            List<ManHinh> danhSach = new List<ManHinh>();
            string sql = "SELECT MaManHinh, TenManHinh FROM ManHinh";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new ManHinh
                        {
                            MaManHinh = reader["MaManHinh"].ToString() ?? "",
                            TenManHinh = reader["TenManHinh"].ToString() ?? ""
                        });
                    }
                }
            }

            return danhSach;
        }

        public List<KieuDang> GetAllStyles()
        {
            List<KieuDang> danhSach = new List<KieuDang>();
            string sql = "SELECT MaKieu, TenKieu FROM KieuDang";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new KieuDang
                        {
                            MaKieu = reader["MaKieu"].ToString() ?? "",
                            TenKieu = reader["TenKieu"].ToString() ?? ""
                        });
                    }
                }
            }

            return danhSach;
        }

        public List<CoManHinh> GetAllSizes()
        {
            List<CoManHinh> danhSach = new List<CoManHinh>();
            string sql = "SELECT MaCo, KichThuocInch FROM CoManHinh";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new CoManHinh
                        {
                            MaCo = reader["MaCo"].ToString() ?? "",
                            KichThuocInch = Convert.ToInt32(reader["KichThuocInch"])
                        });
                    }
                }
            }

            return danhSach;
        }

        public List<NuocSanXuat> GetAllCountries()
        {
            List<NuocSanXuat> danhSach = new List<NuocSanXuat>();
            string sql = "SELECT MaNuoc, TenNuoc FROM NuocSanXuat";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new NuocSanXuat
                        {
                            MaNuoc = reader["MaNuoc"].ToString() ?? "",
                            TenNuoc = reader["TenNuoc"].ToString() ?? ""
                        });
                    }
                }
            }

            return danhSach;
        }

        public bool Insert(Tivi tv)
        {
            string sql = @"
        INSERT INTO Tivi
        (
            MaTivi,
            TenTivi,
            MaHang,
            MaKieu,
            MaMau,
            MaManHinh,
            MaCo,
            MaNuoc,
            SoLuong,
            GiaNhap,
            ThoiGianBaoHanhThang,
            Anh
        )
        VALUES
        (
            @MaTivi,
            @TenTivi,
            @MaHang,
            @MaKieu,
            @MaMau,
            @MaManHinh,
            @MaCo,
            @MaNuoc,
            @SoLuong,
            @GiaNhap,
            @ThoiGianBaoHanhThang,
            @Anh
        );";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    AddTiviParameters(cmd, tv);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(Tivi tv)
        {
            string sql = @"
        UPDATE Tivi
        SET
            TenTivi = @TenTivi,
            MaHang = @MaHang,
            MaKieu = @MaKieu,
            MaMau = @MaMau,
            MaManHinh = @MaManHinh,
            MaCo = @MaCo,
            MaNuoc = @MaNuoc,
            SoLuong = @SoLuong,
            GiaNhap = @GiaNhap,
            ThoiGianBaoHanhThang = @ThoiGianBaoHanhThang,
            Anh = @Anh
        WHERE MaTivi = @MaTivi;";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    AddTiviParameters(cmd, tv);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(string maTivi)
        {
            string sql = @"
        DELETE FROM Tivi
        WHERE MaTivi = @MaTivi
          AND NOT EXISTS (
              SELECT 1
              FROM ChiTietHoaDonNhap
              WHERE MaTivi = @MaTivi
          )
          AND NOT EXISTS (
              SELECT 1
              FROM ChiTietHoaDonBan
              WHERE MaTivi = @MaTivi
          );";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaTivi", maTivi);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private void AddTiviParameters(SqlCommand cmd, Tivi tv)
        {
            cmd.Parameters.Add("@MaTivi", SqlDbType.VarChar, 10)
                .Value = tv.MaTivi;

            cmd.Parameters.Add("@TenTivi", SqlDbType.NVarChar, 150)
                .Value = tv.TenTivi;

            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar, 10)
                .Value = tv.MaHang;

            cmd.Parameters.Add("@MaKieu", SqlDbType.VarChar, 10)
                .Value = (object?)tv.MaKieu ?? DBNull.Value;

            cmd.Parameters.Add("@MaMau", SqlDbType.VarChar, 10)
                .Value = (object?)tv.MaMau ?? DBNull.Value;

            cmd.Parameters.Add("@MaManHinh", SqlDbType.VarChar, 10)
                .Value = (object?)tv.MaManHinh ?? DBNull.Value;

            cmd.Parameters.Add("@MaCo", SqlDbType.VarChar, 10)
                .Value = (object?)tv.MaCo ?? DBNull.Value;

            cmd.Parameters.Add("@MaNuoc", SqlDbType.VarChar, 10)
                .Value = (object?)tv.MaNuoc ?? DBNull.Value;

            cmd.Parameters.Add("@SoLuong", SqlDbType.Int)
                .Value = tv.SoLuong;

            SqlParameter giaNhapParam =
                cmd.Parameters.Add("@GiaNhap", SqlDbType.Decimal);

            giaNhapParam.Precision = 18;
            giaNhapParam.Scale = 2;
            giaNhapParam.Value = tv.GiaNhap;

            cmd.Parameters.Add("@ThoiGianBaoHanhThang", SqlDbType.Int)
                .Value = tv.ThoiGianBaoHanhThang;

            cmd.Parameters.Add("@Anh", SqlDbType.NVarChar, 255)
                .Value = (object?)tv.Anh ?? DBNull.Value;
        }
    }
}
