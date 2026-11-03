using System.Windows.Forms;
using TiviManagementApp.Models;
using TiviManagementApp.Repositories;

namespace QuanLyCuaHangTivi
{
    public partial class PanelNhapHang : UserControl
    {
        private HDNhapRepositories HDNRepository = new HDNhapRepositories();
        private TiviRepositories TiviRepository = new TiviRepositories();

        public PanelNhapHang()
        {
            InitializeComponent();

            StartUp();
        }

        private void StartUp()
        {
            idTVBox.Items.Clear();
            loadComboBoxes();
            employeeHDNBox.SelectedIndex = -1;
            supplierHDNBox.SelectedIndex = -1;
            idTVBox.SelectedIndex = -1;
            idHDNBox.Clear();
            dateHDNBox.Value = DateTime.Now;
            nameTVBox.Clear();
            amountTVBox.Value = 1;
            buyPriceTVBox.Value = 0;
            saleTVBox.Value = 0;
        }

        private void loadComboBoxes()
        {
            var danhSachNV = HDNRepository.GetAllNhanVien();
            employeeHDNBox.DataSource = danhSachNV;
            employeeHDNBox.DisplayMember = "HoTen";
            employeeHDNBox.ValueMember = "MaNV";

            var danhSachNCC = HDNRepository.GetAllNhaCungCap();
            supplierHDNBox.DataSource = danhSachNCC;
            supplierHDNBox.DisplayMember = "TenNCC";
            supplierHDNBox.ValueMember = "MaNCC";

            var danhSachMaTV = TiviRepository.GetAll();
            foreach (var x in danhSachMaTV)
            {
                idTVBox.Items.Add(x.MaTivi);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            StartUp();
        }

        private void idTVBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idTVBox.SelectedIndex == -1) return;

            var maTV = idTVBox.SelectedItem.ToString();
            var tenTV = TiviRepository.SearchByID(maTV);

            nameTVBox.Text = tenTV.TenTivi.ToString();

            var thongTin = HDNRepository.KiemTraTiviDaNhap(maTV);

            if (thongTin != null)
            {
                string? maNCC = thongTin.MaNCC;
                decimal giaNhap = thongTin.GiaNhap;

                buyPriceTVBox.Value = giaNhap;
                buyPriceTVBox.ReadOnly = true;
                buyPriceTVBox.Enabled = false;
                supplierHDNBox.SelectedValue = maNCC;
            }
            else
            {
                buyPriceTVBox.Value = 0;
                buyPriceTVBox.ReadOnly = false;
                buyPriceTVBox.Enabled = true;
                supplierHDNBox.SelectedIndex = -1;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (idTVBox.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn mã Tivi!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                idTVBox.Focus();
                return;
            }

            decimal donGia = buyPriceTVBox.Value;

            if (donGia <= 0)
            {
                MessageBox.Show(
                    "Đơn giá nhập phải lớn hơn 0!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                buyPriceTVBox.Focus();
                return;
            }

            string maTivi = idTVBox.SelectedItem.ToString()!;
            string tenTivi = nameTVBox.Text.Trim();
            int soLuong = (int)amountTVBox.Value;
            decimal giamGia = saleTVBox.Value;

            decimal thanhTien = soLuong * donGia * (1 - giamGia / 100);

            foreach (DataGridViewRow row in dataTableView.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["col1"].Value?.ToString() == maTivi)
                {
                    MessageBox.Show(
                        "Tivi này đã có trong danh sách nhập hàng!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            int index = dataTableView.Rows.Add(
                maTivi,
                tenTivi,
                soLuong,
                donGia.ToString("N0"),
                thanhTien.ToString("N0")
            );

            dataTableView.Rows[index].Tag = new ChiTietNhapTam
            {
                MaTivi = maTivi,
                SoLuong = soLuong,
                DonGia = donGia,
                GiamGia = giamGia
            };

            int tongSoLuong = 0;
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dataTableView.Rows)
            {
                if (row.IsNewRow) continue;

                tongSoLuong += Convert.ToInt32(row.Cells["col3"].Value);

                tongTien += Convert.ToDecimal(
                    row.Cells["col5"].Value?.ToString()?.Replace(",", "")
                );
            }

            label10.Text = $"Tổng số sản phẩm: {tongSoLuong} chiếc";
            totalFeeLbl.Text = $"TỔNG TIỀN: {tongTien:N0} đ";

            MessageBox.Show(
                "Đã thêm Tivi vào danh sách nhập hàng!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            StartUp();
            label10.Text = "Tổng số sản phẩm: 0 chiếc";
            totalFeeLbl.Text = "TỔNG TIỀN: ";
            dataTableView.Rows.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string soHDN = idHDNBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(soHDN))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                idHDNBox.Focus();
                return;
            }

            if (employeeHDNBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!");
                return;
            }

            if (supplierHDNBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                return;
            }

            List<ChiTietNhapTam> chiTietList = new List<ChiTietNhapTam>();

            foreach (DataGridViewRow row in dataTableView.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Tag is not ChiTietNhapTam ct)
                {
                    MessageBox.Show("Có dòng chi tiết không hợp lệ!");
                    return;
                }

                chiTietList.Add(ct);
            }

            if (chiTietList.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một Tivi!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn lưu hóa đơn nhập này không?",
                "Xác nhận lưu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                bool result = HDNRepository.LuuHoaDonNhap(
                    soHDN,
                    employeeHDNBox.SelectedValue.ToString()!,
                    supplierHDNBox.SelectedValue.ToString()!,
                    dateHDNBox.Value,
                    chiTietList
                );

                if (result)
                {
                    MessageBox.Show(
                        "Lưu hóa đơn nhập thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    cancelBtn_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lưu hóa đơn:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
