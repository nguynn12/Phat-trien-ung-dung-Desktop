using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace _2312704_Lab3
{
    public partial class frmReadJsonFile : Form
    {
        /// <summary>
        /// Phương thức đọc tập tin JSON
        /// </summary>
        /// <param name="Path">Đường dẫn tập tin</param>
        /// <return>Danh sách các đối tượng từ tập tin JSON</return>

        private List<StudentInfo> LoadJSON(string Path)
        {
            List<StudentInfo> List = new List<StudentInfo>();

            StreamReader r = new StreamReader(Path);

            string json = r.ReadToEnd();

            var array = (JObject)JsonConvert.DeserializeObject(json);

            var students = array["sinhvien"].Children();

            foreach (var item in students)
            {
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["hoten"].Value<string>();
                int tuoi = item["tuoi"].Value<int>();
                double diem = item["diem"].Value<double>();
                bool tongiao = item["tongiao"].Value<bool>();

                StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);
                List.Add(info);
            }

            return List;
        }

        public frmReadJsonFile()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string Str = "";
            string Path = "../../students.json";
            List<StudentInfo> List = LoadJSON(Path);

            for (int i = 0; i < List.Count; i++)
            {
                StudentInfo info = List[i];

                Str += string.Format("Sinh viên {0} có MSSV: {1}, họ tên: {2}," +
                    " điểm TB: {3}\r\n", (i + 1), info.MSSV, info.Hoten, info.Diem);
            }
            MessageBox.Show(Str);
        }

        private void btnDocFileXML_Click(object sender, EventArgs e)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("..\\..\\books.xml");

            var nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/book");

            foreach (XmlNode node in nodeList)
            {
                string Str = "";
                var isbn = node.Attributes["ISBN"].Value;
                var title = node.SelectSingleNode("title").InnerText;
                var price = node.SelectSingleNode("price").InnerText;
                var firstName = node.SelectSingleNode("author/first-name").InnerText;
                var lastName = node.SelectSingleNode("author/last-name").InnerText;
                Str = string.Format("{0, -15}{1, -50}{2, -15}{3, -15}{4, 6}", isbn, title, firstName, lastName, price);
                MessageBox.Show(Str);
            }
        }

        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            using (XmlWriter writer = XmlWriter.Create("books.xml"))
            {
                String pi = "type=\"text/xsl\" href=\"book.xsl\"";

                writer.WriteProcessingInstruction("xml-stylesheet", pi);
                writer.WriteDocType("catalog", null, null, "<!ENTITY h \"hardcover\">");
                writer.WriteComment("This is a book sample XML");
                writer.WriteStartElement("book");
                writer.WriteAttributeString("ISBN", "9831123212");
                writer.WriteAttributeString("yearpublished", "2002");
                writer.WriteElementString("author", "Mahesh Chand");
                writer.WriteElementString("title", "Visual C# Programming");
                writer.WriteElementString("price", "44.95");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }
    }
}
