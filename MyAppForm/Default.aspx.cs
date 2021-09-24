
 
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyAppForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }
        private  string _dataDir = "D:\\pdf/";

        protected void lblButton_Click(object sender, EventArgs e)
        {

            /* Itext 7  */

            //using (PdfWriter pdfWriter = new PdfWriter(_dataDir + "hello3.pdf"))
            //using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
            //using (Document document = new Document(pdfDocument))
            //{
            //    document.Add(new Paragraph("Uno mas  !"));
            //}


            PdfDocument pdf = new PdfDocument(new PdfWriter(_dataDir+"merged.pdf"));
            PdfMerger merger = new PdfMerger(pdf);

            //Add pages from the first document
            PdfDocument firstSourcePdf = new PdfDocument(new PdfReader(_dataDir + "hello.pdf"));
            merger.Merge(firstSourcePdf, 1, firstSourcePdf.GetNumberOfPages());

            //Add pages from the second pdf document
            PdfDocument secondSourcePdf = new PdfDocument(new PdfReader(_dataDir + "hello2.pdf"));
            merger.Merge(secondSourcePdf, 1, secondSourcePdf.GetNumberOfPages());

            //Add pages from the second pdf document
            PdfDocument oneMore = new PdfDocument(new PdfReader(_dataDir + "hello3.pdf"));
            merger.Merge(oneMore, 1, oneMore.GetNumberOfPages());

             
            pdf.Close();




            //PdfDocument pdfDocument = new PdfDocument(new PdfReader(_dataDir + "HelloWorld_out.pdf"), new PdfWriter(_dataDir + "merged.pdf"));
            //PdfDocument pdfDocument2 = new PdfDocument(new PdfReader(_dataDir + "HelloWorld_out2.pdf"));

            //PdfMerger merger = new PdfMerger(pdfDocument);
            //merger.Merge(pdfDocument2, 1, pdfDocument2.GetNumberOfPages());

            //pdfDocument2.Close();
            //pdfDocument.Close();



            /*Dynamic pdf*/

            //MergeDocument document = new MergeDocument($"{_dataDir}HelloWorld_out.pdf");
            //MergeOptions options = MergeOptions.Append;
            //options.Outlines = false;
            //document.Append($"{_dataDir}HelloWorld_out2.pdf", options);
            //document.Append($"{_dataDir}ConcatenatePdfFiles_out.pdf", options);
            //document.Draw($"{_dataDir}output.pdf");



        }
    }
}

//// Initialize document object
//Aspose.Pdf.Document document = new Aspose.Pdf.Document();

//// Add page
//Aspose.Pdf.Page page = document.Pages.Add();
//// Add text to new page
//page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Hello World 2!"));
//// Save updated PDF
//var outputFileName = System.IO.Path.Combine(_dataDir, "HelloWorld_out2.pdf");
//document.Save( outputFileName );


//Aspose.Pdf.Document doc1 = new Aspose.Pdf.Document(_dataDir + "HelloWorld_out.pdf");
//Aspose.Pdf.Document doc2 = new Aspose.Pdf.Document(_dataDir + "HelloWorld_out2.pdf");


//doc1.Pages.Add(doc2.Pages);

//_dataDir = _dataDir + "ConcatenatePdfFiles_out.pdf";
// Save concatenated output file
//doc1.Save(_dataDir);