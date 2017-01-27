using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHKOLA
{
    class ExerciseGenerator
    {
        public static Excercise GenPlusMinusExercise()
        {
            int maxValue = 20;
            Random r = new Random();
            int aa = r.Next(0, maxValue);
            int bb = r.Next(0, maxValue);
            int zn = r.Next(0, maxValue);

            string znak = (zn % 2 == 0) ? " + " : " - ";

            int result;
            if (znak == " - ")
            {
                if (aa < bb)
                {
                    int cc = bb;
                    bb = aa;
                    aa = cc;
                }
                result = aa - bb;
            }
            else result = aa + bb;

            return new Excercise(aa.ToString() + znak + bb.ToString() + " = ", result.ToString());
        }

        public static List<Excercise> GenPlusMinusExamExercises(int num)
        {
            List<Excercise> excList = new List<Excercise>();

            while(excList.Count < num)
            {
                Excercise buf = GenPlusMinusExercise();

                if (!excList.Contains(buf))
                    excList.Add(buf);
            }
            return excList;
        }
    }
}
