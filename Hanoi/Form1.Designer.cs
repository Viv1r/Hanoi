namespace Hanoi
{
    partial class Hanoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hanoi));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttonplus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonplus10 = new System.Windows.Forms.Button();
            this.buttonminus10 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Анимация";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(32, 83);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(195, 56);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Старт!";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество колец: 3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonminus
            // 
            this.buttonminus.Location = new System.Drawing.Point(194, 27);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(33, 23);
            this.buttonminus.TabIndex = 4;
            this.buttonminus.Text = "-1";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.buttonminus_Click);
            // 
            // buttonplus
            // 
            this.buttonplus.Location = new System.Drawing.Point(142, 20);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(34, 23);
            this.buttonplus.TabIndex = 4;
            this.buttonplus.Text = "+1";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buttonminus10);
            this.groupBox1.Controls.Add(this.buttonplus10);
            this.groupBox1.Controls.Add(this.buttonplus);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 176);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // buttonplus10
            // 
            this.buttonplus10.Location = new System.Drawing.Point(142, 44);
            this.buttonplus10.Name = "buttonplus10";
            this.buttonplus10.Size = new System.Drawing.Size(34, 23);
            this.buttonplus10.TabIndex = 6;
            this.buttonplus10.Text = "+10";
            this.buttonplus10.UseVisualStyleBackColor = true;
            this.buttonplus10.Click += new System.EventHandler(this.buttonplus10_Click);
            // 
            // buttonminus10
            // 
            this.buttonminus10.Location = new System.Drawing.Point(182, 44);
            this.buttonminus10.Name = "buttonminus10";
            this.buttonminus10.Size = new System.Drawing.Size(33, 23);
            this.buttonminus10.TabIndex = 6;
            this.buttonminus10.Text = "-10";
            this.buttonminus10.UseVisualStyleBackColor = true;
            this.buttonminus10.Click += new System.EventHandler(this.buttonminus10_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(195, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Hanoi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonminus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hanoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ханойские башни";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Hanoi_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Hanoi_Paint_1);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonplus10;
        private System.Windows.Forms.Button buttonminus10;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

