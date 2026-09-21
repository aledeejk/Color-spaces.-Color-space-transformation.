using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab2_project
{
    public partial class Form1 : Form
    {
        private Bitmap originalBitmap;
        private Bitmap grayBitmap1;
        private Bitmap grayBitmap2;
        private Bitmap differenceBitmap;
        private int[] histogram1 = new int[256];
        private int[] histogram2 = new int[256];

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Bitmap loadedBitmap = new Bitmap(openFileDialog1.FileName);

            if (originalBitmap != null)
            {
                originalBitmap.Dispose();
            }

            if (grayBitmap1 != null)
            {
                grayBitmap1.Dispose();
            }

            if (grayBitmap2 != null)
            {
                grayBitmap2.Dispose();
            }

            if (differenceBitmap != null)
            {
                differenceBitmap.Dispose();
            }

            originalBitmap = loadedBitmap;
            pictureBoxOriginal.Image = originalBitmap;
            pictureBoxGray1.Image = null;
            pictureBoxGray2.Image = null;
            pictureBoxDifference.Image = null;
            grayBitmap1 = null;
            grayBitmap2 = null;
            differenceBitmap = null;
            histogram1 = new int[256];
            histogram2 = new int[256];
            panelHistogram1.Invalidate();
            panelHistogram2.Invalidate();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            if (originalBitmap == null)
            {
                return;
            }

            if (grayBitmap1 != null)
            {
                grayBitmap1.Dispose();
            }

            if (grayBitmap2 != null)
            {
                grayBitmap2.Dispose();
            }

            if (differenceBitmap != null)
            {
                differenceBitmap.Dispose();
            }

            grayBitmap1 = ToGray1(originalBitmap);
            grayBitmap2 = ToGray2(originalBitmap);
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

            pictureBoxGray1.Image = grayBitmap1;
            pictureBoxGray2.Image = grayBitmap2;
            pictureBoxDifference.Image = differenceBitmap;
            panelHistogram1.Invalidate();
            panelHistogram2.Invalidate();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (differenceBitmap == null)
            {
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                differenceBitmap.Save(saveFileDialog1.FileName);
            }
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
                    {
                        value = 0;
                    }

                    if (value > 255)
                    {
                        value = 255;
                    }

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
                    {
                        value = 0;
                    }

                    if (value > 255)
                    {
                        value = 255;
                    }

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

        private void DrawHistogram(Panel panel, int[] histogram)
        {
            using Graphics graphics = panel.CreateGraphics();
            graphics.Clear(panel.BackColor);

            int maximum = 0;

            for (int i = 0; i < 256; i++)
            {
                if (histogram[i] > maximum)
                {
                    maximum = histogram[i];
                }
            }

            if (maximum == 0 || panel.Width == 0 || panel.Height == 0)
            {
                return;
            }

            using Pen pen = new Pen(Color.Black);

            for (int i = 0; i < 256; i++)
            {
                int x = i * panel.Width / 256;
                int nextX = (i + 1) * panel.Width / 256;
                int height = histogram[i] * panel.Height / maximum;

                if (nextX <= x)
                {
                    nextX = x + 1;
                }

                for (int lineX = x; lineX < nextX && lineX < panel.Width; lineX++)
                {
                    graphics.DrawLine(pen, lineX, panel.Height - 1, lineX, panel.Height - 1 - height);
                }
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawHistogram(panelHistogram1, histogram1);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawHistogram(panelHistogram2, histogram2);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (originalBitmap != null)
            {
                originalBitmap.Dispose();
            }

            if (grayBitmap1 != null)
            {
                grayBitmap1.Dispose();
            }

            if (grayBitmap2 != null)
            {
                grayBitmap2.Dispose();
            }

            if (differenceBitmap != null)
            {
                differenceBitmap.Dispose();
            }

            base.OnFormClosed(e);
        }
    }
}