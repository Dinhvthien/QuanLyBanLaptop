namespace _3.PL.Views
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.Ibtn_login = new FontAwesome.Sharp.IconButton();
            this.ntf_quanly = new System.Windows.Forms.NotifyIcon(this.components);
            this.ntf_nhanvien = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptb_thoat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_thoat)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Tw Cen MT Condensed", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbx_password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbx_password.Location = new System.Drawing.Point(75, 102);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(241, 35);
            this.tbx_password.TabIndex = 10;
            this.tbx_password.Text = "password";
            this.tbx_password.Enter += new System.EventHandler(this.tbx_password_Enter);
            // 
            // tbx_username
            // 
            this.tbx_username.Font = new System.Drawing.Font("Tw Cen MT Condensed", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbx_username.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbx_username.Location = new System.Drawing.Point(72, 48);
            this.tbx_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(244, 35);
            this.tbx_username.TabIndex = 10;
            this.tbx_username.Text = "username";
            this.tbx_username.Enter += new System.EventHandler(this.tbx_username_Enter);
            // 
            // Ibtn_login
            // 
            this.Ibtn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ibtn_login.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.Ibtn_login.IconColor = System.Drawing.Color.White;
            this.Ibtn_login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ibtn_login.IconSize = 35;
            this.Ibtn_login.Location = new System.Drawing.Point(152, 166);
            this.Ibtn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ibtn_login.Name = "Ibtn_login";
            this.Ibtn_login.Size = new System.Drawing.Size(46, 25);
            this.Ibtn_login.TabIndex = 12;
            this.Ibtn_login.UseVisualStyleBackColor = false;
            this.Ibtn_login.Click += new System.EventHandler(this.Ibtn_login_Click);
            // 
            // ntf_quanly
            // 
            this.ntf_quanly.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ntf_quanly.BalloonTipText = "Quản lý đã đăng nhập";
            this.ntf_quanly.BalloonTipTitle = "Thông báo";
            this.ntf_quanly.Icon = ((System.Drawing.Icon)(resources.GetObject("ntf_quanly.Icon")));
            this.ntf_quanly.Text = "notifyIcon1";
            this.ntf_quanly.Visible = true;
            // 
            // ntf_nhanvien
            // 
            this.ntf_nhanvien.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ntf_nhanvien.BalloonTipText = "Nhân viên đã đăng nhập";
            this.ntf_nhanvien.BalloonTipTitle = "Thông báo";
            this.ntf_nhanvien.Icon = ((System.Drawing.Icon)(resources.GetObject("ntf_nhanvien.Icon")));
            this.ntf_nhanvien.Text = "notifyIcon2";
            this.ntf_nhanvien.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ptb_thoat
            // 
            this.ptb_thoat.Image = ((System.Drawing.Image)(resources.GetObject("ptb_thoat.Image")));
            this.ptb_thoat.Location = new System.Drawing.Point(345, 1);
            this.ptb_thoat.Name = "ptb_thoat";
            this.ptb_thoat.Size = new System.Drawing.Size(43, 18);
            this.ptb_thoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_thoat.TabIndex = 14;
            this.ptb_thoat.TabStop = false;
            this.ptb_thoat.Click += new System.EventHandler(this.ptb_thoat_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 289);
            this.Controls.Add(this.ptb_thoat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ibtn_login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_thoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbx_password;
        private TextBox tbx_username;
        private FontAwesome.Sharp.IconButton Ibtn_login;
        private NotifyIcon ntf_quanly;
        private NotifyIcon ntf_nhanvien;
        private PictureBox pictureBox1;
        private PictureBox ptb_thoat;
    }
}