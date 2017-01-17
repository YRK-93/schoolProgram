using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHKOLA
{
    class MainView : BaseView
    {
        public static void OnMathClicked()
        {
            var mathForm = new MathSelectMode();
            mathForm.ShowDialog();
        }
    }
}
