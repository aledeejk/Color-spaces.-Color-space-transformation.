using System;
using System.Drawing;

namespace lab2_project
{
    /// <summary>
    /// Задание 2: Выделение RGB каналов и построение гистограмм
    /// </summary>
    public class Task2Solution : ISolution
    {
        private Bitmap redBitmap;
        private Bitmap greenBitmap;
        private Bitmap blueBitmap;
        private int[] histR = new int[256];
        private int[] histG = new int[256];
        private int[] histB = new int[256];

        public string Name => "Задание 2";

        public string Description => "Выделение каналов R, G, B + гистограммы по цветам";

        public void Execute(Bitmap source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            Cleanup();

            int width = source.Width;
            int height = source.Height;

            redBitmap = new Bitmap(width, height);
            greenBitmap = new Bitmap(width, height);
            blueBitmap = new Bitmap(width, height);

            histR = new int[256];
            histG = new int[256];
            histB = new int[256];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c = source.GetPixel(x, y);

                    histR[c.R]++;
                    histG[c.G]++;
                    histB[c.B]++;

                    redBitmap.SetPixel(x, y, Color.FromArgb(c.R, 0, 0));
                    greenBitmap.SetPixel(x, y, Color.FromArgb(0, c.G, 0));
                    blueBitmap.SetPixel(x, y, Color.FromArgb(0, 0, c.B));
                }
            }
        }

        public (string title, Bitmap image)[] GetResultImages()
        {
            return new[]
            {
                ("Red Channel", redBitmap),
                ("Green Channel", greenBitmap),
                ("Blue Channel", blueBitmap)
            };
        }

        public (string title, int[] histogram, Color color)[] GetHistograms()
        {
            return new[]
            {
                ("Red Histogram", histR, Color.Red),
                ("Green Histogram", histG, Color.Green),
                ("Blue Histogram", histB, Color.Blue)
            };
        }

        public void Cleanup()
        {
            redBitmap?.Dispose();
            greenBitmap?.Dispose();
            blueBitmap?.Dispose();
            redBitmap = null;
            greenBitmap = null;
            blueBitmap = null;
        }
    }
}
