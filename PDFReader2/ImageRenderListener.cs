using iTextSharp.text;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFReader2
{
    public class ImageRenderListener : IRenderListener
    {
        public List<byte[]> ExtractedImages { get; private set; } = new List<byte[]>();
        //Başlangıç ve Bitiş Alanlarının Ayarlanması
        public void BeginTextBlock() { }
        public void EndTextBlock() { }
        public void RenderImage(ImageRenderInfo renderInfo)
        {
            //PDF Dosyasından Resim Çek
            var imageObject = renderInfo.GetImage();
            if (imageObject != null)
            {
                //Verileri Bitlere Dönüştür
                byte[] imageBytes = imageObject.GetImageAsBytes();
                ExtractedImages.Add(imageBytes);
            }
        }

        public void RenderText(TextRenderInfo renderInfo) { }
    }
}
