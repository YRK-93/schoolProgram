using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHKOLA.Properties;

namespace SHKOLA
{
    public partial class MainForm
    {
        List<WinElement> controlsList;

        public MainForm()
        {
            InitializeComponent();

            // Initialization
            controlsList = new List<WinElement>();
            controlsList.Add(new ButtonControl(ref this.btnMath, 0.2f, 0.3f, 0.4f, 0.16f, Resources.btnMathG, this));
            controlsList.Add(new ButtonControl(ref this.btnOptions, 0.81f, 0.5f, 0.08f, -1.0f, Resources.btnSettings, this));
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
        }

        public void OnOptionsCliked()
        {
            var winOptions = new Options();
            winOptions.ShowDialog();
        }
    }
}
