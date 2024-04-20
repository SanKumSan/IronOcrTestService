namespace WebApplication1.Services;
using IronOcr;

public class IronOcrService
{
    public string BarcodeTester()
    {
        var ocr = new IronTesseract();

        using (var ocrInput = new OcrInput())
        {
            var resPath = @"F:\Learning2023\NetCoreProjects\we2\WebApplication1\Resources";
            ocrInput.LoadImage(Path.Combine(resPath, "test.jpg"));
            //ocrInput.LoadPdf("document.pdf");
    
            // Optionally Apply Filters if needed:
            // ocrInput.Deskew();  // use only if image not straight
            // ocrInput.DeNoise(); // use only if image contains digital noise
    
            var ocrResult = ocr.Read(ocrInput);
            Console.WriteLine(ocrResult.Text);
            return ocrResult.Text;
        }
    }
}