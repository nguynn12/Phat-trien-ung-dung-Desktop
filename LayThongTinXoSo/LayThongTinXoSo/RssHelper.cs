using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LayThongTinXoSo
{
    public static class RssHelper
    {
        // Đọc toàn bộ kết quả từ RSS
        public static async Task<List<KetQuaXoSo>> LoadFromRssAsync(string rssUrl)
        {
            List<KetQuaXoSo> results = new List<KetQuaXoSo>();

            using (HttpClient client = new HttpClient())
            {
                string xml = await client.GetStringAsync(rssUrl);
                XDocument doc = XDocument.Parse(xml);

                foreach (XElement item in doc.Descendants("item"))
                {
                    KetQuaXoSo kq = KetQuaXoSo.FromXElement(item);
                    if (kq != null)
                    {
                        results.Add(kq);
                    }
                }
            }

            return results;
        }
    }
}
