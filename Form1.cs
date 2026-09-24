using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab2_project
{
    public partial class Form1 : Form
    {
        private Bitmap originalBitmap;
        private ISolution currentSolution;
        private readonly Dictionary<string, ISolution> solutions;

        public Form1()
        {
            InitializeComponent();

            // Регистрация всех решений
            solutions = new Dictionary<string, ISolution>
            {
                { "Задание 1", new Task1Solution() },
                { "Задание 2", new Task2Solution() },
                { "Задание 3", new Task3Solution() }
            };

            // Заполнение ComboBox
            comboBoxTasks.Items.AddRange(solutions.Keys.ToArray());
            if (comboBoxTasks.Items.Count > 0)
            {
                comboBoxTasks.SelectedIndex = 0;
            }
        }

        private void ComboBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTasks.SelectedItem == null)
                return;

            string selectedTask = comboBoxTasks.SelectedItem.ToString();
            currentSolution = solutions[selectedTask];
            labelDescription.Text = currentSolution.Description;

            // Очистка результатов при смене задания
            ClearResults();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            originalBitmap?.Dispose();
            originalBitmap = new Bitmap(openFileDialog1.FileName);
            pictureBoxOriginal.Image = originalBitmap;

            ClearResults();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            if (originalBitmap == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentSolution == null)
            {
                MessageBox.Show("Выберите задание!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Для задания 3 показываем диалог настройки HSV
                if (currentSolution is Task3Solution task3)
                {
                    using var dialog = new HsvAdjustDialog();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        task3.HueShift = dialog.HueShift;
                        task3.SaturationShift = dialog.SaturationShift;
                        task3.ValueShift = dialog.ValueShift;
                    }
                    else
                    {
                        return; // Пользователь отменил
                    }
                }

                // Выполнение текущего решения
                currentSolution.Execute(originalBitmap);

                // Отображение результатов
                DisplayResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayResults()
        {
            // Получение результирующих изображений
            var resultImages = currentSolution.GetResultImages();

            if (resultImages.Length > 0)
                pictureBoxResult1.Image = resultImages[0].image;
            if (resultImages.Length > 1)
                pictureBoxResult2.Image = resultImages[1].image;
            if (resultImages.Length > 2)
                pictureBoxResult3.Image = resultImages[2].image;

            // Обновление подписей
            if (resultImages.Length > 0)
                labelResult1.Text = resultImages[0].title;
            if (resultImages.Length > 1)
                labelResult2.Text = resultImages[1].title;
            if (resultImages.Length > 2)
                labelResult3.Text = resultImages[2].title;

            // Перерисовка гистограмм
            panelHistogram1.Invalidate();
            panelHistogram2.Invalidate();
            panelHistogram3.Invalidate();
        }

        private void ClearResults()
        {
            pictureBoxResult1.Image = null;
            pictureBoxResult2.Image = null;
            pictureBoxResult3.Image = null;
            labelResult1.Text = "";
            labelResult2.Text = "";
            labelResult3.Text = "";
            panelHistogram1.Invalidate();
            panelHistogram2.Invalidate();
            panelHistogram3.Invalidate();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxResult1.Image == null)
            {
                MessageBox.Show("Нет результатов для сохранения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxResult1.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("Изображение сохранено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DrawHistogram(Panel panel, int[] histogram, Color barColor)
        {
            if (histogram == null || panel.Width == 0 || panel.Height == 0)
                return;

            using Graphics graphics = panel.CreateGraphics();
            graphics.Clear(panel.BackColor);

            int maximum = 0;
            for (int i = 0; i < 256; i++)
            {
                if (histogram[i] > maximum)
                    maximum = histogram[i];
            }

            if (maximum == 0)
                return;

            using Pen pen = new Pen(barColor);

            for (int i = 0; i < 256; i++)
            {
                int x = i * panel.Width / 256;
                int nextX = (i + 1) * panel.Width / 256;
                int height = histogram[i] * panel.Height / maximum;

                if (nextX <= x)
                    nextX = x + 1;

                for (int lineX = x; lineX < nextX && lineX < panel.Width; lineX++)
                {
                    graphics.DrawLine(pen, lineX, panel.Height - 1, lineX, panel.Height - 1 - height);
                }
            }
        }

        private void PanelHistogram1_Paint(object sender, PaintEventArgs e)
        {
            if (currentSolution == null)
                return;

            var histograms = currentSolution.GetHistograms();
            if (histograms.Length > 0)
                DrawHistogram(panelHistogram1, histograms[0].histogram, histograms[0].color);
        }

        private void PanelHistogram2_Paint(object sender, PaintEventArgs e)
        {
            if (currentSolution == null)
                return;

            var histograms = currentSolution.GetHistograms();
            if (histograms.Length > 1)
                DrawHistogram(panelHistogram2, histograms[1].histogram, histograms[1].color);
        }

        private void PanelHistogram3_Paint(object sender, PaintEventArgs e)
        {
            if (currentSolution == null)
                return;

            var histograms = currentSolution.GetHistograms();
            if (histograms.Length > 2)
                DrawHistogram(panelHistogram3, histograms[2].histogram, histograms[2].color);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            originalBitmap?.Dispose();

            foreach (var solution in solutions.Values)
            {
                solution.Cleanup();
            }

            base.OnFormClosed(e);
        }
    }
}
