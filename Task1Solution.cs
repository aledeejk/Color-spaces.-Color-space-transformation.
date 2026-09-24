using System;
using System.Drawing;

namespace lab2_project
{
    /// <summary>
    /// Задание 1: Преобразование RGB в оттенки серого двумя методами
    /// </summary>
    public class Task1Solution : ISolution
    {
        private Bitmap grayBitmap1;
        private Bitmap grayBitmap2;
        private Bitmap differenceBitmap;
        private int[] histogram1 = new int[256];
        private int[] histogram2 = new int[256];

        public string Name => "Задание 1";

        public string Description => "Преобразование RGB → Grayscale (2 формулы) + разность + гистограммы";

        public void Execute(Bitmap source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            Cleanup();

            grayBitmap1 = ToGray1(source);
            grayBitmap2 = ToGray2(source);
            differenceBitmap = Diff(grayBitmap1, grayBitmap2);

            histogram1 = new int[256];
            histogram2 = new int[256];

            for (int y = 0; y < grayBitmap1.Height; y++)
            {
                for (int x = 0; x < grayBitmap1.Width; x++)
                {
                    histogram1[grayBitmap1.GetPixel(x, y).R]++;
                    histogram2[grayBitmap2.GetPixel(x, y).R]++;
                }
            }
        }

        public (string title, Bitmap image)[] GetResultImages()
        {
            return new[]
            {
                ("Gray Method 1 (0.299R + 0.587G + 0.114B)", grayBitmap1),
                ("Gray Method 2 (0.2126R + 0.7152G + 0.0722B)", grayBitmap2),
                ("Difference", differenceBitmap)
            };
        }

        public (string title, int[] histogram, Color color)[] GetHistograms()
        {
            return new[]
            {
                ("Histogram Method 1", histogram1, Color.Black),
                ("Histogram Method 2", histogram2, Color.Black)
            };
        }

        public void Cleanup()
        {
            grayBitmap1?.Dispose();
            grayBitmap2?.Dispose();
            differenceBitmap?.Dispose();
            grayBitmap1 = null;
            grayBitmap2 = null;
            differenceBitmap = null;
        }

        private Bitmap ToGray1(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color color = source.GetPixel(x, y);
                    int value = (int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B + 0.5);

                    if (value < 0)
                        value = 0;
                    if (value > 255)
                        value = 255;

                    result.SetPixel(x, y, Color.FromArgb(value, value, value));
                }
            }

            return result;
        }

        private Bitmap ToGray2(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color color = source.GetPixel(x, y);
                    int value = (int)(0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B + 0.5);

                    if (value < 0)
                        value = 0;
                    if (value > 255)
                        value = 255;

                    result.SetPixel(x, y, Color.FromArgb(value, value, value));
                }
            }

            return result;
        }

        private Bitmap Diff(Bitmap first, Bitmap second)
        {
            Bitmap result = new Bitmap(first.Width, first.Height);

            for (int y = 0; y < first.Height; y++)
            {
                for (int x = 0; x < first.Width; x++)
                {
                    int value = Math.Abs(first.GetPixel(x, y).R - second.GetPixel(x, y).R);
                    result.SetPixel(x, y, Color.FromArgb(value, value, value));
                }
            }

            return result;
        }
    }
}
