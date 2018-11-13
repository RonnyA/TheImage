using System;
using System.Drawing;

namespace TheImage
{
    public class ImageInfo
    {
        long countPixel(Image image)
        {
            return image.Size.Width * image.Size.Height;
        }
    }
}
