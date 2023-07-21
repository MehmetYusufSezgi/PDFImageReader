using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using System.IO;
using System.Drawing;

namespace PDFReader2
{
    public class PdfImageExtractor
    {
        private string pdfFilePath;
        private string tesseractDataFolderPath;

        //Arayüzden PDF Yollarının Alınması
        public PdfImageExtractor(string pdfFilePath, string tesseractDataFolderPath)
        {
            this.pdfFilePath = pdfFilePath;
            this.tesseractDataFolderPath = tesseractDataFolderPath;
        }
        //Çıkartılan Resimden Metinlerin Alınması
        public List<string> ExtractTextFromImages(ImageRenderListener imageListener)
        {
            var extractedTexts = new List<string>();

            using (var reader = new PdfReader(pdfFilePath))
            {
                var parser = new PdfReaderContentParser(reader);
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    imageListener.ExtractedImages.Clear();
                    parser.ProcessContent(i, imageListener);
                    foreach (var extractedImage in imageListener.ExtractedImages)
                    {
                        //OCR Görüntüleme Çalıştırılması
                        string extractedText = PerformOCR(extractedImage);
                        extractedTexts.Add(extractedText);
                    }
                }
            }

            return extractedTexts;
        }

        private string PerformOCR(byte[] imageBytes)
        {
            //OCR İşlemleri
            var ocrEngine = new TesseractEngine(tesseractDataFolderPath, "tur", EngineMode.Default);
            using (var imageStream = new MemoryStream(imageBytes))
            using (var image = new Bitmap(imageStream)) //Bitmap dönüşümü
            using (var page = ocrEngine.Process(PixConverter.ToPix(image)))
            {
                string extractedText = page.GetText();
                //Resmi düzenle
                return extractedText;
            }
        }
    }
}

