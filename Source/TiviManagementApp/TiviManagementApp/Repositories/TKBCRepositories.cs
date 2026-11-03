using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TiviManagementApp.Data;

namespace TiviManagementApp.Repositories
{
    internal class TKBCRepositories
    {
        public DataTable GetAllCustomers()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT MaKhach, TenKhach
                    FROM KhachHang
                    ORDER BY TenKhach";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable GetAllSuppliers()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT MaNCC, TenNCC
                    FROM NhaCungCap
                    ORDER BY TenNCC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable GetTop3TiviByCustomer(string maKhach)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT TOP 3
                        t.MaTivi AS MaTivi,
                        t.TenTivi AS TenTivi,
                        SUM(ct.SoLuong) AS TongSoLuongMua
                    FROM HoaDonBan hd
                    INNER JOIN ChiTietHoaDonBan ct ON hd.SoHDB = ct.SoHDB
                    INNER JOIN Tivi t ON ct.MaTivi = t.MaTivi
                    WHERE hd.MaKhach = @MaKhach
                    GROUP BY t.MaTivi, t.TenTivi
                    ORDER BY SUM(ct.SoLuong) DESC, t.MaTivi";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaKhach", SqlDbType.VarChar, 10).Value = maKhach;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetImportInvoicesBySupplier(string maNCC)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT
                        hd.SoHDN AS SoHoaDonNhap,
                        hd.NgayNhap AS NgayNhap,
                        nv.HoTen AS NhanVien,
                        hd.TongTien AS TongTien
                    FROM HoaDonNhap hd
                    INNER JOIN NhanVien nv ON hd.MaNV = nv.MaNV
                    WHERE hd.MaNCC = @MaNCC
                    ORDER BY hd.NgayNhap DESC, hd.SoHDN DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar, 10).Value = maNCC;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetSalesByQuarter(int year, int quarter)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT
                        hd.SoHDB AS SoHoaDonBan,
                        hd.NgayBan AS NgayBan,
                        nv.HoTen AS NhanVien,
                        kh.TenKhach AS KhachHang,
                        hd.TongTien AS TongTien
                    FROM HoaDonBan hd
                    INNER JOIN NhanVien nv ON hd.MaNV = nv.MaNV
                    INNER JOIN KhachHang kh ON hd.MaKhach = kh.MaKhach
                    WHERE hd.NgayBan >= @StartDate
                      AND hd.NgayBan < @EndDate
                    ORDER BY hd.NgayBan DESC, hd.SoHDB DESC";

                DateTime startDate = new DateTime(year, (quarter - 1) * 3 + 1, 1);
                DateTime endDate = startDate.AddMonths(3);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = startDate;
                    cmd.Parameters.Add("@EndDate", SqlDbType.Date).Value = endDate;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetTop5SuppliersByMonth(int month, int year)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT TOP 5
                        ncc.MaNCC AS MaNCC,
                        ncc.TenNCC AS TenNCC,
                        COUNT(hd.SoHDN) AS SoHoaDonNhap,
                        SUM(hd.TongTien) AS TongTienNhap
                    FROM NhaCungCap ncc
                    INNER JOIN HoaDonNhap hd ON ncc.MaNCC = hd.MaNCC
                    WHERE hd.NgayNhap >= @StartDate
                      AND hd.NgayNhap < @EndDate
                    GROUP BY ncc.MaNCC, ncc.TenNCC
                    ORDER BY SUM(hd.TongTien) DESC, ncc.MaNCC";

                DateTime startDate = new DateTime(year, month, 1);
                DateTime endDate = startDate.AddMonths(1);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = startDate;
                    cmd.Parameters.Add("@EndDate", SqlDbType.Date).Value = endDate;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
