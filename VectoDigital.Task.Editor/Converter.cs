using System;
using System.Drawing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace VectoDigital.Task.Editor
{
    public class Converter
    {
        // here must be all convert functions (resize, effects...)
        public void ResizeTo100x300()
        {

            //...
        }
        public void ToDo()
        {
            //...
        }
        public static System.Drawing.Image Resize(System.Drawing.Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
    }
}
