using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace QuickTest
{
    class DisplayQuestion
    {
        int count = 0;
      
        int firstQ = 0;
        
        
        List<String> button = new List<String>();
        int[] shown = new int[60];

        public static int PickQuestion()
        {
            List<int> items = new List<int>(0);
            int x = 0;
            Random ran = new Random();
            x = ran.Next(1, QuestionsAndAnswers.Questions.LastQuestion());
             
            if (items.Count > 1 && items.Contains(x))
            {

                do
                {
                    x = ran.Next(1, QuestionsAndAnswers.Questions.LastQuestion());
                } while (items.Contains(x) == true);
                // MessageBox.Show(x.ToString() + " in loop was generated");
                items.Add(x);
                setQuestions(x);
            }
            else
            {
                items.Add(x);
                setQuestions(x);
                //MessageBox.Show(x.ToString() + " was generated");
            }
            return x;

        }
        //used to set the question and options 
       public static void setQuestions(int x)
        {
            //txtQuestion.Text = QuestionsAndAnswers.Questions.GetQuestion(x);

            //lblA.Text = QuestionsAndAnswers.Questions.A;
            //lblB.Text = QuestionsAndAnswers.Questions.B;
            //lblC.Text = QuestionsAndAnswers.Questions.C;
            //lblD.Text = QuestionsAndAnswers.Questions.D;

        }
    }
}
