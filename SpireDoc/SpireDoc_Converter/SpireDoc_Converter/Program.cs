using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Doc;
namespace SpireDoc_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            doc.LoadFromFile("Berry_Topped_Chocolate.docx");
            doc.SaveToFile("Berry_Topped_Chocolate_PdfVersion.PDF", FileFormat.PDF);
           // System.Diagnostics.Process.Start("Berry_Topped_Chocolate_PdfVersion.PDF");
            Console.WriteLine("Conversion Done!");


            Document doc1 = new Document();
            doc1.LoadFromFile("Berry_Topped_Chocolate.docx");
            doc1.SaveToFile("Berry_Topped_Chocolate_DocVersion.docx", FileFormat.Docx);
            System.Diagnostics.Process.Start("Berry_Topped_Chocolate_DocVersion.docx");
            Console.WriteLine("Conversion Done!");
            
            Console.ReadLine();




        }
    }
}
