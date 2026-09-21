namespace lab2_project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxGray1;
        private System.Windows.Forms.PictureBox pictureBoxGray2;
        private System.Windows.Forms.PictureBox pictureBoxDifference;
        private System.Windows.Forms.Panel panelHistogram1;
        private System.Windows.Forms.Panel panelHistogram2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelGray1;
        private System.Windows.Forms.Label labelGray2;
        private System.Windows.Forms.Label labelDifference;
        private System.Windows.Forms.Label labelHistogram1;
        private System.Windows.Forms.Label labelHistogram2;

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
            pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            pictureBoxGray1 = new System.Windows.Forms.PictureBox();
            pictureBoxGray2 = new System.Windows.Forms.PictureBox();
            pictureBoxDifference = new System.Windows.Forms.PictureBox();
            panelHistogram1 = new System.Windows.Forms.Panel();
            panelHistogram2 = new System.Windows.Forms.Panel();
            btnOpen = new System.Windows.Forms.Button();
            btnProcess = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            labelOriginal = new System.Windows.Forms.Label();
            labelGray1 = new System.Windows.Forms.Label();
            labelGray2 = new System.Windows.Forms.Label();
            labelDifference = new System.Windows.Forms.Label();
            labelHistogram1 = new System.Windows.Forms.Label();
            labelHistogram2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDifference).BeginInit();
            SuspendLayout();
            pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxOriginal.Location = new System.Drawing.Point(12, 36);
            pictureBoxOriginal.Name = "pictureBoxOriginal";
            pictureBoxOriginal.Size = new System.Drawing.Size(280, 210);
            pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxOriginal.TabIndex = 0;
            pictureBoxOriginal.TabStop = false;
            pictureBoxGray1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxGray1.Location = new System.Drawing.Point(308, 36);
            pictureBoxGray1.Name = "pictureBoxGray1";
            pictureBoxGray1.Size = new System.Drawing.Size(280, 210);
            pictureBoxGray1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxGray1.TabIndex = 1;
            pictureBoxGray1.TabStop = false;
            pictureBoxGray2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxGray2.Location = new System.Drawing.Point(604, 36);
            pictureBoxGray2.Name = "pictureBoxGray2";
            pictureBoxGray2.Size = new System.Drawing.Size(280, 210);
            pictureBoxGray2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxGray2.TabIndex = 2;
            pictureBoxGray2.TabStop = false;
            pictureBoxDifference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxDifference.Location = new System.Drawing.Point(900, 36);
            pictureBoxDifference.Name = "pictureBoxDifference";
            pictureBoxDifference.Size = new System.Drawing.Size(280, 210);
            pictureBoxDifference.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxDifference.TabIndex = 3;
            pictureBoxDifference.TabStop = false;
            panelHistogram1.BackColor = System.Drawing.Color.White;
            panelHistogram1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelHistogram1.Location = new System.Drawing.Point(12, 300);
            panelHistogram1.Name = "panelHistogram1";
            panelHistogram1.Size = new System.Drawing.Size(568, 220);
            panelHistogram1.TabIndex = 4;
            panelHistogram1.Paint += Panel1_Paint;
            panelHistogram2.BackColor = System.Drawing.Color.White;
            panelHistogram2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelHistogram2.Location = new System.Drawing.Point(604, 300);
            panelHistogram2.Name = "panelHistogram2";
            panelHistogram2.Size = new System.Drawing.Size(576, 220);
            panelHistogram2.TabIndex = 5;
            panelHistogram2.Paint += Panel2_Paint;
            btnOpen.Location = new System.Drawing.Point(12, 555);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(120, 35);
            btnOpen.TabIndex = 6;
            btnOpen.Text = "Открыть";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += BtnOpen_Click;
            btnProcess.Location = new System.Drawing.Point(144, 555);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new System.Drawing.Size(120, 35);
            btnProcess.TabIndex = 7;
            btnProcess.Text = "Обработать";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += BtnProcess_Click;
            btnSave.Location = new System.Drawing.Point(276, 555);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(120, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            openFileDialog1.Filter = "Изображения|*.bmp;*.jpg;*.jpeg;*.png;*.gif|Все файлы|*.*";
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.Filter = "PNG изображение|*.png|BMP изображение|*.bmp|JPEG изображение|*.jpg";
            labelOriginal.AutoSize = true;
            labelOriginal.Location = new System.Drawing.Point(12, 12);
            labelOriginal.Text = "Исходное изображение";
            labelGray1.AutoSize = true;
            labelGray1.Location = new System.Drawing.Point(308, 12);
            labelGray1.Text = "Формула 1";
            labelGray2.AutoSize = true;
            labelGray2.Location = new System.Drawing.Point(604, 12);
            labelGray2.Text = "Формула 2";
            labelDifference.AutoSize = true;
            labelDifference.Location = new System.Drawing.Point(900, 12);
            labelDifference.Text = "Разность";
            labelHistogram1.AutoSize = true;
            labelHistogram1.Location = new System.Drawing.Point(12, 275);
            labelHistogram1.Text = "Гистограмма формулы 1";
            labelHistogram2.AutoSize = true;
            labelHistogram2.Location = new System.Drawing.Point(604, 275);
            labelHistogram2.Text = "Гистограмма формулы 2";
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1192, 610);
            Controls.Add(labelHistogram2);
            Controls.Add(labelHistogram1);
            Controls.Add(labelDifference);
            Controls.Add(labelGray2);
            Controls.Add(labelGray1);
            Controls.Add(labelOriginal);
            Controls.Add(btnSave);
            Controls.Add(btnProcess);
            Controls.Add(btnOpen);
            Controls.Add(panelHistogram2);
            Controls.Add(panelHistogram1);
            Controls.Add(pictureBoxDifference);
            Controls.Add(pictureBoxGray2);
            Controls.Add(pictureBoxGray1);
            Controls.Add(pictureBoxOriginal);
            Name = "Form1";
            Text = "Преобразование изображения";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDifference).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}