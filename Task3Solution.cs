using System;
using System.Drawing;

namespace lab2_project
{
    /// <summary>
    /// Задание 3: Преобразование RGB → HSV с регулировкой параметров
    /// </summary>
    public class Task3Solution : ISolution
    {
        private Bitmap hsvBitmap;
        private Bitmap adjustedBitmap;

        // Параметры для регулировки (диапазоны: H: -180..180, S: -100..100, V: -100..100)
        public int HueShift { get; set; } = 0;
        public int SaturationShift { get; set; } = 0;
        public int ValueShift { get; set; } = 0;

        public string Name => "Задание 3";

        public string Description => "Преобразование RGB → HSV с регулировкой оттенка, насыщенности и яркости";

        public void Execute(Bitmap source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            Cleanup();

            int width = source.Width;
            int height = source.Height;

            hsvBitmap = new Bitmap(width, height);
            adjustedBitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color rgb = source.GetPixel(x, y);

                    // Преобразование RGB → HSV
                    RgbToHsv(rgb.R, rgb.G, rgb.B, out double h, out double s, out double v);

                    // Визуализация HSV (для первого изображения)
                    Color hsvColor = HsvToRgb(h, s, v);
                    hsvBitmap.SetPixel(x, y, hsvColor);

                    // Применение сдвигов
                    double adjustedH = (h + HueShift + 360) % 360;
                    double adjustedS = Math.Max(0, Math.Min(1, s + SaturationShift / 100.0));
                    double adjustedV = Math.Max(0, Math.Min(1, v + ValueShift / 100.0));

                    // Преобразование обратно в RGB
                    Color adjustedColor = HsvToRgb(adjustedH, adjustedS, adjustedV);
                    adjustedBitmap.SetPixel(x, y, adjustedColor);
                }
            }
        }

        public (string title, Bitmap image)[] GetResultImages()
        {
            return new[]
            {
                ("Original → HSV", hsvBitmap),
                ($"Adjusted (H:{HueShift:+#;-#;0}° S:{SaturationShift:+#;-#;0}% V:{ValueShift:+#;-#;0}%)", adjustedBitmap)
            };
        }

        public (string title, int[] histogram, Color color)[] GetHistograms()
        {
            // Для задания 3 гистограммы не требуются
            return Array.Empty<(string, int[], Color)>();
        }

        public void Cleanup()
        {
            hsvBitmap?.Dispose();
            adjustedBitmap?.Dispose();
            hsvBitmap = null;
            adjustedBitmap = null;
        }

        /// <summary>
        /// Преобразование RGB (0-255) → HSV (H: 0-360, S: 0-1, V: 0-1)
        /// </summary>
        private void RgbToHsv(int r, int g, int b, out double h, out double s, out double v)
        {
            double rNorm = r / 255.0;
            double gNorm = g / 255.0;
            double bNorm = b / 255.0;

            double max = Math.Max(rNorm, Math.Max(gNorm, bNorm));
            double min = Math.Min(rNorm, Math.Min(gNorm, bNorm));
            double delta = max - min;

            // Value (яркость)
            v = max;

            // Saturation (насыщенность)
            if (max == 0)
            {
                s = 0;
                h = 0;
                return;
            }
            s = delta / max;

            // Hue (оттенок)
            if (delta == 0)
            {
                h = 0;
            }
            else if (max == rNorm)
            {
                h = 60 * (((gNorm - bNorm) / delta) % 6);
            }
            else if (max == gNorm)
            {
                h = 60 * (((bNorm - rNorm) / delta) + 2);
            }
            else // max == bNorm
            {
                h = 60 * (((rNorm - gNorm) / delta) + 4);
            }

            if (h < 0)
                h += 360;
        }

        /// <summary>
        /// Преобразование HSV (H: 0-360, S: 0-1, V: 0-1) → RGB (0-255)
        /// </summary>
        private Color HsvToRgb(double h, double s, double v)
        {
            double c = v * s;
            double x = c * (1 - Math.Abs((h / 60.0) % 2 - 1));
            double m = v - c;

            double r = 0, g = 0, b = 0;

            if (h >= 0 && h < 60)
            {
                r = c; g = x; b = 0;
            }
            else if (h >= 60 && h < 120)
            {
                r = x; g = c; b = 0;
            }
            else if (h >= 120 && h < 180)
            {
                r = 0; g = c; b = x;
            }
            else if (h >= 180 && h < 240)
            {
                r = 0; g = x; b = c;
            }
            else if (h >= 240 && h < 300)
            {
                r = x; g = 0; b = c;
            }
            else if (h >= 300 && h < 360)
            {
                r = c; g = 0; b = x;
            }

            int R = (int)Math.Round((r + m) * 255);
            int G = (int)Math.Round((g + m) * 255);
            int B = (int)Math.Round((b + m) * 255);

            return Color.FromArgb(
                Math.Max(0, Math.Min(255, R)),
                Math.Max(0, Math.Min(255, G)),
                Math.Max(0, Math.Min(255, B))
            );
        }
    }
}
