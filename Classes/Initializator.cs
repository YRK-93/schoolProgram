using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHKOLA
{
    abstract class Initializator
    {
        public static bool LoadImages()
        {
            AppStatistic.ResetStatistic();

            return true;
        }
    }
}
