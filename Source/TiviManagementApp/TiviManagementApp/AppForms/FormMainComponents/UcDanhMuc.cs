using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi
{
    /// <summary>Quản lý danh mục tivi (bảng DM tivi).</summary>
    public partial class UcDanhMuc : UserControl
    {
        private bool _isAdding;   // true: đang thêm mới, false: đang sửa

        public UcDanhMuc()
        {
            InitializeComponent();
        }

        private void UcDanhMuc_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;   // không chạy khi đang mở trong Designer

            LoadComboBoxes();
            LoadTivi();
            SetEditMode(false);
        }

        // ================== Nạp dữ liệu ==================

        private void LoadComboBoxes()
        {
            // TODO: thay bằng dữ liệu thật từ CSDL, ví dụ:
            //   cboHangSx.DataSource = dt; cboHangSx.DisplayMember = "TenHang"; cboHangSx.ValueMember = "MaHangSX";
            cboHangSx.Items.AddRange(new object[] { "Samsung", "Sony", "LG", "TCL" });
            cboKieuDang.Items.AddRange(new object[] { "Phẳng", "Cong" });
            cboMau.Items.AddRange(new object[] { "Đen", "Bạc", "Trắng" });
            cboManHinh.Items.AddRange(new object[] { "LED", "QLED", "OLED" });
            cboCo.Items.AddRange(new object[] { "43", "50", "55", "65" });
            cboNuocSx.Items.AddRange(new object[] { "Việt Nam", "Hàn Quốc", "Nhật Bản", "Trung Quốc" });
        }

        private void LoadTivi()
        {
            // TODO: thay bằng truy vấn CSDL. Dữ liệu dưới đây chỉ để xem thử giao diện.
            dgvTivi.Rows.Clear();
            dgvTivi.Rows.Add("TV001", "Bravia X80", "Sony", 12, 15400000);
            dgvTivi.Rows.Add("TV002", "QLED Q60", "Samsung", 5, 18700000);
            dgvTivi.Rows.Add("TV003", "OLED C3", "LG", 3, 32100000);
            dgvTivi.Rows.Add("TV004", "Smart 43", "TCL", 20, 6600000);
            dgvTivi.Columns["colGiaBan"].DefaultCellStyle.Format = "N0";
            dgvTivi.Columns["colGiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTivi.Columns["colSoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        // ================== Lọc & chọn dòng ==================

        private void txtLoc_TextChanged(object sender, EventArgs e)
        {
            string key = txtLoc.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dgvTivi.Rows)
            {
                string ten = Convert.ToString(row.Cells["colTen"].Value).ToLower();
                row.Visible = key.Length == 0 || ten.Contains(key);
            }
        }

        private void dgvTivi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTivi.CurrentRow == null || _isAdding) return;
            var c = dgvTivi.CurrentRow.Cells;

            txtMaTivi.Text = Convert.ToString(c["colMa"].Value);
            txtTenTivi.Text = Convert.ToString(c["colTen"].Value);
            cboHangSx.Text = Convert.ToString(c["colHang"].Value);
            txtSoLuong.Text = Convert.ToString(c["colSoLuong"].Value);
            txtDonGiaBan.Text = string.Format("{0:N0}", c["colGiaBan"].Value);

            // TODO: truy vấn CSDL theo mã tivi để nạp các trường còn lại
            // (kiểu dáng, màu, màn hình, cỡ, nước sx, bảo hành, đơn giá nhập, ảnh).
        }

        // ================== Trạng thái nhập liệu ==================

        private void SetEditMode(bool editing)
        {
            txtMaTivi.ReadOnly = !(editing && _isAdding);   // mã chỉ nhập khi thêm mới
            txtTenTivi.ReadOnly = !editing;
            cboHangSx.Enabled = cboKieuDang.Enabled = cboMau.Enabled = editing;
            cboManHinh.Enabled = cboCo.Enabled = cboNuocSx.Enabled = editing;
            nudBaoHanh.Enabled = btnChonAnh.Enabled = editing;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = !editing;
            btnLuu.Enabled = btnHuy.Enabled = editing;
            dgvTivi.Enabled = !editing;
        }

        private void ClearForm()
        {
            txtMaTivi.Clear();
            txtTenTivi.Clear();
            foreach (var cbo in new[] { cboHangSx, cboKieuDang, cboMau, cboManHinh, cboCo, cboNuocSx })
                cbo.SelectedIndex = -1;
            nudBaoHanh.Value = 12;
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtDonGiaBan.Text = "0";
            picAnh.Image = null;
        }

        // ================== Các nút ==================

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            ClearForm();
            SetEditMode(true);
            txtMaTivi.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTivi.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một tivi để sửa.", "Thông báo");
                return;
            }
            _isAdding = false;
            SetEditMode(true);
            txtTenTivi.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTivi.CurrentRow == null) return;

            var confirm = MessageBox.Show("Bạn có chắc muốn xoá tivi này?", "Xác nhận xoá",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            // TODO: DELETE khỏi CSDL (chú ý lỗi khoá ngoại nếu tivi đã có trong hoá đơn)
            LoadTivi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTivi.Text) || string.IsNullOrWhiteSpace(txtTenTivi.Text))
            {
                MessageBox.Show("Mã tivi và Tên tivi không được để trống.", "Thiếu thông tin");
                return;
            }
            if (cboHangSx.SelectedIndex < 0 || cboManHinh.SelectedIndex < 0 || cboCo.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn Hãng sx, Màn hình và Cỡ màn hình.", "Thiếu thông tin");
                return;
            }

            // TODO: INSERT (nếu _isAdding) hoặc UPDATE vào CSDL.
            // Lưu ý: KHÔNG ghi Số lượng, Đơn giá nhập, Đơn giá bán từ form này -
            // các trường đó chỉ được cập nhật khi nhập hàng / bán hàng.

            SetEditMode(false);
            _isAdding = false;
            LoadTivi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _isAdding = false;
            SetEditMode(false);
            dgvTivi_SelectionChanged(dgvTivi, EventArgs.Empty);   // trả form về dòng đang chọn
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                    picAnh.Image = Image.FromFile(dlg.FileName);
                // TODO: lưu đường dẫn / dữ liệu ảnh vào cột Ảnh khi bấm Lưu
            }
        }
    }
}
