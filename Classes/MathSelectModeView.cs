using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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

            controlsList = new List<WinElement>();
            controlsList.Add(new ButtonControl(ref this.btnPlus, 0.2f, 0.2f, 0.6f, 0.1f, Resources.plusG, this, "Тренировка на тему сложение", fnt));
            controlsList.Add(new ButtonControl(ref this.btnPlusExam, 0.3f, 0.2f, 0.6f, 0.1f, Resources.plusG, this, "Контроль на тему сложение", fnt));
            controlsList.Add(new ButtonControl(ref this.btnMulTraining, 0.4f, 0.2f, 0.6f, 0.1f, Resources.plusG, this, "Тренировка табл. умножения", fnt));
            controlsList.Add(new ButtonControl(ref this.btnMulExam, 0.5f, 0.2f, 0.6f, 0.1f, Resources.plusG, this, "Контроль таблица умножения", fnt));
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

    }
}
