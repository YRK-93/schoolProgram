using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHKOLA
{
    abstract class WinElement
    {
        protected Control baseCtrl;
        protected float topRatio; // If value is fractial and lower then 1, then it calculates as percent of window height, otherwise as absolute value in pixels.
        protected float leftRatio; // If value is fractial and lower then 1, then it calculates as percent of window width, otherwise as absolute value in pixels.
        protected float widthRatio; // If value is fractial and lower then 1, then it calculates as percent of window width, otherwise as absolute value in pixels.
        protected float heightRatio; // If value is fractial and lower then 1, then it calculates as percent of window height, otherwise as absolute value in pixels.

        abstract public void SetRightStyle();

        public virtual void OnUpdate(Form updForm)
        {
            baseCtrl.Top = (topRatio < 1.0f) ? (int)(updForm.Height * topRatio) : Convert.ToInt32(topRatio);
            baseCtrl.Left = (leftRatio < 1.0f) ? (int)(updForm.Width * leftRatio) : Convert.ToInt32(leftRatio);
            baseCtrl.Width = (widthRatio < 1.0f) ? (int)(updForm.Width * widthRatio) : Convert.ToInt32(widthRatio);
            if (heightRatio == -1.0f)
                baseCtrl.Height = baseCtrl.Width;
            else 
                baseCtrl.Height = (heightRatio < 1.0f) ? (int)(updForm.Height * heightRatio) : Convert.ToInt32(heightRatio);
        }
    }
}
