using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHKOLA
{
    public class Excercise
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

        public bool isRight()
        {
            return isCorrect;
        }

        public override string ToString()
        {
            return equation + answer;
        }

        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
                return false;

            // If parameter cannot be cast to Excercise return false.
            Excercise p = obj as Excercise;
            if ((System.Object)p == null)
                return false;

            // Return true if the fields match:
            return equation == p.equation;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator == (Excercise a, Excercise b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
                return true;

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
                return false;

            return a.equation == b.equation;
        }

        public static bool operator != (Excercise a, Excercise b)
        {
            return !(a == b);
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
