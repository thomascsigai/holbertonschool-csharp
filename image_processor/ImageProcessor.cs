using System;
using System.Drawing;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        foreach (string file in filenames)
        {
            Bitmap originalBitmap = new Bitmap(file);
        }
    }
}
