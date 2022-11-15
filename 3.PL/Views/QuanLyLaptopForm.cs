using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class QuanLyLaptopForm : Form
    {
        IMauSacService mauSacService;
        INsxService nsxService;
        ILaptopService laptopService;
        IThuocTinhService thuocTinhService;
        IGiaTriService giaTriService;
        IChiTietLaptopService chiTietLaptopService;
        Guid GetIdMauSac { get; set; }
        Guid GetIdNsx { get; set; }
        Guid GetIdLaptop { get; set; }
        Guid GetIdThuocTinh { get; set; }
        Guid GetIdGiaTri { get; set; }
        public QuanLyLaptopForm()
        {
            InitializeComponent();
            mauSacService = new MauSacService();
            nsxService = new NsxService();
            laptopService = new LaptopService();
            thuocTinhService = new ThuocTinhService();
            giaTriService = new GiaTriService();
            chiTietLaptopService = new ChiTietLaptopService();
        }
        void LoadDataMauSac(List<MauSacView> listms)
        {
            int sttms = 0;
            dtg_showmausac.Rows.Clear();
            dtg_showmausac.ColumnCount = 4;
            dtg_showmausac.Columns[0].Name = "ID";
            dtg_showmausac.Columns[0].Visible = false;
            dtg_showmausac.Columns[1].Name = "STT";
            dtg_showmausac.Columns[2].Name = "Mã";
            dtg_showmausac.Columns[3].Name = "Tên";
            foreach (var b in listms)
            {
                sttms++;
                dtg_showmausac.Rows.Add(b.ID, sttms, b.Ma, b.Ten);
            }
        }
        void LoadDataNsx(List<NsxView> listnsx)
        {
            int sttnsx = 0;
            dtg_shownsx.Rows.Clear();
            dtg_shownsx.ColumnCount = 4;
            dtg_shownsx.Columns[0].Name = "ID";
            dtg_shownsx.Columns[0].Visible = false;
            dtg_shownsx.Columns[1].Name = "STT";
            dtg_shownsx.Columns[2].Name = "Mã";
            dtg_shownsx.Columns[3].Name = "Tên";
            foreach (var c in listnsx)
            {
                sttnsx++;
                dtg_shownsx.Rows.Add(c.ID, sttnsx, c.Ma, c.Ten);
            }
        }
        void LoadDataLaptop(List<LaptopView> listlt)
        {
            int sttlt = 0;
            dtg_showlaptop.Rows.Clear();
            dtg_showlaptop.ColumnCount = 6;
            dtg_showlaptop.Columns[0].Name = "ID";
            dtg_showlaptop.Columns[0].Visible = false;
            dtg_showlaptop.Columns[1].Name = "STT";
            dtg_showlaptop.Columns[2].Name = "Mã";
            dtg_showlaptop.Columns[3].Name = "Tên";
            dtg_showlaptop.Columns[4].Name = "Tên thuộc tính";
            dtg_showlaptop.Columns[5].Name = "Thông số giá trị";
            foreach (var g in listlt)
            {
                sttlt++;
                dtg_showlaptop.Rows.Add(g.ID, sttlt, g.Ma, g.Ten,g.TenThuocTinh,g.ThongSoGiaTri);
            }
        }
        void LoadDataThuocTinh(List<ThuocTinhView> listtt)
        {
            int stttt = 0;
            dtg_showthuoctinh.Rows.Clear();
            dtg_showthuoctinh.ColumnCount = 5;
            dtg_showthuoctinh.Columns[0].Name = "ID";
            dtg_showthuoctinh.Columns[0].Visible = false;
            dtg_showthuoctinh.Columns[1].Name = "STT";
            dtg_showthuoctinh.Columns[2].Name = "Mã thuộc tính";
            dtg_showthuoctinh.Columns[3].Name = "Mã laptop";
            dtg_showthuoctinh.Columns[4].Name = "Tên thuộc tính";
            foreach (var g in listtt)
            {
                stttt++;
                dtg_showthuoctinh.Rows.Add(g.ID, stttt, g.Ma, g.MaLaptop, g.Ten);
            }
        }
        void LoadDataGiaTri(List<GiaTriView> listgtv)
        {
            int sttgt = 0;
            dtg_showgiatri.Rows.Clear();
            dtg_showgiatri.ColumnCount = 5;
            dtg_showgiatri.Columns[0].Name = "ID";
            dtg_showgiatri.Columns[0].Visible = false;
            dtg_showgiatri.Columns[1].Name = "STT";
            dtg_showgiatri.Columns[2].Name = "Mã";
            dtg_showgiatri.Columns[3].Name = "Mã thuộc tính";
            dtg_showgiatri.Columns[4].Name = "Thông số";
            foreach (var h in listgtv)
            {
                sttgt++;
                dtg_showgiatri.Rows.Add(h.ID, sttgt, h.Ma, h.MaThuocTinh, h.ThongSo);
            }
        }
        void LoadDataChiTietLaptop(List<ChiTietLaptopView> list)
        {
            int sttctlt = 0;
            dtg_showchitietlaptop.Rows.Clear();
            dtg_showchitietlaptop.ColumnCount = 12;
            dtg_showchitietlaptop.Columns[0].Name = "ID";
            dtg_showchitietlaptop.Columns[0].Visible = false;
            dtg_showchitietlaptop.Columns[1].Name = "STT";
            dtg_showchitietlaptop.Columns[2].Name = "Mã Laptop ";
            dtg_showchitietlaptop.Columns[3].Name = "TenLaptop";
            dtg_showchitietlaptop.Columns[4].Name = "Tên thuộc tính";
            dtg_showchitietlaptop.Columns[5].Name = "Thông số giá trị";
            dtg_showchitietlaptop.Columns[6].Name = "Mã nhà sản xuất";
            dtg_showchitietlaptop.Columns[7].Name = "Mã màu sắc";
            dtg_showchitietlaptop.Columns[8].Name = "Mô tả";
            dtg_showchitietlaptop.Columns[9].Name = "Số lượng";
            dtg_showchitietlaptop.Columns[10].Name = "Giá nhập";
            dtg_showchitietlaptop.Columns[11].Name = "Giá bán";
            foreach (var s in list)
            {
                sttctlt++;
                dtg_showchitietlaptop.Rows.Add(s.ID, sttctlt, s.MaLaptop, s.TenLaptop, s.TenThuocTinh, s.ThongSoGiaTri, s.MaNsx, s.MaMauSac, s.MoTa, s.SoLuong, s.GiaNhap, s.Giaban);
            }
        }
        void LoadCombobox()
        {
            cbb_mams.Items.Clear();
            cbb_mansx.Items.Clear();
            cbb_idlaptoptt.Items.Clear();
            cbb_malaptopctlt.Items.Clear();
            cbb_idthuoctinh.Items.Clear();
            foreach (var d in mauSacService.GetMauSac())
            {
                cbb_mams.Items.Add(d.Ma);
            }
            foreach (var e in nsxService.GetNsx())
            {
                cbb_mansx.Items.Add(e.Ma);
            }
            foreach (var f in laptopService.GetLaptop())
            {
                cbb_idlaptoptt.Items.Add(f.Ma);
                cbb_malaptopctlt.Items.Add(f.Ma);
            }
            foreach (var i in thuocTinhService.GetThuocTinh())
            {
                cbb_idthuoctinh.Items.Add(i.Ma);
            }
        }

        private void QuanLyLaptopForm_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadDataMauSac(mauSacService.GetMauSac());
            LoadDataNsx(nsxService.GetNsx());
            LoadDataLaptop(laptopService.GetLaptop());
            LoadDataThuocTinh(thuocTinhService.GetThuocTinh());
            LoadDataGiaTri(giaTriService.GetGiaTri());
            LoadDataChiTietLaptop(chiTietLaptopService.GetChiTietLaptop());

        }

        private void btn_themms_Click(object sender, EventArgs e)
        {
            MauSacView blue = new MauSacView();
            blue.ID = Guid.NewGuid();
            blue.Ma = tbx_mams.Text;
            blue.Ten = tbx_tenms.Text;
            if (mauSacService.CheckMa(tbx_mams.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(mauSacService.Add(blue));
                LoadDataMauSac(mauSacService.GetMauSac());
            }
        }

        private void btn_suams_Click(object sender, EventArgs e)
        {
            MauSacView blue = new MauSacView();
            blue.ID = GetIdMauSac;
            blue.Ten = tbx_tenms.Text;
            MessageBox.Show(mauSacService.Update(blue));
            LoadDataMauSac(mauSacService.GetMauSac());
        }

        private void btn_xoams_Click(object sender, EventArgs e)
        {
            MauSacView blue = new MauSacView();
            blue.ID = GetIdMauSac;
            MessageBox.Show(mauSacService.Delete(blue));
            LoadDataMauSac(mauSacService.GetMauSac());
        }

        private void dtg_showmausac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdMauSac = Guid.Parse(dtg_showmausac.CurrentRow.Cells[0].Value.ToString());
            tbx_mams.Text = dtg_showmausac.CurrentRow.Cells[2].Value.ToString();
            tbx_tenms.Text = dtg_showmausac.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_themnsx_Click(object sender, EventArgs e)
        {
            NsxView apple = new NsxView();
            apple.ID = Guid.NewGuid();
            apple.Ma = tbx_mansx.Text;
            apple.Ten = tbx_tennsx.Text;
            if (nsxService.CheckMa(tbx_mansx.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(nsxService.Add(apple));
                LoadDataNsx(nsxService.GetNsx());
            }
        }

        private void btn_suansx_Click(object sender, EventArgs e)
        {
            NsxView apple = new NsxView();
            apple.ID = GetIdNsx;
            apple.Ten = tbx_tennsx.Text;
            MessageBox.Show(nsxService.Update(apple));
            LoadDataNsx(nsxService.GetNsx());
        }

        private void btn_xoansx_Click(object sender, EventArgs e)
        {
            NsxView apple = new NsxView();
            apple.ID = GetIdNsx;
            MessageBox.Show(nsxService.Delete(apple));
            LoadDataNsx(nsxService.GetNsx());
        }

        private void dtg_shownsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdNsx = Guid.Parse(dtg_shownsx.CurrentRow.Cells[0].Value.ToString());
            tbx_mansx.Text = dtg_shownsx.CurrentRow.Cells[2].Value.ToString();
            tbx_tennsx.Text = dtg_shownsx.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_themlt_Click(object sender, EventArgs e)
        {
            LaptopView lv = new LaptopView();
            lv.ID = Guid.NewGuid();
            lv.Ma = tbx_malaptop.Text;
            lv.Ten = tbx_tenlaptop.Text;
            if (laptopService.CheckMa(tbx_malaptop.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(laptopService.AddLaptop(lv));
                LoadDataLaptop(laptopService.GetLaptop());
            }
        }

        private void btn_sualt_Click(object sender, EventArgs e)
        {
            LaptopView lv = new LaptopView();
            lv.ID = GetIdLaptop;
            lv.Ten = tbx_tenlaptop.Text;
            MessageBox.Show(laptopService.UpdateLaptop(lv));
            LoadDataLaptop(laptopService.GetLaptop());
        }

        private void btn_xoalt_Click(object sender, EventArgs e)
        {
            LaptopView lv = new LaptopView();
            lv.ID = GetIdLaptop;
            MessageBox.Show(laptopService.DeleteLaptop(lv));
            LoadDataLaptop(laptopService.GetLaptop());
        }

        private void dtg_showlaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdLaptop = Guid.Parse(dtg_showlaptop.CurrentRow.Cells[0].Value.ToString());
            tbx_malaptop.Text = dtg_showlaptop.CurrentRow.Cells[2].Value.ToString();
            tbx_tenlaptop.Text = dtg_showlaptop.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_themthuoctinh_Click(object sender, EventArgs e)
        {
            ThuocTinhView xinh = new ThuocTinhView();
            xinh.ID = Guid.NewGuid();
            xinh.IDLaptop = laptopService.GetLaptop().FirstOrDefault(a => a.Ma == cbb_idlaptoptt.Text).ID;
            xinh.Ma = tbx_mathuoctinh.Text;
            xinh.Ten = tbx_tenthuoctinh.Text;
            if (thuocTinhService.CheckMaTt(tbx_mathuoctinh.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(thuocTinhService.AddTt(xinh));
                LoadDataThuocTinh(thuocTinhService.GetThuocTinh());
            }
        }

        private void btn_suathuoctinh_Click(object sender, EventArgs e)
        {
            ThuocTinhView xinh = new ThuocTinhView();
            xinh.ID = GetIdThuocTinh;
            xinh.Ten = tbx_tenthuoctinh.Text;
            MessageBox.Show(thuocTinhService.UpdateTt(xinh));
            LoadDataThuocTinh(thuocTinhService.GetThuocTinh());
        }

        private void btn_xoathuoctinh_Click(object sender, EventArgs e)
        {
            ThuocTinhView xinh = new ThuocTinhView();
            xinh.ID = GetIdThuocTinh;
            MessageBox.Show(thuocTinhService.DeleteTt(xinh));
            LoadDataThuocTinh(thuocTinhService.GetThuocTinh());
        }

        private void dtg_showthuoctinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdThuocTinh = Guid.Parse(dtg_showthuoctinh.CurrentRow.Cells[0].Value.ToString());
            tbx_mathuoctinh.Text = dtg_showthuoctinh.CurrentRow.Cells[2].Value.ToString();
            tbx_tenthuoctinh.Text = dtg_showthuoctinh.CurrentRow.Cells[4].Value.ToString();
            cbb_idlaptoptt.Text = dtg_showthuoctinh.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_themgiatri_Click(object sender, EventArgs e)
        {
            GiaTriView gtv = new GiaTriView();
            gtv.ID = Guid.NewGuid();
            gtv.IDThuocTinh = thuocTinhService.GetThuocTinh().FirstOrDefault(a => a.Ma == cbb_idthuoctinh.Text).ID;
            gtv.Ma = tbx_magiatri.Text;
            gtv.ThongSo = tbx_thongsogt.Text;
            if (giaTriService.CheckMaGt(tbx_magiatri.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(giaTriService.AddGt(gtv));
                LoadDataGiaTri(giaTriService.GetGiaTri());
            }
        }

        private void btn_suagiatri_Click(object sender, EventArgs e)
        {
            GiaTriView gtv = new GiaTriView();
            gtv.ID = GetIdGiaTri;
            gtv.ThongSo = tbx_thongsogt.Text;
            MessageBox.Show(giaTriService.UpDateGt(gtv));
            LoadDataGiaTri(giaTriService.GetGiaTri());
        }

        private void btn_xoagiatri_Click(object sender, EventArgs e)
        {
            GiaTriView gtv = new GiaTriView();
            gtv.ID = GetIdGiaTri;
            MessageBox.Show(giaTriService.DeleteGt(gtv));
            LoadDataGiaTri(giaTriService.GetGiaTri());
        }

        private void dtg_showgiatri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdGiaTri = Guid.Parse(dtg_showgiatri.CurrentRow.Cells[0].Value.ToString());
            tbx_magiatri.Text = dtg_showgiatri.CurrentRow.Cells[2].Value.ToString();
            tbx_thongsogt.Text = dtg_showgiatri.CurrentRow.Cells[4].Value.ToString();
            cbb_idthuoctinh.Text = dtg_showgiatri.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_themctlt_Click(object sender, EventArgs e)
        {
            ChiTietLaptopView thao = new ChiTietLaptopView();
            thao.ID = Guid.NewGuid();
            thao.IDLaptop = laptopService.GetLaptop().FirstOrDefault(a => a.Ma == cbb_malaptopctlt.Text).ID;
            thao.IDMauSac = mauSacService.GetMauSac().FirstOrDefault(a => a.Ma == cbb_mams.Text).ID;
            thao.IDNsx = nsxService.GetNsx().FirstOrDefault(a => a.Ma == cbb_mansx.Text).ID;
            thao.MoTa = tbx_mota.Text;
            thao.SoLuong = Convert.ToInt32(nud_soluong.Value);
            thao.GiaNhap = Convert.ToDecimal(tbx_ctltgianhap.Text);
            thao.Giaban = Convert.ToDecimal(tbx_ctltgiaban.Text);
            MessageBox.Show(chiTietLaptopService.Add(thao));
            LoadDataChiTietLaptop(chiTietLaptopService.GetChiTietLaptop());
        }

        private void btn_suactlt_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoactlt_Click(object sender, EventArgs e)
        {

        }
    }
}
