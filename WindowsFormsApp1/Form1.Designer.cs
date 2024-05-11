namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bPause = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.DensityNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ResolutionNud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.Controls.Add(this.bPause);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.DensityNud);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.ResolutionNud);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(970, 497);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 0;
            // 
            // bPause
            // 
            this.bPause.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPause.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPause.Location = new System.Drawing.Point(22, 210);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(120, 36);
            this.bPause.TabIndex = 5;
            this.bPause.Text = "стоп";
            this.bPause.UseVisualStyleBackColor = false;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStart.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(22, 168);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(120, 36);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Заразить";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // DensityNud
            // 
            this.DensityNud.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DensityNud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DensityNud.Location = new System.Drawing.Point(22, 89);
            this.DensityNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DensityNud.Name = "DensityNud";
            this.DensityNud.Size = new System.Drawing.Size(120, 20);
            this.DensityNud.TabIndex = 3;
            this.DensityNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DensityNud.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Density";
            // 
            // ResolutionNud
            // 
            this.ResolutionNud.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ResolutionNud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResolutionNud.Location = new System.Drawing.Point(22, 34);
            this.ResolutionNud.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ResolutionNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ResolutionNud.Name = "ResolutionNud";
            this.ResolutionNud.Size = new System.Drawing.Size(120, 20);
            this.ResolutionNud.TabIndex = 1;
            this.ResolutionNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResolutionNud.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 493);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(970, 497);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Симулятор Вируса";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DensityNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown ResolutionNud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown DensityNud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Timer timer1;
    }
}

