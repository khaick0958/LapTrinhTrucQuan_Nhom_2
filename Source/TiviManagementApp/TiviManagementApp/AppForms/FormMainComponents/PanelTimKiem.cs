using System.Windows.Forms;
using TiviManagementApp.Models;
using TiviManagementApp.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace QuanLyCuaHangTivi
{
    public partial class PanelTimKiem : UserControl
    {
        private TiviRepositories repository = new TiviRepositories();
        private string? branch = null;
        private string? screen = null;
        private string? size = null;

        private HDNhapRepositories repositoryHDN = new HDNhapRepositories();
        private string? maTV = null;
        private int? soLuong = null;

        public PanelTimKiem()
        {
            InitializeComponent();

            StartUpTV();
            StartUpHDN();
        }

        private void LoadTivi()
        {
            dataTableViewTV.Rows.Clear();

            var danhSach = repository.GetAllDetails();

            foreach (var x in danhSach)
            {
                dataTableViewTV.Rows.Add(x.MaTivi, x.TenTivi, x.TenHang, x.TenManHinh, x.CoManHinh, x.SoLuong, x.GiaBan);
            }
        }

        private void loadComboBoxes()
        {
            var danhSachHang = repository.GetAllBranches();

            danhSachHang.Insert(0, new HangSanXuat
            {
                MaHang = "ALL",
                TenHang = "Tất cả"
            });

            branchCBox.DataSource = danhSachHang;
            branchCBox.DisplayMember = "TenHang";
            branchCBox.ValueMember = "MaHang";
            branchCBox.SelectedValue = "ALL";

            var danhSachManHinh = repository.GetAllScreens();

            danhSachManHinh.Insert(0, new ManHinh
            {
                MaManHinh = "ALL",
                TenManHinh = "Tất cả"
            });

            screenCBox.DataSource = danhSachManHinh;
            screenCBox.DisplayMember = "TenManHinh";
            screenCBox.ValueMember = "MaManHinh";
            screenCBox.SelectedValue = "ALL";

            sizeCBox.DataSource = repository.GetAllSizes();
            sizeCBox.DisplayMember = "KichThuocInch";
            sizeCBox.ValueMember = "MaCo";
        }

        private void StartUpTV()
        {
            LoadTivi();
            loadComboBoxes();
            branchCBox.SelectedIndex = 0;
            screenCBox.SelectedIndex = 0;
            sizeCBox.SelectedIndex = -1;
        }

        private void SearchTivi(List<TiviDetail> danhSach)
        {
            dataTableViewTV.Rows.Clear();

            foreach (var x in danhSach)
            {
                dataTableViewTV.Rows.Add(
                    x.MaTivi,
                    x.TenTivi,
                    x.TenHang,
                    x.TenManHinh,
                    x.CoManHinh,
                    x.SoLuong,
                    x.GiaBan
                );
            }
        }

        private void branchCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (branchCBox.SelectedIndex == -1 || branchCBox.SelectedIndex == 0) branch = null;
            else
            {
                branch = branchCBox.SelectedValue?.ToString();
            }
        }

        private void screenCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (screenCBox.SelectedIndex == -1 || screenCBox.SelectedIndex == 0) screen = null;
            else
            {
                screen = screenCBox.SelectedValue?.ToString();
            }
        }

        private void sizeCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sizeCBox.SelectedIndex == -1 || sizeCBox.SelectedIndex == 0) size = null;
            else
            {
                size = sizeCBox.SelectedValue?.ToString();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<TiviDetail> danhSachBetter = repository.SearchTiviByFilters(branch, screen, size);

            SearchTivi(danhSachBetter);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            StartUpTV();
        }

        private void loadHDN()
        {
            dataTableViewHDN.Rows.Clear();

            var danhSach = repositoryHDN.GetAllCTHDN();

            foreach (var x in danhSach)
            {
                dataTableViewHDN.Rows.Add(
                    x.SoHDN,
                    x.NgayNhap.ToString("dd/MM/yyyy"),
                    x.MaTivi,
                    x.SoLuong,
                    x.DonGia,
                    x.GiamGia,
                    x.ThanhTien
                );
            }
        }

        private void StartUpHDN()
        {
            maTVBox.Clear();
            amountBox.Clear();
            loadHDN();
            maTVBox.Focus();
        }
        
        private void searchHDNBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maTVBox.Text))
            {
                maTV = null;
            }
            else maTV = maTVBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(amountBox.Text))
            {
                if (!int.TryParse(amountBox.Text.Trim(), out int value)
                    || value <= 0)
                {
                    MessageBox.Show("Số lượng nhập phải là số nguyên dương!");
                    amountBox.Focus();
                    return;
                }

                soLuong = value;
            }

            var danhSach = repositoryHDN.SearchCTHDN(maTV, soLuong);

            dataTableViewHDN.Rows.Clear();

            foreach (var x in danhSach)
            {
                dataTableViewHDN.Rows.Add(
                    x.SoHDN,
                    x.NgayNhap.ToString("dd/MM/yyyy"),
                    x.MaTivi,
                    x.SoLuong,
                    x.DonGia,
                    x.GiamGia,
                    x.ThanhTien
                );
            }
        }

        private void resetHDNBtn_Click(object sender, EventArgs e)
        {
            StartUpHDN();
        }
    }
}
