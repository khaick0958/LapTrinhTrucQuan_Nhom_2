namespace QuanLyCuaHangTivi
{
    partial class UcDanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlList = new System.Windows.Forms.Panel();
            this.dgvTivi = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.pnlGap = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblMaTivi = new System.Windows.Forms.Label();
            this.txtMaTivi = new System.Windows.Forms.TextBox();
            this.lblTenTivi = new System.Windows.Forms.Label();
            this.txtTenTivi = new System.Windows.Forms.TextBox();
            this.lblHangSx = new System.Windows.Forms.Label();
            this.cboHangSx = new System.Windows.Forms.ComboBox();
            this.lblKieuDang = new System.Windows.Forms.Label();
            this.cboKieuDang = new System.Windows.Forms.ComboBox();
            this.lblMau = new System.Windows.Forms.Label();
            this.cboMau = new System.Windows.Forms.ComboBox();
            this.lblManHinh = new System.Windows.Forms.Label();
            this.cboManHinh = new System.Windows.Forms.ComboBox();
            this.lblCo = new System.Windows.Forms.Label();
            this.cboCo = new System.Windows.Forms.ComboBox();
            this.lblNuocSx = new System.Windows.Forms.Label();
            this.cboNuocSx = new System.Windows.Forms.ComboBox();
            this.lblBaoHanh = new System.Windows.Forms.Label();
            this.nudBaoHanh = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblDonGiaNhap = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTivi)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaoHanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.White;
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Controls.Add(this.dgvTivi);
            this.pnlList.Controls.Add(this.pnlSearch);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlList.Location = new System.Drawing.Point(24, 20);
            this.pnlList.Name = "pnlList";
            this.pnlList.Padding = new System.Windows.Forms.Padding(14);
            this.pnlList.Size = new System.Drawing.Size(460, 617);
            this.pnlList.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtLoc);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(14, 14);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSearch.Size = new System.Drawing.Size(430, 36);
            this.pnlSearch.TabIndex = 0;
            // 
            // txtLoc
            // 
            this.txtLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLoc.Location = new System.Drawing.Point(0, 0);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.PlaceholderText = "Lọc nhanh theo tên tivi...";
            this.txtLoc.Size = new System.Drawing.Size(430, 23);
            this.txtLoc.TabIndex = 0;
            this.txtLoc.TextChanged += new System.EventHandler(this.txtLoc_TextChanged);
            // 
            // dgvTivi
            // 
            this.dgvTivi.AllowUserToAddRows = false;
            this.dgvTivi.AllowUserToDeleteRows = false;
            this.dgvTivi.AllowUserToResizeRows = false;
            this.dgvTivi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTivi.BackgroundColor = System.Drawing.Color.White;
            this.dgvTivi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(15, 118, 110);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(15, 118, 110);
            headerStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTivi.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvTivi.ColumnHeadersHeight = 32;
            this.dgvTivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTivi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colMa, this.colTen, this.colHang, this.colSoLuong, this.colGiaBan });
            this.dgvTivi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTivi.EnableHeadersVisualStyles = false;
            this.dgvTivi.Location = new System.Drawing.Point(14, 50);
            this.dgvTivi.MultiSelect = false;
            this.dgvTivi.Name = "dgvTivi";
            this.dgvTivi.ReadOnly = true;
            this.dgvTivi.RowHeadersVisible = false;
            this.dgvTivi.RowTemplate.Height = 28;
            this.dgvTivi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTivi.Size = new System.Drawing.Size(430, 553);
            this.dgvTivi.TabIndex = 1;
            this.dgvTivi.SelectionChanged += new System.EventHandler(this.dgvTivi_SelectionChanged);
            // 
            // colMa
            // 
            this.colMa.FillWeight = 70;
            this.colMa.HeaderText = "Mã";
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            // 
            // colTen
            // 
            this.colTen.FillWeight = 160;
            this.colTen.HeaderText = "Tên tivi";
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // colHang
            // 
            this.colHang.FillWeight = 90;
            this.colHang.HeaderText = "Hãng";
            this.colHang.Name = "colHang";
            this.colHang.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FillWeight = 50;
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.FillWeight = 110;
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            // 
            // pnlGap
            // 
            this.pnlGap.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGap.Location = new System.Drawing.Point(484, 20);
            this.pnlGap.Name = "pnlGap";
            this.pnlGap.Size = new System.Drawing.Size(16, 617);
            this.pnlGap.TabIndex = 1;
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Controls.Add(this.lblMaTivi);
            this.pnlForm.Controls.Add(this.txtMaTivi);
            this.pnlForm.Controls.Add(this.lblTenTivi);
            this.pnlForm.Controls.Add(this.txtTenTivi);
            this.pnlForm.Controls.Add(this.lblHangSx);
            this.pnlForm.Controls.Add(this.cboHangSx);
            this.pnlForm.Controls.Add(this.lblKieuDang);
            this.pnlForm.Controls.Add(this.cboKieuDang);
            this.pnlForm.Controls.Add(this.lblMau);
            this.pnlForm.Controls.Add(this.cboMau);
            this.pnlForm.Controls.Add(this.lblManHinh);
            this.pnlForm.Controls.Add(this.cboManHinh);
            this.pnlForm.Controls.Add(this.lblCo);
            this.pnlForm.Controls.Add(this.cboCo);
            this.pnlForm.Controls.Add(this.lblNuocSx);
            this.pnlForm.Controls.Add(this.cboNuocSx);
            this.pnlForm.Controls.Add(this.lblBaoHanh);
            this.pnlForm.Controls.Add(this.nudBaoHanh);
            this.pnlForm.Controls.Add(this.lblSoLuong);
            this.pnlForm.Controls.Add(this.txtSoLuong);
            this.pnlForm.Controls.Add(this.lblDonGiaNhap);
            this.pnlForm.Controls.Add(this.txtDonGiaNhap);
            this.pnlForm.Controls.Add(this.lblDonGiaBan);
            this.pnlForm.Controls.Add(this.txtDonGiaBan);
            this.pnlForm.Controls.Add(this.lblAnh);
            this.pnlForm.Controls.Add(this.picAnh);
            this.pnlForm.Controls.Add(this.btnChonAnh);
            this.pnlForm.Controls.Add(this.btnThem);
            this.pnlForm.Controls.Add(this.btnSua);
            this.pnlForm.Controls.Add(this.btnXoa);
            this.pnlForm.Controls.Add(this.btnLuu);
            this.pnlForm.Controls.Add(this.btnHuy);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(500, 20);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(476, 617);
            this.pnlForm.TabIndex = 2;
            // 
            // lblMaTivi
            // 
            this.lblMaTivi.AutoSize = true;
            this.lblMaTivi.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblMaTivi.Location = new System.Drawing.Point(16, 16);
            this.lblMaTivi.Name = "lblMaTivi";
            this.lblMaTivi.Size = new System.Drawing.Size(80, 15);
            this.lblMaTivi.TabIndex = 1;
            this.lblMaTivi.Text = "Mã tivi";

            // 
            // txtMaTivi
            // 
            this.txtMaTivi.Location = new System.Drawing.Point(16, 36);
            this.txtMaTivi.Name = "txtMaTivi";
            this.txtMaTivi.Size = new System.Drawing.Size(210, 23);
            this.txtMaTivi.TabIndex = 2;

            // 
            // lblTenTivi
            // 
            this.lblTenTivi.AutoSize = true;
            this.lblTenTivi.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblTenTivi.Location = new System.Drawing.Point(246, 16);
            this.lblTenTivi.Name = "lblTenTivi";
            this.lblTenTivi.Size = new System.Drawing.Size(80, 15);
            this.lblTenTivi.TabIndex = 3;
            this.lblTenTivi.Text = "Tên tivi";

            // 
            // txtTenTivi
            // 
            this.txtTenTivi.Location = new System.Drawing.Point(246, 36);
            this.txtTenTivi.Name = "txtTenTivi";
            this.txtTenTivi.Size = new System.Drawing.Size(210, 23);
            this.txtTenTivi.TabIndex = 4;

            // 
            // lblHangSx
            // 
            this.lblHangSx.AutoSize = true;
            this.lblHangSx.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblHangSx.Location = new System.Drawing.Point(16, 72);
            this.lblHangSx.Name = "lblHangSx";
            this.lblHangSx.Size = new System.Drawing.Size(80, 15);
            this.lblHangSx.TabIndex = 5;
            this.lblHangSx.Text = "Hãng sx";

            // 
            // cboHangSx
            // 
            this.cboHangSx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHangSx.FormattingEnabled = true;
            this.cboHangSx.Location = new System.Drawing.Point(16, 92);
            this.cboHangSx.Name = "cboHangSx";
            this.cboHangSx.Size = new System.Drawing.Size(210, 23);
            this.cboHangSx.TabIndex = 6;

            // 
            // lblKieuDang
            // 
            this.lblKieuDang.AutoSize = true;
            this.lblKieuDang.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblKieuDang.Location = new System.Drawing.Point(246, 72);
            this.lblKieuDang.Name = "lblKieuDang";
            this.lblKieuDang.Size = new System.Drawing.Size(80, 15);
            this.lblKieuDang.TabIndex = 7;
            this.lblKieuDang.Text = "Kiểu dáng";

            // 
            // cboKieuDang
            // 
            this.cboKieuDang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKieuDang.FormattingEnabled = true;
            this.cboKieuDang.Location = new System.Drawing.Point(246, 92);
            this.cboKieuDang.Name = "cboKieuDang";
            this.cboKieuDang.Size = new System.Drawing.Size(210, 23);
            this.cboKieuDang.TabIndex = 8;

            // 
            // lblMau
            // 
            this.lblMau.AutoSize = true;
            this.lblMau.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblMau.Location = new System.Drawing.Point(16, 128);
            this.lblMau.Name = "lblMau";
            this.lblMau.Size = new System.Drawing.Size(80, 15);
            this.lblMau.TabIndex = 9;
            this.lblMau.Text = "Màu sắc";

            // 
            // cboMau
            // 
            this.cboMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMau.FormattingEnabled = true;
            this.cboMau.Location = new System.Drawing.Point(16, 148);
            this.cboMau.Name = "cboMau";
            this.cboMau.Size = new System.Drawing.Size(210, 23);
            this.cboMau.TabIndex = 10;

            // 
            // lblManHinh
            // 
            this.lblManHinh.AutoSize = true;
            this.lblManHinh.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblManHinh.Location = new System.Drawing.Point(246, 128);
            this.lblManHinh.Name = "lblManHinh";
            this.lblManHinh.Size = new System.Drawing.Size(80, 15);
            this.lblManHinh.TabIndex = 11;
            this.lblManHinh.Text = "Màn hình";

            // 
            // cboManHinh
            // 
            this.cboManHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManHinh.FormattingEnabled = true;
            this.cboManHinh.Location = new System.Drawing.Point(246, 148);
            this.cboManHinh.Name = "cboManHinh";
            this.cboManHinh.Size = new System.Drawing.Size(210, 23);
            this.cboManHinh.TabIndex = 12;

            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblCo.Location = new System.Drawing.Point(16, 184);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(80, 15);
            this.lblCo.TabIndex = 13;
            this.lblCo.Text = "Cỡ màn hình (inch)";

            // 
            // cboCo
            // 
            this.cboCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCo.FormattingEnabled = true;
            this.cboCo.Location = new System.Drawing.Point(16, 204);
            this.cboCo.Name = "cboCo";
            this.cboCo.Size = new System.Drawing.Size(210, 23);
            this.cboCo.TabIndex = 14;

            // 
            // lblNuocSx
            // 
            this.lblNuocSx.AutoSize = true;
            this.lblNuocSx.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblNuocSx.Location = new System.Drawing.Point(246, 184);
            this.lblNuocSx.Name = "lblNuocSx";
            this.lblNuocSx.Size = new System.Drawing.Size(80, 15);
            this.lblNuocSx.TabIndex = 15;
            this.lblNuocSx.Text = "Nước sx";

            // 
            // cboNuocSx
            // 
            this.cboNuocSx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNuocSx.FormattingEnabled = true;
            this.cboNuocSx.Location = new System.Drawing.Point(246, 204);
            this.cboNuocSx.Name = "cboNuocSx";
            this.cboNuocSx.Size = new System.Drawing.Size(210, 23);
            this.cboNuocSx.TabIndex = 16;

            // 
            // lblBaoHanh
            // 
            this.lblBaoHanh.AutoSize = true;
            this.lblBaoHanh.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblBaoHanh.Location = new System.Drawing.Point(16, 240);
            this.lblBaoHanh.Name = "lblBaoHanh";
            this.lblBaoHanh.Size = new System.Drawing.Size(80, 15);
            this.lblBaoHanh.TabIndex = 17;
            this.lblBaoHanh.Text = "Bảo hành (tháng)";

            // 
            // nudBaoHanh
            // 
            this.nudBaoHanh.Location = new System.Drawing.Point(16, 260);
            this.nudBaoHanh.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            this.nudBaoHanh.Name = "nudBaoHanh";
            this.nudBaoHanh.Size = new System.Drawing.Size(210, 23);
            this.nudBaoHanh.TabIndex = 18;
            this.nudBaoHanh.Value = new decimal(new int[] { 12, 0, 0, 0 });

            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblSoLuong.Location = new System.Drawing.Point(246, 240);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(80, 15);
            this.lblSoLuong.TabIndex = 19;
            this.lblSoLuong.Text = "Số lượng (tự cập nhật)";

            // 
            // txtSoLuong
            // 
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(236, 238, 242);
            this.txtSoLuong.Location = new System.Drawing.Point(246, 260);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(210, 23);
            this.txtSoLuong.TabIndex = 20;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // lblDonGiaNhap
            // 
            this.lblDonGiaNhap.AutoSize = true;
            this.lblDonGiaNhap.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblDonGiaNhap.Location = new System.Drawing.Point(16, 296);
            this.lblDonGiaNhap.Name = "lblDonGiaNhap";
            this.lblDonGiaNhap.Size = new System.Drawing.Size(80, 15);
            this.lblDonGiaNhap.TabIndex = 21;
            this.lblDonGiaNhap.Text = "Đơn giá nhập (tự cập nhật)";

            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.ReadOnly = true;
            this.txtDonGiaNhap.BackColor = System.Drawing.Color.FromArgb(236, 238, 242);
            this.txtDonGiaNhap.Location = new System.Drawing.Point(16, 316);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(210, 23);
            this.txtDonGiaNhap.TabIndex = 22;
            this.txtDonGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // lblDonGiaBan
            // 
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblDonGiaBan.Location = new System.Drawing.Point(246, 296);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(80, 15);
            this.lblDonGiaBan.TabIndex = 23;
            this.lblDonGiaBan.Text = "Đơn giá bán = 110% nhập";

            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.ReadOnly = true;
            this.txtDonGiaBan.BackColor = System.Drawing.Color.FromArgb(236, 238, 242);
            this.txtDonGiaBan.Location = new System.Drawing.Point(246, 316);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(210, 23);
            this.txtDonGiaBan.TabIndex = 24;
            this.txtDonGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblAnh.Location = new System.Drawing.Point(16, 352);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(80, 15);
            this.lblAnh.TabIndex = 25;
            this.lblAnh.Text = "Ảnh";

            // 
            // picAnh
            // 
            this.picAnh.BackColor = System.Drawing.Color.FromArgb(217, 221, 229);
            this.picAnh.Location = new System.Drawing.Point(16, 372);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(150, 94);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 26;
            this.picAnh.TabStop = false;

            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.White;
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.ForeColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnChonAnh.Location = new System.Drawing.Point(178, 372);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(100, 30);
            this.btnChonAnh.TabIndex = 27;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);

            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(16, 490);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 32);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnSua.Location = new System.Drawing.Point(108, 490);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 32);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnXoa.Location = new System.Drawing.Point(200, 490);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 32);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnLuu.Location = new System.Drawing.Point(292, 490);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 32);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnHuy.Location = new System.Drawing.Point(384, 490);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 32);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // UcDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 247, 251);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlGap);
            this.Controls.Add(this.pnlList);
            this.Name = "UcDanhMuc";
            this.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.Size = new System.Drawing.Size(1000, 657);
            this.Load += new System.EventHandler(this.UcDanhMuc_Load);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTivi)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaoHanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlGap;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.DataGridView dgvTivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.Label lblMaTivi;
        private System.Windows.Forms.TextBox txtMaTivi;
        private System.Windows.Forms.Label lblTenTivi;
        private System.Windows.Forms.TextBox txtTenTivi;
        private System.Windows.Forms.Label lblHangSx;
        private System.Windows.Forms.ComboBox cboHangSx;
        private System.Windows.Forms.Label lblKieuDang;
        private System.Windows.Forms.ComboBox cboKieuDang;
        private System.Windows.Forms.Label lblMau;
        private System.Windows.Forms.ComboBox cboMau;
        private System.Windows.Forms.Label lblManHinh;
        private System.Windows.Forms.ComboBox cboManHinh;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.ComboBox cboCo;
        private System.Windows.Forms.Label lblNuocSx;
        private System.Windows.Forms.ComboBox cboNuocSx;
        private System.Windows.Forms.Label lblBaoHanh;
        private System.Windows.Forms.NumericUpDown nudBaoHanh;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblDonGiaNhap;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
