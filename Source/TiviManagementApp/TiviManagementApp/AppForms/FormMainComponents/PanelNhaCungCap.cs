using System.Windows.Forms;
using TiviManagementApp.Models;
using TiviManagementApp.Repositories;

namespace QuanLyCuaHangTivi
{
    public partial class PanelNhaCungCap : UserControl
    {
        private readonly NCCRepositories repository =
            new NCCRepositories();

        private bool isAdding = false;
        private bool isEditing = false;
        private string selectedMaNCC = "";

        public PanelNhaCungCap()
        {
            InitializeComponent();

            Load += PanelNhaCungCap_Load;

            searchBtn.Click += searchBtn_Click;
            addBtn.Click += addBtn_Click;
            editBtn.Click += editBtn_Click;
            deleteBtn.Click += deleteBtn_Click;
            saveBtn.Click += saveBtn_Click;
            cancelBtn.Click += cancelBtn_Click;

            dataTableView.CellClick += dataTableView_CellClick;
        }

        private void PanelNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
            SetDefaultState();
        }

        private void LoadData()
        {
            try
            {
                List<NhaCungCap> list = repository.GetAll();
                DisplayData(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách nhà cung cấp: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DisplayData(List<NhaCungCap> list)
        {
            dataTableView.Rows.Clear();

            foreach (var ncc in list)
            {
                dataTableView.Rows.Add(
                    ncc.MaNCC,
                    ncc.TenNCC,
                    ncc.DiaChi,
                    ncc.DienThoai
                );
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = searchBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    LoadData();
                    return;
                }

                List<NhaCungCap> list = repository.Search(keyword);
                DisplayData(list);

                if (list.Count == 0)
                {
                    MessageBox.Show(
                        "Không tìm thấy nhà cung cấp phù hợp.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tìm kiếm: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;

            ClearInput();

            idNCCBox.ReadOnly = false;
            idNCCBox.Focus();

            SetEditingState();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedMaNCC))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa.");
                return;
            }

            isAdding = false;
            isEditing = true;

            idNCCBox.ReadOnly = true;

            SetEditingState();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedMaNCC))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhà cung cấp này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                repository.Delete(selectedMaNCC);

                MessageBox.Show(
                    "Xóa nhà cung cấp thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();
                ClearInput();
                SetDefaultState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!isAdding && !isEditing)
            {
                MessageBox.Show("Vui lòng chọn Thêm hoặc Sửa trước khi Lưu.");
                return;
            }

            if (!ValidateInput())
                return;

            NhaCungCap ncc = new NhaCungCap
            {
                MaNCC = idNCCBox.Text.Trim(),
                TenNCC = nameNCCBox.Text.Trim(),
                DiaChi = addressNCCBox.Text.Trim(),
                DienThoai = phoneNCCBox.Text.Trim()
            };

            try
            {
                if (isAdding)
                {
                    repository.Add(ncc);

                    MessageBox.Show(
                        "Thêm nhà cung cấp thành công.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else if (isEditing)
                {
                    repository.Update(ncc);

                    MessageBox.Show(
                        "Cập nhật nhà cung cấp thành công.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                LoadData();
                ClearInput();
                SetDefaultState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lưu nhà cung cấp: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(idNCCBox.Text))
            {
                MessageBox.Show("Mã nhà cung cấp không được để trống.");
                idNCCBox.Focus();
                return false;
            }

            if (idNCCBox.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã nhà cung cấp không được vượt quá 10 ký tự.");
                idNCCBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(nameNCCBox.Text))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống.");
                nameNCCBox.Focus();
                return false;
            }

            if (nameNCCBox.Text.Trim().Length > 150)
            {
                MessageBox.Show("Tên nhà cung cấp không được vượt quá 150 ký tự.");
                nameNCCBox.Focus();
                return false;
            }

            if (addressNCCBox.Text.Trim().Length > 200)
            {
                MessageBox.Show("Địa chỉ không được vượt quá 200 ký tự.");
                addressNCCBox.Focus();
                return false;
            }

            if (phoneNCCBox.Text.Trim().Length > 15)
            {
                MessageBox.Show("Số điện thoại không được vượt quá 15 ký tự.");
                phoneNCCBox.Focus();
                return false;
            }

            return true;
        }

        private void dataTableView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || isAdding || isEditing)
                return;

            DataGridViewRow row = dataTableView.Rows[e.RowIndex];

            selectedMaNCC = row.Cells[0].Value?.ToString() ?? "";

            idNCCBox.Text = row.Cells[0].Value?.ToString() ?? "";
            nameNCCBox.Text = row.Cells[1].Value?.ToString() ?? "";
            addressNCCBox.Text = row.Cells[2].Value?.ToString() ?? "";
            phoneNCCBox.Text = row.Cells[3].Value?.ToString() ?? "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetDefaultState();
        }

        private void ClearInput()
        {
            idNCCBox.Clear();
            nameNCCBox.Clear();
            addressNCCBox.Clear();
            phoneNCCBox.Clear();

            selectedMaNCC = "";

            dataTableView.ClearSelection();
        }

        private void SetDefaultState()
        {
            isAdding = false;
            isEditing = false;

            idNCCBox.ReadOnly = true;

            addBtn.Enabled = true;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;

            saveBtn.Enabled = false;
            cancelBtn.Enabled = false;
        }

        private void SetEditingState()
        {
            addBtn.Enabled = false;
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;

            saveBtn.Enabled = true;
            cancelBtn.Enabled = true;
        }
    }
}
