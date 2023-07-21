using PDFReader2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFReader2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNormalPDF_Click(object sender, EventArgs e)
        {
            //Normal PDF Dosyasını Okuma
            string pdfFilePath = @"C:\Users\msezg\OneDrive\Masaüstü\Direksiyon sınavı.pdf";
            PdfNormalExtractor normalExtractor = new PdfNormalExtractor();
            TBLPDF tBLPDF = normalExtractor.ExtractData(pdfFilePath);
            richTextBox1.Text = tBLPDF.PageContext;
        }

        private void buttonImgPDF_Click(object sender, EventArgs e)
        {
            //İçi Fotoğraf Olan PDF Dosyasını Okuma
            string pdfFilePath = @"C:\Users\msezg\OneDrive\Masaüstü\TESTING.pdf";
            string tesseractDataFolderPath = @"C:\Users\msezg\OneDrive\Masaüstü\BETTER TESSERACT";
            //ImageRenderListener oluşturulma
            var imageListener = new ImageRenderListener();

            //Resimden veri çekme
            var pdfImageExtractor = new PdfImageExtractor(pdfFilePath, tesseractDataFolderPath);
            List<string> extractedTexts = pdfImageExtractor.ExtractTextFromImages(imageListener);

            richTextBox1.Text = "";

            //Ekrana yaz
            foreach (string extractedText in extractedTexts)
            {
                richTextBox1.Text += extractedText + Environment.NewLine;
            }
        }
    }
}
