using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace Testing
{ 
    
    class TestingProvider
    {
        int l;
        int p;
        int k;
        int a;
        int b;
        int r;
        List<SoundPlayer> RightList;
        List<SoundPlayer> WrongList;
        int counter;
        int wrongAnswersCounter;
        int rightAnswersCounter;
        bool isEnded;
        string finalMessage;
        public int QuestionsNumber
        {
            get { return questionsList.Count; }
        }

        List<QuestionClass> questionsList;
        public QuestionClass CurrentQuestion
        { get { return questionsList[counter]; } }

        public int RightAnswersCounter
        {
            get
            {
                return rightAnswersCounter;
            }

            set
            {
                rightAnswersCounter = value;
            }
        }

        public bool IsEnded
        {
            get
            {
                return isEnded;
            }

            set
            {
                isEnded = value;
            }
        }

        public string FinalMessage
        {
            get
            {
                return finalMessage;
            }

            set
            {
                finalMessage = value;
            }
        }

        public TestingProvider(string PathToFile)
        {
            RightList = new List<SoundPlayer>();
            WrongList = new List<SoundPlayer>();
            RightList.Add(new SoundPlayer(Properties.Resources.sina));
            RightList.Add(new SoundPlayer(Properties.Resources.Bone));
            RightList.Add(new SoundPlayer(Properties.Resources.naher));
            RightList.Add(new SoundPlayer(Properties.Resources.smoke));

            WrongList.Add(new SoundPlayer(Properties.Resources.dno));
            WrongList.Add(new SoundPlayer(Properties.Resources.joker));
            WrongList.Add(new SoundPlayer(Properties.Resources.kedavra));
            WrongList.Add(new SoundPlayer(Properties.Resources.mass));

            IsEnded = false;
            wrongAnswersCounter = 0;
            RightAnswersCounter = 0;
            counter = 0;
            questionsList = GetQuestions(PathToFile);
        }

       

        List<QuestionClass> GetQuestions(string path)
        {
            List<QuestionClass> questList = new List<QuestionClass>();
            List<string> lines = new List<string>();
            string line;
            if (!File.Exists(path))
            {
                MessageBox.Show("В корневой папке должен быть файл с именем filetest.txt, проверьте его наличие");
                Environment.Exit(3);
                
            }
            StreamReader sr = new StreamReader(path, Encoding.GetEncoding(1251));
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
               
            }
            sr.Close();
            string questTemp;
            string answTemp;
           
            QuestionClass qcTemp=new QuestionClass();
            try
            {
                for (int i = 0; i < lines.Count - 1; ++i)
                {
                    qcTemp = new QuestionClass();
                    if (lines[i][0].Equals('Q'))
                    {
                        questTemp = lines[i].Remove(0, 1);
                        qcTemp.QuestionText = questTemp;

                        answTemp = lines[i + 1];
                        if (answTemp[0].Equals('$'))
                            qcTemp.Answers.Add(new AnswerClass(answTemp.Remove(0, 1), true));
                        else
                            qcTemp.Answers.Add(new AnswerClass(answTemp, false));

                        answTemp = lines[i + 2];
                        if (answTemp[0].Equals('$'))
                            qcTemp.Answers.Add(new AnswerClass(answTemp.Remove(0, 1), true));
                        else
                            qcTemp.Answers.Add(new AnswerClass(answTemp, false));

                        answTemp = lines[i + 3];
                        if (answTemp[0].Equals('$'))
                            qcTemp.Answers.Add(new AnswerClass(answTemp.Remove(0, 1), true));
                        else
                            qcTemp.Answers.Add(new AnswerClass(answTemp, false));


                        questList.Add(qcTemp);

                    }



                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка в файле, провертьте правильность его написания");
            }
        return questList;
        }

        public void NextQuestion(int answerBefore)
        {
            if (!IsEnded)
            {
                if (CurrentQuestion.Answers[answerBefore - 1].IsCorrect)
                {
                    RightAnswersCounter++;
                    if (RightAnswersCounter == 1)
                    {
                        RightList[0].Load();
                        RightList[0].Play();

                    }
                    else
                    {
                        int num = (new Random()).Next(0, 4);
                        RightList[num].Load();
                        RightList[num].Play();
                    }
                    Thread.Sleep(3000);

                }
                else
                    {
                    wrongAnswersCounter++;
                    if (wrongAnswersCounter == 1)
                    {
                        WrongList[0].Load();
                        WrongList[0].Play();

                    }
                    else
                    {
                        int num = (new Random()).Next(0, 4);
                        WrongList[num].Load();
                        WrongList[num].Play();
                    }
                    Thread.Sleep(3000);
                }
                if (counter >= questionsList.Count - 1)
                    EndTheGame();
                else
                    counter++;
            }
        }
        void EndTheGame()
        {
            IsEnded = true;
            FinalMessage = "Вы отгадали правильно " + RightAnswersCounter + "/" + QuestionsNumber;
        }
    }
}
