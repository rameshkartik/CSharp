using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace WorkingWithMsWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Document doc = new Document();

            doc.AddSection();
            Section sec = doc.Sections[0];
            Paragraph Para = sec.AddParagraph();
            Para.AppendText("Welcome to the Document created by Ram!");
            doc.SaveToFile("SampleDoc.docx", FileFormat.Docx);


            doc.AddSection();
            //Add Header
            Section section = doc.Sections[1];
            HeaderFooter header = section.HeadersFooters.Header;
            Paragraph HeaderParagraph = header.AddParagraph();
            TextRange HeaderText = HeaderParagraph.AppendText("Restaurant for everyone \n");    
           

            //Set Header Text Format
            HeaderText.CharacterFormat.FontName = "Cambria";
            HeaderText.CharacterFormat.FontSize = 11;
            HeaderText.CharacterFormat.TextColor = Color.OrangeRed;

            //Set Header Paragraph Format
            HeaderParagraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
            HeaderParagraph.Format.Borders.Bottom.BorderType = Spire.Doc.Documents.BorderStyle.ThickThinMediumGap;
            HeaderParagraph.Format.Borders.Bottom.Space = 0.05f;
            HeaderParagraph.Format.Borders.Bottom.Color = Color.DarkGray;

            DocPicture headerimage = HeaderParagraph.AppendPicture(Image.FromFile(@"G:\RameshKartik\Tech\C# Samples\SpireDoc\WorkingWithMsWord\WorkingWithMsWord\bin\Debug\test.png"));
            headerimage.VerticalAlignment = ShapeVerticalAlignment.Bottom;

            doc.SaveToFile("SampleDoc.docx", FileFormat.Docx);

            //Add Footer
            HeaderFooter footer = section.HeadersFooters.Footer;
            Paragraph FooterParagraph = footer.AddParagraph();
            TextRange FooterText = FooterParagraph.AppendText("My Company.,Footer Information");

            //Set Footer Text Format
            FooterText.CharacterFormat.FontName = "Calibri";
            FooterText.CharacterFormat.FontSize = 12;
            FooterText.CharacterFormat.TextColor = Color.Brown;

            //Set Footer Paragrah Format
            FooterParagraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
            FooterParagraph.Format.Borders.Top.BorderType = Spire.Doc.Documents.BorderStyle.ThinThinSmallGap;
            FooterParagraph.Format.Borders.Top.Space = 0.15f;
            FooterParagraph.Format.Borders.Color = Color.DarkGray;

            doc.SaveToFile("SampleDoc.docx", FileFormat.Docx);

            MessageBox.Show("Document Created!");



        }
    }
}

