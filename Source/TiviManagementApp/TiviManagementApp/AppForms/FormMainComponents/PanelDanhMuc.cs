using System.Windows.Forms;
using TiviManagementApp.Repositories;

namespace QuanLyCuaHangTivi
{
    public partial class PanelDanhMuc : UserControl
    {
        private TiviRepositories repository = new TiviRepositories();

        public PanelDanhMuc()
        {
            InitializeComponent();

            LoadTivi();

            LoadComboxes();
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
            var colors = repository.GetAllColors();
            var countries = repository.GetAllCountries();
            var sizes = repository.GetAllSizes();
            var branches = repository.GetAllBranches();
            var styles = repository.GetAllStyles();
            var screens = repository.GetAllScreens();

            foreach (var x in colors)
            {
                colorTVBox.Items.Add(x);
            }

            foreach (var x in countries)
            {
                countryTVBox.Items.Add(x);
            }

            foreach (var x in sizes)
            {
                sizeTVBox.Items.Add(x);
            }

            foreach(var x in branches)
            {
                branchTVBox.Items.Add(x);
            }

            foreach (var x in styles)
            {
                styleTVBox.Items.Add(x);
            }

            foreach (var x in screens)
            {
                screenTVBox.Items.Add(x);
            }
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
            var c = dataViewTable.CurrentRow.Cells;

            var id = c["MaTV"].ToString();

            var product = repository.GetDetailByID(id);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
