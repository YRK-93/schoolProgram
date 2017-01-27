using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHKOLA
{
    public enum MathWindowMode
    {
        mmPlusMinusTraining,
        mmPlusMinusExam
    }
    class MathSelectModeView : BaseView
    {
        public static void OnMathPlusClicked(MathWindowMode mm)
        {
            var mathForm = new MathPlus(mm);
            mathForm.ShowDialog();
            mathForm.Dispose();
        }

    }
}
