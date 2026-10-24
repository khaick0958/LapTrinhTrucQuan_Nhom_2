using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TiviManagementApp.Repositories;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using Image = System.Drawing.Image;

namespace TiviManagementApp.AppForms
{
    public partial class FormDetail : Form
    {
        private TiviRepositories repository = new TiviRepositories();
        private string id;

        public FormDetail(string maTV)
        {
            InitializeComponent();

            id = maTV;

            showDetails();
        }

        private void loadImage(string? imageName)
        {
            if (TVPicture.Image != null)
            {
                TVPicture.Image.Dispose();
                TVPicture.Image = null;
            }

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
                TVPicture.Image = new Bitmap(original);
            }
        }

        private void showDetails()
        {
            var product = repository.GetDetailByID(id);

            TVNameLbl.Text = product.TenTivi;
            kieuDangLbl.Text = product.TenKieu;
            kichThuocLbl.Text = $"{product.CoManHinh} inch";
            hangSXLbl.Text = product.TenHang;
            colorLbl.Text = product.TenMau;
            technologyLbl.Text = product.TenManHinh;
            countryLbl.Text = product.TenNuoc;
            soLuongLbl.Text = $"{product.SoLuong}";
            giaNhapLbl.Text = $"{product.GiaNhap} đ";
            giaBanLbl.Text = $"{product.GiaBan} đ";
            baoHanhLbl.Text = $"{product.ThoiGianBaoHanhThang} tháng";
            loadImage(product.Anh);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
