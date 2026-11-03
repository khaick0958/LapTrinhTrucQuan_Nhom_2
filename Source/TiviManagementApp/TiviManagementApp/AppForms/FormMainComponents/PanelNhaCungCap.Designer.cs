namespace QuanLyCuaHangTivi
{
    partial class PanelNhaCungCap
    {
        private System.ComponentModel.IContainer components = null;

        private Label searchLbl;
        private TextBox searchBox;
        private Button searchBtn;

        private GroupBox infoGroup;
        private Label idLbl;
        private Label nameLbl;
        private Label addressLbl;
        private Label phoneLbl;

        private TextBox idNCCBox;
        private TextBox nameNCCBox;
        private TextBox addressNCCBox;
        private TextBox phoneNCCBox;

        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private Button saveBtn;
        private Button cancelBtn;

        private GroupBox listGroup;
        private DataGridView dataTableView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            searchLbl = new Label();
            searchBox = new TextBox();
            searchBtn = new Button();
            infoGroup = new GroupBox();
            idLbl = new Label();
            idNCCBox = new TextBox();
            nameLbl = new Label();
            nameNCCBox = new TextBox();
            addressLbl = new Label();
            addressNCCBox = new TextBox();
            phoneLbl = new Label();
            phoneNCCBox = new TextBox();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            saveBtn = new Button();
            cancelBtn = new Button();
            listGroup = new GroupBox();
            dataTableView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            infoGroup.SuspendLayout();
            listGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTableView).BeginInit();
            SuspendLayout();
            // 
            // searchLbl
            // 
            searchLbl.AutoSize = true;
            searchLbl.Font = new Font("Segoe UI", 10F);
            searchLbl.Location = new Point(30, 35);
            searchLbl.Name = "searchLbl";
            searchLbl.Size = new Size(83, 23);
            searchLbl.TabIndex = 0;
            searchLbl.Text = "Tìm kiếm:";
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 10F);
            searchBox.Location = new Point(115, 30);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(330, 30);
            searchBox.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchBtn.Location = new Point(460, 28);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(105, 34);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Tìm kiếm";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // infoGroup
            // 
            infoGroup.Controls.Add(idLbl);
            infoGroup.Controls.Add(idNCCBox);
            infoGroup.Controls.Add(nameLbl);
            infoGroup.Controls.Add(nameNCCBox);
            infoGroup.Controls.Add(addressLbl);
            infoGroup.Controls.Add(addressNCCBox);
            infoGroup.Controls.Add(phoneLbl);
            infoGroup.Controls.Add(phoneNCCBox);
            infoGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            infoGroup.Location = new Point(25, 85);
            infoGroup.Name = "infoGroup";
            infoGroup.Size = new Size(1093, 220);
            infoGroup.TabIndex = 3;
            infoGroup.TabStop = false;
            infoGroup.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Font = new Font("Segoe UI", 10F);
            idLbl.Location = new Point(25, 42);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(147, 23);
            idLbl.TabIndex = 0;
            idLbl.Text = "Mã nhà cung cấp:";
            // 
            // idNCCBox
            // 
            idNCCBox.Font = new Font("Segoe UI", 10F);
            idNCCBox.Location = new Point(178, 39);
            idNCCBox.Name = "idNCCBox";
            idNCCBox.Size = new Size(330, 30);
            idNCCBox.TabIndex = 1;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Segoe UI", 10F);
            nameLbl.Location = new Point(550, 42);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(149, 23);
            nameLbl.TabIndex = 2;
            nameLbl.Text = "Tên nhà cung cấp:";
            // 
            // nameNCCBox
            // 
            nameNCCBox.Font = new Font("Segoe UI", 10F);
            nameNCCBox.Location = new Point(700, 38);
            nameNCCBox.Name = "nameNCCBox";
            nameNCCBox.Size = new Size(350, 30);
            nameNCCBox.TabIndex = 3;
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Font = new Font("Segoe UI", 10F);
            addressLbl.Location = new Point(25, 105);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(66, 23);
            addressLbl.TabIndex = 4;
            addressLbl.Text = "Địa chỉ:";
            // 
            // addressNCCBox
            // 
            addressNCCBox.Font = new Font("Segoe UI", 10F);
            addressNCCBox.Location = new Point(178, 102);
            addressNCCBox.Name = "addressNCCBox";
            addressNCCBox.Size = new Size(330, 30);
            addressNCCBox.TabIndex = 5;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Font = new Font("Segoe UI", 10F);
            phoneLbl.Location = new Point(550, 105);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(93, 23);
            phoneLbl.TabIndex = 6;
            phoneLbl.Text = "Điện thoại:";
            // 
            // phoneNCCBox
            // 
            phoneNCCBox.Font = new Font("Segoe UI", 10F);
            phoneNCCBox.Location = new Point(700, 100);
            phoneNCCBox.Name = "phoneNCCBox";
            phoneNCCBox.Size = new Size(350, 30);
            phoneNCCBox.TabIndex = 7;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addBtn.Location = new Point(25, 320);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(100, 36);
            addBtn.TabIndex = 4;
            addBtn.Text = "Thêm";
            // 
            // editBtn
            // 
            editBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editBtn.Location = new Point(140, 320);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(100, 36);
            editBtn.TabIndex = 5;
            editBtn.Text = "Sửa";
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteBtn.Location = new Point(255, 320);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(100, 36);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Xóa";
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            saveBtn.Location = new Point(370, 320);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(100, 36);
            saveBtn.TabIndex = 7;
            saveBtn.Text = "Lưu";
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cancelBtn.Location = new Point(485, 320);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(100, 36);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Hủy";
            // 
            // listGroup
            // 
            listGroup.Controls.Add(dataTableView);
            listGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            listGroup.Location = new Point(25, 375);
            listGroup.Name = "listGroup";
            listGroup.Size = new Size(1093, 475);
            listGroup.TabIndex = 9;
            listGroup.TabStop = false;
            listGroup.Text = "DANH SÁCH NHÀ CUNG CẤP";
            // 
            // dataTableView
            // 
            dataTableView.AllowUserToAddRows = false;
            dataTableView.AllowUserToDeleteRows = false;
            dataTableView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTableView.BackgroundColor = Color.White;
            dataTableView.ColumnHeadersHeight = 40;
            dataTableView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataTableView.Font = new Font("Segoe UI", 9.5F);
            dataTableView.Location = new Point(0, 0);
            dataTableView.MultiSelect = false;
            dataTableView.Name = "dataTableView";
            dataTableView.ReadOnly = true;
            dataTableView.RowHeadersVisible = false;
            dataTableView.RowHeadersWidth = 51;
            dataTableView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTableView.Size = new Size(1093, 475);
            dataTableView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "MaNCC";
            dataGridViewTextBoxColumn1.HeaderText = "Mã nhà cung cấp";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "TenNCC";
            dataGridViewTextBoxColumn2.HeaderText = "Tên nhà cung cấp";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "DiaChi";
            dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "DienThoai";
            dataGridViewTextBoxColumn4.HeaderText = "Điện thoại";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // PanelNhaCungCap
            // 
            BackColor = Color.FromArgb(246, 247, 251);
            Controls.Add(searchLbl);
            Controls.Add(searchBox);
            Controls.Add(searchBtn);
            Controls.Add(infoGroup);
            Controls.Add(addBtn);
            Controls.Add(editBtn);
            Controls.Add(deleteBtn);
            Controls.Add(saveBtn);
            Controls.Add(cancelBtn);
            Controls.Add(listGroup);
            Name = "PanelNhaCungCap";
            Size = new Size(1143, 876);
            infoGroup.ResumeLayout(false);
            infoGroup.PerformLayout();
            listGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataTableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
