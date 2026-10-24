using System.Globalization;
using System.Windows.Forms;
using TiviManagementApp.Models;
using TiviManagementApp.Repositories;

namespace QuanLyCuaHangTivi
{
    public partial class PanelDanhMuc : UserControl
    {
        private TiviRepositories repository = new TiviRepositories();
        private bool AddMode = false;
        private string? imagePath = null;

        public PanelDanhMuc()
        {
            InitializeComponent();

            StartUp();
        }

        private void LoadTivi()
        {
            dataViewTable.Rows.Clear();

            var danhSach = repository.GetAll();

            foreach (var x in danhSach)
            {
                dataViewTable.Rows.Add(x.MaTivi, x.TenTivi, x.SoLuong, x.GiaNhap, x.GiaBan);
            }
        }

        private void LoadComboxes()
        {
            colorTVBox.DataSource = repository.GetAllColors();
            colorTVBox.DisplayMember = "TenMau";
            colorTVBox.ValueMember = "MaMau";

            branchTVBox.DataSource = repository.GetAllBranches();
            branchTVBox.DisplayMember = "TenHang";
            branchTVBox.ValueMember = "MaHang";

            screenTVBox.DataSource = repository.GetAllScreens();
            screenTVBox.DisplayMember = "TenManHinh";
            screenTVBox.ValueMember = "MaManHinh";

            styleTVBox.DataSource = repository.GetAllStyles();
            styleTVBox.DisplayMember = "TenKieu";
            styleTVBox.ValueMember = "MaKieu";

            sizeTVBox.DataSource = repository.GetAllSizes();
            sizeTVBox.DisplayMember = "KichThuocInch";
            sizeTVBox.ValueMember = "MaCo";

            countryTVBox.DataSource = repository.GetAllCountries();
            countryTVBox.DisplayMember = "TenNuoc";
            countryTVBox.ValueMember = "MaNuoc";
        }

        private void loadImage(string? imageName)
        {
            if (imageBox.Image != null)
            {
                imageBox.Image.Dispose();
                imageBox.Image = null;
            }


            imageBox.SizeMode = PictureBoxSizeMode.Zoom;

            if (string.IsNullOrWhiteSpace(imageName))
                return;

            string imagePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "images",
                Path.GetFileName(imageName)
            );

            if (!File.Exists(imagePath))
            {
                MessageBox.Show($"Không tìm thấy ảnh: {imageName}");
                return;
            }

            using (Image original = Image.FromFile(imagePath))
            {
                imageBox.Image = new Bitmap(original);
            }
        }

        private void StartUp()
        {
            LoadTivi();
            LoadComboxes();
            filterBox.Clear();
            AddMode = false;

            idTVBox.ReadOnly = true;
            nameTVBox.ReadOnly = true;
            branchTVBox.Enabled = false;
            styleTVBox.Enabled = false;
            sizeTVBox.Enabled = false;
            colorTVBox.Enabled = false;
            screenTVBox.Enabled = false;
            countryTVBox.Enabled = false;
            repairTVBox.Enabled = false;
            pickImageBtn.Enabled = false;

            addBtn.Enabled = true;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            saveBtn.Enabled = false;
            cancelBtn.Enabled = false;
        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            string key = filterBox.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dataViewTable.Rows)
            {
                string ten = Convert.ToString(row.Cells["TenTV"].Value).ToLower();
                row.Visible = key.Length == 0 || ten.Contains(key);
            }
        }

        private void dataViewTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dataViewTable.CurrentRow == null) return;

            var id = dataViewTable.CurrentRow.Cells["MaTV"].Value?.ToString();

            var product = repository.SearchByID(id);

            if (product == null) return;

            idTVBox.Text = product.MaTivi;
            nameTVBox.Text = product.TenTivi;
            branchTVBox.SelectedValue = product.MaHang;
            styleTVBox.SelectedValue = product.MaKieu;
            sizeTVBox.SelectedValue = product.MaCo;
            colorTVBox.SelectedValue = product.MaMau;
            screenTVBox.SelectedValue = product.MaManHinh;
            countryTVBox.SelectedValue = product.MaNuoc;
            repairTVBox.Value = product.ThoiGianBaoHanhThang;
            amountTVBox.Text = product.SoLuong.ToString();
            sellPriceBox.Text = product.GiaBan.ToString();
            buyPriceBox.Text = product.GiaNhap.ToString();
            loadImage(product.Anh);
        }

        private void Editing()
        {
            if (AddMode)
            {
                idTVBox.ReadOnly = false;
                
            }
            else idTVBox.ReadOnly = true;

            nameTVBox.ReadOnly = false;
            branchTVBox.Enabled = true;
            styleTVBox.Enabled = true;
            sizeTVBox.Enabled = true;
            colorTVBox.Enabled = true;
            screenTVBox.Enabled = true;
            countryTVBox.Enabled = true;
            repairTVBox.Enabled = true;
            pickImageBtn.Enabled = true;

            addBtn.Enabled = false;
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
            saveBtn.Enabled = true;
            cancelBtn.Enabled = true;
        }

        private void ClearForm()
        {
            idTVBox.Clear();
            nameTVBox.Clear();
            branchTVBox.SelectedIndex = -1;
            styleTVBox.SelectedIndex = -1;
            sizeTVBox.SelectedIndex = -1;
            colorTVBox.SelectedIndex = -1;
            screenTVBox.SelectedIndex = -1;
            countryTVBox.SelectedIndex = -1;
            repairTVBox.Value = 12;
            amountTVBox.Text = "0";
            sellPriceBox.Text = "0";
            buyPriceBox.Text = "0";
            imageBox.Image = null;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
            AddMode = true;
            Editing();
            idTVBox.Focus();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            AddMode = false;
            Editing();
            nameTVBox.Focus();
        }

        private void pickImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh tivi";
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;

                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    using (var image = Image.FromStream(stream))
                    {
                        imageBox.Image = new Bitmap(image);
                    }

                    imageBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(idTVBox.Text))
            {
                MessageBox.Show("Vui lòng nhập mã tivi.");
                idTVBox.Focus();
                return false;
            }

            if (idTVBox.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã tivi không được vượt quá 10 ký tự.");
                idTVBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(nameTVBox.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tivi.");
                nameTVBox.Focus();
                return false;
            }

            if (nameTVBox.Text.Trim().Length > 150)
            {
                MessageBox.Show("Tên tivi không được vượt quá 150 ký tự.");
                nameTVBox.Focus();
                return false;
            }

            if (branchTVBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất.");
                branchTVBox.Focus();
                return false;
            }

            if (colorTVBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc.");
                colorTVBox.Focus();
                return false;
            }

            if (screenTVBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại màn hình.");
                screenTVBox.Focus();
                return false;
            }

            if (sizeTVBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn cỡ màn hình.");
                sizeTVBox.Focus();
                return false;
            }

            if (styleTVBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn kiểu dáng.");
                styleTVBox.Focus();
                return false;
            }

            if (countryTVBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nước sản xuất.");
                countryTVBox.Focus();
                return false;
            }

            if (!int.TryParse(amountTVBox.Text.Trim(), out int soLuong))
            {
                MessageBox.Show("Số lượng phải là số nguyên.");
                amountTVBox.Focus();
                return false;
            }

            if (soLuong < 0)
            {
                MessageBox.Show("Số lượng không được âm.");
                amountTVBox.Focus();
                return false;
            }

            if (!decimal.TryParse(
                buyPriceBox.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out decimal giaNhap))
            {
                MessageBox.Show("Giá nhập không hợp lệ.");
                buyPriceBox.Focus();
                return false;
            }

            if (giaNhap < 0)
            {
                MessageBox.Show("Giá nhập không được âm.");
                buyPriceBox.Focus();
                return false;
            }

            if (repairTVBox.Value < repairTVBox.Minimum ||
                repairTVBox.Value > repairTVBox.Maximum)
            {
                MessageBox.Show("Thời gian bảo hành không hợp lệ.");
                repairTVBox.Focus();
                return false;
            }

            return true;
        }

        private Tivi GetTiviFromInput()
        {
            return new Tivi
            {
                MaTivi = idTVBox.Text.Trim(),
                TenTivi = nameTVBox.Text.Trim(),

                MaHang = branchTVBox.SelectedValue!.ToString()!,
                MaKieu = styleTVBox.SelectedValue?.ToString(),
                MaCo = sizeTVBox.SelectedValue?.ToString(),
                MaMau = colorTVBox.SelectedValue?.ToString(),
                MaManHinh = screenTVBox.SelectedValue?.ToString(),
                MaNuoc = countryTVBox.SelectedValue?.ToString(),

                ThoiGianBaoHanhThang = (int)repairTVBox.Value,
                SoLuong = int.Parse(amountTVBox.Text.Trim()),
                GiaNhap = decimal.Parse(
                    buyPriceBox.Text.Trim(),
                    CultureInfo.CurrentCulture),

                Anh = Path.GetFileName(imagePath)
            };
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                Tivi tv = GetTiviFromInput();

                bool success;

                if (AddMode)
                {
                    success = repository.Insert(tv);
                }
                else
                {
                    success = repository.Update(tv);
                }

                if (success)
                {
                    MessageBox.Show(
                        AddMode ? "Thêm tivi thành công!" : "Cập nhật tivi thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadTivi();
                    ClearForm();
                    StartUp();

                    AddMode = false;
                    idTVBox.Enabled = true;
                }
                else
                {
                    MessageBox.Show(
                        "Không có dữ liệu nào được thay đổi. Hãy kiểm tra lại mã tivi.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lưu dữ liệu thất bại: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            StartUp();
            dataViewTable_SelectionChanged(dataViewTable, EventArgs.Empty);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string maTivi = idTVBox.Text.Trim();

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tivi này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            bool deleted = repository.Delete(maTivi);

            if (deleted)
            {
                MessageBox.Show("Xóa tivi thành công!");
                LoadTivi();
            }
            else
            {
                MessageBox.Show(
                    "Không thể xóa tivi này vì sản phẩm đã xuất hiện trong hóa đơn hoặc không còn tồn tại.",
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
