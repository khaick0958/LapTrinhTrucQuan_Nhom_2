namespace QuanLyCuaHangTivi
{
    partial class PanelDanhMuc
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
            dataViewTable = new DataGridView();
            MaTV = new DataGridViewTextBoxColumn();
            TenTV = new DataGridViewTextBoxColumn();
            Branch = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            SellPrice = new DataGridViewTextBoxColumn();
            filterBox = new TextBox();
            groupBox2 = new GroupBox();
            pickImageBtn = new Button();
            label13 = new Label();
            imageBox = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            repairTVBox = new NumericUpDown();
            countryTVBox = new ComboBox();
            sizeTVBox = new ComboBox();
            screenTVBox = new ComboBox();
            colorTVBox = new ComboBox();
            styleTVBox = new ComboBox();
            branchTVBox = new ComboBox();
            amountTVBox = new TextBox();
            sellPriceBox = new TextBox();
            buyPriceBox = new TextBox();
            nameTVBox = new TextBox();
            idTVBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cancelBtn = new Button();
            saveBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataViewTable).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repairTVBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataViewTable);
            groupBox1.Controls.Add(filterBox);
            groupBox1.Location = new Point(15, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(518, 845);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dataViewTable
            // 
            dataViewTable.AllowUserToAddRows = false;
            dataViewTable.AllowUserToDeleteRows = false;
            dataViewTable.AllowUserToResizeRows = false;
            dataViewTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataViewTable.BackgroundColor = Color.White;
            dataViewTable.BorderStyle = BorderStyle.None;
            dataViewTable.ColumnHeadersHeight = 32;
            dataViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataViewTable.Columns.AddRange(new DataGridViewColumn[] { MaTV, TenTV, Branch, Amount, SellPrice });
            dataViewTable.Location = new Point(16, 67);
            dataViewTable.Margin = new Padding(3, 4, 3, 4);
            dataViewTable.MultiSelect = false;
            dataViewTable.Name = "dataViewTable";
            dataViewTable.ReadOnly = true;
            dataViewTable.RowHeadersVisible = false;
            dataViewTable.RowHeadersWidth = 51;
            dataViewTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataViewTable.Size = new Size(491, 734);
            dataViewTable.TabIndex = 1;
            dataViewTable.SelectionChanged += dataViewTable_SelectionChanged;
            // 
            // MaTV
            // 
            MaTV.FillWeight = 85.36182F;
            MaTV.HeaderText = "Mã TiVi";
            MaTV.MinimumWidth = 6;
            MaTV.Name = "MaTV";
            MaTV.ReadOnly = true;
            // 
            // TenTV
            // 
            TenTV.FillWeight = 146.835556F;
            TenTV.HeaderText = "Tên Tivi";
            TenTV.MinimumWidth = 6;
            TenTV.Name = "TenTV";
            TenTV.ReadOnly = true;
            // 
            // Branch
            // 
            Branch.FillWeight = 41.1497231F;
            Branch.HeaderText = "SL";
            Branch.MinimumWidth = 6;
            Branch.Name = "Branch";
            Branch.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.FillWeight = 111.679581F;
            Amount.HeaderText = "Giá nhập";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // SellPrice
            // 
            SellPrice.FillWeight = 114.973251F;
            SellPrice.HeaderText = "Giá bán";
            SellPrice.MinimumWidth = 6;
            SellPrice.Name = "SellPrice";
            SellPrice.ReadOnly = true;
            // 
            // filterBox
            // 
            filterBox.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterBox.ForeColor = SystemColors.ButtonShadow;
            filterBox.Location = new Point(16, 33);
            filterBox.Name = "filterBox";
            filterBox.PlaceholderText = "Lọc theo tên tivi...";
            filterBox.Size = new Size(492, 30);
            filterBox.TabIndex = 0;
            filterBox.TextChanged += filterBox_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pickImageBtn);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(imageBox);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(repairTVBox);
            groupBox2.Controls.Add(countryTVBox);
            groupBox2.Controls.Add(sizeTVBox);
            groupBox2.Controls.Add(screenTVBox);
            groupBox2.Controls.Add(colorTVBox);
            groupBox2.Controls.Add(styleTVBox);
            groupBox2.Controls.Add(branchTVBox);
            groupBox2.Controls.Add(amountTVBox);
            groupBox2.Controls.Add(sellPriceBox);
            groupBox2.Controls.Add(buyPriceBox);
            groupBox2.Controls.Add(nameTVBox);
            groupBox2.Controls.Add(idTVBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cancelBtn);
            groupBox2.Controls.Add(saveBtn);
            groupBox2.Controls.Add(deleteBtn);
            groupBox2.Controls.Add(editBtn);
            groupBox2.Controls.Add(addBtn);
            groupBox2.Location = new Point(539, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 845);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // pickImageBtn
            // 
            pickImageBtn.Location = new Point(236, 454);
            pickImageBtn.Name = "pickImageBtn";
            pickImageBtn.Size = new Size(118, 46);
            pickImageBtn.TabIndex = 31;
            pickImageBtn.Text = "Chọn ảnh";
            pickImageBtn.UseVisualStyleBackColor = true;
            pickImageBtn.Click += pickImageBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 431);
            label13.Name = "label13";
            label13.Size = new Size(35, 20);
            label13.TabIndex = 30;
            label13.Text = "Ảnh";
            // 
            // imageBox
            // 
            imageBox.BackColor = Color.FromArgb(217, 221, 229);
            imageBox.Location = new Point(32, 454);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(183, 171);
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.TabIndex = 29;
            imageBox.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(349, 368);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 28;
            label12.Text = "Đơn giá bán";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 368);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 27;
            label11.Text = "Đơn giá nhập";
            // 
            // repairTVBox
            // 
            repairTVBox.Location = new Point(32, 324);
            repairTVBox.Name = "repairTVBox";
            repairTVBox.Size = new Size(207, 27);
            repairTVBox.TabIndex = 26;
            // 
            // countryTVBox
            // 
            countryTVBox.FormattingEnabled = true;
            countryTVBox.Location = new Point(349, 257);
            countryTVBox.Name = "countryTVBox";
            countryTVBox.Size = new Size(207, 28);
            countryTVBox.TabIndex = 25;
            // 
            // sizeTVBox
            // 
            sizeTVBox.FormattingEnabled = true;
            sizeTVBox.Location = new Point(32, 257);
            sizeTVBox.Name = "sizeTVBox";
            sizeTVBox.Size = new Size(207, 28);
            sizeTVBox.TabIndex = 24;
            // 
            // screenTVBox
            // 
            screenTVBox.FormattingEnabled = true;
            screenTVBox.Location = new Point(349, 190);
            screenTVBox.Name = "screenTVBox";
            screenTVBox.Size = new Size(207, 28);
            screenTVBox.TabIndex = 23;
            // 
            // colorTVBox
            // 
            colorTVBox.FormattingEnabled = true;
            colorTVBox.Location = new Point(32, 190);
            colorTVBox.Name = "colorTVBox";
            colorTVBox.Size = new Size(207, 28);
            colorTVBox.TabIndex = 22;
            // 
            // styleTVBox
            // 
            styleTVBox.FormattingEnabled = true;
            styleTVBox.Location = new Point(349, 123);
            styleTVBox.Name = "styleTVBox";
            styleTVBox.Size = new Size(207, 28);
            styleTVBox.TabIndex = 21;
            // 
            // branchTVBox
            // 
            branchTVBox.FormattingEnabled = true;
            branchTVBox.Location = new Point(32, 123);
            branchTVBox.Name = "branchTVBox";
            branchTVBox.Size = new Size(207, 28);
            branchTVBox.TabIndex = 20;
            // 
            // amountTVBox
            // 
            amountTVBox.Location = new Point(349, 323);
            amountTVBox.Name = "amountTVBox";
            amountTVBox.ReadOnly = true;
            amountTVBox.Size = new Size(207, 27);
            amountTVBox.TabIndex = 19;
            // 
            // sellPriceBox
            // 
            sellPriceBox.Location = new Point(349, 391);
            sellPriceBox.Name = "sellPriceBox";
            sellPriceBox.ReadOnly = true;
            sellPriceBox.Size = new Size(207, 27);
            sellPriceBox.TabIndex = 18;
            // 
            // buyPriceBox
            // 
            buyPriceBox.Location = new Point(32, 391);
            buyPriceBox.Name = "buyPriceBox";
            buyPriceBox.ReadOnly = true;
            buyPriceBox.Size = new Size(207, 27);
            buyPriceBox.TabIndex = 17;
            // 
            // nameTVBox
            // 
            nameTVBox.Location = new Point(349, 56);
            nameTVBox.Name = "nameTVBox";
            nameTVBox.Size = new Size(207, 27);
            nameTVBox.TabIndex = 16;
            // 
            // idTVBox
            // 
            idTVBox.Location = new Point(32, 56);
            idTVBox.Name = "idTVBox";
            idTVBox.Size = new Size(207, 27);
            idTVBox.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(347, 301);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 14;
            label10.Text = "Số lượng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 301);
            label9.Name = "label9";
            label9.Size = new Size(160, 20);
            label9.TabIndex = 13;
            label9.Text = "Bảo hành (Theo tháng)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(349, 234);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 12;
            label8.Text = "Nước sản xuất";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 234);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 11;
            label7.Text = "Cỡ màn hình (inch)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 167);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 10;
            label6.Text = "Màn hình";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 167);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 9;
            label5.Text = "Màu sắc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 100);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 8;
            label4.Text = "Kiểu dáng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 100);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 7;
            label3.Text = "Hãng sản xuất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 33);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên tivi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã tivi";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(462, 658);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(107, 46);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Hủy";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(349, 658);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(107, 46);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Lưu";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(236, 658);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(107, 46);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Xóa";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(123, 658);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(107, 46);
            editBtn.TabIndex = 1;
            editBtn.Text = "Sửa";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(10, 658);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(107, 46);
            addBtn.TabIndex = 0;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // PanelDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 251);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelDanhMuc";
            Size = new Size(1143, 876);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataViewTable).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)repairTVBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox filterBox;
        private DataGridView dataViewTable;
        private NumericUpDown repairTVBox;
        private ComboBox countryTVBox;
        private ComboBox sizeTVBox;
        private ComboBox screenTVBox;
        private ComboBox colorTVBox;
        private ComboBox styleTVBox;
        private ComboBox branchTVBox;
        private TextBox amountTVBox;
        private TextBox sellPriceBox;
        private TextBox buyPriceBox;
        private TextBox nameTVBox;
        private TextBox idTVBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button cancelBtn;
        private Button saveBtn;
        private Button deleteBtn;
        private Button editBtn;
        private Button addBtn;
        private Label label12;
        private Label label11;
        private PictureBox imageBox;
        private Button pickImageBtn;
        private Label label13;
        private DataGridViewTextBoxColumn MaTV;
        private DataGridViewTextBoxColumn TenTV;
        private DataGridViewTextBoxColumn Branch;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn SellPrice;
    }
}
