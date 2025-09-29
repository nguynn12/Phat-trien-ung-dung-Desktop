using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312704_Lab3_PhanC
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTenLot { get; set; }

        public DateTime NgaySinh { get; set; }

        public string CMND { get; set; }

        public string DiaChi { get; set; }

        public bool GioiTinh { get; set; }

        public string Ten { get; set; }

        public string Lop { get; set; }

        public string SDT { get; set; }

        public List<string> MonHoc { get; set; }

        public SinhVien()
        {
            MonHoc = new List<string>();
        }

        public SinhVien(string mssv, string hotenlot, DateTime ngaysinh, 
            string cmnd, string diachi, bool gioitinh, string ten, 
            string lop, string sdt, List<string> monhoc)
        {
            MSSV = mssv;
            HoTenLot = hotenlot;
            NgaySinh = ngaysinh;
            CMND = cmnd;
            DiaChi = diachi;
            GioiTinh = gioitinh;
            Ten = ten;
            Lop = lop;
            SDT = sdt;
            MonHoc = monhoc;
        }
    }
}
