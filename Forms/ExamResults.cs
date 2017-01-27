using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHKOLA.Properties;

namespace SHKOLA
{
    public partial class ExamResults : Form
    {
        public ExamResults()
        {
            userAnswersList = new List<Answer>();
            InitializeComponent();
        }

        public ExamResults(List<Answer> usrAnswers)
        {
            if (usrAnswers != null)
                userAnswersList = usrAnswers;
            else
                userAnswersList = new List<Answer>();

            InitializeComponent();

            btnAccept = new ButtonControl(ref this.btnOk, 0.82f, 0.4f, 0.2f, 0.11f, Resources.btnOk, this);
        }

        List<Answer> userAnswersList;
        ButtonControl btnAccept;


        private int getRightAnswersCount()
        {
            int cnt = 0;
            foreach(Answer exc in userAnswersList)
            {
                if (exc.isRight())
                    cnt++;
            }
            return cnt;
        }

        private void ExamResults_Load(object sender, EventArgs e)
        {
            label1.Text = "Результаты \nпроверки \nзнаний";

            btnAccept.OnUpdate(this);

            int excercisesSolved = userAnswersList.Count;
            int rightAnswersCount = getRightAnswersCount();
            int wrongAnswersCount = excercisesSolved - rightAnswersCount;

            richTextBox1.Text = "Решено примеров: " + excercisesSolved.ToString();
            richTextBox1.Text = richTextBox1.Text + "\nПравильных ответов: " + rightAnswersCount.ToString();
            richTextBox1.Text = richTextBox1.Text + "\nОшибок: " + wrongAnswersCount.ToString();

            printExcersices();
        }

        private void printExcersices()
        {
            int num = 1;
            foreach (Answer answ in userAnswersList)
            {
                richTextBox1.Text += "\n" + num.ToString() + ". " + answ.ToString();
                num++;
            }

            foreach (Answer answ in userAnswersList)
            {
                string anwerStr = answ.ToString();
                Color cl = answ.isRight() ? Color.Green : Color.Red;

                if (richTextBox1.Find(anwerStr) > 0)
                {
                    int position = richTextBox1.Find(anwerStr);
                    richTextBox1.SelectionStart = position;
                    richTextBox1.SelectionLength = anwerStr.Length;
                    richTextBox1.SelectionColor = cl;
                }
            }
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
