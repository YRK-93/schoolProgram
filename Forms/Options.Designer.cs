namespace SHKOLA
{
    partial class Options
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
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabMainSettings = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.tabMathSettings = new System.Windows.Forms.TabPage();
            this.groupMultiplication = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupExcerciseNumbers = new System.Windows.Forms.GroupBox();
            this.numericMaxPlusResult = new System.Windows.Forms.NumericUpDown();
            this.labelMaxPlusExcerciseResult = new System.Windows.Forms.Label();
            this.numericMaxPlusValue = new System.Windows.Forms.NumericUpDown();
            this.labelExcerciseNumberValue = new System.Windows.Forms.Label();
            this.groupExam = new System.Windows.Forms.GroupBox();
            this.numericExamQuestionsCount = new System.Windows.Forms.NumericUpDown();
            this.labelExamQuestionsCount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabOptions.SuspendLayout();
            this.tabMainSettings.SuspendLayout();
            this.tabMathSettings.SuspendLayout();
            this.groupMultiplication.SuspendLayout();
            this.groupExcerciseNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxPlusResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxPlusValue)).BeginInit();
            this.groupExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExamQuestionsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tabMainSettings);
            this.tabOptions.Controls.Add(this.tabMathSettings);
            this.tabOptions.Location = new System.Drawing.Point(13, 13);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(808, 446);
            this.tabOptions.TabIndex = 0;
            // 
            // tabMainSettings
            // 
            this.tabMainSettings.Controls.Add(this.label1);
            this.tabMainSettings.Controls.Add(this.comboBox1);
            this.tabMainSettings.Controls.Add(this.checkBoxSound);
            this.tabMainSettings.Location = new System.Drawing.Point(4, 22);
            this.tabMainSettings.Name = "tabMainSettings";
            this.tabMainSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainSettings.Size = new System.Drawing.Size(800, 420);
            this.tabMainSettings.TabIndex = 0;
            this.tabMainSettings.Text = "Основные настройки";
            this.tabMainSettings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Язык в приложения:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Русский",
            "Беларуская"});
            this.comboBox1.Location = new System.Drawing.Point(122, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Location = new System.Drawing.Point(6, 6);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(205, 17);
            this.checkBoxSound.TabIndex = 0;
            this.checkBoxSound.Text = "Использовать звуки в приложении";
            this.checkBoxSound.UseVisualStyleBackColor = true;
            // 
            // tabMathSettings
            // 
            this.tabMathSettings.Controls.Add(this.groupMultiplication);
            this.tabMathSettings.Controls.Add(this.groupExcerciseNumbers);
            this.tabMathSettings.Controls.Add(this.groupExam);
            this.tabMathSettings.Location = new System.Drawing.Point(4, 22);
            this.tabMathSettings.Name = "tabMathSettings";
            this.tabMathSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabMathSettings.Size = new System.Drawing.Size(800, 420);
            this.tabMathSettings.TabIndex = 1;
            this.tabMathSettings.Text = "Математика";
            this.tabMathSettings.UseVisualStyleBackColor = true;
            // 
            // groupMultiplication
            // 
            this.groupMultiplication.Controls.Add(this.checkBox9);
            this.groupMultiplication.Controls.Add(this.checkBox8);
            this.groupMultiplication.Controls.Add(this.checkBox7);
            this.groupMultiplication.Controls.Add(this.checkBox6);
            this.groupMultiplication.Controls.Add(this.checkBox5);
            this.groupMultiplication.Controls.Add(this.checkBox4);
            this.groupMultiplication.Controls.Add(this.checkBox3);
            this.groupMultiplication.Controls.Add(this.checkBox2);
            this.groupMultiplication.Controls.Add(this.checkBox1);
            this.groupMultiplication.Location = new System.Drawing.Point(324, 7);
            this.groupMultiplication.Name = "groupMultiplication";
            this.groupMultiplication.Size = new System.Drawing.Size(191, 90);
            this.groupMultiplication.TabIndex = 2;
            this.groupMultiplication.TabStop = false;
            this.groupMultiplication.Text = "Настройки таблицы умножения";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(123, 67);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(49, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "9 x 9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(123, 44);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(49, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "8 x 8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(123, 20);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(49, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "7 x 7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(65, 67);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(49, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "6 x 6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(65, 44);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(49, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "5 x 5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(65, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(49, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "4 x 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(49, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "3 x 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "2 x 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "1 x 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupExcerciseNumbers
            // 
            this.groupExcerciseNumbers.Controls.Add(this.numericMaxPlusResult);
            this.groupExcerciseNumbers.Controls.Add(this.labelMaxPlusExcerciseResult);
            this.groupExcerciseNumbers.Controls.Add(this.numericMaxPlusValue);
            this.groupExcerciseNumbers.Controls.Add(this.labelExcerciseNumberValue);
            this.groupExcerciseNumbers.Location = new System.Drawing.Point(7, 63);
            this.groupExcerciseNumbers.Name = "groupExcerciseNumbers";
            this.groupExcerciseNumbers.Size = new System.Drawing.Size(305, 100);
            this.groupExcerciseNumbers.TabIndex = 1;
            this.groupExcerciseNumbers.TabStop = false;
            this.groupExcerciseNumbers.Text = "Настройка чисел в примерах на сложение и вычитание";
            // 
            // numericMaxPlusResult
            // 
            this.numericMaxPlusResult.Location = new System.Drawing.Point(209, 41);
            this.numericMaxPlusResult.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericMaxPlusResult.Name = "numericMaxPlusResult";
            this.numericMaxPlusResult.ReadOnly = true;
            this.numericMaxPlusResult.Size = new System.Drawing.Size(51, 20);
            this.numericMaxPlusResult.TabIndex = 3;
            this.numericMaxPlusResult.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelMaxPlusExcerciseResult
            // 
            this.labelMaxPlusExcerciseResult.AutoSize = true;
            this.labelMaxPlusExcerciseResult.Location = new System.Drawing.Point(6, 43);
            this.labelMaxPlusExcerciseResult.Name = "labelMaxPlusExcerciseResult";
            this.labelMaxPlusExcerciseResult.Size = new System.Drawing.Size(200, 13);
            this.labelMaxPlusExcerciseResult.TabIndex = 2;
            this.labelMaxPlusExcerciseResult.Text = "Максимальное значения результата :";
            // 
            // numericMaxPlusValue
            // 
            this.numericMaxPlusValue.Location = new System.Drawing.Point(209, 14);
            this.numericMaxPlusValue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericMaxPlusValue.Name = "numericMaxPlusValue";
            this.numericMaxPlusValue.ReadOnly = true;
            this.numericMaxPlusValue.Size = new System.Drawing.Size(51, 20);
            this.numericMaxPlusValue.TabIndex = 1;
            this.numericMaxPlusValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelExcerciseNumberValue
            // 
            this.labelExcerciseNumberValue.AutoSize = true;
            this.labelExcerciseNumberValue.Location = new System.Drawing.Point(6, 16);
            this.labelExcerciseNumberValue.Name = "labelExcerciseNumberValue";
            this.labelExcerciseNumberValue.Size = new System.Drawing.Size(200, 13);
            this.labelExcerciseNumberValue.TabIndex = 0;
            this.labelExcerciseNumberValue.Text = "Максимальное значение слагаемого:";
            // 
            // groupExam
            // 
            this.groupExam.Controls.Add(this.numericExamQuestionsCount);
            this.groupExam.Controls.Add(this.labelExamQuestionsCount);
            this.groupExam.Location = new System.Drawing.Point(4, 4);
            this.groupExam.Name = "groupExam";
            this.groupExam.Size = new System.Drawing.Size(301, 52);
            this.groupExam.TabIndex = 0;
            this.groupExam.TabStop = false;
            this.groupExam.Text = "Настройки контрольных";
            // 
            // numericExamQuestionsCount
            // 
            this.numericExamQuestionsCount.Location = new System.Drawing.Point(248, 18);
            this.numericExamQuestionsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericExamQuestionsCount.Name = "numericExamQuestionsCount";
            this.numericExamQuestionsCount.ReadOnly = true;
            this.numericExamQuestionsCount.Size = new System.Drawing.Size(47, 20);
            this.numericExamQuestionsCount.TabIndex = 1;
            this.numericExamQuestionsCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelExamQuestionsCount
            // 
            this.labelExamQuestionsCount.AutoSize = true;
            this.labelExamQuestionsCount.Location = new System.Drawing.Point(7, 20);
            this.labelExamQuestionsCount.Name = "labelExamQuestionsCount";
            this.labelExamQuestionsCount.Size = new System.Drawing.Size(235, 13);
            this.labelExamQuestionsCount.TabIndex = 0;
            this.labelExamQuestionsCount.Text = "Количество вопросов в контрольной работе:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(665, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(746, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabOptions);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.tabOptions.ResumeLayout(false);
            this.tabMainSettings.ResumeLayout(false);
            this.tabMainSettings.PerformLayout();
            this.tabMathSettings.ResumeLayout(false);
            this.groupMultiplication.ResumeLayout(false);
            this.groupMultiplication.PerformLayout();
            this.groupExcerciseNumbers.ResumeLayout(false);
            this.groupExcerciseNumbers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxPlusResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxPlusValue)).EndInit();
            this.groupExam.ResumeLayout(false);
            this.groupExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExamQuestionsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabMainSettings;
        private System.Windows.Forms.TabPage tabMathSettings;
        private System.Windows.Forms.GroupBox groupExam;
        private System.Windows.Forms.Label labelExamQuestionsCount;
        private System.Windows.Forms.NumericUpDown numericExamQuestionsCount;
        private System.Windows.Forms.GroupBox groupExcerciseNumbers;
        private System.Windows.Forms.Label labelExcerciseNumberValue;
        private System.Windows.Forms.NumericUpDown numericMaxPlusValue;
        private System.Windows.Forms.NumericUpDown numericMaxPlusResult;
        private System.Windows.Forms.Label labelMaxPlusExcerciseResult;
        private System.Windows.Forms.GroupBox groupMultiplication;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}