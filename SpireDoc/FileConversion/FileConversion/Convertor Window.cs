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

namespace FileConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DocToPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            doc.LoadFromFile("Caramel_Chocolate.docx");
            doc.SaveToFile("Caramel_Chocolate_PdfVersion.PDF", FileFormat.PDF);
            System.Diagnostics.Process.Start("Caramel_Chocolate_PdfVersion.PDF");
            MessageBox.Show("Conversion Done!", "File Conversion",
                MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

       

        private void btn_DocToTxt_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            doc.LoadFromFile("Caramel_Chocolate.docx");
            doc.SaveToFile("Caramel_Chocolate_TxtVersion.txt", FileFormat.Txt);
            System.Diagnostics.Process.Start("Caramel_Chocolate_TxtVersion.txt");
            MessageBox.Show("Conversion Done!", "File Conversion", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_DocToXps_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            doc.LoadFromFile("Caramel_Chocolate.docx");
            doc.SaveToFile("Caramel_Chocolate_XpsVersion.Xps", FileFormat.XPS);
            System.Diagnostics.Process.Start("Caramel_Chocolate_XpsVersion.Xps");
            MessageBox.Show("Conversion Done!", "File Conversion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
