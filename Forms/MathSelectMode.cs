using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHKOLA
{
    public partial class MathSelectMode : Form
    {
        private void MathSelectMode_Load(object sender, EventArgs e)
        {
            Actualize();
            this.TopMost = false;
        }

        private void MathSelectMode_Resize(object sender, EventArgs e)
        {
            Actualize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnMathModeSelected(MathWindowMode.mmPlusMinusTraining);
        }

        private void btnPlusExam_Click(object sender, EventArgs e)
        {
            OnMathModeSelected(MathWindowMode.mmPlusMinusExam);
        }

        private void btnMulTraining_Click(object sender, EventArgs e)
        {
            OnMathModeSelected(MathWindowMode.mmMultiplyTraining);
        }

        private void btnMulExam_Click(object sender, EventArgs e)
        {
            OnMathModeSelected(MathWindowMode.mmMultiplyExam);
        }
    }
}
