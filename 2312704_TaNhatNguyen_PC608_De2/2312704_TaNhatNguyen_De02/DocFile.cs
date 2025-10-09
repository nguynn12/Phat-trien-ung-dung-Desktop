using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace _2312704_TaNhatNguyen_De02
{
    public class DocFile
    {
        // Đề câu 8 ghi xuất file *.xml nhưng trên giao diện
        // hiển thị xuất json nên em làm theo đề.

        public static List<NhaCungCap> DocJson(string path)
        {
            string json = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<List<NhaCungCap>>(json);
        }

        public static void GhiJson(string path, List<NhaCungCap> ds)
        {
            string json = JsonConvert.SerializeObject(ds, Formatting.Indented);

            File.WriteAllText(path, json);
        }

        // Ghi file xml
        // using System.Xml.Serialization;
        public static void GhiXml(string path, List<NhaCungCap> ds)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<NhaCungCap>));

            using (var fs = new FileStream(path, FileMode.Create))
            {
                xs.Serialize(fs, ds);
            }
        }
    }
}
