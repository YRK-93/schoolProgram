using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SHKOLA
{
    enum HorizPanelAlign
    {
        hLeftAlign,
        hRightAlign,
        hCenterAlign,
        hEvenly
    }
    class HorizontalButtonsPane : WinElement
    {
        List<ButtonControl> paneButtons;
        float spaceBetweenButtons;   // If value is fractial and lower then 1, then it calculates as percent of pane height, otherwise as absolute value in pixels.
        Form parentControl;
        HorizPanelAlign hpAlign;

        public HorizontalButtonsPane(Form parent, float topR, float leftR, float widthR, float heightR, HorizPanelAlign hpa, float space = -1.0f)
        {
            parentControl = parent;
            topRatio = topR;
            leftRatio = leftR;
            widthRatio = widthR;
            heightRatio = heightR;
            spaceBetweenButtons = space;
            paneButtons = new List<ButtonControl>();
            hpAlign = hpa;
        }

        public override void SetRightStyle()
        {

        }

        public void AddButtonOnPane(ref Button controlFounder, Image backImg, string name = "")
        {
            paneButtons.Add(new ButtonControl(ref controlFounder, topRatio, leftRatio, widthRatio, heightRatio, backImg, parentControl, name));
        }

        public override void OnUpdate(Form updForm)
        {
            int paneTop = (int)(updForm.Height * topRatio);
            int paneLeft = (int)(updForm.Width * leftRatio);
            int paneWidth = (int)(updForm.Width * widthRatio);
            int paneHeight = (int)(updForm.Height * heightRatio);
            int space = (spaceBetweenButtons > 1.0f) ? Convert.ToInt32(spaceBetweenButtons) : (int)(paneHeight * spaceBetweenButtons);

            if (paneButtons != null && paneButtons.Count > 0)
                switch (hpAlign)
                {
                    case HorizPanelAlign.hLeftAlign:
                        {
                            int bTop = paneTop;
                            int bLeft = paneLeft;
                            int bHeight = paneHeight;
                            int bWidth = bHeight;
                            foreach (ButtonControl btn in paneButtons)
                            {
                                btn.SetLocationOnWindow(bTop, bLeft, bHeight, bWidth);
                                bLeft += bWidth;
                            }
                            break;
                        }

                    case HorizPanelAlign.hRightAlign:
                        {
                            int bTop = paneTop;
                            int bLeft = (paneLeft + paneWidth) - paneHeight * paneButtons.Count;
                            int bHeight = paneHeight;
                            int bWidth = bHeight;
                            foreach (ButtonControl btn in paneButtons)
                            {
                                btn.SetLocationOnWindow(bTop, bLeft, bHeight, bWidth);
                                bLeft += bWidth;
                            }
                            break;
                        }

                    case HorizPanelAlign.hCenterAlign:
                        {
                            int bTop = paneTop;
                            int bLeft = paneLeft;
                            int diff = paneWidth - paneHeight * paneButtons.Count;
                            if (diff > 0)
                                bLeft = paneLeft + diff / 2;
                            int bHeight = paneHeight;
                            int bWidth = bHeight;
                            foreach (ButtonControl btn in paneButtons)
                            {
                                btn.SetLocationOnWindow(bTop, bLeft, bHeight, bWidth);
                                bLeft += bWidth;
                            }
                            break;
                        }

                    case HorizPanelAlign.hEvenly:
                        {
                            int bTop = paneTop;
                            int bLeft = paneLeft;
                            int bHeight = paneHeight;
                            int bWidth = bHeight;
                            int bspace = 0;

                            int part = paneWidth / paneButtons.Count;
                            if (part >= bWidth)
                                bspace = part - bWidth;
                            
                            foreach (ButtonControl btn in paneButtons)
                            {
                                btn.SetLocationOnWindow(bTop, bLeft, bHeight, bWidth);
                                bLeft += bWidth;
                                bLeft += bspace;
                            }
                            break;
                        }

                }
        }

    }
}
