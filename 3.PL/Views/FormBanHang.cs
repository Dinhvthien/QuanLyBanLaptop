using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace _3.PL.Views
{
    public partial class FormBanHang : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice videoCaptureDevice;
        IKhachHangService khachHangService;
        INhanVienService nhanVienService;
        IChiTietLaptopService chiTietLaptopService;
        IHoaDonChiTietService hoaDonChiTietService;
        IHoaDonService hoaDonService;
        IVoucherService voucherService;
        ImeiDaBanService imeiDaBanService;
        Guid GetIdKhachHang { get; set; }
        Guid GetIdHoaDon { get; set; }
        Guid GetIdHoaDonChiTiet { get; set; }
        Connection thuy = new Connection();

        public FormBanHang()
        {
            InitializeComponent();
            khachHangService = new KhachHangService();
            nhanVienService = new NhanVienService();
            chiTietLaptopService = new ChiTietLaptopService();
            hoaDonChiTietService = new HoaDonChiTietService();
            hoaDonService = new HoaDonService();
            voucherService = new VoucherService();
            imeiDaBanService = new ImeiDaBanService();

        }
        private void FormBanHang_Load(object sender, EventArgs e)
        {
            tbx_mavoucher.Text = "0";
            LoadCombobox();
            LoadDataKhachHang(khachHangService.GetKhachHang());
            LoadDataLaptop(chiTietLaptopService.GetChiTietLaptop());
            LoadDataHoaDon(hoaDonService.GetHoaDon());
            LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietNoJoin());
            listview_hoadon.Visible = true;
            btn_thanhtoan.Visible = false;
            /////
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cbb_choose.Items.Add(Device.Name);
            }

            cbb_choose.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
            //string lay = "select * from khachhang";
            //thuy(lay.All());
            //dtg_testsql.DataSource = thuy;
            //   Functions.

        }
        void LoadCombobox()
        {
            cbb_manhanvien.Items.Clear();
            foreach (var s in nhanVienService.GetAllNhanVien())
            {
                cbb_manhanvien.Items.Add(s.Ma);
            }
        }
        void LoadDataLaptop(List<ChiTietLaptopView> list)
        {
            int sttctlt = 0;
            dtg_xemlaptop.Rows.Clear();
            dtg_xemlaptop.ColumnCount = 14;
            dtg_xemlaptop.Columns[0].Name = "ID";
            dtg_xemlaptop.Columns[0].Visible = false;
            dtg_xemlaptop.Columns[1].Name = "STT";
            dtg_xemlaptop.Columns[2].Name = "Mã";
            dtg_xemlaptop.Columns[3].Name = "Mã Laptop ";
            dtg_xemlaptop.Columns[4].Name = "TenLaptop";
            dtg_xemlaptop.Columns[5].Name = "Tên thuộc tính";
            dtg_xemlaptop.Columns[6].Name = "Thông số giá trị";
            dtg_xemlaptop.Columns[7].Name = "Tên nhà sản xuất";
            dtg_xemlaptop.Columns[8].Name = "Tên màu sắc";
            dtg_xemlaptop.Columns[9].Name = "Mô tả";
            dtg_xemlaptop.Columns[10].Name = "Số lượng";
            dtg_xemlaptop.Columns[11].Name = "Giá nhập";
            dtg_xemlaptop.Columns[12].Name = "Giá bán";
            dtg_xemlaptop.Columns[13].Name = "Số Imei";
            dtg_xemlaptop.Columns[1].Visible = false;
            dtg_xemlaptop.Columns[2].Visible = false;
            dtg_xemlaptop.Columns[3].Visible = false;
            dtg_xemlaptop.Columns[4].Visible = false;
            dtg_xemlaptop.Columns[7].Visible = false;
            dtg_xemlaptop.Columns[8].Visible = false;
            dtg_xemlaptop.Columns[9].Visible = false;
            dtg_xemlaptop.Columns[10].Visible = false;
            dtg_xemlaptop.Columns[11].Visible = false;
            dtg_xemlaptop.Columns[12].Visible = false;
            dtg_xemlaptop.Columns[13].Visible = false;
            foreach (var s in list)
            {
                sttctlt++;
                dtg_xemlaptop.Rows.Add(s.ID, sttctlt, s.Ma, s.MaLaptop, s.TenLaptop, s.TenThuocTinh, s.ThongSoGiaTri, s.TenNsx, s.TenMauSac, s.MoTa, s.SoLuong, s.GiaNhap, s.Giaban, s.SoImei);
            }
        }
        void LoadDataKhachHang(List<KhachHangView> list)
        {
            int stt = 0;
            dtg_showkhachhang.Rows.Clear();
            dtg_showkhachhang.ColumnCount = 5;
            dtg_showkhachhang.Columns[0].Name = "ID";
            dtg_showkhachhang.Columns[0].Visible = false;
            dtg_showkhachhang.Columns[1].Name = "STT";
            dtg_showkhachhang.Columns[2].Name = "Họ Tên";
            dtg_showkhachhang.Columns[3].Name = "Địa Chỉ";
            dtg_showkhachhang.Columns[4].Name = "SĐT";
            foreach (var a in list)
            {
                stt++;
                dtg_showkhachhang.Rows.Add(a.ID, stt, a.HoTen, a.DiaChi, a.SDT);
            }

        }
        void LoadDataHoaDon(List<HoaDonView> listhdv)
        {
            dtg_showhoadon.Rows.Clear();
            dtg_showhoadon.ColumnCount = 9;
            dtg_showhoadon.Columns[0].Name = "ID";
            dtg_showhoadon.Columns[0].Visible = false;
            dtg_showhoadon.Columns[1].Name = "Mã";
            dtg_showhoadon.Columns[2].Name = "Mã nhân viên";
            dtg_showhoadon.Columns[3].Name = "Số điện thoại khách hàng";
            dtg_showhoadon.Columns[4].Name = "Ngày tạo";
            dtg_showhoadon.Columns[5].Name = "Tên người nhận";
            dtg_showhoadon.Columns[6].Name = "SĐT người nhận";
            dtg_showhoadon.Columns[7].Name = "Mã voucher";
            dtg_showhoadon.Columns[8].Name = "Tình trạng";

            foreach (var s in listhdv)
            {
                dtg_showhoadon.Rows.Add(s.ID, s.Ma, s.MaNhanVien, s.SdtKhachHang, s.NgayTao, s.TenNguoiNhan, s.SdtNguoiNhan, s.MaVoucher, s.TinhTrang);
            }
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
        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            if (tbx_sdtkhachhang.Text == "" || tbx_tenkhachhang.Text == "" || tbx_diachikhachhang.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin khách hàng", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachHangView thao = new KhachHangView();
                thao.ID = Guid.NewGuid();
                thao.HoTen = tbx_tenkhachhang.Text;
                thao.DiaChi = tbx_diachikhachhang.Text;
                thao.SDT = tbx_sdtkhachhang.Text;
                if (khachHangService.CheckSDT(tbx_sdtkhachhang.Text))
                {
                    MessageBox.Show("Khách hàng đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(khachHangService.AddKhachHang(thao));
                    LoadDataKhachHang(khachHangService.GetKhachHang());
                }

            }

        }

        private void btn_suakhachhang_Click(object sender, EventArgs e)
        {
            if (tbx_sdtkhachhang.Text == "" || tbx_tenkhachhang.Text == "" || tbx_diachikhachhang.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin khách hàng", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachHangView thao = new KhachHangView();
                thao.ID = GetIdKhachHang;
                thao.HoTen = tbx_tenkhachhang.Text;
                thao.DiaChi = tbx_diachikhachhang.Text;
                MessageBox.Show(khachHangService.UpdateKhachHang(thao));
                LoadDataKhachHang(khachHangService.GetKhachHang());
            }

        }

        private void btn_xoakhachhang_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangView thao = new KhachHangView();
                thao.ID = GetIdKhachHang;
                MessageBox.Show(khachHangService.DeleteKhachHang(thao));
                LoadDataKhachHang(khachHangService.GetKhachHang());
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy chọn khách hàng để xóa", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void dtg_showkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow x = dtg_showkhachhang.Rows[e.RowIndex];
                    GetIdKhachHang = Guid.Parse(dtg_showkhachhang.CurrentRow.Cells[0].Value.ToString());
                    tbx_tenkhachhang.Text = x.Cells[2].Value.ToString();
                    tbx_diachikhachhang.Text = x.Cells[3].Value.ToString();
                    tbx_sdtkhachhang.Text = x.Cells[4].Value.ToString();
                    tbx_sodienthoaikh.Text = x.Cells[4].Value.ToString();
                    tbx_tennguoinhan.Text = x.Cells[2].Value.ToString();
                    tbx_sdtnguoinhan.Text = x.Cells[4].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu");
            }

        }
        private void tbx_timsdtkhachhang_TextChanged(object sender, EventArgs e)
        {
            //var thao = khachHangService.GetKhachHang().Where(a => a.SDT.Contains(tbx_timsdtkhachhang.Text)).ToList();
            //LoadDataKhachHang(thao);
            var thao = khachHangService.FindKhachHang(tbx_timsdtkhachhang.Text);
            LoadDataKhachHang(thao);
        }

        private void tbx_qrtimtheoma_TextChanged(object sender, EventArgs e)
        {
            var q = chiTietLaptopService.GetChiTietLaptop().Where(a => a.Ma == tbx_qrtimtheoma.Text).ToList();
            LoadDataLaptop(q);
        }

        private void cbb_timtheonsx_TextChanged(object sender, EventArgs e)
        {
            var x = chiTietLaptopService.GetChiTietLaptop().Where(a => a.MaNsx.Contains(cbb_timtheonsx.Text)).ToList();
            LoadDataLaptop(x);
        }
        private void btn_opencamera_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(CaptureDevice[cbb_choose.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += new NewFrameEventHandler(videoCaptureDevice_NewFrame);
            videoCaptureDevice.Start();
        }
        private void videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ptb_qrcode.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_showcode_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)ptb_qrcode.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    timer1.Stop();
                    tbx_qrtimtheoma.Text = decoded;
                    tbx_hoadon_mactlt.Text = decoded;
                    MessageBox.Show(decoded);
                }
            }
            catch (Exception)
            {

            }
        }
        private void FormBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.SignalToStop();
            }
        }
        private void btn_closecamera_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.SignalToStop();
        }

        private void dtg_xemlaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbx_machitietlaptop.Text = dtg_xemlaptop.CurrentRow.Cells[2].Value.ToString();
                tbx_xemlaptopmalaptop.Text = dtg_xemlaptop.CurrentRow.Cells[3].Value.ToString();
                tbx_xemlaptop_tennsx.Text = dtg_xemlaptop.CurrentRow.Cells[7].Value.ToString();
                tbx_xemlaptop_tenmausac.Text = dtg_xemlaptop.CurrentRow.Cells[8].Value.ToString();
                tbx_mota.Text = dtg_xemlaptop.CurrentRow.Cells[9].Value.ToString();
                tbx_xemlaptopsoluong.Text = dtg_xemlaptop.CurrentRow.Cells[10].Value.ToString();
                tbx_ctltgianhap.Text = dtg_xemlaptop.CurrentRow.Cells[11].Value.ToString();
                tbx_ctltgiaban.Text = dtg_xemlaptop.CurrentRow.Cells[12].Value.ToString();
                tbx_xemlaptop_soimei.Text = dtg_xemlaptop.CurrentRow.Cells[13].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void btn_themhoadon_Click(object sender, EventArgs e)
        {
            if (cbb_manhanvien.Text == "" || tbx_sdtkhachhang.Text == "" || tbx_mavoucher.Text == "" || tbx_tennguoinhan.Text == "" || tbx_sdtnguoinhan.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //int linh = 0;
                //linh = dtg_showhoadon.Rows.Count;
                //string ngoc = "";
                //int anh = 0;
                //ngoc = Convert.ToString(dtg_showhoadon.Rows[linh - 2].Cells[1].Value);
                //anh = Convert.ToInt32(ngoc.Remove(0, 6));
                //tbx_mahoadon.Text = "HoaDon" + (anh + 1).ToString();
                //listview_hoadon.Visible = true;
                //var thao = khachHangService.GetKhachHang();
                //var linh = thao.FirstOrDefault(a => a.SDT == tbx_sodienthoaikh.Text);
                tbx_mahoadon.Text = "HoaDon" + DateTime.Now.ToString();
                HoaDonView hoadon = new HoaDonView();
                hoadon.ID = Guid.NewGuid();
                hoadon.Ma = tbx_mahoadon.Text;
                hoadon.NgayTao = dtp_ngaytaohoadon.Value;
                hoadon.TenNguoiNhan = tbx_tennguoinhan.Text;
                hoadon.SdtNguoiNhan = tbx_sdtnguoinhan.Text;
                hoadon.IdNhanVien = nhanVienService.GetAllNhanVien().FirstOrDefault(a => a.Ma == cbb_manhanvien.Text).ID;
                hoadon.IdKhachHang = khachHangService.GetKhachHang().FirstOrDefault(a => a.SDT == tbx_sodienthoaikh.Text).ID;
                hoadon.IdVoucher = voucherService.GetVoucher().FirstOrDefault(a => a.Ma == tbx_mavoucher.Text).ID;
                if (rbt_chuathanhtoan.Checked)
                {
                    hoadon.TinhTrang = 0;
                }
                else { hoadon.TinhTrang = 1; }

                if (hoaDonService.CheckMa(tbx_mahoadon.Text))
                {
                    MessageBox.Show("Hóa đơn đã tồn tại", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(hoaDonService.Add(hoadon));
                    LoadDataHoaDon(hoaDonService.GetHoaDon());
                }
            }

        }

        private void btn_suahoadon_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonView hoadonx = new HoaDonView();
                hoadonx.ID = GetIdHoaDon;
                hoadonx.TenNguoiNhan = tbx_tennguoinhan.Text;
                hoadonx.SdtNguoiNhan = tbx_sdtnguoinhan.Text;
                if (rbt_chuathanhtoan.Checked)
                {
                    hoadonx.TinhTrang = 0;
                }
                else
                {
                    hoadonx.TinhTrang = 1;
                }
                MessageBox.Show(hoaDonService.Update(hoadonx));
                LoadDataHoaDon(hoaDonService.GetHoaDon());
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy điển đủ dữ liệu mới được sửa", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_xoahoadon_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonView hoadonx = new HoaDonView();
                hoadonx.ID = GetIdHoaDon;
                DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    MessageBox.Show(hoaDonService.Delete(hoadonx));
                    LoadDataHoaDon(hoaDonService.GetHoaDon());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy chọn hóa đơn để xóa", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void dtg_showhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetIdHoaDon = Guid.Parse(dtg_showhoadon.CurrentRow.Cells[0].Value.ToString());
                tbx_mahoadon.Text = dtg_showhoadon.CurrentRow.Cells[1].Value.ToString();
                dtp_ngaytaohoadon.Value = Convert.ToDateTime(dtg_showhoadon.CurrentRow.Cells[4].Value.ToString());
                tbx_tennguoinhan.Text = dtg_showhoadon.CurrentRow.Cells[5].Value.ToString();
                tbx_sdtnguoinhan.Text = dtg_showhoadon.CurrentRow.Cells[6].Value.ToString();
                cbb_manhanvien.Text = dtg_showhoadon.CurrentRow.Cells[2].Value.ToString();
                tbx_sodienthoaikh.Text = dtg_showhoadon.CurrentRow.Cells[3].Value.ToString();
                tbx_mavoucher.Text = dtg_showhoadon.CurrentRow.Cells[7].Value.ToString();
                string tt = dtg_showhoadon.CurrentRow.Cells[8].Value.ToString();
                if (tt == "1")
                {
                    rbt_dathanhtoan.Checked = true;
                }
                else rbt_chuathanhtoan.Checked = true;
            }
            catch (Exception)
            {

            }
        }
        private void tbx_sdtnguoinhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sdtkhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_taohoadonchitiet_Click(object sender, EventArgs e)
        {
            if (tbx_giagoc.Text == "" || tbx_giamgia.Text == "" || tbx_thanhtien.Text == "")
            {
                MessageBox.Show("Hãy tạo hóa đơn,thêm sản phẩm rồi mới được lưu.");
            }
            else
            {
                HoaDonChiTietView hdctv = new HoaDonChiTietView();
                hdctv.ID = Guid.NewGuid();
                hdctv.Ma = tbx_mahoadonchitiet.Text;string ngoc= "HDCT" + Convert.ToString(DateTime.Now);
                hdctv.Ma = ngoc;
                hdctv.IDChiTietLapTop = chiTietLaptopService.GetChiTietLaptop().FirstOrDefault(a => a.Ma == tbx_hoadon_mactlt.Text).ID;
                hdctv.IDHoaDon = hoaDonService.GetHoaDon().FirstOrDefault(a => a.Ma == tbx_mahoadon.Text).ID;
                hdctv.SoLuong = Convert.ToInt32(nud_hdctsoluong.Value);
                hdctv.GiaTruoc = Convert.ToDecimal(tbx_giagoc.Text);
                hdctv.NgayTao = dtp_ngaytaohoadon.Value;
                hdctv.GiaSauKhiGiam = Convert.ToDecimal(tbx_thanhtien.Text);
                if (rbt_dathanhtoan.Checked)
                {
                    hdctv.TinhTrang = 1;
                    ChiTietLaptopView gh = new ChiTietLaptopView();
                    gh.ID = chiTietLaptopService.GetChiTietLaptop().FirstOrDefault(a => a.Ma == tbx_hoadon_mactlt.Text).ID;
                    gh.SoLuong = 0;
                    chiTietLaptopService.UpdateSoLuong(gh);
                }
                else
                {
                    hdctv.TinhTrang = 0;
                }
                //if (hoaDonChiTietService.CheckMa(tbx_mahoadonchitiet.Text))
                //{
                //    MessageBox.Show("Mã đã có", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                //{
                MessageBox.Show(hoaDonChiTietService.Add(hdctv));
                LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietNoJoin());
                if (tbx_soimeidaban.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (hoaDonChiTietService.GetHoaDonChiTietNoJoin().FirstOrDefault(a => a.Ma == ngoc).TinhTrang == 0)
                {
                    MessageBox.Show("Chưa thanh toán ! Không thể thêm imei đã bán", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ImeiDaBanView i = new ImeiDaBanView();
                    i.ID = Guid.NewGuid();
                    i.IDHoaDonChiTiet = hoaDonChiTietService.GetHoaDonChiTietNoJoin().FirstOrDefault(a => a.Ma == ngoc).ID;
                    i.SoEmei = tbx_soimeidaban.Text;
                    MessageBox.Show(imeiDaBanService.Add(i));
                    LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTiet());
                }
                // }
               
            }
        }

        private void btn_themimeidaban_Click(object sender, EventArgs e)
        {


        }

        void LoadDataCreateHoaDon()
        {


        }
        int soluongsanphammua = 0;
        decimal tongtien = 0;
        private void btn_createhoadon_Click(object sender, EventArgs e)
        {
            var linh = chiTietLaptopService.GetChiTietLaptop().FirstOrDefault(a => a.Ma == tbx_hoadon_mactlt.Text);

            if (linh == null)
            {
                MessageBox.Show("K tìm thấy sản phẩm", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (linh.SoLuong <= 0)
            {
                MessageBox.Show("Sản phẩm đã hết hàng", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (nud_hdctsoluong.Value <= 0)
                {
                    MessageBox.Show("Số lượng sản phẩm sai", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var soimei = chiTietLaptopService.GetChiTietLaptop().FirstOrDefault(a => a.Ma == tbx_hoadon_mactlt.Text).SoImei;
                    var s = hoaDonService.GetHoaDon().FirstOrDefault(a => a.Ma == tbx_mahoadon.Text).GiaTriVoucher;
                    var h = chiTietLaptopService.GetChiTietLaptop().FirstOrDefault(a => a.Ma == tbx_hoadon_mactlt.Text).Giaban;
                    decimal x = h * nud_hdctsoluong.Value - s;
                    tbx_giamgia.Text = Convert.ToString(s);
                    tbx_giagoc.Text = Convert.ToString(h);
                    tbx_thanhtien.Text = Convert.ToString(x);
                    tbx_soimeidaban.Text = soimei;
                    var li = chiTietLaptopService.GetChiTietLaptop().FirstOrDefault(a => a.Ma == tbx_hoadon_mactlt.Text);
                    listview_hoadon.FullRowSelect = true;
                    listview_hoadon.GridLines = true;
                    ListViewItem l1 = new ListViewItem();
                    l1.Text = li.Ma;
                    l1.SubItems.Add(li.TenLaptop);
                    l1.SubItems.Add(li.TenLaptop);
                    l1.SubItems.Add(li.SoImei);
                    l1.SubItems.Add(Convert.ToString(li.Giaban));
                    listview_hoadon.Items.Add(l1);
                    soluongsanphammua++;
                    tongtien += li.Giaban;
                    nudz_slhoadon.Value = soluongsanphammua;
                    tbx_tongtien.Text = Convert.ToString(tongtien);
                }
            }

        }

        private void dtg_hoadonchitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetIdHoaDonChiTiet = Guid.Parse(dtg_hoadonchitiet.CurrentRow.Cells[0].Value.ToString());
                tbx_mahoadonchitiet.Text = dtg_hoadonchitiet.CurrentRow.Cells[1].Value.ToString();
                string getMaCTLT = dtg_hoadonchitiet.CurrentRow.Cells[3].Value.ToString();
                tbx_soimeidaban.Text = chiTietLaptopService.GetChiTietLaptop().FirstOrDefault(a => a.Ma == getMaCTLT).SoImei;
            }
            catch (Exception)
            {


            }

        }

        private void rbt_timhoadonchuatt_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataHoaDon(hoaDonService.GetHoaDon().Where(a => a.TinhTrang == 0).ToList());
            LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietNoJoin().Where(a => a.TinhTrang == 0).ToList());
            btn_thanhtoan.Visible = true;
        }

        private void rbt_timhddathanhtoan_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataHoaDon(hoaDonService.GetHoaDon().Where(a => a.TinhTrang == 1).ToList());
            LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietNoJoin().Where(a => a.TinhTrang == 1).ToList());
            btn_thanhtoan.Visible = false;
        }

        private void rbt_hienthiall_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataHoaDon(hoaDonService.GetHoaDon());
            LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietNoJoin());
            btn_thanhtoan.Visible = false;
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonChiTietView hoadonchitetxsmax = new HoaDonChiTietView();
                hoadonchitetxsmax.TinhTrang = 1;
                hoadonchitetxsmax.ID = GetIdHoaDonChiTiet;
                MessageBox.Show(hoaDonChiTietService.UpdateTrangThai(hoadonchitetxsmax));
                LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietNoJoin());
                ImeiDaBanView i = new ImeiDaBanView();
                i.ID = Guid.NewGuid();
                i.IDHoaDonChiTiet = hoaDonChiTietService.GetHoaDonChiTietNoJoin().FirstOrDefault(a => a.Ma == tbx_mahoadonchitiet.Text).ID;
                i.SoEmei = tbx_soimeidaban.Text;
                MessageBox.Show(imeiDaBanService.Add(i));
                LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTiet());

            }
            catch (Exception)
            {

            }
        }

        private void tbx_sodienthoaikh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_xoahoadonchitiet_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonChiTietView hoadonchitetxsmax = new HoaDonChiTietView();
                hoadonchitetxsmax.ID = GetIdHoaDonChiTiet;
                DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    MessageBox.Show(hoaDonChiTietService.Delete(hoadonchitetxsmax));
                    //  LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTiet());
                    LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietNoJoin());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hãy chọn để xóa", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
