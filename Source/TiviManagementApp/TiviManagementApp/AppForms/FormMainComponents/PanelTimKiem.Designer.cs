namespace QuanLyCuaHangTivi
{
    partial class PanelTimKiem
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            dataTableViewTV = new DataGridView();
            MaTivi = new DataGridViewTextBoxColumn();
            TenTivi = new DataGridViewTextBoxColumn();
            Branch = new DataGridViewTextBoxColumn();
            Screen = new DataGridViewTextBoxColumn();
            TVSize = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            SellPrice = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            branchCBox = new ComboBox();
            screenCBox = new ComboBox();
            resetTVBtn = new Button();
            sizeCBox = new ComboBox();
            searchTVBtn = new Button();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            dataTableViewHDN = new DataGridView();
            MaHDN = new DataGridViewTextBoxColumn();
            dateHDN = new DataGridViewTextBoxColumn();
            maTVHDN = new DataGridViewTextBoxColumn();
            AmountHDN = new DataGridViewTextBoxColumn();
            FirstPriceHDN = new DataGridViewTextBoxColumn();
            SaleHDN = new DataGridViewTextBoxColumn();
            TotalPriceHDN = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            amountBox = new TextBox();
            maTVBox = new TextBox();
            searchHDNBtn = new Button();
            resetHDNBtn = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTableViewTV).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTableViewHDN).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1143, 876);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1135, 843);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tìm tivi";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataTableViewTV);
            groupBox2.Location = new Point(12, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1117, 714);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // dataTableViewTV
            // 
            dataTableViewTV.AllowUserToAddRows = false;
            dataTableViewTV.AllowUserToDeleteRows = false;
            dataTableViewTV.AllowUserToResizeRows = false;
            dataTableViewTV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTableViewTV.BackgroundColor = SystemColors.Control;
            dataTableViewTV.BorderStyle = BorderStyle.None;
            dataTableViewTV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTableViewTV.Columns.AddRange(new DataGridViewColumn[] { MaTivi, TenTivi, Branch, Screen, TVSize, Amount, SellPrice });
            dataTableViewTV.Dock = DockStyle.Fill;
            dataTableViewTV.Location = new Point(3, 23);
            dataTableViewTV.Name = "dataTableViewTV";
            dataTableViewTV.RowHeadersVisible = false;
            dataTableViewTV.RowHeadersWidth = 51;
            dataTableViewTV.Size = new Size(1111, 688);
            dataTableViewTV.TabIndex = 0;
            // 
            // MaTivi
            // 
            MaTivi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MaTivi.FillWeight = 60F;
            MaTivi.HeaderText = "Mã";
            MaTivi.MinimumWidth = 6;
            MaTivi.Name = "MaTivi";
            MaTivi.ReadOnly = true;
            MaTivi.Width = 109;
            // 
            // TenTivi
            // 
            TenTivi.FillWeight = 160F;
            TenTivi.HeaderText = "Tên tivi";
            TenTivi.MinimumWidth = 6;
            TenTivi.Name = "TenTivi";
            TenTivi.ReadOnly = true;
            // 
            // Branch
            // 
            Branch.FillWeight = 90F;
            Branch.HeaderText = "Hãng";
            Branch.MinimumWidth = 6;
            Branch.Name = "Branch";
            Branch.ReadOnly = true;
            // 
            // Screen
            // 
            Screen.FillWeight = 90F;
            Screen.HeaderText = "Màn hình";
            Screen.MinimumWidth = 6;
            Screen.Name = "Screen";
            Screen.ReadOnly = true;
            // 
            // TVSize
            // 
            TVSize.FillWeight = 50F;
            TVSize.HeaderText = "Cỡ";
            TVSize.MinimumWidth = 6;
            TVSize.Name = "TVSize";
            TVSize.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.FillWeight = 50F;
            Amount.HeaderText = "SL";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // SellPrice
            // 
            SellPrice.FillWeight = 110F;
            SellPrice.HeaderText = "Giá bán";
            SellPrice.MinimumWidth = 6;
            SellPrice.Name = "SellPrice";
            SellPrice.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(branchCBox);
            groupBox1.Controls.Add(screenCBox);
            groupBox1.Controls.Add(resetTVBtn);
            groupBox1.Controls.Add(sizeCBox);
            groupBox1.Controls.Add(searchTVBtn);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1123, 111);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 28);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 7;
            label3.Text = "Cỡ (Inch)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 28);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Màn hình";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 5;
            label1.Text = "Hãng sản xuất";
            // 
            // branchCBox
            // 
            branchCBox.Font = new Font("Segoe UI", 12F);
            branchCBox.FormattingEnabled = true;
            branchCBox.Location = new Point(6, 51);
            branchCBox.Name = "branchCBox";
            branchCBox.Size = new Size(225, 36);
            branchCBox.TabIndex = 2;
            branchCBox.SelectedIndexChanged += branchCBox_SelectedIndexChanged;
            // 
            // screenCBox
            // 
            screenCBox.Font = new Font("Segoe UI", 12F);
            screenCBox.FormattingEnabled = true;
            screenCBox.Location = new Point(275, 51);
            screenCBox.Name = "screenCBox";
            screenCBox.Size = new Size(225, 36);
            screenCBox.TabIndex = 1;
            screenCBox.SelectedIndexChanged += screenCBox_SelectedIndexChanged;
            // 
            // resetTVBtn
            // 
            resetTVBtn.Location = new Point(979, 37);
            resetTVBtn.Name = "resetTVBtn";
            resetTVBtn.Size = new Size(110, 54);
            resetTVBtn.TabIndex = 4;
            resetTVBtn.Text = "Đặt lại";
            resetTVBtn.UseVisualStyleBackColor = true;
            resetTVBtn.Click += resetBtn_Click;
            // 
            // sizeCBox
            // 
            sizeCBox.Font = new Font("Segoe UI", 12F);
            sizeCBox.FormattingEnabled = true;
            sizeCBox.Location = new Point(548, 51);
            sizeCBox.Name = "sizeCBox";
            sizeCBox.Size = new Size(225, 36);
            sizeCBox.TabIndex = 0;
            sizeCBox.SelectedIndexChanged += sizeCBox_SelectedIndexChanged;
            // 
            // searchTVBtn
            // 
            searchTVBtn.Location = new Point(838, 37);
            searchTVBtn.Name = "searchTVBtn";
            searchTVBtn.Size = new Size(110, 54);
            searchTVBtn.TabIndex = 3;
            searchTVBtn.Text = "Tìm kiếm";
            searchTVBtn.UseVisualStyleBackColor = true;
            searchTVBtn.Click += searchBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1135, 843);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tìm hóa đơn nhập";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataTableViewHDN);
            groupBox4.Location = new Point(6, 112);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1123, 725);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // dataTableViewHDN
            // 
            dataTableViewHDN.AllowUserToAddRows = false;
            dataTableViewHDN.AllowUserToDeleteRows = false;
            dataTableViewHDN.AllowUserToResizeColumns = false;
            dataTableViewHDN.AllowUserToResizeRows = false;
            dataTableViewHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTableViewHDN.BackgroundColor = SystemColors.Control;
            dataTableViewHDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTableViewHDN.Columns.AddRange(new DataGridViewColumn[] { MaHDN, dateHDN, maTVHDN, AmountHDN, FirstPriceHDN, SaleHDN, TotalPriceHDN });
            dataTableViewHDN.Dock = DockStyle.Fill;
            dataTableViewHDN.Location = new Point(3, 23);
            dataTableViewHDN.Name = "dataTableViewHDN";
            dataTableViewHDN.ReadOnly = true;
            dataTableViewHDN.RowHeadersVisible = false;
            dataTableViewHDN.RowHeadersWidth = 51;
            dataTableViewHDN.Size = new Size(1117, 699);
            dataTableViewHDN.TabIndex = 6;
            // 
            // MaHDN
            // 
            MaHDN.FillWeight = 80F;
            MaHDN.HeaderText = "Mã hóa đơn nhập";
            MaHDN.MinimumWidth = 6;
            MaHDN.Name = "MaHDN";
            MaHDN.ReadOnly = true;
            // 
            // dateHDN
            // 
            dateHDN.FillWeight = 60F;
            dateHDN.HeaderText = "Ngày nhập";
            dateHDN.MinimumWidth = 6;
            dateHDN.Name = "dateHDN";
            dateHDN.ReadOnly = true;
            // 
            // maTVHDN
            // 
            maTVHDN.FillWeight = 80F;
            maTVHDN.HeaderText = "Mã tivi";
            maTVHDN.MinimumWidth = 6;
            maTVHDN.Name = "maTVHDN";
            maTVHDN.ReadOnly = true;
            // 
            // AmountHDN
            // 
            AmountHDN.FillWeight = 50F;
            AmountHDN.HeaderText = "SL nhập";
            AmountHDN.MinimumWidth = 6;
            AmountHDN.Name = "AmountHDN";
            AmountHDN.ReadOnly = true;
            // 
            // FirstPriceHDN
            // 
            FirstPriceHDN.HeaderText = "Đơn giá";
            FirstPriceHDN.MinimumWidth = 6;
            FirstPriceHDN.Name = "FirstPriceHDN";
            FirstPriceHDN.ReadOnly = true;
            // 
            // SaleHDN
            // 
            SaleHDN.FillWeight = 50F;
            SaleHDN.HeaderText = "Giảm giá";
            SaleHDN.MinimumWidth = 6;
            SaleHDN.Name = "SaleHDN";
            SaleHDN.ReadOnly = true;
            // 
            // TotalPriceHDN
            // 
            TotalPriceHDN.HeaderText = "Thành tiền";
            TotalPriceHDN.MinimumWidth = 6;
            TotalPriceHDN.Name = "TotalPriceHDN";
            TotalPriceHDN.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(amountBox);
            groupBox3.Controls.Add(maTVBox);
            groupBox3.Controls.Add(searchHDNBtn);
            groupBox3.Controls.Add(resetHDNBtn);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1123, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 23);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 9;
            label5.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 23);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 8;
            label4.Text = "Mã Tivi";
            // 
            // amountBox
            // 
            amountBox.Font = new Font("Segoe UI", 12F);
            amountBox.Location = new Point(376, 43);
            amountBox.Name = "amountBox";
            amountBox.PlaceholderText = "Nhập số lượng...";
            amountBox.Size = new Size(189, 34);
            amountBox.TabIndex = 7;
            // 
            // maTVBox
            // 
            maTVBox.Font = new Font("Segoe UI", 12F);
            maTVBox.Location = new Point(16, 43);
            maTVBox.Name = "maTVBox";
            maTVBox.PlaceholderText = "Nhập mã tivi...";
            maTVBox.Size = new Size(301, 34);
            maTVBox.TabIndex = 6;
            // 
            // searchHDNBtn
            // 
            searchHDNBtn.Location = new Point(722, 27);
            searchHDNBtn.Name = "searchHDNBtn";
            searchHDNBtn.Size = new Size(114, 50);
            searchHDNBtn.TabIndex = 4;
            searchHDNBtn.Text = "Tìm kiếm";
            searchHDNBtn.UseVisualStyleBackColor = true;
            searchHDNBtn.Click += searchHDNBtn_Click;
            // 
            // resetHDNBtn
            // 
            resetHDNBtn.Location = new Point(931, 27);
            resetHDNBtn.Name = "resetHDNBtn";
            resetHDNBtn.Size = new Size(114, 50);
            resetHDNBtn.TabIndex = 5;
            resetHDNBtn.Text = "Đặt lại";
            resetHDNBtn.UseVisualStyleBackColor = true;
            resetHDNBtn.Click += resetHDNBtn_Click;
            // 
            // PanelTimKiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 251);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelTimKiem";
            Size = new Size(1143, 876);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataTableViewTV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataTableViewHDN).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ComboBox branchCBox;
        private ComboBox screenCBox;
        private Button resetTVBtn;
        private ComboBox sizeCBox;
        private Button searchTVBtn;
        private DataGridView dataTableViewTV;
        private DataGridViewTextBoxColumn MaTivi;
        private DataGridViewTextBoxColumn TenTivi;
        private DataGridViewTextBoxColumn Branch;
        private DataGridViewTextBoxColumn Screen;
        private DataGridViewTextBoxColumn TVSize;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn SellPrice;
        private DataGridView dataTableViewHDN;
        private Button resetHDNBtn;
        private Button searchHDNBtn;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox amountBox;
        private TextBox maTVBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn MaHDN;
        private DataGridViewTextBoxColumn dateHDN;
        private DataGridViewTextBoxColumn maTVHDN;
        private DataGridViewTextBoxColumn AmountHDN;
        private DataGridViewTextBoxColumn FirstPriceHDN;
        private DataGridViewTextBoxColumn SaleHDN;
        private DataGridViewTextBoxColumn TotalPriceHDN;
    }
}
