using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class Commen
    {

        public Image byteToImage(byte[] byteArr)
        {
            MemoryStream ms = new MemoryStream(byteArr);
            return Image.FromStream(ms);
        }

        public byte[] ImageToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }
    }
}
