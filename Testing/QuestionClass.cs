using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class QuestionClass
    {
        int per1;
        int dsf3;
        string questionText;
        List<AnswerClass> answers;

        public string QuestionText
        {
            get
            {
                return questionText;
            }

            set
            {
                questionText = value;
            }
        }

        public List<AnswerClass> Answers
        {
            get
            {
                return answers;
            }

            set
            {
                answers = value;
            }
        }

        public QuestionClass()
        {
            Answers = new List<AnswerClass>();               
        }

    }
}
