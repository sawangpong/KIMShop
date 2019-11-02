using KIM.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KIM.utils
{
    public static class BarcodeUtils
    {
        #region Embeded Fonts

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        #endregion

        public static Font getBarcodeFont()
        {
            var fontArray = Resources.IDAutomationHC39M;
            var dataLength = Resources.IDAutomationHC39M.Length;
            var data = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, data, dataLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);
            var pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(data, dataLength);

            // release resource
            Marshal.FreeCoTaskMem(data);
            var ff = pfc.Families[0];
            var font = new Font(ff, 16f); //for IDAAutomation ////Font font = new Font(ff, 35f); //22f
            return font;
        } // end GetBarcodeFont

        #region GenerateBarCodeImage

        public static Image GenerateImageBarcode(string text)
        {
            var b = new Bitmap(text.Length * 25, 55);
            using (var g = Graphics.FromImage(b))
            {
                var pf = new PointF(2f, 2f);
                var blackBrush = new SolidBrush(Color.Black);
                var whiteBrush = new SolidBrush(Color.White);
                g.FillRectangle(whiteBrush, 0, 0, b.Width, b.Height);
                g.DrawString("*" + text + "*", getBarcodeFont(), blackBrush, pf);
            }

            using (var ms = new MemoryStream())
            {
                b.Save(ms, ImageFormat.Png);
            }

            return b;
        } // end GenerateImageBarcode

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            foreach (var codec in codecs)
                if (codec.FormatID == format.Guid)
                    return codec;
            return null;
        }

        public static Bitmap GenerateBitmapBarcode(string text)
        {
            var b = new Bitmap(text.Length * 35, 60);
            var jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            using (var g = Graphics.FromImage(b))
            {
                g.Clear(Color.White);
                var fnt = getBarcodeFont();
                var pf = new PointF(2f, 2f);
                var blackBrush = new SolidBrush(Color.Black);
                var whiteBrush = new SolidBrush(Color.White);
                g.FillRectangle(whiteBrush, 0, 0, b.Width, b.Height);
                var sf = new StringFormat { LineAlignment = StringAlignment.Center };
                var barcodeString = text;
                g.DrawString(barcodeString, fnt, blackBrush, pf, sf);
                string filename = $"d:\\barcode.jpg";
                b.Save(filename, ImageFormat.Jpeg); //, theEncoderParameters);
            }
            return b;
        } // end GenerateBitmapBarcode

        public static byte[] GetBarcode(string text) => ImageUtils.ImageToByte(GenerateBitmapBarcode(text));
 
        #endregion
    }
}
