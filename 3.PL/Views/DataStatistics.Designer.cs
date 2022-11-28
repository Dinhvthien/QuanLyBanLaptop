namespace _3.PL.Views
{
    partial class DataStatistics
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
            this.dtg_hoadonchitiet = new System.Windows.Forms.DataGridView();
            this.tbx_tongdoanhthu = new System.Windows.Forms.TextBox();
            this.tbx_soluongdaban = new System.Windows.Forms.TextBox();
            this.btn_doanhthuhomnay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_doanhthuthang = new System.Windows.Forms.Button();
            this.cbb_12thang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_tongtienlai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadonchitiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_hoadonchitiet
            // 
            this.dtg_hoadonchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hoadonchitiet.Location = new System.Drawing.Point(276, 32);
            this.dtg_hoadonchitiet.Name = "dtg_hoadonchitiet";
            this.dtg_hoadonchitiet.RowTemplate.Height = 25;
            this.dtg_hoadonchitiet.Size = new System.Drawing.Size(469, 385);
            this.dtg_hoadonchitiet.TabIndex = 32;
            this.dtg_hoadonchitiet.UseWaitCursor = true;
            // 
            // tbx_tongdoanhthu
            // 
            this.tbx_tongdoanhthu.Location = new System.Drawing.Point(111, 56);
            this.tbx_tongdoanhthu.Name = "tbx_tongdoanhthu";
            this.tbx_tongdoanhthu.ReadOnly = true;
            this.tbx_tongdoanhthu.Size = new System.Drawing.Size(121, 23);
            this.tbx_tongdoanhthu.TabIndex = 33;
            // 
            // tbx_soluongdaban
            // 
            this.tbx_soluongdaban.Location = new System.Drawing.Point(120, 22);
            this.tbx_soluongdaban.Name = "tbx_soluongdaban";
            this.tbx_soluongdaban.ReadOnly = true;
            this.tbx_soluongdaban.Size = new System.Drawing.Size(35, 23);
            this.tbx_soluongdaban.TabIndex = 34;
            // 
            // btn_doanhthuhomnay
            // 
            this.btn_doanhthuhomnay.Location = new System.Drawing.Point(2, 124);
            this.btn_doanhthuhomnay.Name = "btn_doanhthuhomnay";
            this.btn_doanhthuhomnay.Size = new System.Drawing.Size(75, 23);
            this.btn_doanhthuhomnay.TabIndex = 35;
            this.btn_doanhthuhomnay.Text = "Hôm nay";
            this.btn_doanhthuhomnay.UseVisualStyleBackColor = true;
            this.btn_doanhthuhomnay.Click += new System.EventHandler(this.btn_doanhthuhomnay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_doanhthuthang
            // 
            this.btn_doanhthuthang.Location = new System.Drawing.Point(88, 158);
            this.btn_doanhthuthang.Name = "btn_doanhthuthang";
            this.btn_doanhthuthang.Size = new System.Drawing.Size(75, 23);
            this.btn_doanhthuthang.TabIndex = 37;
            this.btn_doanhthuthang.Text = "Theo tháng";
            this.btn_doanhthuthang.UseVisualStyleBackColor = true;
            this.btn_doanhthuthang.Click += new System.EventHandler(this.btn_doanhthuthang_Click);
            // 
            // cbb_12thang
            // 
            this.cbb_12thang.FormattingEnabled = true;
            this.cbb_12thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_12thang.Location = new System.Drawing.Point(6, 159);
            this.cbb_12thang.Name = "cbb_12thang";
            this.cbb_12thang.Size = new System.Drawing.Size(63, 23);
            this.cbb_12thang.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_tongtienlai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_doanhthuhomnay);
            this.groupBox1.Controls.Add(this.cbb_12thang);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_doanhthuthang);
            this.groupBox1.Controls.Add(this.tbx_tongdoanhthu);
            this.groupBox1.Controls.Add(this.tbx_soluongdaban);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 217);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tổng tiền thu được";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Laptop đã bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tiền lãi thực tế";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(832, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(29, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 170);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbx_tongtienlai
            // 
            this.tbx_tongtienlai.Location = new System.Drawing.Point(111, 85);
            this.tbx_tongtienlai.Name = "tbx_tongtienlai";
            this.tbx_tongtienlai.ReadOnly = true;
            this.tbx_tongtienlai.Size = new System.Drawing.Size(100, 23);
            this.tbx_tongtienlai.TabIndex = 0;
            // 
            // DataStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_hoadonchitiet);
            this.Name = "DataStatistics";
            this.Text = "DataStatistics";
            this.Load += new System.EventHandler(this.DataStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadonchitiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtg_hoadonchitiet;
        private TextBox tbx_tongdoanhthu;
        private TextBox tbx_soluongdaban;
        private Button btn_doanhthuhomnay;
        private Button button2;
        private Button btn_doanhthuthang;
        private ComboBox cbb_12thang;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private TextBox tbx_tongtienlai;
    }
}