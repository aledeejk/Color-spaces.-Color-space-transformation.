using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private Bitmap originalBitmap; // Поле для хранения исходной картинки
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик кнопки "Загрузить изображение"
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    originalBitmap = new Bitmap(ofd.FileName);
                    pbOriginal.Image = originalBitmap;
                }
            }
        }

        // Обработчик кнопки "Обработать"
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (originalBitmap == null)
            {
                MessageBox.Show("Изображение не было загружено!");
                return;
            }

            int width = originalBitmap.Width;
            int height = originalBitmap.Height;

            // Три битмапа для каналов
            Bitmap redBitmap = new Bitmap(width, height);
            Bitmap greenBitmap = new Bitmap(width, height);
            Bitmap blueBitmap = new Bitmap(width, height);

            // Три массива для гистограмм
            int[] histR = new int[256];
            int[] histG = new int[256];
            int[] histB = new int[256];

            // Обходим каждый пиксель
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // 4 байта: A (Alpha — прозрачность), R, G, B
                    Color c = originalBitmap.GetPixel(x, y);

                    histR[c.R]++;
                    histG[c.G]++;
                    histB[c.B]++;

                    // В красном битмапе оставляем только красный канал и т.д.
                    redBitmap.SetPixel(x, y, Color.FromArgb(c.R, 0, 0));
                    greenBitmap.SetPixel(x, y, Color.FromArgb(0, c.G, 0));
                    blueBitmap.SetPixel(x, y, Color.FromArgb(0, 0, c.B));
                }
            }

            pbRed.Image = redBitmap;
            pbGreen.Image = greenBitmap;
            pbBlue.Image = blueBitmap;

            // Рисуем гистограммы и ставим их в PictureBox
            pbHistR.Image = BuildHistogram(histR, Color.Red);
            pbHistG.Image = BuildHistogram(histG, Color.Green);
            pbHistB.Image = BuildHistogram(histB, Color.Blue);
        }

        // Вспомогательный метод: строит картинку-гистограмму
        private Bitmap BuildHistogram(int[] histogram, Color barColor)
        {
            int histWidth = 256;
            int histHeight = 200;

            Bitmap bmp = new Bitmap(histWidth, histHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                // Ищем максимум, чтобы нормировать высоту столбиков
                int max = 0;
                for (int i = 0; i < 256; i++)
                    if (histogram[i] > max) max = histogram[i];
                if (max == 0) max = 1;

                using (Brush brush = new SolidBrush(barColor))
                {
                    for (int i = 0; i < 256; i++)
                    {
                        int barHeight = (int)((double)histogram[i] / max * histHeight);
                        g.FillRectangle(brush, i, histHeight - barHeight, 1, barHeight);
                    }
                }

                g.DrawRectangle(Pens.Black, 0, 0, histWidth - 1, histHeight - 1);
            }
            return bmp;
        }
    }
}
