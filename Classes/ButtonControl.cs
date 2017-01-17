using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SHKOLA
{
    class ButtonControl : WinElement
    {
        string backImageName;
        string onSelectImageName;
        string caption;
        Form btnParent;

        public ButtonControl()
        {}

        public ButtonControl(ref Button controlFounder, float topR, float leftR, float widthR, float heightR, string backImg, Form parentForControl = null, string selectImg = "", string name = "")
        {
            btnParent = parentForControl;
            baseCtrl = controlFounder;
            topRatio = topR;
            leftRatio = leftR;
            widthRatio = widthR;
            heightRatio = heightR;
            backImageName = backImg;
            onSelectImageName = selectImg;
            caption = name;
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
            btn.BackgroundImage = ImagesStore.GetImage(backImageName);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Text = caption;
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
