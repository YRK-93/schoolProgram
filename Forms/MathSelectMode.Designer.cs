﻿namespace SHKOLA
{
    partial class MathSelectMode
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPlusExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(337, 47);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "Plus training";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlusExam
            // 
            this.btnPlusExam.Location = new System.Drawing.Point(337, 76);
            this.btnPlusExam.Name = "btnPlusExam";
            this.btnPlusExam.Size = new System.Drawing.Size(75, 23);
            this.btnPlusExam.TabIndex = 2;
            this.btnPlusExam.Text = "Plus exam";
            this.btnPlusExam.UseVisualStyleBackColor = true;
            this.btnPlusExam.Click += new System.EventHandler(this.btnPlusExam_Click);
            // 
            // MathSelectMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SHKOLA.Properties.Resources.mathModeBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 581);
            this.Controls.Add(this.btnPlusExam);
            this.Controls.Add(this.btnPlus);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MathSelectMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathSelectMode";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MathSelectMode_Load);
            this.Resize += new System.EventHandler(this.MathSelectMode_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPlusExam;
    }
}