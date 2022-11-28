using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class DataStatistics : Form
    {
        IHoaDonChiTietService hoaDonChiTietService;
        public DataStatistics()
        {
            InitializeComponent();
            hoaDonChiTietService = new HoaDonChiTietService();
        }
        void LoadDataHoaDonChiTiet(List<HoaDonChiTietView> listhdctv)
        {
            dtg_hoadonchitiet.Rows.Clear();
            dtg_hoadonchitiet.ColumnCount = 11;
            dtg_hoadonchitiet.Columns[0].Name = "ID";
            dtg_hoadonchitiet.Columns[0].Visible = false;
            dtg_hoadonchitiet.Columns[1].Name = "Mã";
            dtg_hoadonchitiet.Columns[2].Name = "Mã hóa đơn";
            dtg_hoadonchitiet.Columns[3].Name = "Mã chi tiết laptop";
            dtg_hoadonchitiet.Columns[4].Name = "Số Imei";
            dtg_hoadonchitiet.Columns[5].Name = "Số lượng";
            dtg_hoadonchitiet.Columns[6].Name = "Giá gốc";
            dtg_hoadonchitiet.Columns[7].Name = "Giảm giá";
            dtg_hoadonchitiet.Columns[8].Name = "Thành tiền";
            dtg_hoadonchitiet.Columns[9].Name = "Ngày tạo";
            dtg_hoadonchitiet.Columns[10].Name = "Tình trạng";
            //dtg_hoadonchitiet.Columns[0].Name = "ID";
            //dtg_hoadonchitiet.Columns[0].Name = "ID";
            foreach (var t in listhdctv)
            {
                dtg_hoadonchitiet.Rows.Add(t.ID, t.Ma, t.MaHoaDon, t.MaChiTietLaptop, t.SoImei, t.SoLuong, t.GiaTruoc, t.GiamGia, t.GiaSauKhiGiam, t.NgayTao, t.TinhTrang);
            }
        }

        private void DataStatistics_Load(object sender, EventArgs e)
        {
            LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTiet());
            HelloBaBy();


        }
        void HelloBaBy()
        {
            //decimal doanhthu = 0;
            //int soluongdaban = 0;
            //foreach (var a in hoaDonChiTietService.GetHoaDonChiTiet().Where(h=>h.TinhTrang==1&&h.NgayTao.Day==DateTime.Now.Day))
            //{
            //    doanhthu += a.GiaSauKhiGiam;
            //    soluongdaban += a.SoLuong;
            //}
            //tbx_tongdoanhthu.Text = Convert.ToString(doanhthu);
            //tbx_soluongdaban.Text = Convert.ToString(soluongdaban);
        }

        private void btn_doanhthuhomnay_Click(object sender, EventArgs e)
        {
            decimal doanhthu = 0;
            int soluongdaban = 0;
            decimal gianhap = 0;
            foreach (var a in hoaDonChiTietService.GetHoaDonChiTiet().Where(h => h.TinhTrang == 1 && h.NgayTao.Day == DateTime.Now.Day))
            {
                doanhthu += a.GiaSauKhiGiam;
                soluongdaban += a.SoLuong;
                gianhap += a.GiaNhap;
            }
            tbx_tongdoanhthu.Text = Convert.ToString(doanhthu);
            tbx_soluongdaban.Text = Convert.ToString(soluongdaban);
            decimal tienlai = doanhthu - gianhap;
            tbx_tongtienlai.Text = Convert.ToString(tienlai);
        }

        private void btn_doanhthuthang_Click(object sender, EventArgs e)
        {
            decimal doanhthu = 0;
            int soluongdaban = 0;
            decimal gianhap = 0;
            int thang = Convert.ToInt32(cbb_12thang.Text);
            foreach (var a in hoaDonChiTietService.GetHoaDonChiTiet().Where(h => h.TinhTrang == 1 && h.NgayTao.Month == thang))
            {
                doanhthu += a.GiaSauKhiGiam;
                soluongdaban += a.SoLuong;
                gianhap += a.GiaNhap;
            }
            tbx_tongdoanhthu.Text = Convert.ToString(doanhthu);
            tbx_soluongdaban.Text = Convert.ToString(soluongdaban);
            decimal tienlai = doanhthu - gianhap;
            tbx_tongtienlai.Text = Convert.ToString(tienlai);

        }
    }
}
