using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Spire.Barcode;
using Contracts.InterFaces;
using System.Drawing.Imaging;
using System.Runtime.ConstrainedExecution;

namespace Service
{

    public class QRCodeGeneratorByOmarService : IQRCodeGeneratorByOmar
    {

        public static int counter = 0;

        public Image GenerateBarcode(string website)
        {

            BarcodeSettings settings = new BarcodeSettings(); //Instantiating a BarcodeSettings Object

            settings.Type = BarCodeType.QRCode; //Specifying the barcode type to QRCode

            settings.Data = $"https://{website}"; //Data inside the QRCode

            // settings.Data2D = "Omars QRCode"; //Display Data on the QRCode

            settings.QRCodeDataMode = QRCodeDataMode.AlphaNumber; //Setting the encoding mode

            settings.X = 5.0f; //Width of the QRCode bar module

            settings.Y = 5.0f;

            settings.QRCodeECL = QRCodeECL.H; //Setting the QRCode correction level to H, H means if barcode 30% damaged, still readable

            BarCodeGenerator generator = new BarCodeGenerator(settings); //Barcode Generator object to generate an object based on the settings provided

            Image barcodeImage = generator.GenerateImage(); //Generating Image of the generated barcode

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            barcodeImage.Save(@$"{path}\QRCode{Guid.NewGuid()}.png"); //Saving the image in the My Pictures folder of the user


            return barcodeImage;

        }

    }
}
