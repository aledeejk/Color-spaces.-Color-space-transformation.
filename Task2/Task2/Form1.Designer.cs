namespace Task2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.gbRed = new System.Windows.Forms.GroupBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.gbGreen = new System.Windows.Forms.GroupBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.gbBlue = new System.Windows.Forms.GroupBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.gbHistR = new System.Windows.Forms.GroupBox();
            this.pbHistR = new System.Windows.Forms.PictureBox();
            this.gbHistG = new System.Windows.Forms.GroupBox();
            this.pbHistG = new System.Windows.Forms.PictureBox();
            this.gbHistB = new System.Windows.Forms.GroupBox();
            this.pbHistB = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.gbOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            this.gbRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            this.gbGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            this.gbBlue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            this.gbHistR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistR)).BeginInit();
            this.gbHistG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistG)).BeginInit();
            this.gbHistB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistB)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.Controls.Add(this.gbHistB, 2, 1);
            this.tableLayout.Controls.Add(this.gbHistG, 1, 1);
            this.tableLayout.Controls.Add(this.gbHistR, 0, 1);
            this.tableLayout.Controls.Add(this.gbBlue, 3, 0);
            this.tableLayout.Controls.Add(this.gbGreen, 2, 0);
            this.tableLayout.Controls.Add(this.gbRed, 1, 0);
            this.tableLayout.Controls.Add(this.gbOriginal, 0, 0);
            this.tableLayout.Controls.Add(this.btnLoad, 1, 2);
            this.tableLayout.Controls.Add(this.btnProcess, 2, 2);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayout.Size = new System.Drawing.Size(905, 699);
            this.tableLayout.TabIndex = 0;
            // 
            // gbOriginal
            // 
            this.gbOriginal.Controls.Add(this.pbOriginal);
            this.gbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOriginal.Location = new System.Drawing.Point(5, 20);
            this.gbOriginal.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(216, 272);
            this.gbOriginal.TabIndex = 0;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Оригинал";
            // 
            // pbOriginal
            // 
            this.pbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOriginal.Location = new System.Drawing.Point(3, 18);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(210, 251);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 0;
            this.pbOriginal.TabStop = false;
            // 
            // gbRed
            // 
            this.gbRed.Controls.Add(this.pbRed);
            this.gbRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRed.Location = new System.Drawing.Point(231, 20);
            this.gbRed.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.gbRed.Name = "gbRed";
            this.gbRed.Size = new System.Drawing.Size(216, 272);
            this.gbRed.TabIndex = 1;
            this.gbRed.TabStop = false;
            this.gbRed.Text = "Red";
            // 
            // pbRed
            // 
            this.pbRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRed.Location = new System.Drawing.Point(3, 18);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(210, 251);
            this.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRed.TabIndex = 0;
            this.pbRed.TabStop = false;
            // 
            // gbGreen
            // 
            this.gbGreen.Controls.Add(this.pbGreen);
            this.gbGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGreen.Location = new System.Drawing.Point(457, 20);
            this.gbGreen.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.gbGreen.Name = "gbGreen";
            this.gbGreen.Size = new System.Drawing.Size(216, 272);
            this.gbGreen.TabIndex = 2;
            this.gbGreen.TabStop = false;
            this.gbGreen.Text = "Green";
            // 
            // pbGreen
            // 
            this.pbGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGreen.Location = new System.Drawing.Point(3, 18);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(210, 251);
            this.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGreen.TabIndex = 0;
            this.pbGreen.TabStop = false;
            // 
            // gbBlue
            // 
            this.gbBlue.Controls.Add(this.pbBlue);
            this.gbBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbBlue.Location = new System.Drawing.Point(683, 20);
            this.gbBlue.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.gbBlue.Name = "gbBlue";
            this.gbBlue.Size = new System.Drawing.Size(217, 272);
            this.gbBlue.TabIndex = 3;
            this.gbBlue.TabStop = false;
            this.gbBlue.Text = "Blue";
            // 
            // pbBlue
            // 
            this.pbBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBlue.Location = new System.Drawing.Point(3, 18);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(211, 251);
            this.pbBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBlue.TabIndex = 0;
            this.pbBlue.TabStop = false;
            // 
            // gbHistR
            // 
            this.gbHistR.Controls.Add(this.pbHistR);
            this.gbHistR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHistR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbHistR.Location = new System.Drawing.Point(5, 332);
            this.gbHistR.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.gbHistR.Name = "gbHistR";
            this.gbHistR.Size = new System.Drawing.Size(216, 272);
            this.gbHistR.TabIndex = 4;
            this.gbHistR.TabStop = false;
            this.gbHistR.Text = "Гистограмма R";
            // 
            // pbHistR
            // 
            this.pbHistR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHistR.Location = new System.Drawing.Point(3, 18);
            this.pbHistR.Name = "pbHistR";
            this.pbHistR.Size = new System.Drawing.Size(210, 251);
            this.pbHistR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHistR.TabIndex = 0;
            this.pbHistR.TabStop = false;
            // 
            // gbHistG
            // 
            this.gbHistG.Controls.Add(this.pbHistG);
            this.gbHistG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHistG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbHistG.Location = new System.Drawing.Point(231, 332);
            this.gbHistG.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.gbHistG.Name = "gbHistG";
            this.gbHistG.Size = new System.Drawing.Size(216, 272);
            this.gbHistG.TabIndex = 5;
            this.gbHistG.TabStop = false;
            this.gbHistG.Text = "Гистограмма G";
            // 
            // pbHistG
            // 
            this.pbHistG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHistG.Location = new System.Drawing.Point(3, 18);
            this.pbHistG.Name = "pbHistG";
            this.pbHistG.Size = new System.Drawing.Size(210, 251);
            this.pbHistG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHistG.TabIndex = 0;
            this.pbHistG.TabStop = false;
            // 
            // gbHistB
            // 
            this.gbHistB.Controls.Add(this.pbHistB);
            this.gbHistB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHistB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbHistB.Location = new System.Drawing.Point(457, 332);
            this.gbHistB.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.gbHistB.Name = "gbHistB";
            this.gbHistB.Size = new System.Drawing.Size(216, 272);
            this.gbHistB.TabIndex = 6;
            this.gbHistB.TabStop = false;
            this.gbHistB.Text = "Гистограмма B";
            // 
            // pbHistB
            // 
            this.pbHistB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHistB.Location = new System.Drawing.Point(3, 18);
            this.pbHistB.Name = "pbHistB";
            this.pbHistB.Size = new System.Drawing.Size(210, 251);
            this.pbHistB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHistB.TabIndex = 0;
            this.pbHistB.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Location = new System.Drawing.Point(231, 644);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(216, 35);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Выбрать изображение";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcess.Location = new System.Drawing.Point(457, 644);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(216, 35);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Обработать";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 699);
            this.Controls.Add(this.tableLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayout.ResumeLayout(false);
            this.gbOriginal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            this.gbRed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            this.gbGreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            this.gbBlue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            this.gbHistR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHistR)).EndInit();
            this.gbHistG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHistG)).EndInit();
            this.gbHistB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHistB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.GroupBox gbBlue;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.GroupBox gbGreen;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.GroupBox gbRed;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.GroupBox gbHistR;
        private System.Windows.Forms.PictureBox pbHistR;
        private System.Windows.Forms.GroupBox gbHistB;
        private System.Windows.Forms.PictureBox pbHistB;
        private System.Windows.Forms.GroupBox gbHistG;
        private System.Windows.Forms.PictureBox pbHistG;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnProcess;
    }
}

