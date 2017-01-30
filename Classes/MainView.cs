using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHKOLA.Properties;
using System.Drawing;

namespace SHKOLA
{
    public partial class MainForm
    {
        List<WinElement> controlsList;

        public MainForm()
        {
            InitializeComponent();

            // Initialization
            Font fnt = new Font("Arial", 45.0f, FontStyle.Bold);
            btnMath.ForeColor = Color.White;
            string mathStr = (Settings.Default.AppLanguage == "ru") ? Resources.mathRU : Resources.mathBY;
            controlsList = new List<WinElement>();
            controlsList.Add(new ButtonControl(ref this.btnMath, 0.2f, 0.3f, 600.0f, 80.0f, Resources.plusG, this, mathStr, fnt));
            controlsList.Add(new ButtonControl(ref this.btnOptions, 0.81f, 0.5f, 120.0f, -1.0f, Resources.btnSettings, this));
        }

        public void Actualize()
        {
            if (controlsList != null)
                foreach (WinElement wElem in controlsList)
                    wElem.OnUpdate(this);
        }

        public void OnMathClicked()
        {
            this.Hide();
            var mathForm = new MathSelectMode();
            mathForm.ShowDialog();
            this.Show();
            this.BringToFront();
        }

        public void OnOptionsCliked()
        {
            var winOptions = new Options();
            var dResult = winOptions.ShowDialog();

            this.btnMath.Text = (Settings.Default.AppLanguage == "ru") ? Resources.mathRU : Resources.mathBY;
            this.btnMath.Update();
        }
    }
}
