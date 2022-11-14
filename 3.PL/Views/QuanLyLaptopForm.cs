using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class QuanLyLaptopForm : Form
    {
        public QuanLyLaptopForm()
        {
            InitializeComponent();
       //     nud_soluong.Value = 5;
        }
        void LoadDataChiTietLaptop(List<ChiTietLaptopView> list)
        {
            dtg_showchitietlaptop.Rows.Clear();
            dtg_showchitietlaptop.ColumnCount = 18;
            dtg_showchitietlaptop.Columns[0].Name = "ID";
            dtg_showchitietlaptop.Columns[0].Visible = false;
            dtg_showchitietlaptop.Columns[1].Name = "STT";
            dtg_showchitietlaptop.Columns[2].Name = "Mã Laptop ";
            dtg_showchitietlaptop.Columns[3].Name = "ID Laptop";
            dtg_showchitietlaptop.Columns[3].Visible = false;
            dtg_showchitietlaptop.Columns[4].Name = "Mã nhà sản xuất";
            dtg_showchitietlaptop.Columns[5].Name = "ID nhà sản xuất";
            dtg_showchitietlaptop.Columns[5].Visible = false;
            dtg_showchitietlaptop.Columns[6].Name = "Màu sắc";
            dtg_showchitietlaptop.Columns[7].Name = "ID màu sắc";
            dtg_showchitietlaptop.Columns[7].Visible = false;
            dtg_showchitietlaptop.Columns[8].Name = "Mã CPU";
            dtg_showchitietlaptop.Columns[9].Name = "ID CPU";
            dtg_showchitietlaptop.Columns[9].Visible = false;
            dtg_showchitietlaptop.Columns[10].Name = "RAM";
            dtg_showchitietlaptop.Columns[11].Name = "ID RAM";
            dtg_showchitietlaptop.Columns[11].Visible = false;
            dtg_showchitietlaptop.Columns[12].Name = "SSD";
            dtg_showchitietlaptop.Columns[13].Name = "ID SSD";
            dtg_showchitietlaptop.Columns[13].Visible = false;
            dtg_showchitietlaptop.Columns[14].Name = "Mô tả";
            dtg_showchitietlaptop.Columns[15].Name = "Số lượng";
            dtg_showchitietlaptop.Columns[16].Name = "Giá nhập";
            dtg_showchitietlaptop.Columns[17].Name = "Giá bán";
            foreach (var s in list)
            {
                dtg_showchitietlaptop.Rows.Add();
            }
        }
        void LoadCombobox()
        {

        }
    }
}
