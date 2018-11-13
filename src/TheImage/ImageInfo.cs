using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;

namespace TheImage
{
    public class ImageInfo
    {
        long countPixel(Image<Rgba32> image)
        {
            return image.Width * image.Height;
        }

        long countPixelFromFile(string fileName)
        {
            using (Image<Rgba32> image = Image.Load("foo.jpg"))
            {
                return countPixel(image);
            }
        }
    }
}
