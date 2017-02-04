using System.Collections.Generic;
using System.Windows.Forms;

namespace SHKOLA
{
    abstract class BaseView
    {
        protected static List<WinElement> controlsList;

        public static void AddElement(WinElement wElement)
        {
            if (controlsList == null)
                controlsList = new List<WinElement>();

            if (wElement != null)
                controlsList.Add(wElement);
        }

        public static void Actualize(Form fm)
        {
            if (controlsList != null)
                foreach (WinElement wElem in controlsList)
                    wElem.OnUpdate(fm);
        }
    }
}
