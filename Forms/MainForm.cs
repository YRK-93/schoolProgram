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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<PicButton> btnsList;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form settings
            MainForm mf = (MainForm)sender;
            mf.CenterToScreen();
            mf.FormBorderStyle = FormBorderStyle.FixedSingle;

            // images loading
            Initializator.LoadImages();

            // Background settings
            picBackground.Image = ImagesStore.GetImage("main_background");
            picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            Initializator.FitBackgroundImageToWindowSize(sender, picBackground);

            // buttons settings
            btnsList = new List<PicButton>();
            btnsList.Add(new PicButton(ref button1, PicButtonName.pbMath, "main_math_button_g", "main_math_button_y"));
            foreach (PicButton pBtn in btnsList)
                UpdateButtonSizeLocation((MainForm)sender, pBtn);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Initializator.FitBackgroundImageToWindowSize(sender, picBackground);

            foreach (PicButton pBtn in btnsList)
                UpdateButtonSizeLocation((MainForm)sender, pBtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mathForm = new MathSelectMode(this.Top, this.Left, this.Width, this.Height);
            mathForm.ShowDialog();
            this.Show();
        }

        private void UpdateButtonSizeLocation(Form win, PicButton btn)
        {
            int marginTop = (int)(win.Height * 0.2);
            //int marginBot = 100;

            switch (btn.bName)
            {
                case PicButtonName.pbMath:
                    {
                        btn.pButton.Width = (int)(win.Width * 0.4);
                        btn.pButton.Height = (int)(win.Height * 0.16);

                        btn.pButton.Top = (int)(marginTop + (/*numberFromTop*/1 - 1) * btn.pButton.Height);
                        btn.pButton.Left = (int)((win.Width * 0.5) - (btn.pButton.Width * 0.5));
                        break;
                    }
                case PicButtonName.pbMathModePlus:
                    break;
            }
        }
        
    }
}
