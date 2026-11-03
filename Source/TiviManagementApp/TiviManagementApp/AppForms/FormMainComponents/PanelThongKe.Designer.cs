
namespace QuanLyCuaHangTivi
{
    partial class PanelThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl;
        private TabPage tabTop3;
        private TabPage tabNCC;
        private TabPage tabQuy;
        private TabPage tabTop5;

        private Label customerLbl;
        private ComboBox customerReportBox;
        private Button reportCustomerBtn;
        private DataGridView top3Grid;

        private Label supplierLbl;
        private ComboBox supplierReportBox;
        private Button reportSupplierBtn;
        private DataGridView supplierGrid;
        private Label totalImportLbl;

        private Label yearQuarterLbl;
        private NumericUpDown yearQuarterBox;
        private Label quarterLbl;
        private ComboBox quarterBox;
        private Button reportQuarterBtn;
        private DataGridView quarterGrid;
        private Label totalSaleLbl;

        private Label monthLbl;
        private ComboBox monthBox;
        private Label yearMonthLbl;
        private NumericUpDown yearMonthBox;
        private Button reportTop5Btn;
        private DataGridView top5Grid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new TabControl();

            tabTop3 = new TabPage();
            customerLbl = new Label();
            customerReportBox = new ComboBox();
            reportCustomerBtn = new Button();
            top3Grid = new DataGridView();

            tabNCC = new TabPage();
            supplierLbl = new Label();
            supplierReportBox = new ComboBox();
            reportSupplierBtn = new Button();
            supplierGrid = new DataGridView();
            totalImportLbl = new Label();

            tabQuy = new TabPage();
            yearQuarterLbl = new Label();
            yearQuarterBox = new NumericUpDown();
            quarterLbl = new Label();
            quarterBox = new ComboBox();
            reportQuarterBtn = new Button();
            quarterGrid = new DataGridView();
            totalSaleLbl = new Label();

            tabTop5 = new TabPage();
            monthLbl = new Label();
            monthBox = new ComboBox();
            yearMonthLbl = new Label();
            yearMonthBox = new NumericUpDown();
            reportTop5Btn = new Button();
            top5Grid = new DataGridView();

            tabControl.SuspendLayout();
            tabTop3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)top3Grid).BeginInit();
            tabNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supplierGrid).BeginInit();
            tabQuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearQuarterBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quarterGrid).BeginInit();
            tabTop5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearMonthBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top5Grid).BeginInit();

            SuspendLayout();

            BackColor = Color.FromArgb(246, 247, 251);
            Name = "PanelThongKe";
            Size = new Size(1143, 876);

            tabControl.Controls.Add(tabTop3);
            tabControl.Controls.Add(tabNCC);
            tabControl.Controls.Add(tabQuy);
            tabControl.Controls.Add(tabTop5);
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.Location = new Point(25, 20);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1093, 830);
            tabControl.TabIndex = 0;

            tabTop3.BackColor = Color.White;
            tabTop3.Controls.Add(customerLbl);
            tabTop3.Controls.Add(customerReportBox);
            tabTop3.Controls.Add(reportCustomerBtn);
            tabTop3.Controls.Add(top3Grid);
            tabTop3.Location = new Point(4, 32);
            tabTop3.Name = "tabTop3";
            tabTop3.Size = new Size(1085, 794);
            tabTop3.TabIndex = 0;
            tabTop3.Text = "Top 3 Tivi theo khách hàng";

            customerLbl.AutoSize = true;
            customerLbl.Font = new Font("Segoe UI", 10F);
            customerLbl.Location = new Point(25, 30);
            customerLbl.Name = "customerLbl";
            customerLbl.Size = new Size(149, 23);
            customerLbl.TabIndex = 0;
            customerLbl.Text = "Chọn khách hàng:";

            customerReportBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerReportBox.Font = new Font("Segoe UI", 10F);
            customerReportBox.Location = new Point(180, 27);
            customerReportBox.Name = "customerReportBox";
            customerReportBox.Size = new Size(300, 31);
            customerReportBox.TabIndex = 1;

            reportCustomerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reportCustomerBtn.Location = new Point(500, 25);
            reportCustomerBtn.Name = "reportCustomerBtn";
            reportCustomerBtn.Size = new Size(130, 36);
            reportCustomerBtn.TabIndex = 2;
            reportCustomerBtn.Text = "Thống kê";
            reportCustomerBtn.UseVisualStyleBackColor = true;

            top3Grid.AllowUserToAddRows = false;
            top3Grid.AllowUserToDeleteRows = false;
            top3Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            top3Grid.BackgroundColor = Color.White;
            top3Grid.ColumnHeadersHeight = 40;
            top3Grid.Location = new Point(20, 85);
            top3Grid.Name = "top3Grid";
            top3Grid.ReadOnly = true;
            top3Grid.RowHeadersVisible = false;
            top3Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            top3Grid.MultiSelect = false;
            top3Grid.Size = new Size(1040, 680);
            top3Grid.TabIndex = 3;

            top3Grid.Columns.Add("col1", "Mã Tivi");
            top3Grid.Columns.Add("col2", "Tên Tivi");
            top3Grid.Columns.Add("col3", "Tổng số lượng mua");

            tabNCC.BackColor = Color.White;
            tabNCC.Controls.Add(supplierLbl);
            tabNCC.Controls.Add(supplierReportBox);
            tabNCC.Controls.Add(reportSupplierBtn);
            tabNCC.Controls.Add(supplierGrid);
            tabNCC.Controls.Add(totalImportLbl);
            tabNCC.Location = new Point(4, 32);
            tabNCC.Name = "tabNCC";
            tabNCC.Size = new Size(1085, 794);
            tabNCC.TabIndex = 1;
            tabNCC.Text = "Hóa đơn nhập theo NCC";

            supplierLbl.AutoSize = true;
            supplierLbl.Font = new Font("Segoe UI", 10F);
            supplierLbl.Location = new Point(25, 30);
            supplierLbl.Name = "supplierLbl";
            supplierLbl.Size = new Size(164, 23);
            supplierLbl.TabIndex = 0;
            supplierLbl.Text = "Chọn nhà cung cấp:";

            supplierReportBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierReportBox.Font = new Font("Segoe UI", 10F);
            supplierReportBox.Location = new Point(195, 27);
            supplierReportBox.Name = "supplierReportBox";
            supplierReportBox.Size = new Size(300, 31);
            supplierReportBox.TabIndex = 1;

            reportSupplierBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reportSupplierBtn.Location = new Point(515, 25);
            reportSupplierBtn.Name = "reportSupplierBtn";
            reportSupplierBtn.Size = new Size(130, 36);
            reportSupplierBtn.TabIndex = 2;
            reportSupplierBtn.Text = "Thống kê";
            reportSupplierBtn.UseVisualStyleBackColor = true;

            supplierGrid.AllowUserToAddRows = false;
            supplierGrid.AllowUserToDeleteRows = false;
            supplierGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            supplierGrid.BackgroundColor = Color.White;
            supplierGrid.ColumnHeadersHeight = 40;
            supplierGrid.Location = new Point(20, 85);
            supplierGrid.Name = "supplierGrid";
            supplierGrid.ReadOnly = true;
            supplierGrid.RowHeadersVisible = false;
            supplierGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            supplierGrid.MultiSelect = false;
            supplierGrid.Size = new Size(1040, 590);
            supplierGrid.TabIndex = 3;

            supplierGrid.Columns.Add("col1", "Số hóa đơn nhập");
            supplierGrid.Columns.Add("col2", "Ngày nhập");
            supplierGrid.Columns.Add("col3", "Nhân viên");
            supplierGrid.Columns.Add("col4", "Tổng tiền");

            totalImportLbl.AutoSize = true;
            totalImportLbl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            totalImportLbl.ForeColor = Color.FromArgb(35, 55, 85);
            totalImportLbl.Location = new Point(20, 700);
            totalImportLbl.Name = "totalImportLbl";
            totalImportLbl.Size = new Size(300, 30);
            totalImportLbl.TabIndex = 4;
            totalImportLbl.Text = "Tổng tiền nhập: 0 VNĐ";

            tabQuy.BackColor = Color.White;
            tabQuy.Controls.Add(yearQuarterLbl);
            tabQuy.Controls.Add(yearQuarterBox);
            tabQuy.Controls.Add(quarterLbl);
            tabQuy.Controls.Add(quarterBox);
            tabQuy.Controls.Add(reportQuarterBtn);
            tabQuy.Controls.Add(quarterGrid);
            tabQuy.Controls.Add(totalSaleLbl);
            tabQuy.Location = new Point(4, 32);
            tabQuy.Name = "tabQuy";
            tabQuy.Size = new Size(1085, 794);
            tabQuy.TabIndex = 2;
            tabQuy.Text = "Hóa đơn bán theo quý";

            yearQuarterLbl.AutoSize = true;
            yearQuarterLbl.Font = new Font("Segoe UI", 10F);
            yearQuarterLbl.Location = new Point(25, 30);
            yearQuarterLbl.Name = "yearQuarterLbl";
            yearQuarterLbl.Size = new Size(51, 23);
            yearQuarterLbl.TabIndex = 0;
            yearQuarterLbl.Text = "Năm:";

            yearQuarterBox.Font = new Font("Segoe UI", 10F);
            yearQuarterBox.Location = new Point(82, 25);
            yearQuarterBox.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            yearQuarterBox.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            yearQuarterBox.Name = "yearQuarterBox";
            yearQuarterBox.Size = new Size(110, 30);
            yearQuarterBox.TabIndex = 1;
            yearQuarterBox.Value = new decimal(new int[] { 2026, 0, 0, 0 });

            quarterLbl.AutoSize = true;
            quarterLbl.Font = new Font("Segoe UI", 10F);
            quarterLbl.Location = new Point(220, 30);
            quarterLbl.Name = "quarterLbl";
            quarterLbl.Size = new Size(45, 23);
            quarterLbl.TabIndex = 2;
            quarterLbl.Text = "Quý:";

            quarterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            quarterBox.Font = new Font("Segoe UI", 10F);
            quarterBox.Items.AddRange(new object[] { "Quý 1", "Quý 2", "Quý 3", "Quý 4" });
            quarterBox.Location = new Point(271, 25);
            quarterBox.Name = "quarterBox";
            quarterBox.Size = new Size(150, 31);
            quarterBox.TabIndex = 3;
            quarterBox.SelectedIndex = 0;

            reportQuarterBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reportQuarterBtn.Location = new Point(450, 23);
            reportQuarterBtn.Name = "reportQuarterBtn";
            reportQuarterBtn.Size = new Size(130, 36);
            reportQuarterBtn.TabIndex = 4;
            reportQuarterBtn.Text = "Thống kê";
            reportQuarterBtn.UseVisualStyleBackColor = true;

            quarterGrid.AllowUserToAddRows = false;
            quarterGrid.AllowUserToDeleteRows = false;
            quarterGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            quarterGrid.BackgroundColor = Color.White;
            quarterGrid.ColumnHeadersHeight = 40;
            quarterGrid.Location = new Point(20, 85);
            quarterGrid.Name = "quarterGrid";
            quarterGrid.ReadOnly = true;
            quarterGrid.RowHeadersVisible = false;
            quarterGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            quarterGrid.MultiSelect = false;
            quarterGrid.Size = new Size(1040, 590);
            quarterGrid.TabIndex = 5;

            quarterGrid.Columns.Add("col1", "Số hóa đơn bán");
            quarterGrid.Columns.Add("col2", "Ngày bán");
            quarterGrid.Columns.Add("col3", "Nhân viên");
            quarterGrid.Columns.Add("col4", "Khách hàng");
            quarterGrid.Columns.Add("col5", "Tổng tiền");

            totalSaleLbl.AutoSize = true;
            totalSaleLbl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            totalSaleLbl.ForeColor = Color.FromArgb(35, 55, 85);
            totalSaleLbl.Location = new Point(20, 700);
            totalSaleLbl.Name = "totalSaleLbl";
            totalSaleLbl.Size = new Size(300, 30);
            totalSaleLbl.TabIndex = 6;
            totalSaleLbl.Text = "Tổng tiền bán: 0 VNĐ";

            tabTop5.BackColor = Color.White;
            tabTop5.Controls.Add(monthLbl);
            tabTop5.Controls.Add(monthBox);
            tabTop5.Controls.Add(yearMonthLbl);
            tabTop5.Controls.Add(yearMonthBox);
            tabTop5.Controls.Add(reportTop5Btn);
            tabTop5.Controls.Add(top5Grid);
            tabTop5.Location = new Point(4, 32);
            tabTop5.Name = "tabTop5";
            tabTop5.Size = new Size(1085, 794);
            tabTop5.TabIndex = 3;
            tabTop5.Text = "Top 5 NCC theo tháng";

            monthLbl.AutoSize = true;
            monthLbl.Font = new Font("Segoe UI", 10F);
            monthLbl.Location = new Point(25, 30);
            monthLbl.Name = "monthLbl";
            monthLbl.Size = new Size(62, 23);
            monthLbl.TabIndex = 0;
            monthLbl.Text = "Tháng:";

            monthBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthBox.Font = new Font("Segoe UI", 10F);
            monthBox.Items.AddRange(new object[]
            {
                "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4",
                "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8",
                "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"
            });
            monthBox.Location = new Point(93, 27);
            monthBox.Name = "monthBox";
            monthBox.Size = new Size(120, 31);
            monthBox.TabIndex = 1;
            monthBox.SelectedIndex = DateTime.Now.Month - 1;

            yearMonthLbl.AutoSize = true;
            yearMonthLbl.Font = new Font("Segoe UI", 10F);
            yearMonthLbl.Location = new Point(245, 30);
            yearMonthLbl.Name = "yearMonthLbl";
            yearMonthLbl.Size = new Size(51, 23);
            yearMonthLbl.TabIndex = 2;
            yearMonthLbl.Text = "Năm:";

            yearMonthBox.Font = new Font("Segoe UI", 10F);
            yearMonthBox.Location = new Point(312, 27);
            yearMonthBox.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            yearMonthBox.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            yearMonthBox.Name = "yearMonthBox";
            yearMonthBox.Size = new Size(120, 30);
            yearMonthBox.TabIndex = 3;
            yearMonthBox.Value = new decimal(new int[] { 2026, 0, 0, 0 });

            reportTop5Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reportTop5Btn.Location = new Point(455, 23);
            reportTop5Btn.Name = "reportTop5Btn";
            reportTop5Btn.Size = new Size(130, 36);
            reportTop5Btn.TabIndex = 4;
            reportTop5Btn.Text = "Thống kê";
            reportTop5Btn.UseVisualStyleBackColor = true;

            top5Grid.AllowUserToAddRows = false;
            top5Grid.AllowUserToDeleteRows = false;
            top5Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            top5Grid.BackgroundColor = Color.White;
            top5Grid.ColumnHeadersHeight = 40;
            top5Grid.Location = new Point(20, 85);
            top5Grid.Name = "top5Grid";
            top5Grid.ReadOnly = true;
            top5Grid.RowHeadersVisible = false;
            top5Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            top5Grid.MultiSelect = false;
            top5Grid.Size = new Size(1040, 680);
            top5Grid.TabIndex = 5;

            top5Grid.Columns.Add("col1", "Mã NCC");
            top5Grid.Columns.Add("col2", "Tên nhà cung cấp");
            top5Grid.Columns.Add("col3", "Số hóa đơn nhập");
            top5Grid.Columns.Add("col4", "Tổng tiền nhập");

            Controls.Add(tabControl);

            tabControl.ResumeLayout(false);
            tabTop3.ResumeLayout(false);
            tabTop3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)top3Grid).EndInit();
            tabNCC.ResumeLayout(false);
            tabNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)supplierGrid).EndInit();
            tabQuy.ResumeLayout(false);
            tabQuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearQuarterBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)quarterGrid).EndInit();
            tabTop5.ResumeLayout(false);
            tabTop5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearMonthBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)top5Grid).EndInit();

            ResumeLayout(false);
        }
    }
}
