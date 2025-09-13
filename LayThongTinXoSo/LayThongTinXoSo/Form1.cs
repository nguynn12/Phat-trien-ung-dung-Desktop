using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace LayThongTinXoSo
{
    public partial class Form1 : Form
    {
        private string linkRss;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            tvXoSo.ExpandAll();

            // Mặc định là ngày hôm nay
            dtpNgay.Value = DateTime.Today;

            linkRss = "https://xosodaiphat.com/ket-qua-xo-so-mien-bac-xsmb.rss";
            await LoadKetQuaAsync(linkRss, dtpNgay.Value);
        }

        private async Task LoadKetQuaAsync(string rssUrl, DateTime ngayChon)
        {
            var all = await RssHelper.LoadFromRssAsync(rssUrl);
            if (all.Count == 0) return;

            #region Skip this
            //if (latest != null)
            //{
            //    lblTieuDe.Text = latest.TieuDe;
            //    //lblNgay.Text = latest.NgayXoSo.ToString("dd/MM/yyyy");
            //    lblKetQua.Text = latest.KetQua;

            //    if (latest.DaiXoSo != null && latest.DaiXoSo.Count > 0)
            //    {
            //        int maxLen = latest.DaiXoSo.Max(d => d.Length);

            //        string str = "";
            //        foreach (var dai in latest.DaiXoSo)
            //        {
            //            str += dai.PadRight(maxLen + 4);
            //        }
            //        lblDaiXoSo.Text = str;
            //    }
            //    else
            //    {
            //        lblDaiXoSo.Text = ""; // hoặc để trống "" cũng được
            //    }

            //    //string text = "";
            //    //foreach (var kvp in latest.GiaiThuong)
            //    //{
            //    //    // kvp.Key = tên giải (VD: "DB", "G.1", "G.7")
            //    //    // kvp.Value = danh sách số trúng (List<string>)
            //    //    text += kvp.Key + ": " + string.Join(" - ", kvp.Value) + Environment.NewLine;
            //    //}

            //    //lblGiaiThuong.Text = text;
            //}
            #endregion

            // Lấy tất cả ngày có trong file RSS, giảm dần
            var allDates = all.Select(kq => kq.NgayXoSo.Date)
                              .Distinct()
                              .OrderByDescending(d => d)
                              .ToList();

            // Xác định giờ xổ số theo miền
            TimeSpan gioQuaySo = TimeSpan.Zero;
            if (rssUrl.Contains("mien-bac")) gioQuaySo = new TimeSpan(18, 30, 0);
            if (rssUrl.Contains("mien-trung")) gioQuaySo = new TimeSpan(15, 30, 0);
            if (rssUrl.Contains("mien-nam")) gioQuaySo = new TimeSpan(16, 30, 0);

            DateTime today = DateTime.Today;
            TimeSpan nowTime = DateTime.Now.TimeOfDay;

            // Xác định ngày hợp lệ đầu tiên
            DateTime ngayHopLe;

            if (allDates.Contains(today))
            {
                if (nowTime < gioQuaySo)
                {
                    ngayHopLe = allDates.FirstOrDefault(d => d < today);
                    if (ngayHopLe == default) ngayHopLe = today;
                }

                else
                {
                    ngayHopLe = today;
                }
            }

            else if (allDates.Contains(ngayChon.Date))
            {
                ngayHopLe = ngayChon.Date;
            }

            else
            {
                // Lấy ngày cùng thứ trong file RSS
                ngayHopLe = allDates.FirstOrDefault(d => d.DayOfWeek == ngayChon.DayOfWeek);
                if (ngayHopLe == default) ngayHopLe = allDates.First();
            }

            // Chọn tuần 7 ngày giảm dần từ ngày hợp lệ
            var weekDates = allDates.Where(d => d <= ngayHopLe)
                                    .Take(7)
                                    .ToList();

            // Lấy kết quả tương ứng cho ngày đầu tiên
            var match = all.FirstOrDefault(kq => kq.NgayXoSo.Date == weekDates.First());

            if (match == null) return;

            lblTieuDe.Text = match.TieuDe;

            // Nếu có nhiều đài (miền Trung / Nam)
            if (match.CacDai != null && match.CacDai.Count > 0)
            {
                int maxLen = match.CacDai.Max(d => d.TenDai.Length);

                string header = string.Join("", match.CacDai
                    .Select(d => d.TenDai.PadRight(maxLen + 8)));

                List<string> lines = new List<string> { header };

                var allGiai = match.CacDai
                    .SelectMany(d => d.GiaiThuong.Keys)
                    .Distinct()
                    .OrderBy(k => k)
                    .ToList();

                foreach (var giai in allGiai)
                {
                    int maxSoDong = match.CacDai.Max(d =>
                        d.GiaiThuong.ContainsKey(giai) ? d.GiaiThuong[giai].Count : 0);

                    for (int row = 0; row < maxSoDong; row++)
                    {
                        string line = "";
                        foreach (var dai in match.CacDai)
                        {
                            if (dai.GiaiThuong.ContainsKey(giai))
                            {
                                var nums = dai.GiaiThuong[giai];

                                if (row < nums.Count)
                                {
                                    if (row == 0)
                                        line += (giai + ": " + nums[row]).PadRight(maxLen + 8);
                                    else
                                        line += (new string(' ', giai.Length + 2) + nums[row]).PadRight(maxLen + 8);
                                }

                                else
                                {
                                    line += "".PadRight(maxLen + 8);
                                }
                            }

                            else
                            {
                                line += "".PadRight(maxLen + 8);
                            }
                        }
                        lines.Add(line);
                    }
                }

                lblGiaiThuong.Text = string.Join(Environment.NewLine, lines);
            }
            // Nếu chỉ có 1 đài (miền Bắc)
            else if (match.CacDai != null && match.CacDai.Count == 1)
            {
                var dai = match.CacDai[0];
                string text = "";

                foreach (var kvp in dai.GiaiThuong)
                {
                    text += kvp.Key + ": " + string.Join(" - ", kvp.Value) + Environment.NewLine;
                }

                lblGiaiThuong.Text = text;
            }
            else
            {
                lblGiaiThuong.Text = "Không có dữ liệu.";
            }
        }

        private async void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null && e.Node.Parent.Text == "Xổ số")
            {
                string index = e.Node.Text;
                DateTime selectedDate = dtpNgay.Value.Date;

                switch (index)
                {
                    case "Miền Bắc":
                        linkRss = "https://xosodaiphat.com/ket-qua-xo-so-mien-bac-xsmb.rss";
                        break;
                    case "Miền Trung":
                        linkRss = "https://xosodaiphat.com/ket-qua-xo-so-mien-trung-xsmt.rss";
                        break;
                    case "Miền Nam":
                        linkRss = "https://xosodaiphat.com/ket-qua-xo-so-mien-nam-xsmn.rss";
                        break;
                }

                await LoadKetQuaAsync(linkRss, selectedDate);
            }
        }
        private async void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpNgay.Value.Date;

            // Chỉ load nếu đã chọn miền
            if (!string.IsNullOrEmpty(linkRss))
            {
                await LoadKetQuaAsync(linkRss, selectedDate);
            }
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

    }
}
