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
            controlsList.Add(new ButtonControl(ref this.button1, 0.2f, 0.3f, 0.4f, 0.16f, Resources.btnMathG, this));
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
    }
}
