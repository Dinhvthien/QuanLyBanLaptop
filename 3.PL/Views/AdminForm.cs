using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class AdminForm : Form
    {
        Guid GetIdCuaHang { get; set; }
        Guid GetIdChucVu { get; set; }
        Guid GetIdNhanVien { get; set; }
        Guid GetIdVoucher { get; set; }
        ICuaHangService cuaHangService;
        IChucVuService chucVuService;
        INhanVienService nhanVienService;
        IVoucherService voucherService;
        public AdminForm()
        {
            InitializeComponent();
            cuaHangService = new CuaHangService();
            chucVuService = new ChucVuService();
            nhanVienService = new NhanVienService();
            voucherService = new VoucherService();

        }
        void LoadCombobox()
        {
            cbb_idchucvu.Items.Clear();
            var lmachucvu = chucVuService.GetChucVu();
            foreach (var s in lmachucvu)
            {
                cbb_idchucvu.Items.Add(s.Ma);
            }
            cbb_idcuahang.Items.Clear();
            var lmacuahang = cuaHangService.GetCuaHang();
            foreach (var a in lmacuahang)
            {
                cbb_idcuahang.Items.Add(a.Ma);
            }
        }
        void LoadCuaHang(List<CuaHangView> listcuahang)
        {
            int stt = 0;
            dtg_cuahang.Rows.Clear();
            dtg_cuahang.ColumnCount = 6;
            dtg_cuahang.Columns[0].Name = "ID";
            dtg_cuahang.Columns[0].Visible = false;
            dtg_cuahang.Columns[1].Name = "STT";
            dtg_cuahang.Columns[2].Name = "Mã";
            dtg_cuahang.Columns[3].Name = "Tên";
            dtg_cuahang.Columns[4].Name = "Địa chỉ";
            dtg_cuahang.Columns[5].Name = "SĐT";
            foreach (var s in listcuahang)
            {
                stt++;
                dtg_cuahang.Rows.Add(s.ID, stt, s.Ma, s.Ten, s.DiaChi, s.Sdt);
            }
        }
        void LoadChucVu(List<ChucVuView> listchucvu)
        {
            int stt = 0;
            dtg_chucvu.Rows.Clear();
            dtg_chucvu.ColumnCount = 4;
            dtg_chucvu.Columns[0].Name = "ID";
            dtg_chucvu.Columns[0].Visible = false;
            dtg_chucvu.Columns[1].Name = "STT";
            dtg_chucvu.Columns[2].Name = "Mã";
            dtg_chucvu.Columns[3].Name = "Tên";

            foreach (var s in listchucvu)
            {
                stt++;
                dtg_chucvu.Rows.Add(s.ID, stt, s.Ma, s.Ten);
            }
        }
        void LoadNhanVien(List<NhanVienView> listnhanvien)
        {
            int sttnv = 0;
            dtg_shownhanvien.Rows.Clear();
            dtg_shownhanvien.ColumnCount = 10;
            dtg_shownhanvien.Columns[0].Name = "ID";
            dtg_shownhanvien.Columns[0].Visible = false;
            dtg_shownhanvien.Columns[1].Name = "STT";
            dtg_shownhanvien.Columns[2].Name = "Mã nhân viên";
            dtg_shownhanvien.Columns[3].Name = "Họ tên";
            dtg_shownhanvien.Columns[4].Name = "Địa Chỉ";
            dtg_shownhanvien.Columns[5].Name = "SDT";
            dtg_shownhanvien.Columns[6].Name = "Mật Khẩu";
            dtg_shownhanvien.Columns[6].Visible = false;
            dtg_shownhanvien.Columns[7].Name = "Trạng Thái";
            dtg_shownhanvien.Columns[8].Name = "Mã cửa hàng";
            dtg_shownhanvien.Columns[9].Name = "Mã chức vụ";
            foreach (var s in listnhanvien)
            {
                sttnv++;
                dtg_shownhanvien.Rows.Add(s.ID, sttnv, s.Ma, s.HoTen, s.DiaChi, s.SDT, s.MatKhau, s.TrangThai, s.MaCuaHang, s.MaChucVu);
            }
        }
        void LoadDataVoucher(List<VoucherView> listvc)
        {
            int sttvc = 0;
            dtg_showvoucher.Rows.Clear();
            dtg_showvoucher.ColumnCount = 8;
            dtg_showvoucher.Columns[0].Name = "ID";
            dtg_showvoucher.Columns[0].Visible = false;
            dtg_showvoucher.Columns[1].Name = "STT";
            dtg_showvoucher.Columns[2].Name = "Mã";
            dtg_showvoucher.Columns[3].Name = "Tên";
            dtg_showvoucher.Columns[4].Name = "Ngày bắt đầu";
            dtg_showvoucher.Columns[5].Name = "Ngày kết thúc";
            dtg_showvoucher.Columns[6].Name = "Giá trị";
            dtg_showvoucher.Columns[7].Name = "Số lượng";
            foreach (var k in listvc)
            {
                sttvc++;
                dtg_showvoucher.Rows.Add(k.ID, sttvc, k.Ma, k.Ten, k.StartDay, k.EndDay, k.GiaTri, k.SoLuong);
            }
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadCuaHang(cuaHangService.GetCuaHang());
            LoadChucVu(chucVuService.GetChucVu());
            LoadNhanVien(nhanVienService.GetAllNhanVien());
            LoadDataVoucher(voucherService.GetVoucher());
            LoadCombobox();
        }

        private void btn_themch_Click(object sender, EventArgs e)
        {
            CuaHangView thao = new CuaHangView();
            thao.ID = Guid.NewGuid();
            thao.Ma = tbx_macuahang.Text;
            thao.Ten = tbx_tencuahang.Text;
            thao.DiaChi = tbx_diachicuahang.Text;
            thao.Sdt = tbx_sdtcuahang.Text;
            if (cuaHangService.CheckMa(tbx_macuahang.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else
            {
                MessageBox.Show(cuaHangService.Add(thao));
                LoadCuaHang(cuaHangService.GetCuaHang());
            }

        }

        private void dtg_cuahang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdCuaHang = Guid.Parse(dtg_cuahang.CurrentRow.Cells[0].Value.ToString());
            tbx_macuahang.Text = dtg_cuahang.CurrentRow.Cells[2].Value.ToString();
            tbx_tencuahang.Text = dtg_cuahang.CurrentRow.Cells[3].Value.ToString();
            tbx_diachicuahang.Text = dtg_cuahang.CurrentRow.Cells[4].Value.ToString();
            tbx_sdtcuahang.Text = dtg_cuahang.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_suach_Click(object sender, EventArgs e)
        {
            CuaHangView thao = new CuaHangView();
            thao.ID = GetIdCuaHang;
            // thao.Ma = tbx_macuahang.Text;
            thao.Ten = tbx_tencuahang.Text;
            thao.DiaChi = tbx_diachicuahang.Text;
            thao.Sdt = tbx_sdtcuahang.Text;
            MessageBox.Show(cuaHangService.Update(thao));
            LoadCuaHang(cuaHangService.GetCuaHang());
        }

        private void btn_xoach_Click(object sender, EventArgs e)
        {
            CuaHangView thao = new CuaHangView();
            thao.ID = GetIdCuaHang;
            MessageBox.Show(cuaHangService.Delete(thao));
            LoadCuaHang(cuaHangService.GetCuaHang());
        }

        private void btn_themchucvu_Click(object sender, EventArgs e)
        {
            ChucVuView chucvuu = new ChucVuView();
            chucvuu.ID = Guid.NewGuid();
            chucvuu.Ma = tbx_machucvu.Text;
            chucvuu.Ten = tbx_tenchucvu.Text;
            if (chucVuService.CheckMa(tbx_machucvu.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else
            {
                MessageBox.Show(chucVuService.Add(chucvuu));
                LoadChucVu(chucVuService.GetChucVu());
            }
        }

        private void btn_suachucvu_Click(object sender, EventArgs e)
        {
            ChucVuView chucvuu = new ChucVuView();
            chucvuu.ID = GetIdChucVu;
            chucvuu.Ten = tbx_tenchucvu.Text;
            MessageBox.Show(chucVuService.Update(chucvuu));
            LoadChucVu(chucVuService.GetChucVu());
        }

        private void btn_xoachucvu_Click(object sender, EventArgs e)
        {
            ChucVuView chucvuu = new ChucVuView();
            chucvuu.ID = GetIdChucVu;
            MessageBox.Show(chucVuService.Delete(chucvuu));
            LoadChucVu(chucVuService.GetChucVu());
        }

        private void dtg_chucvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdChucVu = Guid.Parse(dtg_chucvu.CurrentRow.Cells[0].Value.ToString());
            tbx_machucvu.Text = dtg_chucvu.CurrentRow.Cells[2].Value.ToString();
            tbx_tenchucvu.Text = dtg_chucvu.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_themnhanvien_Click(object sender, EventArgs e)
        {
            NhanVienView t = new NhanVienView();
            t.ID = Guid.NewGuid();
            t.Ma = tbx_manhanvien.Text;
            t.HoTen = tbx_hotennhanvien.Text;
            t.DiaChi = tbx_diachinhanvien.Text;
            t.SDT = tbx_sdtnhanvien.Text;
            t.MatKhau = tbx_matkhaunhanvien.Text;
            t.TrangThai = Convert.ToInt32(nud_ttnhanvien.Value);
            t.IdCuaHang = cuaHangService.GetCuaHang().FirstOrDefault(a => a.Ma == cbb_idcuahang.Text).ID;
            t.IdChucVu = chucVuService.GetChucVu().FirstOrDefault(a => a.Ma == cbb_idchucvu.Text).ID;
            if (nhanVienService.CheckMa(tbx_manhanvien.Text))
            {
                MessageBox.Show("Mã đã có");
            }
            else
            {
                MessageBox.Show(nhanVienService.AddNhanVien(t));
                LoadNhanVien(nhanVienService.GetAllNhanVien());
            }
        }

        private void btn_suanhanvien_Click(object sender, EventArgs e)
        {
            NhanVienView t = new NhanVienView();
            t.ID = GetIdNhanVien;
            t.HoTen = tbx_hotennhanvien.Text;
            t.DiaChi = tbx_diachinhanvien.Text;
            t.SDT = tbx_sdtnhanvien.Text;
            t.MatKhau = tbx_matkhaunhanvien.Text;
            t.TrangThai = Convert.ToInt32(nud_ttnhanvien.Value);
            //t.IdCuaHang = cuaHangService.GetCuaHang().FirstOrDefault(a => a.Ma == cbb_idcuahang.Text).ID;
            //t.IdChucVu = chucVuService.GetChucVu().FirstOrDefault(a => a.Ma == cbb_idchucvu.Text).ID;
            MessageBox.Show(nhanVienService.UpdateNhanVien(t));
            LoadNhanVien(nhanVienService.GetAllNhanVien());
        }

        private void btn_xoanhanvien_Click(object sender, EventArgs e)
        {
            NhanVienView t = new NhanVienView();
            t.ID = GetIdNhanVien;
            MessageBox.Show(nhanVienService.DeleteNhanVien(t));
            LoadNhanVien(nhanVienService.GetAllNhanVien());
        }

        private void dtg_shownhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdNhanVien = Guid.Parse(dtg_shownhanvien.CurrentRow.Cells[0].Value.ToString());
            tbx_manhanvien.Text = dtg_shownhanvien.CurrentRow.Cells[2].Value.ToString();
            tbx_hotennhanvien.Text = dtg_shownhanvien.CurrentRow.Cells[3].Value.ToString();
            tbx_diachinhanvien.Text = dtg_shownhanvien.CurrentRow.Cells[4].Value.ToString();
            tbx_sdtnhanvien.Text = dtg_shownhanvien.CurrentRow.Cells[5].Value.ToString();
            tbx_matkhaunhanvien.Text = dtg_shownhanvien.CurrentRow.Cells[6].Value.ToString();
            nud_ttnhanvien.Value = Convert.ToDecimal(dtg_shownhanvien.CurrentRow.Cells[7].Value.ToString());
            cbb_idchucvu.Text = dtg_shownhanvien.CurrentRow.Cells[9].Value.ToString();
            cbb_idcuahang.Text = dtg_shownhanvien.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_themvoucher_Click(object sender, EventArgs e)
        {
            VoucherView v = new VoucherView();
            v.ID = Guid.NewGuid();
            v.Ma = tbx_mavoucher.Text;
            v.Ten = tbx_tenvoucher.Text;
            v.StartDay = Convert.ToDateTime(dtp_ngaybdvc.Value.ToString("yyyy/MM/dd"));
            v.EndDay = Convert.ToDateTime(dtp_ngayktvc.Value.ToString("yyyy/MM/dd"));
            v.GiaTri = Convert.ToDecimal(tbx_giatrivoucher.Text);
            v.SoLuong = Convert.ToInt32(tbx_soluongvoucher.Text);
            if (voucherService.CheckMa(tbx_mavoucher.Text))
            {
                MessageBox.Show("Voucher đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(voucherService.Add(v));
                LoadDataVoucher(voucherService.GetVoucher());
            }
        }

        private void btn_suavoucher_Click(object sender, EventArgs e)
        {
            VoucherView v = new VoucherView();
            v.ID = GetIdVoucher;
            v.Ten = tbx_tenvoucher.Text;
            v.StartDay = Convert.ToDateTime(dtp_ngaybdvc.Value.ToString("yyyy/MM/dd"));
            v.EndDay = Convert.ToDateTime(dtp_ngayktvc.Value.ToString("yyyy/MM/dd"));
            v.GiaTri = Convert.ToDecimal(tbx_giatrivoucher.Text);
            v.SoLuong = Convert.ToInt32(tbx_soluongvoucher.Text);
            MessageBox.Show(voucherService.Update(v));
            LoadDataVoucher(voucherService.GetVoucher());
        }

        private void btn_xoavoucher_Click(object sender, EventArgs e)
        {
            VoucherView v = new VoucherView();
            v.ID = GetIdVoucher;
            MessageBox.Show(voucherService.Delete(v));
            LoadDataVoucher(voucherService.GetVoucher());
        }

        private void dtg_showvoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdVoucher = Guid.Parse(dtg_showvoucher.CurrentRow.Cells[0].Value.ToString());
            tbx_mavoucher.Text = dtg_showvoucher.CurrentRow.Cells[2].Value.ToString();
            tbx_tenvoucher.Text = dtg_showvoucher.CurrentRow.Cells[3].Value.ToString();
            dtp_ngaybdvc.Value = Convert.ToDateTime(dtg_showvoucher.CurrentRow.Cells[4].Value.ToString());
            dtp_ngayktvc.Value = Convert.ToDateTime(dtg_showvoucher.CurrentRow.Cells[5].Value.ToString());
            tbx_giatrivoucher.Text = dtg_showvoucher.CurrentRow.Cells[6].Value.ToString();
            tbx_soluongvoucher.Text = Convert.ToString(dtg_showvoucher.CurrentRow.Cells[7].Value.ToString());
        }

        private void tbx_giatrivoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_soluongvoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sdtnhanvien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sdtcuahang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
