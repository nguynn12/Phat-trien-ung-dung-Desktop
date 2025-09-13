using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayThongTinXoSo
{
    public class KetQuaXoSo
    {
        // Tiêu đề: KẾT QUẢ XỔ SỐ MIỀN BẮC, MIỀN NAM, ...
        public string TieuDe { get; set; }

        // Ngày xổ số
        public DateTime NgayXoSo { get; set; }

        //// Giải thưởng: G. ĐB: 12345, G. 1: XXXXX - XXXXX, ...
        //// string là tên giải: DB, G1, G2, ...
        //// List<string> là danh sách các số của giải đó
        //public Dictionary<string, List<string>> GiaiThuong { get; set; }

        //// Đài (Miền Nam và Trung): Đài Thành phố, Đài Lâm Đồng, Đài Sóc Trăng, ...
        //public List<string> DaiXoSo { get; set; }

        public List<DaiKetQua> CacDai { get; set; }

        // Kết quả: Test
        public string KetQua { get; set; }

        // Link RSS
        public string Link { get; set; }

        // Phương thức tạo lập
        public KetQuaXoSo()
        {
            CacDai = new List<DaiKetQua>();
        } 

        // Phương thức tách giải thưởng từ thẻ <description> (mô tả)
        public static Dictionary<string, List<string>> TachGiaiThuong(string mota)
        {
            var dsKetqua = new Dictionary<string, List<string>>();

            if (string.IsNullOrEmpty(mota))

                return dsKetqua;

            // Tách thành các "cụm giải" bằng cách chèn thêm ký tự
            // "|" để phân chia theo "G." hoặc "DB:" hoặc "DB6:". 
            // Trong đó "G.": các giải thường, "DB:": giải đặc biệt của Miền Bắc
            // "DB6:" giải đặc biệt của Miền Nam và Miền Trung
            string[] parts = mota
                .Replace("DB6:", "|DB6:")
                .Replace("DB:", "|DB:")
                .Replace("G.", "|G.")
                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            // Duyệt từng cụm giải
            // Nếu không thấy thì bỏ qua
            foreach (string part in parts)
            {
                string trimmed = part.Trim();
                if (string.IsNullOrEmpty(trimmed))

                    continue;

                // Tìm dấu hai chấm để tách tên giải và kết quả.
                // Nếu không thấy thì bỏ qua
                int dauHaiCham = trimmed.IndexOf(':');
                if (dauHaiCham < 0)

                    continue;

                // giai: phần trước dấu hai chấm, ví dụ "DB", "G.7"
                // values: phần sau dấu hai chấm, ví dụ "34 - 23 - 12"
                string giai = trimmed.Substring(0, dauHaiCham).Trim();
                string values = trimmed.Substring(dauHaiCham + 1).Trim();

                // Tách nhiều số bằng dấu "-"
                // Ví dụ: "34 - 23 - 12" -> ["34", "23", "12"]
                string[] nums = values.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                // Tách số ra khỏi khoảng trắng dư thừa rồi thêm vào
                // danh sách số đã tách 
                List<string> soDaTach = new List<string>();

                foreach (string so in nums)
                {
                    string tach = so.Trim();
                    if (!string.IsNullOrEmpty(tach))
                        soDaTach.Add(tach);
                }

                // Cuối cùng, lưu vào Dictionary
                dsKetqua[giai] = soDaTach;
            }

            return dsKetqua;
        }

        // Tách ra nhiều đài (chỉ Miền Nam/Trung có)
        public static List<DaiKetQua> ParseCacDai(string mota)
        {
            var result = new List<DaiKetQua>();
            if (string.IsNullOrEmpty(mota)) return result;

            // Nếu không có dấu [ ] (tức là Miền Bắc)
            if (!mota.Contains("["))
            {
                var dai = new DaiKetQua
                {
                    TenDai = "Miền Bắc",
                    GiaiThuong = TachGiaiThuong(mota)
                };
                result.Add(dai);
                return result;
            }

            // Nếu có nhiều đài (Miền Nam, Trung)
            var parts = mota.Split(new[] { '[' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                int dongNgoac = part.IndexOf(']');
                if (dongNgoac < 0) continue;

                string tenDai = part.Substring(0, dongNgoac).Trim();
                string noiDung = part.Substring(dongNgoac + 1).Trim();

                var dai = new DaiKetQua
                {
                    TenDai = tenDai,
                    GiaiThuong = TachGiaiThuong(noiDung)
                };

                result.Add(dai);
            }

            return result;
        }

        // Phương thức lấy <item> trong RSS XML,
        // lấy các dữ liệu cần thiết, trả về object KetQuaXoSo
        public static KetQuaXoSo FromXElement(XElement item)
        {
            //Nếu ko có, trả về null
            if (item == null) return null;

            // Lấy nội dung thẻ <pubDate> từ RSS
            // Ở đây là lấy ngày xổ 
            DateTime parsedDate = DateTime.MinValue;
            string pubDateRaw = (string)item.Element("pubDate");
            if (!string.IsNullOrWhiteSpace(pubDateRaw))
            {
                DateTime.TryParseExact(pubDateRaw.Trim(),
                                       "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture,
                                       System.Globalization.DateTimeStyles.None,
                                       out parsedDate);
            }

            // Lấy nội dung thẻ <description> từ RSS (chứa các giải ĐB, G1, G2, ...)
            // Ở đây là lấy phần mô tả và tách các giải
            string desc = (string)item.Element("description");

            // Tạo đối tượng kết quả
            var kq = new KetQuaXoSo
            {
                TieuDe = (string)item.Element("title"),
                NgayXoSo = parsedDate,
                KetQua = desc,
                Link = (string)item.Element("link"),
                CacDai = ParseCacDai(desc)
            };

            return kq;
        }
    }
}
