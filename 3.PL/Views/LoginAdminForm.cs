using _2.BUS.IService;
using _2.BUS.Service;

namespace _3.PL.Views
{
    public partial class LoginAdminForm : Form
    {
        INhanVienService nhanVienService;
        public LoginAdminForm()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
        }

        private void btn_loginadmin_Click(object sender, EventArgs e)
        {
            if (nhanVienService.CheckQuanLy(tbx_usernameadm.Text, tbx_passwordadm.Text, "QLX0102S"))
            {
                this.Hide();
                AdminForm adf = new AdminForm();
                adf.ShowDialog();
                this.Show();
                tbx_passwordadm.Text = "";
                tbx_usernameadm.Text = "";
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoatadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoginAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dlr = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dlr != DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
