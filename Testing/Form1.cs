using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class Form1 : Form
    {
        TestingProvider tp;
        public Form1()
        {
            InitializeComponent();
         tp = new TestingProvider("filetest.txt");
            QuestionLabel.Text = tp.CurrentQuestion.QuestionText;
            firstRadio.Text = tp.CurrentQuestion.Answers[0].Answer;
            secondRadio.Text = tp.CurrentQuestion.Answers[1].Answer;
            thirdRadio.Text = tp.CurrentQuestion.Answers[2].Answer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!tp.IsEnded)
            {
                int rightCheck;
                if (firstRadio.Checked)
                    rightCheck = 1;
                else if (secondRadio.Checked)
                    rightCheck = 2;
                else if (thirdRadio.Checked)
                    rightCheck = 3;
                else rightCheck = 1;

                tp.NextQuestion(rightCheck);
                if (!tp.IsEnded)
                {
                    QuestionLabel.Text = tp.CurrentQuestion.QuestionText;
                    firstRadio.Text = tp.CurrentQuestion.Answers[0].Answer;
                    secondRadio.Text = tp.CurrentQuestion.Answers[1].Answer;
                    thirdRadio.Text = tp.CurrentQuestion.Answers[2].Answer;
                }
                else { MessageBox.Show(tp.FinalMessage); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
