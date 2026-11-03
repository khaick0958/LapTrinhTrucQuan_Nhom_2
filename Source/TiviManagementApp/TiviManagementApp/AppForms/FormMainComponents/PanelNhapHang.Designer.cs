
namespace QuanLyCuaHangTivi
{
    partial class PanelNhapHang
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idHDNBox;
        private DateTimePicker dateHDNBox;
        private ComboBox supplierHDNBox;
        private ComboBox employeeHDNBox;

        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox idTVBox;
        private TextBox nameTVBox;
        private NumericUpDown amountTVBox;
        private NumericUpDown buyPriceTVBox;
        private NumericUpDown saleTVBox;
        private Button addBtn;

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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label1 = new Label();
            idHDNBox = new TextBox();
            label2 = new Label();
            dateHDNBox = new DateTimePicker();
            label3 = new Label();
            supplierHDNBox = new ComboBox();
            label4 = new Label();
            employeeHDNBox = new ComboBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            idTVBox = new ComboBox();
            label6 = new Label();
            nameTVBox = new TextBox();
            label7 = new Label();
            amountTVBox = new NumericUpDown();
            label8 = new Label();
            buyPriceTVBox = new NumericUpDown();
            label9 = new Label();
            saleTVBox = new NumericUpDown();
            addBtn = new Button();
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
            ((System.ComponentModel.ISupportInitialize)amountTVBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buyPriceTVBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleTVBox).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTableView).BeginInit();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(idHDNBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateHDNBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(supplierHDNBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(employeeHDNBox);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(20, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1103, 145);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "1. Thông tin hóa đơn nhập";
            // 
            // label1
            // 
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn nhập:";
            // 
            // idHDNBox
            // 
            idHDNBox.Font = new Font("Segoe UI", 10F);
            idHDNBox.Location = new Point(165, 30);
            idHDNBox.Name = "idHDNBox";
            idHDNBox.Size = new Size(330, 30);
            idHDNBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(560, 32);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 2;
            label2.Text = "Ngày nhập:";
            // 
            // dateHDNBox
            // 
            dateHDNBox.Font = new Font("Segoe UI", 10F);
            dateHDNBox.Format = DateTimePickerFormat.Short;
            dateHDNBox.Location = new Point(665, 30);
            dateHDNBox.Name = "dateHDNBox";
            dateHDNBox.Size = new Size(390, 30);
            dateHDNBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(20, 82);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 4;
            label3.Text = "Nhà cung cấp:";
            // 
            // supplierHDNBox
            // 
            supplierHDNBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierHDNBox.Font = new Font("Segoe UI", 10F);
            supplierHDNBox.Location = new Point(165, 80);
            supplierHDNBox.Name = "supplierHDNBox";
            supplierHDNBox.Size = new Size(330, 31);
            supplierHDNBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(560, 82);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 6;
            label4.Text = "Nhân viên nhập:";
            // 
            // employeeHDNBox
            // 
            employeeHDNBox.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeHDNBox.Font = new Font("Segoe UI", 10F);
            employeeHDNBox.Location = new Point(665, 80);
            employeeHDNBox.Name = "employeeHDNBox";
            employeeHDNBox.Size = new Size(390, 31);
            employeeHDNBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(idTVBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(nameTVBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(amountTVBox);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(buyPriceTVBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(saleTVBox);
            groupBox2.Controls.Add(addBtn);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(20, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1103, 195);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "2. Thêm Tivi vào hóa đơn";
            // 
            // label5
            // 
            label5.Location = new Point(20, 35);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 0;
            label5.Text = "Mã Tivi:";
            // 
            // idTVBox
            // 
            idTVBox.DropDownStyle = ComboBoxStyle.DropDownList;
            idTVBox.Font = new Font("Segoe UI", 10F);
            idTVBox.Location = new Point(140, 32);
            idTVBox.Name = "idTVBox";
            idTVBox.Size = new Size(340, 31);
            idTVBox.TabIndex = 1;
            idTVBox.SelectedIndexChanged += idTVBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Location = new Point(520, 35);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 2;
            label6.Text = "Tên Tivi:";
            // 
            // nameTVBox
            // 
            nameTVBox.BackColor = Color.FromArgb(242, 244, 248);
            nameTVBox.Font = new Font("Segoe UI", 10F);
            nameTVBox.Location = new Point(620, 32);
            nameTVBox.Name = "nameTVBox";
            nameTVBox.ReadOnly = true;
            nameTVBox.Size = new Size(435, 30);
            nameTVBox.TabIndex = 3;
            // 
            // label7
            // 
            label7.Location = new Point(20, 88);
            label7.Name = "label7";
            label7.Size = new Size(120, 25);
            label7.TabIndex = 4;
            label7.Text = "Số lượng nhập:";
            // 
            // amountTVBox
            // 
            amountTVBox.Font = new Font("Segoe UI", 10F);
            amountTVBox.Location = new Point(140, 85);
            amountTVBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            amountTVBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amountTVBox.Name = "amountTVBox";
            amountTVBox.Size = new Size(150, 30);
            amountTVBox.TabIndex = 5;
            amountTVBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.Location = new Point(330, 88);
            label8.Name = "label8";
            label8.Size = new Size(120, 25);
            label8.TabIndex = 6;
            label8.Text = "Đơn giá nhập:";
            // 
            // buyPriceTVBox
            // 
            buyPriceTVBox.Font = new Font("Segoe UI", 10F);
            buyPriceTVBox.Location = new Point(450, 85);
            buyPriceTVBox.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            buyPriceTVBox.Name = "buyPriceTVBox";
            buyPriceTVBox.Size = new Size(220, 30);
            buyPriceTVBox.TabIndex = 7;
            buyPriceTVBox.ThousandsSeparator = true;
            // 
            // label9
            // 
            label9.Location = new Point(700, 88);
            label9.Name = "label9";
            label9.Size = new Size(105, 25);
            label9.TabIndex = 8;
            label9.Text = "Giảm giá (%):";
            // 
            // saleTVBox
            // 
            saleTVBox.DecimalPlaces = 2;
            saleTVBox.Font = new Font("Segoe UI", 10F);
            saleTVBox.Location = new Point(805, 85);
            saleTVBox.Name = "saleTVBox";
            saleTVBox.Size = new Size(100, 30);
            saleTVBox.TabIndex = 9;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(36, 116, 71);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(805, 135);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 38);
            addBtn.TabIndex = 10;
            addBtn.Text = "＋  Thêm vào hóa đơn";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(dataTableView);
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox3.Location = new Point(20, 375);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1103, 245);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "3. Danh sách Tivi nhập";
            // 
            // dataTableView
            // 
            dataTableView.AllowUserToAddRows = false;
            dataTableView.AllowUserToDeleteRows = false;
            dataTableView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTableView.BackgroundColor = Color.White;
            dataTableView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(232, 237, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(35, 48, 68);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataTableView.ColumnHeadersHeight = 38;
            dataTableView.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4, col5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(218, 232, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 40, 55);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataTableView.DefaultCellStyle = dataGridViewCellStyle2;
            dataTableView.Dock = DockStyle.Fill;
            dataTableView.EnableHeadersVisualStyles = false;
            dataTableView.Font = new Font("Segoe UI", 9.5F);
            dataTableView.Location = new Point(3, 26);
            dataTableView.MultiSelect = false;
            dataTableView.Name = "dataTableView";
            dataTableView.ReadOnly = true;
            dataTableView.RowHeadersVisible = false;
            dataTableView.RowHeadersWidth = 51;
            dataTableView.RowTemplate.Height = 32;
            dataTableView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTableView.Size = new Size(1097, 216);
            dataTableView.TabIndex = 0;
            // 
            // col1
            // 
            col1.FillWeight = 85F;
            col1.HeaderText = "Mã Tivi";
            col1.MinimumWidth = 6;
            col1.Name = "col1";
            col1.ReadOnly = true;
            // 
            // col2
            // 
            col2.FillWeight = 180F;
            col2.HeaderText = "Tên Tivi";
            col2.MinimumWidth = 6;
            col2.Name = "col2";
            col2.ReadOnly = true;
            // 
            // col3
            // 
            col3.FillWeight = 80F;
            col3.HeaderText = "Số lượng";
            col3.MinimumWidth = 6;
            col3.Name = "col3";
            col3.ReadOnly = true;
            // 
            // col4
            // 
            col4.FillWeight = 120F;
            col4.HeaderText = "Đơn giá nhập";
            col4.MinimumWidth = 6;
            col4.Name = "col4";
            col4.ReadOnly = true;
            // 
            // col5
            // 
            col5.FillWeight = 120F;
            col5.HeaderText = "Thành tiền";
            col5.MinimumWidth = 6;
            col5.Name = "col5";
            col5.ReadOnly = true;
            // 
            // footerPanel
            // 
            footerPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            footerPanel.BackColor = Color.White;
            footerPanel.Controls.Add(label10);
            footerPanel.Controls.Add(totalFeeLbl);
            footerPanel.Controls.Add(saveBtn);
            footerPanel.Controls.Add(resetBtn);
            footerPanel.Controls.Add(cancelBtn);
            footerPanel.Location = new Point(20, 630);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(1103, 149);
            footerPanel.TabIndex = 0;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.FromArgb(90, 100, 115);
            label10.Location = new Point(20, 20);
            label10.Name = "label10";
            label10.Size = new Size(350, 28);
            label10.TabIndex = 0;
            label10.Text = "Tổng số sản phẩm: 0 chiếc";
            // 
            // totalFeeLbl
            // 
            totalFeeLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalFeeLbl.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            totalFeeLbl.ForeColor = Color.FromArgb(36, 116, 71);
            totalFeeLbl.Location = new Point(600, 12);
            totalFeeLbl.Name = "totalFeeLbl";
            totalFeeLbl.Size = new Size(475, 38);
            totalFeeLbl.TabIndex = 1;
            totalFeeLbl.Text = "TỔNG TIỀN: 0 đ";
            totalFeeLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(36, 116, 71);
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(20, 75);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(220, 45);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Lưu phiếu nhập";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(232, 237, 245);
            resetBtn.Cursor = Cursors.Hand;
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Segoe UI", 10F);
            resetBtn.ForeColor = Color.FromArgb(35, 48, 68);
            resetBtn.Location = new Point(255, 75);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(160, 45);
            resetBtn.TabIndex = 3;
            resetBtn.Text = "Làm mới";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.White;
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatAppearance.BorderColor = Color.FromArgb(220, 100, 100);
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 10F);
            cancelBtn.ForeColor = Color.FromArgb(180, 50, 50);
            cancelBtn.Location = new Point(430, 75);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(130, 45);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Hủy";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // PanelNhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 251);
            Controls.Add(footerPanel);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(900, 700);
            Name = "PanelNhapHang";
            Size = new Size(1143, 790);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountTVBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)buyPriceTVBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleTVBox).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataTableView).EndInit();
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
