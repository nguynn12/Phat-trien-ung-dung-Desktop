using BusinessLogic;
using DataAccess;
//using iText.IO.Font;
//using iText.Kernel.Font;
//using iText.Kernel.Geom;
//using iText.Kernel.Pdf;
//using iText.Layout;
//using iText.Layout.Element;
//using iText.Layout.Properties;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantManagementProject
{
    public partial class frmPayment : Form
    {
        private readonly BillsBL billsBL = new BillsBL();
        private readonly BillDetailsBL billDetailsBL = new BillDetailsBL();
        private readonly FoodBL foodBL = new FoodBL();
        private readonly RestaurantTableBL tableBL = new RestaurantTableBL();

        private int currentBillID = 0;
        private float totalAmount = 0;

        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            LoadUnpaidBills();
        }

        #region === TẢI DỮ LIỆU ===
        private void LoadUnpaidBills()
        {
            var unpaidBills = billsBL.GetAll().Where(b => !b.Status).ToList();
            lsvBills.Items.Clear();

            foreach (var bill in unpaidBills)
            {
                var table = tableBL.GetAll().FirstOrDefault(t => t.ID == bill.TableID);
                ListViewItem lvi = new ListViewItem(bill.Name);
                lvi.SubItems.Add(table?.Name ?? "N/A");
                lvi.SubItems.Add(bill.CheckoutDate?.ToString("dd/MM/yyyy HH:mm") ?? "Chưa thanh toán");
                lvi.SubItems.Add(bill.Amount.ToString("N0"));
                lvi.Tag = bill;
                lsvBills.Items.Add(lvi);
            }
        }

        private void LoadBillDetails(int billID)
        {
            currentBillID = billID;
            var details = billDetailsBL.GetAll().Where(d => d.InvoiceID == billID).ToList();

            lsvDetails.Items.Clear();
            totalAmount = 0;

            foreach (var d in details)
            {
                var food = foodBL.GetAll().FirstOrDefault(f => f.ID == d.FoodID);
                if (food == null) continue;

                ListViewItem lvi = new ListViewItem(food.Name);
                lvi.SubItems.Add(d.Quantity.ToString());
                lvi.SubItems.Add(food.Price.ToString("N0"));
                float amount = d.Quantity * food.Price;
                lvi.SubItems.Add(amount.ToString("N0"));
                lvi.Tag = d;
                lsvDetails.Items.Add(lvi);

                totalAmount += amount;
            }

            txtSubtotal.Text = totalAmount.ToString("N0");
            txtDiscount.Text = "0";
            txtTax.Text = "10";
            CalculateTotal();
        }
        #endregion

        #region === TÍNH TOÁN ===
        private void CalculateTotal()
        {
            if (!float.TryParse(txtSubtotal.Text.Replace(",", ""), out float subtotal)) return;
            if (!float.TryParse(txtDiscount.Text, out float discount)) discount = 0;
            if (!float.TryParse(txtTax.Text, out float taxPercent)) taxPercent = 0;

            float tax = subtotal * (taxPercent / 100f);
            float final = subtotal - discount + tax;

            txtTaxAmount.Text = tax.ToString("N0");
            txtFinalAmount.Text = final.ToString("N0");
        }
        #endregion

        #region === SỰ KIỆN ===
        private void lsvBills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBills.SelectedItems.Count == 0) return;
            var bill = (Bills)lsvBills.SelectedItems[0].Tag;
            LoadBillDetails(bill.ID);
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e) => CalculateTotal();
        private void txtTax_TextChanged(object sender, EventArgs e) => CalculateTotal();

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (currentBillID == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtDiscount.Text, out float discount) || discount < 0)
            {
                MessageBox.Show("Chiết khấu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txtTax.Text, out float taxPercent) || taxPercent < 0)
            {
                MessageBox.Show("Thuế không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật hóa đơn
            var bill = billsBL.GetAll().First(b => b.ID == currentBillID);
            bill.Discount = discount;
            bill.Tax = taxPercent / 100f;
            bill.Status = true;
            bill.CheckoutDate = DateTime.Now;
            bill.Amount = int.Parse(txtFinalAmount.Text.Replace(",", ""));

            billsBL.Update(bill);

            // Cập nhật bàn
            var table = new RestaurantTable { ID = bill.TableID, Status = 0 };
            tableBL.Update(table);

            MessageBox.Show("Thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // In hóa đơn PDF
            //PrintBill(bill.ID);

            LoadUnpaidBills();
            ClearPayment();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void ClearPayment()
        {
            currentBillID = 0;
            lsvDetails.Items.Clear();
            txtSubtotal.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtTaxAmount.Clear();
            txtFinalAmount.Clear();
        }

        //#region === IN HÓA ĐƠN PDF – iText 7 + float ===
        //private void PrintBill(int billID)
        //{
        //    try
        //    {
        //        var bill = billsBL.GetAll().First(b => b.ID == billID);
        //        var details = billDetailsBL.GetAll().Where(d => d.InvoiceID == billID).ToList();
        //        var table = tableBL.GetAll().First(t => t.ID == bill.TableID);

        //        string fileName = $"HoaDon_{bill.Name}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
        //        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

        //        using (var writer = new PdfWriter(path))
        //        using (var pdf = new PdfDocument(writer))
        //        using (var document = new Document(pdf, PageSize.A5))  // ĐÃ SỬA
        //        {
        //            document.SetMargins(15, 15, 15, 15);

        //            // Font Unicode
        //            string fontPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
        //            PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H, true);

        //            // Tiêu đề
        //            document.Add(new Paragraph("NHÀ HÀNG XYZ")
        //                .SetFont(font).SetFontSize(16).SetBold().SetTextAlignment(TextAlignment.CENTER));
        //            document.Add(new Paragraph($"Hóa đơn: {bill.Name}")
        //                .SetFont(font).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER));
        //            document.Add(new Paragraph($"Bàn: {table.Name}")
        //                .SetFont(font).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER));
        //            document.Add(new Paragraph($"Thời gian: {bill.CheckoutDate:dd/MM/yyyy HH:mm}")
        //                .SetFont(font).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER));
        //            document.Add(new Paragraph("------------------------------------------------")
        //                .SetFont(font).SetFontSize(10));

        //            // Bảng món
        //            Table pdfTable = new Table(UnitValue.CreatePercentArray(new float[] { 40, 15, 20, 25 })).UseAllAvailableWidth();
        //            pdfTable.AddHeaderCell(new Cell().Add(new Paragraph("Món").SetFont(font).SetBold()));
        //            pdfTable.AddHeaderCell(new Cell().Add(new Paragraph("SL").SetFont(font).SetBold()));
        //            pdfTable.AddHeaderCell(new Cell().Add(new Paragraph("Đơn giá").SetFont(font).SetBold()));
        //            pdfTable.AddHeaderCell(new Cell().Add(new Paragraph("Thành tiền").SetFont(font).SetBold()));

        //            float total = 0;
        //            foreach (var d in details)
        //            {
        //                var food = foodBL.GetAll().First(f => f.ID == d.FoodID);
        //                float amount = d.Quantity * food.Price;
        //                total += amount;

        //                pdfTable.AddCell(new Cell().Add(new Paragraph(food.Name).SetFont(font)));
        //                pdfTable.AddCell(new Cell().Add(new Paragraph(d.Quantity.ToString()).SetFont(font)));
        //                pdfTable.AddCell(new Cell().Add(new Paragraph(food.Price.ToString("N0")).SetFont(font)));
        //                pdfTable.AddCell(new Cell().Add(new Paragraph(amount.ToString("N0")).SetFont(font)));
        //            }

        //            document.Add(pdfTable);
        //            document.Add(new Paragraph("------------------------------------------------").SetFont(font).SetFontSize(10));

        //            // Tổng tiền
        //            document.Add(new Paragraph($"Tổng cộng: {total:N0} VNĐ").SetFont(font).SetBold());
        //            document.Add(new Paragraph($"Chiết khấu: {bill.Discount:N0} VNĐ").SetFont(font));
        //            document.Add(new Paragraph($"Thuế ({bill.Tax * 100}%): {(total * bill.Tax):N0} VNĐ").SetFont(font));
        //            document.Add(new Paragraph($"Thành tiền: {bill.Amount:N0} VNĐ")
        //                .SetFont(font).SetFontSize(12).SetBold().SetTextAlignment(TextAlignment.RIGHT));

        //            document.Add(new Paragraph("Cảm ơn quý khách!").SetFont(font).SetTextAlignment(TextAlignment.CENTER).SetMarginTop(20));
        //            document.Add(new Paragraph("Hẹn gặp lại!").SetFont(font).SetTextAlignment(TextAlignment.CENTER));
        //        }

        //        MessageBox.Show($"Hóa đơn đã được in ra Desktop:\n{fileName}", "In thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        System.Diagnostics.Process.Start(path);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi in hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //#endregion
    }
}