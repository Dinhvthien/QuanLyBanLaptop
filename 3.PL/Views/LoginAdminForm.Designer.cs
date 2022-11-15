namespace _3.PL.Views
{
    partial class LoginAdminForm
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
            this.btn_thoatadmin = new System.Windows.Forms.Button();
            this.tbx_usernameadm = new System.Windows.Forms.TextBox();
            this.tbx_passwordadm = new System.Windows.Forms.TextBox();
            this.btn_loginadmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_thoatadmin
            // 
            this.btn_thoatadmin.Location = new System.Drawing.Point(170, 132);
            this.btn_thoatadmin.Name = "btn_thoatadmin";
            this.btn_thoatadmin.Size = new System.Drawing.Size(75, 23);
            this.btn_thoatadmin.TabIndex = 11;
            this.btn_thoatadmin.Text = "Thoát";
            this.btn_thoatadmin.UseVisualStyleBackColor = true;
            this.btn_thoatadmin.Click += new System.EventHandler(this.btn_thoatadmin_Click);
            // 
            // tbx_usernameadm
            // 
            this.tbx_usernameadm.Location = new System.Drawing.Point(113, 27);
            this.tbx_usernameadm.Name = "tbx_usernameadm";
            this.tbx_usernameadm.Size = new System.Drawing.Size(143, 23);
            this.tbx_usernameadm.TabIndex = 10;
            // 
            // tbx_passwordadm
            // 
            this.tbx_passwordadm.Location = new System.Drawing.Point(113, 78);
            this.tbx_passwordadm.Name = "tbx_passwordadm";
            this.tbx_passwordadm.PasswordChar = '*';
            this.tbx_passwordadm.Size = new System.Drawing.Size(143, 23);
            this.tbx_passwordadm.TabIndex = 9;
            // 
            // btn_loginadmin
            // 
            this.btn_loginadmin.Location = new System.Drawing.Point(45, 132);
            this.btn_loginadmin.Name = "btn_loginadmin";
            this.btn_loginadmin.Size = new System.Drawing.Size(75, 23);
            this.btn_loginadmin.TabIndex = 8;
            this.btn_loginadmin.Text = "Đăng nhập";
            this.btn_loginadmin.UseVisualStyleBackColor = true;
            this.btn_loginadmin.Click += new System.EventHandler(this.btn_loginadmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // LoginAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(329, 195);
            this.Controls.Add(this.btn_thoatadmin);
            this.Controls.Add(this.tbx_usernameadm);
            this.Controls.Add(this.tbx_passwordadm);
            this.Controls.Add(this.btn_loginadmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAdminForm";
            this.Text = "LoginAdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginAdminForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_thoatadmin;
        private TextBox tbx_usernameadm;
        private TextBox tbx_passwordadm;
        private Button btn_loginadmin;
        private Label label2;
        private Label label1;
    }
}