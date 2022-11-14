using _2.BUS.IService;
using _2.BUS.Service;

namespace _3.PL.Views
{
    public partial class FormLogin : Form
    {
        INhanVienService nhanVienService;
        public FormLogin()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (nhanVienService.CheckSdtMkNhanVien(tbx_username.Text, tbx_password.Text))
            {
                IndexForm idf = new IndexForm();
                this.Hide();// ẩn form login
                idf.ShowDialog();// show from index// được ưu tiên hiển thị
                this.Show();// hiện form login
                tbx_password.Text = "";
                tbx_username.Text = "";
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
