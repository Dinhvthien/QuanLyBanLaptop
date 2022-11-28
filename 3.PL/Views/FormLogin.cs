using _2.BUS.IService;
using _2.BUS.Service;

namespace _3.PL.Views
{

    public partial class FormLogin : Form
    {

        INhanVienService nhanVienService;
        //  public static string Sdtnv = string.Empty;
        public static int CheckAdmin = 0;
        public FormLogin()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Ibtn_login_Click(object sender, EventArgs e)
        {
            if (nhanVienService.CheckQuanLy(tbx_username.Text, tbx_password.Text, "ql"))
            {
                CheckAdmin = 1;
                //    Sdtnv = tbx_username.Text;
                ntf_quanly.ShowBalloonTip(5000);
                IndexForm idf = new IndexForm();
                this.Hide();// ẩn form login
                idf.ShowDialog();// show from index// được ưu tiên hiển thị
                this.Show();// hiện form login
                tbx_password.Text = "";
                tbx_username.Text = "";
            }
            else if (nhanVienService.CheckSdtMkNhanVien(tbx_username.Text, tbx_password.Text))
            {
                //Sdtnv = tbx_username.Text;
                ntf_nhanvien.ShowBalloonTip(5000);
                IndexForm idf = new IndexForm();
                this.Hide();// ẩn form login
                idf.ShowDialog();// show from index// được ưu tiên hiển thị
                this.Show();// hiện form login
                tbx_password.Text = "";
                tbx_username.Text = "";
            }

            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptb_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbx_username_Enter(object sender, EventArgs e)
        {

            tbx_username.Text = "";
        }

        private void tbx_password_Enter(object sender, EventArgs e)
        {
            tbx_password.Text = "";

        }
    }
}
