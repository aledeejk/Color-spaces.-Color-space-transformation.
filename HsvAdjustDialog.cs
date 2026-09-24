using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lab2_project
{
    /// <summary>
    /// Диалог для настройки параметров HSV (задание 3)
    /// </summary>
    public class HsvAdjustDialog : Form
    {
        private readonly TrackBar trackBarHue;
        private readonly TrackBar trackBarSaturation;
        private readonly TrackBar trackBarValue;
        private readonly Label labelHueValue;
        private readonly Label labelSaturationValue;
        private readonly Label labelValueValue;
        private readonly Button btnOk;
        private readonly Button btnCancel;
        private readonly Button btnReset;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int HueShift { get; private set; } = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SaturationShift { get; private set; } = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ValueShift { get; private set; } = 0;

        public HsvAdjustDialog()
        {
            Text = "Настройка HSV параметров";
            Width = 400;
            Height = 280;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;

            // Hue (Оттенок)
            var labelHue = new Label
            {
                Text = "Оттенок (Hue):",
                Left = 20,
                Top = 20,
                Width = 120
            };

            trackBarHue = new TrackBar
            {
                Left = 20,
                Top = 45,
                Width = 300,
                Minimum = -180,
                Maximum = 180,
                Value = 0,
                TickFrequency = 30
            };

            labelHueValue = new Label
            {
                Text = "0°",
                Left = 330,
                Top = 50,
                Width = 50
            };

            trackBarHue.ValueChanged += (s, e) =>
            {
                labelHueValue.Text = $"{trackBarHue.Value}°";
            };

            // Saturation (Насыщенность)
            var labelSaturation = new Label
            {
                Text = "Насыщенность (Saturation):",
                Left = 20,
                Top = 90,
                Width = 200
            };

            trackBarSaturation = new TrackBar
            {
                Left = 20,
                Top = 115,
                Width = 300,
                Minimum = -100,
                Maximum = 100,
                Value = 0,
                TickFrequency = 20
            };

            labelSaturationValue = new Label
            {
                Text = "0%",
                Left = 330,
                Top = 120,
                Width = 50
            };

            trackBarSaturation.ValueChanged += (s, e) =>
            {
                labelSaturationValue.Text = $"{trackBarSaturation.Value}%";
            };

            // Value (Яркость)
            var labelValue = new Label
            {
                Text = "Яркость (Value):",
                Left = 20,
                Top = 160,
                Width = 120
            };

            trackBarValue = new TrackBar
            {
                Left = 20,
                Top = 185,
                Width = 300,
                Minimum = -100,
                Maximum = 100,
                Value = 0,
                TickFrequency = 20
            };

            labelValueValue = new Label
            {
                Text = "0%",
                Left = 330,
                Top = 190,
                Width = 50
            };

            trackBarValue.ValueChanged += (s, e) =>
            {
                labelValueValue.Text = $"{trackBarValue.Value}%";
            };

            // Кнопки
            btnReset = new Button
            {
                Text = "Сброс",
                Left = 20,
                Top = 230,
                Width = 80
            };
            btnReset.Click += (s, e) =>
            {
                trackBarHue.Value = 0;
                trackBarSaturation.Value = 0;
                trackBarValue.Value = 0;
            };

            btnOk = new Button
            {
                Text = "OK",
                Left = 200,
                Top = 230,
                Width = 80,
                DialogResult = DialogResult.OK
            };

            btnCancel = new Button
            {
                Text = "Отмена",
                Left = 290,
                Top = 230,
                Width = 80,
                DialogResult = DialogResult.Cancel
            };

            AcceptButton = btnOk;
            CancelButton = btnCancel;

            Controls.AddRange(new Control[]
            {
                labelHue, trackBarHue, labelHueValue,
                labelSaturation, trackBarSaturation, labelSaturationValue,
                labelValue, trackBarValue, labelValueValue,
                btnReset, btnOk, btnCancel
            });

            btnOk.Click += (s, e) =>
            {
                HueShift = trackBarHue.Value;
                SaturationShift = trackBarSaturation.Value;
                ValueShift = trackBarValue.Value;
            };
        }
    }
}
