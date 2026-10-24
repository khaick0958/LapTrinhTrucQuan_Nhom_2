using System;
using System.Collections.Generic;
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

        public List<string> GetAllColors()
        {
            List<string> danhSach = new List<string>();

            string sql = @"SELECT TenMau FROM MauSac";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string x = dataReader["TenMau"].ToString();

                        danhSach.Add(x);
                    }
                }
            }
            return danhSach;
        }

        public List<string> GetAllBranches()
        {
            List<string> danhSach = new List<string>();

            string sql = @"SELECT TenHang FROM HangSanXuat";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string x = dataReader["TenHang"].ToString();

                        danhSach.Add(x);
                    }
                }
            }
            return danhSach;
        }

        public List<string> GetAllScreens()
        {
            List<string> danhSach = new List<string>();

            string sql = @"SELECT TenManHinh FROM ManHinh";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string x = dataReader["TenManHinh"].ToString();

                        danhSach.Add(x);
                    }
                }
            }
            return danhSach;
        }

        public List<string> GetAllStyles()
        {
            List<string> danhSach = new List<string>();

            string sql = @"SELECT TenKieu FROM KieuDang";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string x = dataReader["TenKieu"].ToString();

                        danhSach.Add(x);
                    }
                }
            }
            return danhSach;
        }

        public List<int> GetAllSizes()
        {
            List<int> danhSach = new List<int>();

            string sql = @"SELECT KichThuocInch FROM CoManHinh";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int x = Convert.ToInt32(dataReader["KichThuocInch"]);

                        danhSach.Add(x);
                    }
                }
            }
            return danhSach;
        }

        public List<string> GetAllCountries()
        {
            List<string> danhSach = new List<string>();

            string sql = @"SELECT TenNuoc FROM NuocSanXuat";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string x = dataReader["TenNuoc"].ToString();

                        danhSach.Add(x);
                    }
                }
            }
            return danhSach;
        }
    }
}
