using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class IndexForm : Form
    {
        private Form activeForm = null;
        // public static string Sdtnv = string.Empty;
        public IndexForm()
        {
            InitializeComponent();
        }
        void OpenZeroForm(Form thao)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = thao;
            thao.TopLevel = false;
            thao.FormBorderStyle = FormBorderStyle.None;
            thao.Dock = DockStyle.Fill;
            panel_index.Controls.Add(thao);
            thao.BringToFront();
            thao.Show();
        }
        void LoadDataIndex(List<ChiTietLaptopView> listctlaptop)
        {
            //dtg_viewindex.Rows.Clear();
            //dtg_viewindex.ColumnCount = 11;
            //dtg_viewindex.Columns[0].Name = "ID";
            //dtg_viewindex.Columns[0].Visible = false;
            //dtg_viewindex.Columns[1].Name = "STT";
            //dtg_viewindex.Columns[2].Name = "Tên laptop";
            //dtg_viewindex.Columns[3].Name = "Nhà sản xuất";
            //dtg_viewindex.Columns[4].Name = "Màu sắc";
            //dtg_viewindex.Columns[5].Name = "CPU";
            //dtg_viewindex.Columns[6].Name = "RAM";
            //dtg_viewindex.Columns[7].Name = "SSD";
            //dtg_viewindex.Columns[8].Name = "Mô tả";
            //dtg_viewindex.Columns[9].Name = "Số lượng";
            //dtg_viewindex.Columns[10].Name = "Giá";
            //foreach (var s in listctlaptop)
            //{
            //    dtg_viewindex.Rows.Add();
            //}
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            //   LoadDataIndex();
            //  mni_username.Text = Sdtnv;
        }
        private void mni_admin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(FormLogin.CheckAdmin));
            //this.Hide();
            //LoginAdminForm laf = new LoginAdminForm();
            //laf.ShowDialog();
            //this.Show();
        }

        private void tsmi_quanlylaptop_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //QuanLyLaptopForm qllaptop = new QuanLyLaptopForm();
            //qllaptop.ShowDialog();
            //this.Show();

            OpenZeroForm(new QuanLyLaptopForm());
        }

        private void tsmni_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmn_banhang_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FormBanHang fbh = new FormBanHang();
            //fbh.ShowDialog();
            //this.Show();
        }

        private void IBtn_banhang_Click(object sender, EventArgs e)
        {
            OpenZeroForm(new FormBanHang());
        }

        private void IBtn_quanlylaptop_Click(object sender, EventArgs e)
        {
            if (FormLogin.CheckAdmin == 1)
            {
                OpenZeroForm(new QuanLyLaptopForm());
            }
            else
            {
                MessageBox.Show("Chỉ Admin mới có quyền vào đây", "Cảnh báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void IBtn_loginAdminForm_Click(object sender, EventArgs e)
        {
           
            if (FormLogin.CheckAdmin == 1)
            {
              OpenZeroForm(new AdminForm());
            }
            else
            {
                MessageBox.Show("Chỉ Admin mới có quyền vào đây", "Cảnh báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void IBtn_thongke_Click(object sender, EventArgs e)
        {
            OpenZeroForm(new DataStatistics());
        }
    }
}
