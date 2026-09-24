namespace lab2_project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxTasks;
        private System.Windows.Forms.Label labelTaskSelect;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxResult1;
        private System.Windows.Forms.PictureBox pictureBoxResult2;
        private System.Windows.Forms.PictureBox pictureBoxResult3;
        private System.Windows.Forms.Panel panelHistogram1;
        private System.Windows.Forms.Panel panelHistogram2;
        private System.Windows.Forms.Panel panelHistogram3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelResult1;
        private System.Windows.Forms.Label labelResult2;
        private System.Windows.Forms.Label labelResult3;
        private System.Windows.Forms.Panel panelHsvControls;
        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.TrackBar trackBarValue;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.Label labelSaturation;
        private System.Windows.Forms.Label labelValueHsv;
        private System.Windows.Forms.Label labelHueValue;
        private System.Windows.Forms.Label labelSaturationValue;
        private System.Windows.Forms.Label labelValueHsvValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            comboBoxTasks = new System.Windows.Forms.ComboBox();
            labelTaskSelect = new System.Windows.Forms.Label();
            labelDescription = new System.Windows.Forms.Label();
            pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            pictureBoxResult1 = new System.Windows.Forms.PictureBox();
            pictureBoxResult2 = new System.Windows.Forms.PictureBox();
            pictureBoxResult3 = new System.Windows.Forms.PictureBox();
            panelHistogram1 = new System.Windows.Forms.Panel();
            panelHistogram2 = new System.Windows.Forms.Panel();
            panelHistogram3 = new System.Windows.Forms.Panel();
            btnOpen = new System.Windows.Forms.Button();
            btnProcess = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            labelOriginal = new System.Windows.Forms.Label();
            labelResult1 = new System.Windows.Forms.Label();
            labelResult2 = new System.Windows.Forms.Label();
            labelResult3 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult3).BeginInit();
            SuspendLayout();

            // labelTaskSelect
            labelTaskSelect.AutoSize = true;
            labelTaskSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            labelTaskSelect.Location = new System.Drawing.Point(12, 12);
            labelTaskSelect.Name = "labelTaskSelect";
            labelTaskSelect.Size = new System.Drawing.Size(120, 19);
            labelTaskSelect.TabIndex = 0;
            labelTaskSelect.Text = "Выбор задания:";

            // comboBoxTasks
            comboBoxTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxTasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            comboBoxTasks.FormattingEnabled = true;
            comboBoxTasks.Location = new System.Drawing.Point(140, 10);
            comboBoxTasks.Name = "comboBoxTasks";
            comboBoxTasks.Size = new System.Drawing.Size(200, 23);
            comboBoxTasks.TabIndex = 1;
            comboBoxTasks.SelectedIndexChanged += ComboBoxTasks_SelectedIndexChanged;

            // labelDescription
            labelDescription.AutoSize = true;
            labelDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            labelDescription.ForeColor = System.Drawing.Color.DarkSlateGray;
            labelDescription.Location = new System.Drawing.Point(350, 13);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(0, 15);
            labelDescription.TabIndex = 2;

            // labelOriginal
            labelOriginal.AutoSize = true;
            labelOriginal.Location = new System.Drawing.Point(12, 45);
            labelOriginal.Name = "labelOriginal";
            labelOriginal.Size = new System.Drawing.Size(135, 15);
            labelOriginal.TabIndex = 3;
            labelOriginal.Text = "Исходное изображение";

            // pictureBoxOriginal
            pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxOriginal.Location = new System.Drawing.Point(12, 65);
            pictureBoxOriginal.Name = "pictureBoxOriginal";
            pictureBoxOriginal.Size = new System.Drawing.Size(280, 210);
            pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxOriginal.TabIndex = 4;
            pictureBoxOriginal.TabStop = false;

            // labelResult1
            labelResult1.AutoSize = true;
            labelResult1.Location = new System.Drawing.Point(308, 45);
            labelResult1.Name = "labelResult1";
            labelResult1.Size = new System.Drawing.Size(0, 15);
            labelResult1.TabIndex = 5;

            // pictureBoxResult1
            pictureBoxResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxResult1.Location = new System.Drawing.Point(308, 65);
            pictureBoxResult1.Name = "pictureBoxResult1";
            pictureBoxResult1.Size = new System.Drawing.Size(280, 210);
            pictureBoxResult1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxResult1.TabIndex = 6;
            pictureBoxResult1.TabStop = false;

            // labelResult2
            labelResult2.AutoSize = true;
            labelResult2.Location = new System.Drawing.Point(604, 45);
            labelResult2.Name = "labelResult2";
            labelResult2.Size = new System.Drawing.Size(0, 15);
            labelResult2.TabIndex = 7;

            // pictureBoxResult2
            pictureBoxResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxResult2.Location = new System.Drawing.Point(604, 65);
            pictureBoxResult2.Name = "pictureBoxResult2";
            pictureBoxResult2.Size = new System.Drawing.Size(280, 210);
            pictureBoxResult2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxResult2.TabIndex = 8;
            pictureBoxResult2.TabStop = false;

            // labelResult3
            labelResult3.AutoSize = true;
            labelResult3.Location = new System.Drawing.Point(900, 45);
            labelResult3.Name = "labelResult3";
            labelResult3.Size = new System.Drawing.Size(0, 15);
            labelResult3.TabIndex = 9;

            // pictureBoxResult3
            pictureBoxResult3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxResult3.Location = new System.Drawing.Point(900, 65);
            pictureBoxResult3.Name = "pictureBoxResult3";
            pictureBoxResult3.Size = new System.Drawing.Size(280, 210);
            pictureBoxResult3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxResult3.TabIndex = 10;
            pictureBoxResult3.TabStop = false;

            // panelHistogram1
            panelHistogram1.BackColor = System.Drawing.Color.White;
            panelHistogram1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelHistogram1.Location = new System.Drawing.Point(12, 310);
            panelHistogram1.Name = "panelHistogram1";
            panelHistogram1.Size = new System.Drawing.Size(380, 200);
            panelHistogram1.TabIndex = 11;
            panelHistogram1.Paint += PanelHistogram1_Paint;

            // panelHistogram2
            panelHistogram2.BackColor = System.Drawing.Color.White;
            panelHistogram2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelHistogram2.Location = new System.Drawing.Point(408, 310);
            panelHistogram2.Name = "panelHistogram2";
            panelHistogram2.Size = new System.Drawing.Size(380, 200);
            panelHistogram2.TabIndex = 12;
            panelHistogram2.Paint += PanelHistogram2_Paint;

            // panelHistogram3
            panelHistogram3.BackColor = System.Drawing.Color.White;
            panelHistogram3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelHistogram3.Location = new System.Drawing.Point(804, 310);
            panelHistogram3.Name = "panelHistogram3";
            panelHistogram3.Size = new System.Drawing.Size(380, 200);
            panelHistogram3.TabIndex = 13;
            panelHistogram3.Paint += PanelHistogram3_Paint;

            // btnOpen
            btnOpen.Location = new System.Drawing.Point(12, 530);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(140, 40);
            btnOpen.TabIndex = 14;
            btnOpen.Text = "Открыть";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += BtnOpen_Click;

            // btnProcess
            btnProcess.Location = new System.Drawing.Point(168, 530);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new System.Drawing.Size(140, 40);
            btnProcess.TabIndex = 15;
            btnProcess.Text = "Обработать";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += BtnProcess_Click;

            // btnSave
            btnSave.Location = new System.Drawing.Point(324, 530);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(140, 40);
            btnSave.TabIndex = 16;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;

            // openFileDialog1
            openFileDialog1.Filter = "Изображения|*.bmp;*.jpg;*.jpeg;*.png;*.gif|Все файлы|*.*";

            // saveFileDialog1
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.Filter = "PNG изображение|*.png|BMP изображение|*.bmp|JPEG изображение|*.jpg";

            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 585);
            Controls.Add(btnSave);
            Controls.Add(btnProcess);
            Controls.Add(btnOpen);
            Controls.Add(panelHistogram3);
            Controls.Add(panelHistogram2);
            Controls.Add(panelHistogram1);
            Controls.Add(pictureBoxResult3);
            Controls.Add(labelResult3);
            Controls.Add(pictureBoxResult2);
            Controls.Add(labelResult2);
            Controls.Add(pictureBoxResult1);
            Controls.Add(labelResult1);
            Controls.Add(pictureBoxOriginal);
            Controls.Add(labelOriginal);
            Controls.Add(labelDescription);
            Controls.Add(comboBoxTasks);
            Controls.Add(labelTaskSelect);
            Name = "Form1";
            Text = "Лабораторная работа 2 - Обработка изображений";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
