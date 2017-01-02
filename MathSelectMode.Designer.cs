namespace SHKOLA
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
            this.mathModeBackground = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mathModeBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // mathModeBackground
            // 
            this.mathModeBackground.Location = new System.Drawing.Point(13, 13);
            this.mathModeBackground.Name = "mathModeBackground";
            this.mathModeBackground.Size = new System.Drawing.Size(413, 276);
            this.mathModeBackground.TabIndex = 0;
            this.mathModeBackground.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MathSelectMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mathModeBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MathSelectMode";
            this.Text = "MathSelectMode";
            this.Load += new System.EventHandler(this.MathSelectMode_Load);
            this.Resize += new System.EventHandler(this.MathSelectMode_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.mathModeBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mathModeBackground;
        private System.Windows.Forms.Button button1;
    }
}