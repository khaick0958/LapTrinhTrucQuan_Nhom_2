using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi
{
    public partial class FormMain : Form
    {
        private static readonly Color NavNormal = Color.FromArgb(31, 41, 59);
        private static readonly Color NavActive = Color.FromArgb(55, 72, 98);

        private Button _activeButton;

        private readonly Dictionary<Button, Func<UserControl>> _pageFactories;
        private readonly Dictionary<Button, UserControl> _pageCache = new Dictionary<Button, UserControl>();

        public FormMain()
        {
            InitializeComponent();

            _pageFactories = new Dictionary<Button, Func<UserControl>>
            {
                { btnTrangChu,    () => new PanelTrangChu() },
                { btnDanhMuc,     () => new PanelDanhMuc() },
                { btnTimKiem,     () => new PanelTimKiem() },
                { btnNhapHang,    () => new PanelNhapHang() },
                { btnNhanVien,    () => new PanelNhanVien() },
                { btnNhaCungCap,  () => new PanelNhaCungCap() },
                { btnThongKe,     () => new PanelThongKe() },
            };

            Load += (s, e) => ShowPage(btnTrangChu);
        }

        public void SetUserInfo(string name, string role)
        {
            lblUserName.Text = name;
            lblUserRole.Text = role;
        }

        private void NavigationButton_Click(object sender, EventArgs e)
        {
            ShowPage((Button)sender);
        }

        private void ShowPage(Button button)
        {
            if (!_pageFactories.ContainsKey(button)) return;

            if (_activeButton != null) _activeButton.BackColor = NavNormal;
            _activeButton = button;
            _activeButton.BackColor = NavActive;

            if (!_pageCache.TryGetValue(button, out UserControl page))
            {
                page = _pageFactories[button]();
                page.Dock = DockStyle.Fill;
                _pageCache[button] = page;
            }

            lblPageTitle.Text = button.Text;

            pnlContent.SuspendLayout();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(page);
            pnlContent.ResumeLayout();
        }
    }
}
