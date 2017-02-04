using System.Drawing;
using System.Windows.Forms;

namespace SHKOLA
{
    class ButtonControl : WinElement
    {
        Image backImage;
        string caption;
        Form btnParent;
        Font textFont;

        public ButtonControl()
        {}

        public ButtonControl(ref Button controlFounder, float topR, float leftR, float widthR, float heightR, Image backImg, Form parentForControl = null, string name = "", Font fnt = null)
        {
            btnParent = parentForControl;
            baseCtrl = controlFounder;
            topRatio = topR;
            leftRatio = leftR;
            widthRatio = widthR;
            heightRatio = heightR;
            backImage = backImg;
            caption = name;
            textFont = fnt;
            SetRightStyle();
        }

        public override void SetRightStyle()
        {
            Button btn = (Button)baseCtrl;

            btn.Parent = btnParent;
            btn.BackColor = Color.Transparent;
            btn.TabIndex = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.TabStop = false;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackgroundImage = backImage;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Text = caption;
            btn.Font = textFont;
        }

        public void SetLocationOnWindow(int topR, int leftR, int widthR, int heightR)
        {
            baseCtrl.Top = topR;
            baseCtrl.Left = leftR;
            baseCtrl.Width = widthR;
            baseCtrl.Height = heightR;
        }
    }
}
