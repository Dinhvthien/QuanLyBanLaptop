﻿using _1.DAL.Models;

namespace _2.BUS.ViewModels
{
    public class ChiTietLaptopView
    {
        public Guid ID { get; set; }
        public Guid IDMauSac { get; set; }
        public string MoTa { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal Giaban { get; set; }
        public Guid IDLaptop { get; set; }
        public Guid IDNsx { get; set; }
        public virtual MauSac MauSac { get; set; }
        public virtual Laptop Laptop { get; set; }
        public virtual Nsx Nsx { get; set; }
        public string MaLaptop { get; set; }
        public string MaMauSac { get; set; }
        public string MaNsx { get; set; }

    }
}