using System.Data;
using System.Windows.Forms;
using TiviManagementApp.Repositories;

namespace QuanLyCuaHangTivi
{
    public partial class PanelThongKe : UserControl
    {
        private readonly TKBCRepositories repository = new TKBCRepositories();

        public PanelThongKe()
        {
            InitializeComponent();

            Load += PanelThongKe_Load;

            reportCustomerBtn.Click += reportCustomerBtn_Click;
            reportSupplierBtn.Click += reportSupplierBtn_Click;
            reportQuarterBtn.Click += reportQuarterBtn_Click;
            reportTop5Btn.Click += reportTop5Btn_Click;
        }

        private void PanelThongKe_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadSuppliers();
            LoadQuarter();
            LoadMonth();
            LoadYear();

            ConfigureGrids();
        }

        private void LoadCustomers()
        {
            try
            {
                customerReportBox.DataSource = repository.GetAllCustomers();
                customerReportBox.DisplayMember = "TenKhach";
                customerReportBox.ValueMember = "MaKhach";
                customerReportBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message);
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                supplierReportBox.DataSource = repository.GetAllSuppliers();
                supplierReportBox.DisplayMember = "TenNCC";
                supplierReportBox.ValueMember = "MaNCC";
                supplierReportBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhà cung cấp: " + ex.Message);
            }
        }

        private void LoadQuarter()
        {
            quarterBox.Items.Clear();
            quarterBox.Items.Add("Quý 1");
            quarterBox.Items.Add("Quý 2");
            quarterBox.Items.Add("Quý 3");
            quarterBox.Items.Add("Quý 4");
            quarterBox.SelectedIndex = 0;
        }

        private void LoadMonth()
        {
            monthBox.Items.Clear();

            for (int i = 1; i <= 12; i++)
            {
                monthBox.Items.Add("Tháng " + i);
            }

            monthBox.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void LoadYear()
        {
            yearQuarterBox.Minimum = 2000;
            yearQuarterBox.Maximum = 2100;
            yearQuarterBox.Value = DateTime.Now.Year;

            yearMonthBox.Minimum = 2000;
            yearMonthBox.Maximum = 2100;
            yearMonthBox.Value = DateTime.Now.Year;
        }

        private void ConfigureGrids()
        {
            ConfigureGrid(top3Grid);
            ConfigureGrid(supplierGrid);
            ConfigureGrid(quarterGrid);
            ConfigureGrid(top5Grid);
        }

        private void ConfigureGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = true;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Columns.Clear();
            grid.AutoGenerateColumns = true;
        }

        private void reportCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customerReportBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            try
            {
                string maKhach = customerReportBox.SelectedValue.ToString();

                DataTable dt = repository.GetTop3TiviByCustomer(maKhach);
                top3Grid.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Khách hàng này chưa có dữ liệu mua Tivi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê Tivi theo khách hàng: " + ex.Message);
            }
        }

        private void reportSupplierBtn_Click(object sender, EventArgs e)
        {
            if (supplierReportBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                return;
            }

            try
            {
                string maNCC = supplierReportBox.SelectedValue.ToString();

                DataTable dt = repository.GetImportInvoicesBySupplier(maNCC);
                supplierGrid.DataSource = dt;

                decimal total = 0;

                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["TongTien"]);
                }

                totalImportLbl.Text = "Tổng tiền nhập: " + total.ToString("N0") + " VNĐ";

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nhà cung cấp này chưa có hóa đơn nhập!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê hóa đơn nhập: " + ex.Message);
            }
        }

        private void reportQuarterBtn_Click(object sender, EventArgs e)
        {
            if (quarterBox.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn quý!");
                return;
            }

            try
            {
                int quarter = quarterBox.SelectedIndex + 1;
                int year = Convert.ToInt32(yearQuarterBox.Value);

                DataTable dt = repository.GetSalesByQuarter(year, quarter);
                quarterGrid.DataSource = dt;

                decimal total = 0;

                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["TongTien"]);
                }

                totalSaleLbl.Text = "Tổng tiền bán: " + total.ToString("N0") + " VNĐ";

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có hóa đơn bán trong quý này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê hóa đơn bán: " + ex.Message);
            }
        }

        private void reportTop5Btn_Click(object sender, EventArgs e)
        {
            if (monthBox.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tháng!");
                return;
            }

            try
            {
                int month = monthBox.SelectedIndex + 1;
                int year = Convert.ToInt32(yearMonthBox.Value);

                DataTable dt = repository.GetTop5SuppliersByMonth(month, year);
                top5Grid.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhà cung cấp trong tháng này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê nhà cung cấp: " + ex.Message);
            }
        }
    }
}
