using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FormBanHang : Form
    {
        IKhachHangService khachHangService;
        Guid GetIdKhachHang { get; set; }
        public FormBanHang()
        {
            InitializeComponent();
            khachHangService = new KhachHangService();
        }
        void LoadDataKhachHang(List<KhachHangView> list)
        {
            int stt = 0;
            dtg_showkhachhang.Rows.Clear();
            dtg_showkhachhang.ColumnCount = 6;
            dtg_showkhachhang.Columns[0].Name = "ID";
            dtg_showkhachhang.Columns[0].Visible = false;
            dtg_showkhachhang.Columns[1].Name = "STT";
            dtg_showkhachhang.Columns[2].Name = "Mã";
            dtg_showkhachhang.Columns[3].Name = "Họ Tên";
            dtg_showkhachhang.Columns[4].Name = "Địa Chỉ";
            dtg_showkhachhang.Columns[5].Name = "SĐT";
            foreach (var a in list)
            {
                stt++;
                dtg_showkhachhang.Rows.Add(a.ID, stt, a.Ma, a.HoTen, a.DiaChi, a.SDT);
            }

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            LoadDataKhachHang(khachHangService.GetAllKhachHang());
        }

        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            KhachHangView thao = new KhachHangView();
            thao.ID = Guid.NewGuid();
            thao.Ma = tbx_makhachhang.Text;
            thao.HoTen = tbx_tenkhachhang.Text;
            thao.DiaChi = tbx_diachikhachhang.Text;
            thao.SDT = tbx_sdtkhachhang.Text;
            if (khachHangService.CheckMa(tbx_makhachhang.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(khachHangService.AddKhachHang(thao));
                LoadDataKhachHang(khachHangService.GetAllKhachHang());
            }
        }

        private void btn_suakhachhang_Click(object sender, EventArgs e)
        {
            KhachHangView thao = new KhachHangView();
            thao.ID = GetIdKhachHang;
            thao.HoTen = tbx_tenkhachhang.Text;
            thao.DiaChi = tbx_diachikhachhang.Text;
            thao.SDT = tbx_sdtkhachhang.Text;
            MessageBox.Show(khachHangService.UpdateKhachHang(thao));
            LoadDataKhachHang(khachHangService.GetAllKhachHang());
        }

        private void btn_xoakhachhang_Click(object sender, EventArgs e)
        {
            KhachHangView thao = new KhachHangView();
            thao.ID = GetIdKhachHang;
            MessageBox.Show(khachHangService.DeleteKhachHang(thao));
            LoadDataKhachHang(khachHangService.GetAllKhachHang());
        }

        private void dtg_showkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdKhachHang = Guid.Parse(dtg_showkhachhang.CurrentRow.Cells[0].Value.ToString());
            tbx_makhachhang.Text = dtg_showkhachhang.CurrentRow.Cells[2].Value.ToString();
            tbx_tenkhachhang.Text = dtg_showkhachhang.CurrentRow.Cells[3].Value.ToString();
            tbx_diachikhachhang.Text = dtg_showkhachhang.CurrentRow.Cells[4].Value.ToString();
            tbx_sdtkhachhang.Text = dtg_showkhachhang.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
