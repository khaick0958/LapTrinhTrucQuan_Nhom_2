//using QuanLyCuaHangTivi.Models;
//using QuanLyCuaHangTivi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TiviManagementApp.Models;
using TiviManagementApp.Repositories;

namespace QuanLyCuaHangTivi
{
    public partial class PanelBanHang : UserControl
    {
        private readonly HDBanRepositories repository =
            new HDBanRepositories();

        private List<ChiTietBanTam> chiTietList =
            new List<ChiTietBanTam>();

        private List<TiviBanItem> danhSachTivi =
            new List<TiviBanItem>();

        public PanelBanHang()
        {
            InitializeComponent();

            Load += PanelBanHang_Load;

            addBtn.Click += addBtn_Click;
            saveBtn.Click += saveBtn_Click;
            resetBtn.Click += resetBtn_Click;
            cancelBtn.Click += cancelBtn_Click;

            idTVBox.SelectedIndexChanged += idTVBox_SelectedIndexChanged;
        }

        private void PanelBanHang_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBox();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadComboBox()
        {
            employeeHDBBox.DataSource = repository.GetAllNhanVien();
            employeeHDBBox.DisplayMember = "HoTen";
            employeeHDBBox.ValueMember = "MaNV";
            employeeHDBBox.SelectedIndex = -1;

            customerHDBBox.DataSource = repository.GetAllKhachHang();
            customerHDBBox.DisplayMember = "TenKhach";
            customerHDBBox.ValueMember = "MaKhach";
            customerHDBBox.SelectedIndex = -1;

            danhSachTivi = repository.GetAllTiviConHang();

            idTVBox.DataSource = danhSachTivi;
            idTVBox.DisplayMember = "ThongTinHienThi";
            idTVBox.ValueMember = "MaTivi";
            idTVBox.SelectedIndex = -1;
        }

        private void idTVBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            TiviBanItem tivi = idTVBox.SelectedItem as TiviBanItem;

            if (tivi == null)
            {
                nameTVBox.Clear();
                salePriceTVBox.Value = 0;
                return;
            }

            nameTVBox.Text = tivi.TenTivi;

            decimal giaBan = tivi.GiaBan;

            if (giaBan > salePriceTVBox.Maximum)
                giaBan = salePriceTVBox.Maximum;

            salePriceTVBox.Value = giaBan;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            TiviBanItem tivi = idTVBox.SelectedItem as TiviBanItem;

            if (tivi == null)
            {
                MessageBox.Show("Vui lòng chọn Tivi cần bán.");
                return;
            }

            int soLuong = Convert.ToInt32(amountTVBox.Value);

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                return;
            }

            if (soLuong > tivi.SoLuong)
            {
                MessageBox.Show(
                    "Số lượng tồn kho chỉ còn " + tivi.SoLuong + " chiếc.");
                return;
            }

            ChiTietBanTam dongCu = chiTietList.FirstOrDefault(
                x => x.MaTivi == tivi.MaTivi);

            if (dongCu != null)
            {
                MessageBox.Show(
                    "Tivi này đã có trong hóa đơn. Vui lòng xóa hoặc điều chỉnh số lượng trước khi thêm lại.");
                return;
            }

            ChiTietBanTam ct = new ChiTietBanTam
            {
                MaTivi = tivi.MaTivi,
                TenTivi = tivi.TenTivi,
                SoLuong = soLuong,
                DonGia = tivi.GiaBan
            };

            chiTietList.Add(ct);

            dataTableView.Rows.Add(
                ct.MaTivi,
                ct.TenTivi,
                ct.SoLuong,
                ct.DonGia.ToString("N0"),
                (ct.SoLuong * ct.DonGia).ToString("N0")
            );

            UpdateTotal();

            amountTVBox.Value = 1;
        }

        private void UpdateTotal()
        {
            int tongSoLuong = chiTietList.Sum(x => x.SoLuong);

            decimal tienHang = chiTietList.Sum(
                x => x.SoLuong * x.DonGia);

            decimal thue = taxTVBox.Value;

            decimal tongTien = tienHang * (1 + thue / 100);

            label10.Text = "Tổng số sản phẩm: " +
                           tongSoLuong + " chiếc";

            totalFeeLbl.Text = "TỔNG TIỀN: " +
                               tongTien.ToString("N0") + " đ";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idHDBBox.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn.");
                idHDBBox.Focus();
                return;
            }

            if (employeeHDBBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.");
                return;
            }

            if (customerHDBBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }

            if (chiTietList.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có Tivi nào.");
                return;
            }

            string soHDB = idHDBBox.Text.Trim();
            string maNV = employeeHDBBox.SelectedValue.ToString();
            string maKhach = customerHDBBox.SelectedValue.ToString();

            DateTime ngayBan = dateHDBBox.Value;
            decimal thue = taxTVBox.Value;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn lưu hóa đơn này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                repository.LuuHoaDonBan(
                    soHDB,
                    maNV,
                    maKhach,
                    ngayBan,
                    thue,
                    chiTietList
                );

                MessageBox.Show(
                    "Lưu hóa đơn bán thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadComboBox();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lưu hóa đơn: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            idHDBBox.Clear();

            dateHDBBox.Value = DateTime.Now;

            employeeHDBBox.SelectedIndex = -1;
            customerHDBBox.SelectedIndex = -1;
            idTVBox.SelectedIndex = -1;

            nameTVBox.Clear();

            amountTVBox.Value = 1;
            salePriceTVBox.Value = 0;
            taxTVBox.Value = 10;

            chiTietList.Clear();
            dataTableView.Rows.Clear();

            label10.Text = "Tổng số sản phẩm: 0 chiếc";
            totalFeeLbl.Text = "TỔNG TIỀN: 0 đ";
        }
    }
}