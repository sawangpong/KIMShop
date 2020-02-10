using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.utils
{
    public static class ImageUtils
    {
        #region class field
        private static OpenFileDialog selectFileDialog;
        private static byte[] byteImage;
        private static Size _selectedSize = new Size(80, 120);

        #endregion

        #region Class Property

        public static string ImageFileName
        {
            get; set;
        }

        public static string ConnectionString { get; set; } = null;

        public static string ImageQuery { get; set; } = null;

        public static Image GetPicture
        {
            get; private set;
        }

        #endregion // end class property

        #region class Helper

        #region Overload Method GetImageFromDB

        //
        // Call by No parameter
        public static Image GetImageFromDB() => GetImageFromDB();
 
        //
        // Call by given parameter "PictureSizeMode"
        public static Image GetImageFromDB(DataTable DataSource)
        {
            Bitmap dbBmp = null;
            try
            {
                if (DataSource != null)
                {
                    if (Convert.IsDBNull(DataSource.Rows[0][0]))
                    {
                        return null;
                    }
                    else
                    {
                        var b = (byte[])DataSource.Rows[0][0];
                        using (var ms = new MemoryStream())
                        {
                            ms.Write(b, 0, b.Length);
                            dbBmp = new Bitmap(ms);
                            using (var gBmp = Graphics.FromImage(dbBmp))
                            {
                                gBmp.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                gBmp.DrawImage(dbBmp, new RectangleF(0.0f, 0.0f, dbBmp.Width, dbBmp.Height));
                            } // end graphic object
                        } // end memorystream  object   
                    }
                }
            }
            catch
            {
                dbBmp = null;
            }

            return dbBmp;
        } // end GetImageFromDB

        #endregion //end GetImageFromDB

        #region "Overload Method GetImageListFromDB"

        public static ImageList GetImageListFromDB(DataTable dataSource)
        {
            var imgList = new ImageList();
            Image img = null;
            imgList.ImageSize = new Size(50, 80);

            // Get Image from Database field
            foreach (DataRow dr in dataSource.Rows)
                if (Convert.IsDBNull(dr[1]))
                {
                    img = null;
                }
                else
                {
                    var b = (byte[])dr[1];
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(b, 0, b.Length);
                        img = Image.FromStream(ms, true, true);
                        img.Tag = dr[0].ToString();
                    } // end MemoryStream object
                    imgList.Images.Add(dr[0].ToString(), img);
                }
            return imgList;
        } // end GetImageListFromDB

        #endregion "Overload Method GetImageListFromDB"

        #region "Overload Method GetImageFromField

        public static Image GetImageFromByte(byte[] imageObject)
        {
            Image imgResult;
            using (var ms = new MemoryStream())
            {
                ms.Write(imageObject, 0, imageObject.Length);
                imgResult = Image.FromStream(ms, true, true);
            }

            return imgResult;
        } // end GetImageFromByte

        public static Image GetImageFromField(object ImageField)
        {
            try
            {
                if (ImageField != null)
                {
                    Image imgResult;
                    var b = (byte[])ImageField;
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(b, 0, b.Length);
                        imgResult = Image.FromStream(ms, true, true);
                    } // end memorystream
                    return imgResult;
                }
                return null;
            }
            catch
            {
                return null;
            }
        } // end GetImageFromField

        #endregion // Overload Method GetImageFromField

        #region "Overload Method GetImageFile"

        public static Image GetImageFile(string LastSelectedPath = "")
        {
            Image _getImage;

            // initial OpenFileDialog for all Image extension
            selectFileDialog = new OpenFileDialog();
            selectFileDialog.InitialDirectory = string.IsNullOrEmpty(LastSelectedPath)
                ? Environment.CurrentDirectory
                : LastSelectedPath;
            selectFileDialog.Title = "Select Picture File";
            selectFileDialog.DefaultExt = "*.BMP";
            selectFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            // check selected image
            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageFileName = selectFileDialog.FileName;
                try
                {
                    using (var fs = new FileStream(ImageFileName, FileMode.Open, FileAccess.Read))
                    {
                        LastSelectedPath = selectFileDialog.FileName.Substring(1, selectFileDialog.FileName.LastIndexOf("\\"));
                        byteImage = new byte[Convert.ToInt32(fs.Length)];
                        fs.Read(byteImage, 0, Convert.ToInt32(fs.Length));
                        _getImage = Image.FromFile(selectFileDialog.FileName, false);
                    } // end file stream object
                }
                catch
                {
                    MessageBox.Show("Can't build image from selected file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _getImage = null;
                }
            }
            else
            {
                _getImage = null;
            }

            // assign value to property
            GetPicture = _getImage;

            return _getImage;
        } // end GetImageFile

        #endregion "Overload Method GetImageFile"

        public static ImageList GetImageList(DataTable dataSource)
        {
            var imgList = new ImageList();
            imgList.TransparentColor = Color.White;

            Bitmap bmp;
            foreach (DataRow dr in dataSource.Rows)
                if (Convert.IsDBNull(dr[1]))
                {
                    var p = new PictureBox();
                    imgList.Images.Add(dr[0].ToString(), p.ErrorImage);
                }
                else
                {
                    var b = (byte[])dr[1];
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(b, 0, b.Length);
                        bmp = new Bitmap(ms, true);
                        imgList.Images.Add(dr[0].ToString(), bmp);
                    } // end memorystream object
                }
            return imgList;
        } // end GeiImageList

        #region "Overload Method ResizeImage"

        private static Bitmap ResizeImage(Bitmap SourceImage, Size NewSize) => ResizeImage(SourceImage, NewSize.Width, NewSize.Height);
 
        private static Bitmap ResizeImage(Bitmap sourceImage, int width, int height)
        {
            var bmp = new Bitmap(sourceImage, new Size(width, height));
            using (var grp = Graphics.FromImage(bmp))
            {
                grp.PixelOffsetMode = PixelOffsetMode.None;
                grp.InterpolationMode = InterpolationMode.HighQualityBicubic;
                grp.DrawImage(bmp, new RectangleF(0.0f, 0.0f, bmp.Width, bmp.Height));
            }
            return bmp;
        } // end ResizeImage

        public static Image ResizeImage(Bitmap sourceImage, int width, int height, int quality)
        {
            Image _result = null;
            try
            {
                // get the original image width and height
                var _originalWidth = sourceImage.Width;
                var _originalHeight = sourceImage.Height;

                // to preserve the aspect ratio
                var ratioX = width / (float)_originalWidth;
                var ratioY = height / (float)_originalHeight;
                var ratio = Math.Min(ratioX, ratioY);

                // new width and height based on aspect ratio
                var newWidth = (int)(_originalWidth * ratio);
                var newHeight = (int)(_originalHeight * ratio);

                // convert other formats (including CMYK) to RGB
                var _newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

                // draw the image in the specified size with quality mode set to HighQuality
                using (var g = Graphics.FromImage(_newImage))
                {
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.DrawImage(sourceImage, 0, 0, newWidth, newHeight);
                }

                // get an ImageCodecInfo object that represents the JPEG codec.
                var imageCodecInfo = GetEncoderInfo(ImageFormat.Jpeg);

                // create and Encoder object for the Quality parameter
                var encoder = System.Drawing.Imaging.Encoder.Quality;

                // create and EncoderParameters object
                var encoderParameters = new EncoderParameters(1);

                // save the image as a jpeg file quality level
                var encoderParameter = new EncoderParameter(encoder, quality);
                encoderParameters.Param[0] = encoderParameter;

                //byte[] b;
                Image _img;
                using (var ms = new MemoryStream())
                {
                    var _bmp = new Bitmap(_newImage);
                    _bmp.Save(ms, imageCodecInfo, encoderParameters);
                    _img = Image.FromStream(ms, true, true);
                }
                _result = _img;
            }
            catch
            {
                _result = null;
            }

            return _result;
        } // end

        private static ImageCodecInfo GetEncoderInfo(ImageFormat format) => ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);

        #endregion "Overload Method ResizeImage"

        #endregion // end class helper

        #region path

        public static GraphicsPath GetPath(Rectangle rc, int r)
        {
            var x = rc.X;
            var y = rc.Y;
            var w = rc.Width;
            var h = rc.Height;
            var path = new GraphicsPath();

            //left top corner
            path.AddArc(x, y, r, r, 180, 90);

            //right top corner
            path.AddArc(x + w - r, y, r, r, 270, 90);

            //right bottom corner
            path.AddArc(x + w - r, y + h - r, r, r, 0, 90);

            //left bottom corner
            path.AddArc(x, y + h - r, r, r, 90, 90);
            path.CloseFigure();

            return path;
        } // end GetPath


        public static GraphicsPath GetPath2(Rectangle rc, int r)
        {
            var top = rc.X;
            var left = rc.Y;
            var right = rc.Width;
            var bottom = rc.Height;
            var offset = 2;

            var path = new GraphicsPath();

            // left top corner
            path.AddArc(left + offset, top + offset, r, r, 180, 90);

            //right top corner
            path.AddArc(right - r - offset, top + offset, r, r, 270, 90);

            //right bottom corner
            path.AddArc(right - r - offset, bottom - r - offset, r, r, 0, 90);

            //left bottom corner
            path.AddArc(left + offset, bottom - r - offset, r, r, 90, 90);
            path.CloseFigure();

            return path;
        } // end GetPath

        public static GraphicsPath GetRoundedPath(Rectangle rect, int Radius)
        {
            var Diameter = 2 * Radius;
            var arcRect = new Rectangle(rect.Location, new Size(Diameter, Diameter));
            var path = new GraphicsPath();

            //top left corner
            path.AddArc(arcRect, 180, 90);

            //top right corner
            arcRect.X = rect.Right - Diameter;
            path.AddArc(arcRect, 270, 90);

            //bottom right corner
            arcRect.Y = rect.Bottom - Diameter;
            path.AddArc(arcRect, 0, 90);

            //bottom left corner
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        } // end GetRoundedPath

        #endregion

        #region Save Image to File and Resizing Image

        public static byte[] ConvertImageToByte(Image SourceImg)
        {
            byte[] b = null;
            try
            {
                if (SourceImg != null)
                    using (var ms = new MemoryStream())
                    {
                        var bp = new Bitmap(SourceImg);
                        bp.Save(ms, ImageFormat.Jpeg);
                        b = ms.GetBuffer();
                    }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Conversion Image !!!!!! ", ex);
            }

            return b;
        } // end ConvertImage2Byte

        public static Image GetImage(byte[] ImgObject)
        {
            Image _resultImg;
            try
            {
                using (var ms = new MemoryStream())
                {
                    ms.Write(ImgObject, 0, ImgObject.Length);
                    _resultImg = Image.FromStream(ms, true, true);
                }
            }
            catch
            {
                _resultImg = null;
            }

            return _resultImg;
        } // end GetImage

        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            return null;
        }

        public static int SaveImageToFile(string FullPathName, byte[] SourceImg)
        {
            var _result = 0;
            if (SourceImg.Length > 0)
            {
                ImageCodecInfo myImageCodecInfo;
                System.Drawing.Imaging.Encoder myEncoder;
                EncoderParameter myEncoderParameter;
                EncoderParameters myEncoderParameters;

                // Get an ImageCodecInfo object that represents the JPEG codec.
                myImageCodecInfo = GetEncoderInfo("image/jpeg");

                // Create an Encoder object based on the GUID 
                // for the Quality parameter category.
                myEncoder = System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object. 
                // An EncoderParameters object has an array of EncoderParameter 
                // objects. In this case, there is only one 
                // EncoderParameter object in the array.
                myEncoderParameters = new EncoderParameters(1);

                try
                {
                    // Save the bitmap as a JPEG file with quality level 75.
                    myEncoderParameter = new EncoderParameter(myEncoder, 75L);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    using (var ms = new MemoryStream(SourceImg))
                    {
                        var x = Image.FromStream(ms);
                        x.Save(FullPathName, myImageCodecInfo, myEncoderParameters);
                    }

                    // return value due to save complete
                    _result = 1;
                }
                catch (ExternalException ex)
                {
                    MessageBox.Show(ex.ToString(),"Save Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }

            return _result;
        } // end SaveImageToFile

        public static Image CreateImageResult(Bitmap SourceImage, int ImageWidth, int ImageHeight, int Quality)
        {
            Image _result = null;
            if (SourceImage != null)
                try
                {
                    //var _imgdb = new OMImageDB();
                    _result = ResizeImage(SourceImage, ImageWidth, ImageHeight, Quality);
                }
                catch
                {
                    _result = null;
                }

            return _result;
        } // end CreateImageResult

        #endregion


        #region Extension Method
        public static Image ToImageFromByte(this byte[] imageObject)
        {
            Image imgResult;
            using (var ms = new MemoryStream())
            {
                ms.Write(imageObject, 0, imageObject.Length);
                imgResult = Image.FromStream(ms, true, true);
            }

            return imgResult;
        } // end ToImageFromByte

        public static byte[] ImageToByte(this Image SourceImg)
        {
            byte[] b = null;
            try
            {
                if (SourceImg != null)
                    using (var ms = new MemoryStream())
                    {
                        var bp = new Bitmap(SourceImg);
                        bp.Save(ms, ImageFormat.Jpeg);
                        b = ms.GetBuffer();
                    }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Conversion Image !!!!!! ", ex);
            }

            return b;
        } // end ImageToByte


        public static Image ToImageResize(this Image currentBitmap, int newWidth, int newHeight)
        {
            if (newWidth != 0 && newHeight != 0)
            {
                var temp = (Bitmap)currentBitmap;
                var bmap = new Bitmap(newWidth, newHeight, temp.PixelFormat);

                var nWidthFactor = temp.Width / (double)newWidth;
                var nHeightFactor = temp.Height / (double)newHeight;

                double fx, fy, nx, ny;
                int cx, cy, fr_x, fr_y;
                var color1 = new Color();
                var color2 = new Color();
                var color3 = new Color();
                var color4 = new Color();
                byte nRed, nGreen, nBlue;

                byte bp1, bp2;

                for (var x = 0; x < bmap.Width; ++x)
                    for (var y = 0; y < bmap.Height; ++y)
                    {
                        fr_x = (int)Math.Floor(x * nWidthFactor);
                        fr_y = (int)Math.Floor(y * nHeightFactor);
                        cx = fr_x + 1;
                        if (cx >= temp.Width)
                            cx = fr_x;
                        cy = fr_y + 1;
                        if (cy >= temp.Height)
                            cy = fr_y;
                        fx = x * nWidthFactor - fr_x;
                        fy = y * nHeightFactor - fr_y;
                        nx = 1.0 - fx;
                        ny = 1.0 - fy;

                        color1 = temp.GetPixel(fr_x, fr_y);
                        color2 = temp.GetPixel(cx, fr_y);
                        color3 = temp.GetPixel(fr_x, cy);
                        color4 = temp.GetPixel(cx, cy);

                        // Blue
                        bp1 = (byte)(nx * color1.B + fx * color2.B);

                        bp2 = (byte)(nx * color3.B + fx * color4.B);

                        nBlue = (byte)(ny * bp1 + fy * bp2);

                        // Green
                        bp1 = (byte)(nx * color1.G + fx * color2.G);

                        bp2 = (byte)(nx * color3.G + fx * color4.G);

                        nGreen = (byte)(ny * bp1 + fy * bp2);

                        // Red
                        bp1 = (byte)(nx * color1.R + fx * color2.R);

                        bp2 = (byte)(nx * color3.R + fx * color4.R);

                        nRed = (byte)(ny * bp1 + fy * bp2);

                        bmap.SetPixel(x, y, Color.FromArgb
                            (255, nRed, nGreen, nBlue));
                    }
                return (Image)bmap.Clone();
            }
            return null;
        } // end ToImageResize

        #endregion
    }
}
