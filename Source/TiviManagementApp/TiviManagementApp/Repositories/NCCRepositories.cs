using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TiviManagementApp.Data;
using TiviManagementApp.Models;

namespace TiviManagementApp.Repositories
{
    internal class NCCRepositories
    {
        public List<NhaCungCap> GetAll()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"
                    SELECT MaNCC, TenNCC, DiaChi, DienThoai
                    FROM NhaCungCap
                    ORDER BY MaNCC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new NhaCungCap
                            {
                                MaNCC = reader["MaNCC"].ToString(),
                                TenNCC = reader["TenNCC"].ToString(),
                                DiaChi = reader["DiaChi"] == DBNull.Value
                                    ? null : reader["DiaChi"].ToString(),
                                DienThoai = reader["DienThoai"] == DBNull.Value
                                    ? null : reader["DienThoai"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

        public List<NhaCungCap> Search(string keyword)
        {
            List<NhaCungCap> list = new List<NhaCungCap>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"
                    SELECT MaNCC, TenNCC, DiaChi, DienThoai
                    FROM NhaCungCap
                    WHERE MaNCC LIKE @Keyword
                       OR TenNCC LIKE @Keyword
                       OR DienThoai LIKE @Keyword
                    ORDER BY MaNCC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Keyword", SqlDbType.NVarChar, 150)
                        .Value = "%" + keyword.Trim() + "%";

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new NhaCungCap
                            {
                                MaNCC = reader["MaNCC"].ToString(),
                                TenNCC = reader["TenNCC"].ToString(),
                                DiaChi = reader["DiaChi"] == DBNull.Value
                                    ? null : reader["DiaChi"].ToString(),
                                DienThoai = reader["DienThoai"] == DBNull.Value
                                    ? null : reader["DienThoai"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

        public void Add(NhaCungCap ncc)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"
                    INSERT INTO NhaCungCap
                        (MaNCC, TenNCC, DiaChi, DienThoai)
                    VALUES
                        (@MaNCC, @TenNCC, @DiaChi, @DienThoai)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    AddParameters(cmd, ncc);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(NhaCungCap ncc)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"
                    UPDATE NhaCungCap
                    SET TenNCC = @TenNCC,
                        DiaChi = @DiaChi,
                        DienThoai = @DienThoai
                    WHERE MaNCC = @MaNCC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    AddParameters(cmd, ncc);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows == 0)
                        throw new Exception("Không tìm thấy nhà cung cấp cần sửa.");
                }
            }
        }

        public void Delete(string maNCC)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlCheck = @"
                            SELECT COUNT(*)
                            FROM HoaDonNhap
                            WHERE MaNCC = @MaNCC";

                        using (SqlCommand cmd = new SqlCommand(
                            sqlCheck, conn, transaction))
                        {
                            cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar, 10)
                                .Value = maNCC;

                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                            {
                                throw new Exception(
                                    "Không thể xóa nhà cung cấp này vì đã phát sinh hóa đơn nhập.");
                            }
                        }

                        string sqlDelete = @"
                            DELETE FROM NhaCungCap
                            WHERE MaNCC = @MaNCC";

                        using (SqlCommand cmd = new SqlCommand(
                            sqlDelete, conn, transaction))
                        {
                            cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar, 10)
                                .Value = maNCC;

                            int rows = cmd.ExecuteNonQuery();

                            if (rows == 0)
                                throw new Exception("Không tìm thấy nhà cung cấp cần xóa.");
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private void AddParameters(SqlCommand cmd, NhaCungCap ncc)
        {
            cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar, 10)
                .Value = ncc.MaNCC;

            cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 150)
                .Value = ncc.TenNCC;

            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200)
                .Value = string.IsNullOrWhiteSpace(ncc.DiaChi)
                    ? (object)DBNull.Value : ncc.DiaChi;

            cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15)
                .Value = string.IsNullOrWhiteSpace(ncc.DienThoai)
                    ? (object)DBNull.Value : ncc.DienThoai;
        }
    }
}
