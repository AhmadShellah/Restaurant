using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Contracts.InterFaces
{
    public interface IQRCodeGeneratorByOmar
    {
        public Image GenerateBarcode(string website);
    }
}
