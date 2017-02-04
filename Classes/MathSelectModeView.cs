using System.Collections.Generic;
using SHKOLA.Properties;
using System.Drawing;

namespace SHKOLA
{
    public enum MathWindowMode
    {
        mmPlusMinusTraining,
        mmPlusMinusExam,
        mmMultiplyTraining,
        mmMultiplyExam
    }

    public partial class MathSelectMode
    {
        List<WinElement> controlsList;

        public MathSelectMode()
        {
            InitializeComponent();

            // Initialization
            btnPlus.ForeColor = Color.White;
            btnPlusExam.ForeColor = Color.White;
            btnMulExam.ForeColor = Color.White;
            btnMulTraining.ForeColor = Color.White;
            Font fnt = new Font("Arial", 45.0f, FontStyle.Bold);

            string plusTrainStr = (Settings.Default.AppLanguage == "ru") ? Resources.mathModePlusTrainRU : Resources.mathModePlusTrainBY;
            string plusExamStr = (Settings.Default.AppLanguage == "ru") ? Resources.mathModePlusExamRU : Resources.mathModePlusExamBY;
            string mulTrainStr = (Settings.Default.AppLanguage == "ru") ? Resources.mathModeMulTrainRU : Resources.mathModeMulTrainBY;
            string mulExamStr = (Settings.Default.AppLanguage == "ru") ? Resources.mathModeMulExamRU : Resources.mathModeMulExamBY;

            controlsList = new List<WinElement>();
            controlsList.Add(new ButtonControl(ref this.btnBack, AppConstants.topButtonMarginKoef, AppConstants.topButtonMarginKoef, 0.1f, 0.12f, Resources.btnBack, this));
            controlsList.Add(new ButtonControl(ref this.btnPlus, 0.2f, 0.2f, 0.6f, 0.1f, Resources.plusG, this, plusTrainStr, fnt));
            controlsList.Add(new ButtonControl(ref this.btnPlusExam, 0.3f, 0.2f, 0.6f, 0.1f, Resources.plusG, this, plusExamStr, fnt));
            controlsList.Add(new ButtonControl(ref this.btnMulTraining, 0.4f, 0.2f, 0.6f, 0.1f, Resources.plusG, this, mulTrainStr, fnt));
            controlsList.Add(new ButtonControl(ref this.btnMulExam, 0.5f, 0.2f, 0.6f, 0.1f, Resources.plusG, this, mulExamStr, fnt));
        }

        public void Actualize()
        {
            if (controlsList != null)
                foreach (WinElement wElem in controlsList)
                    wElem.OnUpdate(this);
        }

        public void OnMathModeSelected(MathWindowMode mm)
        {
            this.Hide();
            var mathForm = new MathPlus(mm);
            mathForm.ShowDialog();
            mathForm.Dispose();
            this.Show();
        }

        private void OnBackButtonClicked()
        {
            this.Close();
        }
    }
}
