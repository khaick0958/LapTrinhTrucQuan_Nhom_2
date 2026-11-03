
namespace QuanLyCuaHangTivi
{
    partial class PanelBanHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dateHDBBox = new DateTimePicker();
            employeeHDBBox = new ComboBox();
            customerHDBBox = new ComboBox();
            idHDBBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            addBtn = new Button();
            taxTVBox = new NumericUpDown();
            salePriceTVBox = new NumericUpDown();
            amountTVBox = new NumericUpDown();
            nameTVBox = new TextBox();
            idTVBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            dataTableView = new DataGridView();
            col1 = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            col4 = new DataGridViewTextBoxColumn();
            col5 = new DataGridViewTextBoxColumn();
            footerPanel = new Panel();
            label10 = new Label();
            totalFeeLbl = new Label();
            saveBtn = new Button();
            resetBtn = new Button();
            cancelBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taxTVBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salePriceTVBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountTVBox).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTableView).BeginInit();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateHDBBox);
            groupBox1.Controls.Add(employeeHDBBox);
            groupBox1.Controls.Add(customerHDBBox);
            groupBox1.Controls.Add(idHDBBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(20, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1103, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN HÓA ĐƠN BÁN";
            // 
            // dateHDBBox
            // 
            dateHDBBox.CustomFormat = "dd/MM/yyyy HH:mm";
            dateHDBBox.Font = new Font("Segoe UI", 10F);
            dateHDBBox.Format = DateTimePickerFormat.Custom;
            dateHDBBox.Location = new Point(690, 34);
            dateHDBBox.Name = "dateHDBBox";
            dateHDBBox.Size = new Size(350, 30);
            dateHDBBox.TabIndex = 1;
            // 
            // employeeHDBBox
            // 
            employeeHDBBox.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeHDBBox.Font = new Font("Segoe UI", 10F);
            employeeHDBBox.FormattingEnabled = true;
            employeeHDBBox.Location = new Point(690, 87);
            employeeHDBBox.Name = "employeeHDBBox";
            employeeHDBBox.Size = new Size(350, 31);
            employeeHDBBox.TabIndex = 3;
            // 
            // customerHDBBox
            // 
            customerHDBBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerHDBBox.Font = new Font("Segoe UI", 10F);
            customerHDBBox.FormattingEnabled = true;
            customerHDBBox.Location = new Point(160, 87);
            customerHDBBox.Name = "customerHDBBox";
            customerHDBBox.Size = new Size(350, 31);
            customerHDBBox.TabIndex = 2;
            // 
            // idHDBBox
            // 
            idHDBBox.Font = new Font("Segoe UI", 10F);
            idHDBBox.Location = new Point(160, 34);
            idHDBBox.Name = "idHDBBox";
            idHDBBox.Size = new Size(350, 30);
            idHDBBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 4;
            label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(560, 38);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 5;
            label2.Text = "Ngày bán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(25, 91);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 6;
            label3.Text = "Khách hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(560, 91);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 7;
            label4.Text = "Nhân viên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(addBtn);
            groupBox2.Controls.Add(taxTVBox);
            groupBox2.Controls.Add(salePriceTVBox);
            groupBox2.Controls.Add(amountTVBox);
            groupBox2.Controls.Add(nameTVBox);
            groupBox2.Controls.Add(idTVBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(20, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1103, 190);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN TIVI BÁN";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(37, 99, 235);
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(920, 135);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(120, 35);
            addBtn.TabIndex = 5;
            addBtn.Text = "＋ Thêm";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // taxTVBox
            // 
            taxTVBox.DecimalPlaces = 2;
            taxTVBox.Font = new Font("Segoe UI", 10F);
            taxTVBox.Location = new Point(810, 90);
            taxTVBox.Name = "taxTVBox";
            taxTVBox.Size = new Size(100, 30);
            taxTVBox.TabIndex = 4;
            taxTVBox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // salePriceTVBox
            // 
            salePriceTVBox.DecimalPlaces = 2;
            salePriceTVBox.Font = new Font("Segoe UI", 10F);
            salePriceTVBox.Location = new Point(450, 90);
            salePriceTVBox.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            salePriceTVBox.Name = "salePriceTVBox";
            salePriceTVBox.ReadOnly = true;
            salePriceTVBox.Size = new Size(220, 30);
            salePriceTVBox.TabIndex = 3;
            salePriceTVBox.ThousandsSeparator = true;
            // 
            // amountTVBox
            // 
            amountTVBox.Font = new Font("Segoe UI", 10F);
            amountTVBox.Location = new Point(130, 90);
            amountTVBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            amountTVBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amountTVBox.Name = "amountTVBox";
            amountTVBox.Size = new Size(150, 30);
            amountTVBox.TabIndex = 2;
            amountTVBox.ThousandsSeparator = true;
            amountTVBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nameTVBox
            // 
            nameTVBox.Font = new Font("Segoe UI", 10F);
            nameTVBox.Location = new Point(610, 38);
            nameTVBox.Name = "nameTVBox";
            nameTVBox.ReadOnly = true;
            nameTVBox.Size = new Size(430, 30);
            nameTVBox.TabIndex = 1;
            // 
            // idTVBox
            // 
            idTVBox.DropDownStyle = ComboBoxStyle.DropDownList;
            idTVBox.Font = new Font("Segoe UI", 10F);
            idTVBox.FormattingEnabled = true;
            idTVBox.Location = new Point(130, 38);
            idTVBox.Name = "idTVBox";
            idTVBox.Size = new Size(330, 31);
            idTVBox.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(25, 42);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 6;
            label5.Text = "Mã Tivi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(500, 42);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 7;
            label6.Text = "Tên Tivi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(25, 94);
            label7.Name = "label7";
            label7.Size = new Size(82, 23);
            label7.TabIndex = 8;
            label7.Text = "Số lượng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(320, 94);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 9;
            label8.Text = "Đơn giá bán:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(710, 94);
            label9.Name = "label9";
            label9.Size = new Size(81, 23);
            label9.TabIndex = 10;
            label9.Text = "Thuế (%):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataTableView);
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox3.Location = new Point(20, 375);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1103, 280);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "CHI TIẾT HÓA ĐƠN BÁN";
            // 
            // dataTableView
            // 
            dataTableView.AllowUserToAddRows = false;
            dataTableView.AllowUserToDeleteRows = false;
            dataTableView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTableView.BackgroundColor = Color.White;
            dataTableView.ColumnHeadersHeight = 40;
            dataTableView.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4, col5 });
            dataTableView.Location = new Point(0, 0);
            dataTableView.MultiSelect = false;
            dataTableView.Name = "dataTableView";
            dataTableView.ReadOnly = true;
            dataTableView.RowHeadersVisible = false;
            dataTableView.RowHeadersWidth = 51;
            dataTableView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTableView.Size = new Size(1103, 280);
            dataTableView.TabIndex = 0;
            // 
            // col1
            // 
            col1.FillWeight = 90F;
            col1.HeaderText = "Mã Tivi";
            col1.MinimumWidth = 6;
            col1.Name = "col1";
            col1.ReadOnly = true;
            // 
            // col2
            // 
            col2.FillWeight = 200F;
            col2.HeaderText = "Tên Tivi";
            col2.MinimumWidth = 6;
            col2.Name = "col2";
            col2.ReadOnly = true;
            // 
            // col3
            // 
            col3.FillWeight = 90F;
            col3.HeaderText = "Số lượng";
            col3.MinimumWidth = 6;
            col3.Name = "col3";
            col3.ReadOnly = true;
            // 
            // col4
            // 
            col4.FillWeight = 130F;
            col4.HeaderText = "Đơn giá bán";
            col4.MinimumWidth = 6;
            col4.Name = "col4";
            col4.ReadOnly = true;
            // 
            // col5
            // 
            col5.FillWeight = 140F;
            col5.HeaderText = "Thành tiền";
            col5.MinimumWidth = 6;
            col5.Name = "col5";
            col5.ReadOnly = true;
            // 
            // footerPanel
            // 
            footerPanel.Controls.Add(label10);
            footerPanel.Controls.Add(totalFeeLbl);
            footerPanel.Controls.Add(saveBtn);
            footerPanel.Controls.Add(resetBtn);
            footerPanel.Controls.Add(cancelBtn);
            footerPanel.Location = new Point(20, 665);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(1103, 190);
            footerPanel.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(55, 65, 81);
            label10.Location = new Point(10, 15);
            label10.Name = "label10";
            label10.Size = new Size(244, 25);
            label10.TabIndex = 0;
            label10.Text = "Tổng số sản phẩm: 0 chiếc";
            // 
            // totalFeeLbl
            // 
            totalFeeLbl.AutoSize = true;
            totalFeeLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            totalFeeLbl.ForeColor = Color.FromArgb(22, 101, 52);
            totalFeeLbl.Location = new Point(10, 55);
            totalFeeLbl.Name = "totalFeeLbl";
            totalFeeLbl.Size = new Size(214, 37);
            totalFeeLbl.TabIndex = 1;
            totalFeeLbl.Text = "TỔNG TIỀN: 0 đ";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(22, 163, 74);
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(480, 120);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(170, 42);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Lưu hóa đơn";
            saveBtn.UseVisualStyleBackColor = false;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(245, 158, 11);
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            resetBtn.ForeColor = Color.White;
            resetBtn.Location = new Point(670, 120);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(170, 42);
            resetBtn.TabIndex = 1;
            resetBtn.Text = "Làm mới";
            resetBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(220, 38, 38);
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(860, 120);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(170, 42);
            cancelBtn.TabIndex = 2;
            cancelBtn.Text = "Hủy";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // PanelBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 251);
            Controls.Add(footerPanel);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelBanHang";
            Size = new Size(1143, 876);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taxTVBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)salePriceTVBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountTVBox).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataTableView).EndInit();
            footerPanel.ResumeLayout(false);
            footerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateHDBBox;
        private ComboBox employeeHDBBox;
        private ComboBox customerHDBBox;
        private TextBox idHDBBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        private GroupBox groupBox2;
        private Button addBtn;
        private NumericUpDown taxTVBox;
        private NumericUpDown salePriceTVBox;
        private NumericUpDown amountTVBox;
        private TextBox nameTVBox;
        private ComboBox idTVBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;

        private GroupBox groupBox3;
        private DataGridView dataTableView;
        private DataGridViewTextBoxColumn col1;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn col4;
        private DataGridViewTextBoxColumn col5;

        private Panel footerPanel;
        private Label label10;
        private Label totalFeeLbl;
        private Button saveBtn;
        private Button resetBtn;
        private Button cancelBtn;
    }
}
