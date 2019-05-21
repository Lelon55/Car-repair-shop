using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;

using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace Car_Repair_Shop
{

    public class PdfAddForm
    {
        private Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

        private Font SetFont(string name)
        {
            return new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\" + name + ".ttf", BaseFont.CP1250, true));
        }

        private void Pdf_Meta()
        {
            pdfDoc.AddTitle("Data for VIN: " + Car.Vin + " from Car Repair Shop Program");
            pdfDoc.AddAuthor("Adrian Lelonkiewicz");
        }

        private void Pdf_Header()
        {
            pdfDoc.Open();
            PdfPTable pdfHeader = new PdfPTable(2);
            pdfHeader.SetTotalWidth(new float[] { (pdfDoc.PageSize.Width * 0.5f), (pdfDoc.PageSize.Width * 0.5f) });
            pdfHeader.LockedWidth = true;

            PdfPCell _cell = new PdfPCell(new Paragraph("Company Name \nstreet. xyz 1\n00-901 Warsaw"));
            _cell.Border = 0;
            _cell.PaddingLeft = 10f;
            _cell.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfHeader.AddCell(_cell);

            System.Drawing.Image logo = System.Drawing.Image.FromFile("./image/tire.png");
            Image iLogo = Image.GetInstance(logo, ImageFormat.Png);
            iLogo.ScaleAbsolute(75f, 75f);
            PdfPCell _cell_logo = new PdfPCell(iLogo);
            _cell_logo.Border = 0;
            _cell_logo.HorizontalAlignment = Element.ALIGN_RIGHT;
            pdfHeader.AddCell(_cell_logo);

            pdfDoc.Add(pdfHeader);
        }

        private void Pdf_Title()
        {
            Paragraph phrase_cell = new Paragraph("DATA CAR");
            phrase_cell.Font.Size = 24;
            phrase_cell.SpacingBefore = 50;
            phrase_cell.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(phrase_cell);
        }

        private void Pdf_Body()
        {
            Paragraph p1 = new Paragraph("VIN: " + Car.Vin);
            p1.SpacingBefore = 50;
            Paragraph p2 = new Paragraph("Plate: " + Car.Plate);
            p2.SpacingBefore = 10;
            Paragraph p3 = new Paragraph("Brand: " + Car.Brand + "\nModel: " + Car.Model + "\nYear production: " + Car.YearProduction + "\nMileage: " + Car.Mileage + " km");
            p3.SpacingBefore = 10;
            Paragraph p4 = new Paragraph("Acceptance Car: " + Car.DateAcceptance + "\nDevotion Car: " + Car.DateDevotion, SetFont("Arial"));
            p4.SpacingBefore = 10;
            Paragraph p5 = new Paragraph("Parts Cost: " + Car.PartCost + " PLN" + "\nLabor Cost: " + Car.LaborCost + " PLN", SetFont("Arial"));
            p5.SpacingBefore = 10;
            Paragraph p6 = new Paragraph("To do: " + Car.ToDo, SetFont("Arial"));
            p6.SpacingBefore = 10;
            Paragraph p7 = new Paragraph("Repaired: " + Car.Repaired, SetFont("Arial"));
            p7.SpacingBefore = 10;
            Paragraph p8 = new Paragraph("Comment: " + Car.Comment, SetFont("Arial"));
            p8.SpacingBefore = 10;

            pdfDoc.Add(p1);
            pdfDoc.Add(p2);
            pdfDoc.Add(p3);
            pdfDoc.Add(p4);
            pdfDoc.Add(p5);
            pdfDoc.Add(p6);
            pdfDoc.Add(p7);
            pdfDoc.Add(p8);
        }

        private void Pdf_Footer()
        {
            Paragraph phrase_footer = new Paragraph("Document generated: " + DateTime.Now);
            phrase_footer.Font.Size = 12;
            phrase_footer.SpacingBefore = 35;
            phrase_footer.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(phrase_footer);
        }

        private void Pdf_SaveFile()
        {
            SaveFileDialog SaveWindow = new SaveFileDialog();
            SaveWindow.Filter = "PDF(*.pdf) |*.pdf";
            SaveWindow.ShowDialog();
            if (SaveWindow.FileName != "")
            {
                PdfWriter pwriter = PdfWriter.GetInstance(pdfDoc, new FileStream(SaveWindow.FileName, FileMode.Create));
                MessageBox.Show("Saved PDF", "Car Repair Shop");
            }
        }

        public void Generate_PdfAddForm()
        {
            pdfDoc.Open();
            Pdf_SaveFile();

            Pdf_Meta();
            Pdf_Header();
            Pdf_Title();

            Pdf_Body();
            Pdf_Footer();
            pdfDoc.Close();

        }
    }
}
