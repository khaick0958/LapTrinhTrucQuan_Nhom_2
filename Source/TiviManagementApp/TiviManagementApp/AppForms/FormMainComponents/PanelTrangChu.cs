using System.Windows.Forms;
using TiviManagementApp.Repositories;

namespace QuanLyCuaHangTivi
{
    public partial class PanelTrangChu : UserControl
    {
        private TiviRepositories TVRepository = new TiviRepositories();
        private NhanVienRepositories NVRepository = new NhanVienRepositories();
        private HDNhapRepositories HDNRepository = new HDNhapRepositories();
        private int totalTV;
        private int totalNV;
        private int totalHDN;

        public PanelTrangChu()
        {
            InitializeComponent();

            SetStats();
        }



        public void SetStats()
        {
            totalTV = TVRepository.GetTotalTivis();
            totalHDN = HDNRepository.GetTotalHDNs();
            totalNV = NVRepository.GetTotalNhanViens();

            lblValTivi.Text = totalTV.ToString();
            lblValPhieuNhap.Text = totalHDN.ToString();
            lblValNhanVien.Text = totalNV.ToString();
        }
    }
}
