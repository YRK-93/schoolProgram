using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHKOLA.Properties;

namespace SHKOLA
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            LoadCurrentOptions();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            btnCancel.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSaveOptionsClicked();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadCurrentOptions()
        {
            checkBoxSound.Checked = Settings.Default.SoundEnabled;
            numericExamQuestionsCount.Value = Settings.Default.MathExamQuestionsCount;
            numericMaxPlusValue.Value = Settings.Default.MathMaxOperandValue;
            numericMaxPlusResult.Value = Settings.Default.MathMaxResultValue;
            SetMultTableValues(Settings.Default.MathMultTableUse);
            if (Settings.Default.AppLanguage == "ru")
                comboBox1.SelectedIndex = 0;
            else
                comboBox1.SelectedIndex = 1;
        }

        void SetMultTableValues(string values)
        {
            checkBox1.Checked = values.Contains('1');
            checkBox2.Checked = values.Contains('2');
            checkBox3.Checked = values.Contains('3');
            checkBox4.Checked = values.Contains('4');
            checkBox5.Checked = values.Contains('5');
            checkBox6.Checked = values.Contains('6');
            checkBox7.Checked = values.Contains('7');
            checkBox8.Checked = values.Contains('8');
            checkBox9.Checked = values.Contains('9');
        }

        string GetMultTableValues()
        {
            string resStr = "";

            resStr = checkBox1.Checked ? resStr + '1' : resStr;
            resStr = checkBox2.Checked ? resStr + '2' : resStr;
            resStr = checkBox3.Checked ? resStr + '3' : resStr;
            resStr = checkBox4.Checked ? resStr + '4' : resStr;
            resStr = checkBox5.Checked ? resStr + '5' : resStr;
            resStr = checkBox6.Checked ? resStr + '6' : resStr;
            resStr = checkBox7.Checked ? resStr + '7' : resStr;
            resStr = checkBox8.Checked ? resStr + '8' : resStr;
            resStr = checkBox9.Checked ? resStr + '9' : resStr;

            return resStr;
        }

        void ShowWarning(string str)
        {
            MessageBox.Show(null, str + " Исправьте значения чтобы продолжить сохранение...", "Некорректные значения", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        bool valuesCorrect()
        {
            if (numericMaxPlusValue.Value > numericMaxPlusResult.Value)
            {
                ShowWarning("Значение слагаемого не должно быть больше значения суммы.");
                return false;
            }

            int possibleVariantsCount = (int)((numericMaxPlusValue.Value + 1) * (numericMaxPlusValue.Value + 1));
            if (possibleVariantsCount < numericExamQuestionsCount.Value)
            {
                string msg = "При текущем значении слагаемого (" + numericMaxPlusValue.Value.ToString();
                msg += ") не удастся сформировать указанное количество уникальных примеров для контрольной.";
                msg += " Рекомендуется установить значение " + possibleVariantsCount + ".";
                ShowWarning(msg);
                return false;
            }

            if (string.IsNullOrEmpty(GetMultTableValues()))
            {
                ShowWarning("Должно быть выбрано хотябы одно значения для талицы умножения.");
                return false;
            }

            return true;
        }

        string GetSelectedLanguage()
        {
            if (comboBox1.SelectedIndex == 0)
                return "ru";

            if (comboBox1.SelectedIndex == 0)
                return "by";
            return "by";
        }

        void OnSaveOptionsClicked()
        {
            if (valuesCorrect())
            {
                Settings.Default.SoundEnabled = checkBoxSound.Checked;
                Settings.Default.AppLanguage = GetSelectedLanguage();
                Settings.Default.MathExamQuestionsCount = Convert.ToUInt32(numericExamQuestionsCount.Value);
                Settings.Default.MathMaxOperandValue  = Convert.ToUInt32(numericMaxPlusValue.Value);
                Settings.Default.MathMaxResultValue = Convert.ToUInt32(numericMaxPlusResult.Value);
                Settings.Default.MathMultTableUse = GetMultTableValues();

                Settings.Default.Save();
                this.Close();
            }

        }
    }
}
