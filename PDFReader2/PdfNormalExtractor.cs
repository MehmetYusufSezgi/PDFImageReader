using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFReader2.Model
{
    public class PdfNormalExtractor
    {
        public TBLPDF ExtractData(string pdfFilePath)
        {
            using (var reader = new PdfReader(pdfFilePath))
            {
                //Normal PDF Dosyasından yazıların çekilmesi
                var stringBuilder = new StringBuilder();
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    stringBuilder.Append(PdfTextExtractor.GetTextFromPage(reader, page));
                }

                string extractedText = stringBuilder.ToString();

                //Veri Tabanına Çekilen Değerlerin Aktarılması
                TBLPDF dataModel = new TBLPDF
                {
                    PageContext = extractedText
                };

                return dataModel;
            }
        }
    }
}
