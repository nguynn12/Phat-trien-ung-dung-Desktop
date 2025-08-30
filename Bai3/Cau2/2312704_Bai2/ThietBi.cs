using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312704_Bai2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }

        public string TenThietBi { get; set; }

        public string NuocSanXuat { get; set; }

        public int DonGia { get; set; }

        public int SoLuong { get; set; }

        public ThietBi(string maTB, string tenTB, string nSX, int donGia, int soLuong) 
        {
            MaThietBi = maTB;
            TenThietBi = tenTB;
            NuocSanXuat = nSX;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public int ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public string HienThi()
        {
            return string.Format($"{MaThietBi}, {TenThietBi}, {NuocSanXuat}, {DonGia}, {SoLuong}" +
                $", {ThanhTien()}");
        }
    }
}
