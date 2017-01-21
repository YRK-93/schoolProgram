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
        bool isCorrect;

        public Excercise(string str)
        {
            string[] res = str.Split(' ');
            isCorrect = checkIfCorrect(res[0], res[1], res[2], res[4]);
            equation = res[0] + " " + res[1] + " " + res[2] + " = ";
            answer = res[4];
        }

        private bool checkIfCorrect(string aa, string opration, string bb, string res)
        {
            int a = Convert.ToInt32(aa);
            int b = Convert.ToInt32(bb);
            int r = Convert.ToInt32(res);

            if (opration == "+")
                return (a + b) == r;

            if (opration == "-")
                return (a - b) == r;

            if (opration == "*")
                return (a * b) == r;

            return false;
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

            return new Excercise(aa.ToString() + znak + bb.ToString() + " = " + result.ToString());
        }
    }
}
