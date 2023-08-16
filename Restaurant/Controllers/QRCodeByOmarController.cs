using Contracts.InterFaces;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace Restaurant.Controllers
{
    [ApiController]
    public class QRCodeByOmarController : Controller, IQRCodeGeneratorByOmar
    {
        private readonly IQRCodeGeneratorByOmar _qrcodegeneratorbyomar;

        public QRCodeByOmarController(IQRCodeGeneratorByOmar qrcodegeneratorbyomar)
        {
            _qrcodegeneratorbyomar = qrcodegeneratorbyomar;
        }

        [HttpGet]
        [Route("api/QRCode/OmarsGenerateBarcode")]
        public Image GenerateBarcode(string website)
        {
            return _qrcodegeneratorbyomar.GenerateBarcode(website);
        }
        
    }
}
