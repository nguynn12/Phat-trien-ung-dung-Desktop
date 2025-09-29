using Newtonsoft.Json;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _2312704_Lab3_PhanC
{
    public delegate int SoSanh(object sv1, object sv2);

    public enum KieuSoSanh
    {
        TheoTen,
        TheoLop,
        TheoMSSV
    }

    public class QLSinhVien
    {
        public List<SinhVien> dsSinhVien = new List<SinhVien>();

        public QLSinhVien()
        {
            dsSinhVien = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return dsSinhVien[index]; }

            set { dsSinhVien[index] = value; }
        }

        public void Them(SinhVien sv)
        {
            dsSinhVien.Add(sv);
        }

        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svkq = null;

            foreach (SinhVien sv in dsSinhVien)
            
                if (ss(obj, sv) == 0)
                {
                    svkq = sv;

                    break;
                }
           
            return svkq;
        }

        public List<SinhVien> TimTatCa(object obj, SoSanh ss)
        {
            List<SinhVien> kq = new List<SinhVien>();

            foreach (SinhVien sv in dsSinhVien)

                if (ss(obj, sv) == 0)

                    kq.Add(sv);

            return kq;
        }

        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            bool kq = false;

            for (int i = 0; i < this.dsSinhVien.Count; i++)

                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }

            return kq;
        }

        public void Xoa(object obj, SoSanh ss)
        {
            int i = dsSinhVien.Count - 1;

            for (; i >= 0; i--)

                if (ss(obj, this[i]) == 0)

                    this.dsSinhVien.RemoveAt(i);
        }

        public void GhiFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(
                new FileStream(filename, FileMode.Create))) // Create: ghi đè
            {
                foreach (SinhVien sv in dsSinhVien)
                {
                    string gioiTinh = sv.GioiTinh ? "Nam" : "Nữ";
                    string monHoc = string.Join(",", sv.MonHoc);

                    string line = string.Join("\t", new string[]
                    {
                        sv.MSSV,
                        sv.HoTenLot,
                        sv.Ten,
                        sv.NgaySinh.ToString("MM/dd/yyyy"),
                        sv.CMND,
                        sv.DiaChi,
                        gioiTinh,
                        sv.Lop,
                        sv.SDT,
                        monHoc
                    });

                    sw.WriteLine(line);
                }
            }
        }

        public void DocTuFile(string filename)
        {
            string t;
            string[] s;
            SinhVien sv;
            using (StreamReader sr = new StreamReader(
                new FileStream(filename, FileMode.Open))) 
            {
                while ((t = sr.ReadLine())!= null)
                {
                    s = t.Split('\t');
                    sv = new SinhVien();
                    sv.MSSV = s[0];
                    sv.HoTenLot = s[1];
                    sv.Ten = s[2];
                    sv.NgaySinh = DateTime.Parse(s[3]);
                    sv.CMND = s[4];
                    sv.DiaChi = s[5];

                    sv.GioiTinh = true;
                    if (s[6] == "Nữ")
                        sv.GioiTinh = false;

                    sv.Lop = s[7];
                    sv.SDT = s[8];

                    string[] monhoc = s[9].Split(',');

                    foreach (string mh in monhoc)

                        sv.MonHoc.Add(mh);

                    Them(sv);
                }
            }
        }

        public string TaoMSSV(string lop, string cccNhap)
        {
            // Lấy số khóa từ tên lớp, ví dụ CTK47A -> 47
            string khoaStr = new string(lop.Where(char.IsDigit).ToArray());
            int khoa = int.Parse(khoaStr);

            // Năm nhập học: CTK47 => 2023, CTK48 => 2024, CTK49 => 2025 ...
            int namNhapHoc = 1976 + khoa;
            string AA = (namNhapHoc % 100).ToString("D2"); // lấy 2 số cuối

            string BB = "10";

            // Chuẩn hóa CCC: nếu người dùng nhập thiếu số thì tự thêm cho đủ 3 số
            string CCC = cccNhap.PadLeft(3, '0');

            // Kiểm tra trùng MSSV
            string mssv = AA + BB + CCC;
            if (dsSinhVien.Any(sv => sv.MSSV == mssv))
            {
                throw new Exception("MSSV này đã tồn tại, vui lòng nhập số khác!");
            }

            return mssv;
        }

        public static void GhiFileJSON(string path, List<SinhVien> dssv)
        {
            string json = JsonConvert.SerializeObject(dssv, Formatting.Indented);

            File.WriteAllText(path, json);  
        }

        public static List<SinhVien> DocFileJSON(string path)
        {
            if (!File.Exists(path)) 
                return new List<SinhVien>();

            string json = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<List<SinhVien>>(json);
        }

        public static void GhiFileXML(string path, List<SinhVien> dssv)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<SinhVien>));

            using (var fs = new FileStream(path, FileMode.Create))
            {
                xs.Serialize(fs, dssv);
            }
        }

        public static List<SinhVien> DocFileXML(string path)
        {
            if (!File.Exists(path))
                return new List<SinhVien>();

            XmlSerializer xs = new XmlSerializer(typeof(List<SinhVien>));

            using (var fs = new FileStream(path, FileMode.Open))
            {
                return (List<SinhVien>)xs.Deserialize(fs);
            }
        }
    }
}
