using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class AnswerClass
    {
        string answer;
        bool isCorrect;

        public string Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }

        public bool IsCorrect
        {
            get
            {
                return isCorrect;
            }

            set
            {
                isCorrect = value;
            }
        }
        public AnswerClass(string answr, bool isRight)
        {
            Answer = answr;
            IsCorrect = isRight;
        }
    }
}
