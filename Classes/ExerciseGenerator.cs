using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHKOLA
{
    class Excercise
    {
        string equation;
        string answer;

        public Excercise(string equ, string ans)
        {
            equation = equ;
            answer = ans;
        }

        public string getEquation()
        {
            return equation;
        }

        public string getAnswer()
        {
            return answer;
        }

        public override string ToString()
        {
            return equation + answer;
        }
    }

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
    }
}
