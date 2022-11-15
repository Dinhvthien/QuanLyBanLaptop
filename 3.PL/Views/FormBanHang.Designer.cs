namespace _3.PL.Views
{
    partial class FormBanHang
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabp_khachhang = new System.Windows.Forms.TabPage();
            this.dtg_showkhachhang = new System.Windows.Forms.DataGridView();
            this.tbx_diachikhachhang = new System.Windows.Forms.TextBox();
            this.tbx_sdtkhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_suakhachhang = new System.Windows.Forms.Button();
            this.btn_xoakhachhang = new System.Windows.Forms.Button();
            this.tbx_makhachhang = new System.Windows.Forms.TextBox();
            this.tbx_tenkhachhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_themkhachhang = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabp_khachhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabp_khachhang);
            this.tabControl1.Location = new System.Drawing.Point(7, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1089, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1081, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa Đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1081, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hóa Đơn Chi Tiết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabp_khachhang
            // 
            this.tabp_khachhang.Controls.Add(this.dtg_showkhachhang);
            this.tabp_khachhang.Controls.Add(this.tbx_diachikhachhang);
            this.tabp_khachhang.Controls.Add(this.tbx_sdtkhachhang);
            this.tabp_khachhang.Controls.Add(this.label2);
            this.tabp_khachhang.Controls.Add(this.label3);
            this.tabp_khachhang.Controls.Add(this.btn_suakhachhang);
            this.tabp_khachhang.Controls.Add(this.btn_xoakhachhang);
            this.tabp_khachhang.Controls.Add(this.tbx_makhachhang);
            this.tabp_khachhang.Controls.Add(this.tbx_tenkhachhang);
            this.tabp_khachhang.Controls.Add(this.label1);
            this.tabp_khachhang.Controls.Add(this.label4);
            this.tabp_khachhang.Controls.Add(this.btn_themkhachhang);
            this.tabp_khachhang.Location = new System.Drawing.Point(4, 27);
            this.tabp_khachhang.Name = "tabp_khachhang";
            this.tabp_khachhang.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_khachhang.Size = new System.Drawing.Size(1081, 517);
            this.tabp_khachhang.TabIndex = 2;
            this.tabp_khachhang.Text = "Khách Hàng";
            this.tabp_khachhang.UseVisualStyleBackColor = true;
            // 
            // dtg_showkhachhang
            // 
            this.dtg_showkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showkhachhang.Location = new System.Drawing.Point(357, 55);
            this.dtg_showkhachhang.Name = "dtg_showkhachhang";
            this.dtg_showkhachhang.RowTemplate.Height = 25;
            this.dtg_showkhachhang.Size = new System.Drawing.Size(446, 264);
            this.dtg_showkhachhang.TabIndex = 18;
            this.dtg_showkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showkhachhang_CellClick);
            // 
            // tbx_diachikhachhang
            // 
            this.tbx_diachikhachhang.Location = new System.Drawing.Point(80, 127);
            this.tbx_diachikhachhang.Name = "tbx_diachikhachhang";
            this.tbx_diachikhachhang.Size = new System.Drawing.Size(100, 23);
            this.tbx_diachikhachhang.TabIndex = 17;
            // 
            // tbx_sdtkhachhang
            // 
            this.tbx_sdtkhachhang.Location = new System.Drawing.Point(80, 169);
            this.tbx_sdtkhachhang.Name = "tbx_sdtkhachhang";
            this.tbx_sdtkhachhang.Size = new System.Drawing.Size(100, 23);
            this.tbx_sdtkhachhang.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Địa Chỉ";
            // 
            // btn_suakhachhang
            // 
            this.btn_suakhachhang.ForeColor = System.Drawing.Color.Red;
            this.btn_suakhachhang.Location = new System.Drawing.Point(79, 274);
            this.btn_suakhachhang.Name = "btn_suakhachhang";
            this.btn_suakhachhang.Size = new System.Drawing.Size(75, 30);
            this.btn_suakhachhang.TabIndex = 13;
            this.btn_suakhachhang.Text = "Sửa";
            this.btn_suakhachhang.UseVisualStyleBackColor = true;
            this.btn_suakhachhang.Click += new System.EventHandler(this.btn_suakhachhang_Click);
            // 
            // btn_xoakhachhang
            // 
            this.btn_xoakhachhang.ForeColor = System.Drawing.Color.Red;
            this.btn_xoakhachhang.Location = new System.Drawing.Point(81, 334);
            this.btn_xoakhachhang.Name = "btn_xoakhachhang";
            this.btn_xoakhachhang.Size = new System.Drawing.Size(75, 28);
            this.btn_xoakhachhang.TabIndex = 12;
            this.btn_xoakhachhang.Text = "Xóa";
            this.btn_xoakhachhang.UseVisualStyleBackColor = true;
            this.btn_xoakhachhang.Click += new System.EventHandler(this.btn_xoakhachhang_Click);
            // 
            // tbx_makhachhang
            // 
            this.tbx_makhachhang.Location = new System.Drawing.Point(79, 42);
            this.tbx_makhachhang.Name = "tbx_makhachhang";
            this.tbx_makhachhang.Size = new System.Drawing.Size(100, 23);
            this.tbx_makhachhang.TabIndex = 11;
            // 
            // tbx_tenkhachhang
            // 
            this.tbx_tenkhachhang.Location = new System.Drawing.Point(79, 84);
            this.tbx_tenkhachhang.Name = "tbx_tenkhachhang";
            this.tbx_tenkhachhang.Size = new System.Drawing.Size(100, 23);
            this.tbx_tenkhachhang.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã";
            // 
            // btn_themkhachhang
            // 
            this.btn_themkhachhang.ForeColor = System.Drawing.Color.Red;
            this.btn_themkhachhang.Location = new System.Drawing.Point(79, 228);
            this.btn_themkhachhang.Name = "btn_themkhachhang";
            this.btn_themkhachhang.Size = new System.Drawing.Size(75, 28);
            this.btn_themkhachhang.TabIndex = 7;
            this.btn_themkhachhang.Text = "Thêm";
            this.btn_themkhachhang.UseVisualStyleBackColor = true;
            this.btn_themkhachhang.Click += new System.EventHandler(this.btn_themkhachhang_Click);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1108, 569);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabp_khachhang.ResumeLayout(false);
            this.tabp_khachhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showkhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabp_khachhang;
        private Button btn_suakhachhang;
        private Button btn_xoakhachhang;
        private TextBox tbx_makhachhang;
        private TextBox tbx_tenkhachhang;
        private Label label1;
        private Label label4;
        private Button btn_themkhachhang;
        private TextBox tbx_diachikhachhang;
        private TextBox tbx_sdtkhachhang;
        private Label label2;
        private Label label3;
        private DataGridView dtg_showkhachhang;
    }
}