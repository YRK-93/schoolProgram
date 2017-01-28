using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using SHKOLA.Properties;

namespace SHKOLA
{
    class ResultMessage : WinElement
    {
        ButtonControl btn;

        public ResultMessage(ref Button baseBtn, float topR, float leftR, float widthR, float heightR, Form parentForControl = null)
        {
            baseCtrl = baseBtn;
            topRatio = topR;
            leftRatio = leftR;
            widthRatio = widthR;
            heightRatio = heightR;
            btn = new ButtonControl(ref baseBtn, topR, leftR, widthR, heightR, Resources.resMsgGr, parentForControl);
            baseCtrl.Hide();
        }

        public override void SetRightStyle()
        {
            baseCtrl.Hide();
            baseCtrl.Font = new Font("Arial", 70.0f, FontStyle.Bold);
            baseCtrl.ForeColor = Color.White;
        }

        public override void OnUpdate(Form updForm)
        {
            baseCtrl.Top = (topRatio < 1.0f) ? (int)(updForm.Height * topRatio) : Convert.ToInt32(topRatio);
            baseCtrl.Height = (heightRatio < 1.0f) ? (int)(updForm.Height * heightRatio) : Convert.ToInt32(heightRatio);
            baseCtrl.Width = (widthRatio < 1.0f) ? (int)(updForm.Width * widthRatio) : Convert.ToInt32(widthRatio);
            baseCtrl.Left = (int)((updForm.Width - baseCtrl.Width) * 0.5f);
        }

        public void ShowRight()
        {
            Answer(true);
        }

        public void ShowWrong()
        {
            Answer(false);
        }

        private void Answer(bool isRight)
        {
            var snd = isRight ? System.Media.SystemSounds.Asterisk : System.Media.SystemSounds.Hand;
            baseCtrl.Text = isRight ? "ПРАВИЛЬНО" : "НЕПРАВИЛЬНО";
            baseCtrl.BackgroundImage = isRight ? Resources.resMsgGr : Resources.resMsgRd;
 
            SetRightStyle();
            OnUpdate((Form)baseCtrl.Parent);
            baseCtrl.Show();
            baseCtrl.Update();

            if (Settings.Default.SoundEnabled)
                snd.Play();

            Thread.Sleep(600);
            baseCtrl.Hide();
        }
    }
}
