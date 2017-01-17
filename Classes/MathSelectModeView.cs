using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHKOLA
{
    class MathSelectModeView : BaseView
    {
        public static void OnMathPlusClicked()
        {
            var mathForm = new MathPlus();
            mathForm.ShowDialog();
            mathForm.Dispose();
        }

    }
}
