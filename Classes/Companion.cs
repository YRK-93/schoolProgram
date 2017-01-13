using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SHKOLA
{
    enum CompanionType
    {
        ctMathPig,
        ctOther
    }

    class Companion : WinElement
    {
        Form compParent;
        CompanionType comanionType;
        List<string> statusImagesList;
        List<string> goodPhrases;
        List<string> badPhrases;
        int curStatus;

        public Companion()
        {

        }

        public Companion(Form paren, ref Button ctrl, CompanionType ctp, float topR, float leftR, float widthR, float heightR)
        {
            compParent = paren;
            baseCtrl = ctrl;
            comanionType = ctp;

            topRatio = topR;
            leftRatio = leftR;
            widthRatio = widthR;
            heightRatio = heightR;

            statusImagesList = Initializator.GetStatusesList(ctp);
            goodPhrases = Initializator.GetGoodPhrasesList(ctp);
            badPhrases = Initializator.GetBadPhrasesList(ctp);
            curStatus = 0;
        }

        public override void SetRightStyle() 
        {
            Button btn = (Button)baseCtrl;
            btn.Parent = compParent;
            btn.BackColor = Color.Transparent;
            btn.TabIndex = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.TabStop = false;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackgroundImage = ImagesStore.GetImage(statusImagesList[curStatus], Color.White);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Text = "";
        }

        private void SetStatusImage(int indx)
        {
            baseCtrl.BackgroundImage = ImagesStore.GetImage(statusImagesList[indx], Color.White);
        }

        public void Unhappy()
        {
            if (curStatus < (statusImagesList.Count - 1)) // The higher curStatus value, more sad companion will be
            {
                curStatus++;
                SetStatusImage(curStatus);
            }
        }

        public void Happy()
        {
            if (curStatus > 0) // The lower --> the happier
            {
                curStatus--;
                SetStatusImage(curStatus);
            }
        }

    }
}
