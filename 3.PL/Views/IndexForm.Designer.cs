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
            this.tsmn_banhang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_quanlylaptop = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_username = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmni_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtg_viewindex = new System.Windows.Forms.DataGridView();
            this.panel_formload = new System.Windows.Forms.Panel();
            this.ms_menuindex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_viewindex)).BeginInit();
            this.panel_formload.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menuindex
            // 
            this.ms_menuindex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_menuindex.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ms_menuindex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmn_banhang,
            this.tsmi_quanlylaptop,
            this.mni_admin,
            this.mni_username});
            this.ms_menuindex.Location = new System.Drawing.Point(0, 0);
            this.ms_menuindex.Name = "ms_menuindex";
            this.ms_menuindex.Size = new System.Drawing.Size(1147, 33);
            this.ms_menuindex.TabIndex = 0;
            this.ms_menuindex.Text = "Menu Index";
            // 
            // tsmn_banhang
            // 
            this.tsmn_banhang.Name = "tsmn_banhang";
            this.tsmn_banhang.Size = new System.Drawing.Size(104, 29);
            this.tsmn_banhang.Text = "Bán hàng";
            this.tsmn_banhang.Click += new System.EventHandler(this.tsmn_banhang_Click);
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
            // dtg_viewindex
            // 
            this.dtg_viewindex.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtg_viewindex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_viewindex.Location = new System.Drawing.Point(35, 30);
            this.dtg_viewindex.Name = "dtg_viewindex";
            this.dtg_viewindex.RowTemplate.Height = 25;
            this.dtg_viewindex.Size = new System.Drawing.Size(969, 451);
            this.dtg_viewindex.TabIndex = 1;
            // 
            // panel_formload
            // 
            this.panel_formload.Controls.Add(this.dtg_viewindex);
            this.panel_formload.Location = new System.Drawing.Point(128, 36);
            this.panel_formload.Name = "panel_formload";
            this.panel_formload.Size = new System.Drawing.Size(1007, 593);
            this.panel_formload.TabIndex = 3;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(1147, 641);
            this.Controls.Add(this.panel_formload);
            this.Controls.Add(this.ms_menuindex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.ms_menuindex;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IndexForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.ms_menuindex.ResumeLayout(false);
            this.ms_menuindex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_viewindex)).EndInit();
            this.panel_formload.ResumeLayout(false);
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
        private DataGridView dtg_viewindex;
        private ToolStripMenuItem tsmn_banhang;
        private Panel panel_formload;
    }
}