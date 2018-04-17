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

        //kiểm tra xem chuỗi có phải số không
        public Boolean CheckIsNumber(String s)
        {
            for (int i = 0; i < s.Length; i++)
                if (s[i] < '0' || s[i] > '9')
                    return false;
            return true;
        }
        //độ dài chuỗi hợp lệ không
        public Boolean CheckLength(string s)
        {
            if (s.Length > 10)
                return false;
            return true;
        }
    }
}
