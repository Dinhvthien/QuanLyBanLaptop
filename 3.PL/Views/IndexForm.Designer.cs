namespace _3.PL.Views
{
    partial class IndexForm
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
            this.ms_menuindex = new System.Windows.Forms.MenuStrip();
            this.tsmi_quanlylaptop = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_username = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmni_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_formload = new System.Windows.Forms.Panel();
            this.IBtn_thongke = new FontAwesome.Sharp.IconButton();
            this.IBtn_loginAdminForm = new FontAwesome.Sharp.IconButton();
            this.IBtn_quanlylaptop = new FontAwesome.Sharp.IconButton();
            this.IBtn_banhang = new FontAwesome.Sharp.IconButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel_index = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ms_menuindex.SuspendLayout();
            this.panel_formload.SuspendLayout();
            this.panel_index.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menuindex
            // 
            this.ms_menuindex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_menuindex.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ms_menuindex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_quanlylaptop,
            this.mni_admin,
            this.mni_username});
            this.ms_menuindex.Location = new System.Drawing.Point(0, 0);
            this.ms_menuindex.Name = "ms_menuindex";
            this.ms_menuindex.Size = new System.Drawing.Size(1086, 33);
            this.ms_menuindex.TabIndex = 0;
            this.ms_menuindex.Text = "Menu Index";
            // 
            // tsmi_quanlylaptop
            // 
            this.tsmi_quanlylaptop.Name = "tsmi_quanlylaptop";
            this.tsmi_quanlylaptop.Size = new System.Drawing.Size(150, 29);
            this.tsmi_quanlylaptop.Text = "Quản lý laptop";
            this.tsmi_quanlylaptop.Click += new System.EventHandler(this.tsmi_quanlylaptop_Click);
            // 
            // mni_admin
            // 
            this.mni_admin.Name = "mni_admin";
            this.mni_admin.Size = new System.Drawing.Size(81, 29);
            this.mni_admin.Text = "Admin";
            this.mni_admin.Click += new System.EventHandler(this.mni_admin_Click);
            // 
            // mni_username
            // 
            this.mni_username.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmni_dangxuat,
            this.exitToolStripMenuItem});
            this.mni_username.Name = "mni_username";
            this.mni_username.Size = new System.Drawing.Size(105, 29);
            this.mni_username.Text = "Tài khoản";
            // 
            // tsmni_dangxuat
            // 
            this.tsmni_dangxuat.Name = "tsmni_dangxuat";
            this.tsmni_dangxuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmni_dangxuat.Size = new System.Drawing.Size(213, 30);
            this.tsmni_dangxuat.Text = "Logout";
            this.tsmni_dangxuat.Click += new System.EventHandler(this.tsmni_dangxuat_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // panel_formload
            // 
            this.panel_formload.Controls.Add(this.IBtn_thongke);
            this.panel_formload.Controls.Add(this.IBtn_loginAdminForm);
            this.panel_formload.Controls.Add(this.IBtn_quanlylaptop);
            this.panel_formload.Controls.Add(this.IBtn_banhang);
            this.panel_formload.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_formload.Location = new System.Drawing.Point(0, 33);
            this.panel_formload.Name = "panel_formload";
            this.panel_formload.Size = new System.Drawing.Size(184, 456);
            this.panel_formload.TabIndex = 3;
            // 
            // IBtn_thongke
            // 
            this.IBtn_thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.IBtn_thongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtn_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.IBtn_thongke.ForeColor = System.Drawing.Color.White;
            this.IBtn_thongke.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.IBtn_thongke.IconColor = System.Drawing.Color.White;
            this.IBtn_thongke.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtn_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtn_thongke.Location = new System.Drawing.Point(0, 182);
            this.IBtn_thongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IBtn_thongke.Name = "IBtn_thongke";
            this.IBtn_thongke.Size = new System.Drawing.Size(184, 56);
            this.IBtn_thongke.TabIndex = 8;
            this.IBtn_thongke.Text = "Thống kê ";
            this.IBtn_thongke.UseVisualStyleBackColor = false;
            this.IBtn_thongke.Click += new System.EventHandler(this.IBtn_thongke_Click);
            // 
            // IBtn_loginAdminForm
            // 
            this.IBtn_loginAdminForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.IBtn_loginAdminForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtn_loginAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.IBtn_loginAdminForm.ForeColor = System.Drawing.Color.White;
            this.IBtn_loginAdminForm.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.IBtn_loginAdminForm.IconColor = System.Drawing.Color.White;
            this.IBtn_loginAdminForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtn_loginAdminForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtn_loginAdminForm.Location = new System.Drawing.Point(0, 128);
            this.IBtn_loginAdminForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IBtn_loginAdminForm.Name = "IBtn_loginAdminForm";
            this.IBtn_loginAdminForm.Size = new System.Drawing.Size(184, 54);
            this.IBtn_loginAdminForm.TabIndex = 7;
            this.IBtn_loginAdminForm.Text = "Admin";
            this.IBtn_loginAdminForm.UseVisualStyleBackColor = false;
            this.IBtn_loginAdminForm.Click += new System.EventHandler(this.IBtn_loginAdminForm_Click);
            // 
            // IBtn_quanlylaptop
            // 
            this.IBtn_quanlylaptop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.IBtn_quanlylaptop.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtn_quanlylaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.IBtn_quanlylaptop.ForeColor = System.Drawing.Color.White;
            this.IBtn_quanlylaptop.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.IBtn_quanlylaptop.IconColor = System.Drawing.Color.White;
            this.IBtn_quanlylaptop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtn_quanlylaptop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtn_quanlylaptop.Location = new System.Drawing.Point(0, 64);
            this.IBtn_quanlylaptop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IBtn_quanlylaptop.Name = "IBtn_quanlylaptop";
            this.IBtn_quanlylaptop.Size = new System.Drawing.Size(184, 64);
            this.IBtn_quanlylaptop.TabIndex = 6;
            this.IBtn_quanlylaptop.Text = "Quản lý laptop";
            this.IBtn_quanlylaptop.UseVisualStyleBackColor = false;
            this.IBtn_quanlylaptop.Click += new System.EventHandler(this.IBtn_quanlylaptop_Click);
            // 
            // IBtn_banhang
            // 
            this.IBtn_banhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.IBtn_banhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtn_banhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.IBtn_banhang.ForeColor = System.Drawing.Color.White;
            this.IBtn_banhang.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.IBtn_banhang.IconColor = System.Drawing.Color.White;
            this.IBtn_banhang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtn_banhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtn_banhang.Location = new System.Drawing.Point(0, 0);
            this.IBtn_banhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IBtn_banhang.Name = "IBtn_banhang";
            this.IBtn_banhang.Size = new System.Drawing.Size(184, 64);
            this.IBtn_banhang.TabIndex = 5;
            this.IBtn_banhang.Text = "Bán hàng";
            this.IBtn_banhang.UseVisualStyleBackColor = false;
            this.IBtn_banhang.Click += new System.EventHandler(this.IBtn_banhang_Click);
            // 
            // panel_index
            // 
            this.panel_index.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.panel_index.Controls.Add(this.label2);
            this.panel_index.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_index.Location = new System.Drawing.Point(184, 33);
            this.panel_index.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_index.Name = "panel_index";
            this.panel_index.Size = new System.Drawing.Size(902, 456);
            this.panel_index.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông báo";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1086, 489);
            this.Controls.Add(this.panel_index);
            this.Controls.Add(this.panel_formload);
            this.Controls.Add(this.ms_menuindex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.ms_menuindex;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAPTOP";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.ms_menuindex.ResumeLayout(false);
            this.ms_menuindex.PerformLayout();
            this.panel_formload.ResumeLayout(false);
            this.panel_index.ResumeLayout(false);
            this.panel_index.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip ms_menuindex;
        private ToolStripMenuItem mni_username;
        private ToolStripMenuItem tsmni_dangxuat;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem mni_admin;
        private ToolStripMenuItem tsmi_quanlylaptop;
        private Panel panel_formload;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private FontAwesome.Sharp.IconButton IBtn_thongke;
        private FontAwesome.Sharp.IconButton IBtn_loginAdminForm;
        private FontAwesome.Sharp.IconButton IBtn_quanlylaptop;
        private FontAwesome.Sharp.IconButton IBtn_banhang;
        private Panel panel_index;
        private Label label2;
    }
}