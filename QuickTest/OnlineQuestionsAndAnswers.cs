using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace QuickTest
{
    class OnlineQuestions
    {
        public OnlineQuestions()
        {
          Questions();
        }


        public static string[] A;
        public static string[] B;
        public static string[] C;
        public static string[] D;
        public static string[] Answer;
       public static string[] Question;
        int count = 1;
        private static int lastQuestion = 0;
        /// <summary>
        /// UPLOAD TH QUESTIONS FROM THE DATABASE
        /// </summary>
        private  void Questions()
        {
            try
            {
                MySqlConnection con = new MyConnection().getConnection();
                string TotalQuestion = "SELECT COUNT(QuestionID) FROM questions";
                con.Open();
                MySqlCommand commandQuestions = new MySqlCommand(TotalQuestion, con);
                MySqlDataReader Questionreader = commandQuestions.ExecuteReader();

                if (Questionreader.HasRows)
                {
                    //get the total number of the question and use it as the question array rank
                    while (Questionreader.Read())
                    {
                        
                        var total = Int32.Parse(Questionreader.GetString(0));
                        //MessageBox.Show(total.ToString() , "total questions");
                        Question = new string[total+1];
                        A = new string[total +1];
                        B = new string[total +1];
                        C = new string[total +1];
                        D = new string[total +1];
                        Answer = new string[total ];
                    }
                    con.Close();
                }
                con.Open();
                string Query = "SELECT questions.Question,questions.OptA,questions.OptB,questions.OptC,questions.OptD,answers.Answer FROM questions JOIN answers ON questions.QuestionID=answers.QuestionID";

                //MySqlCommand command = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query , con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                int x = dt.Rows.Count;
                if (x>0)
                {
                   foreach(DataRow dr in dt.Rows)
                    {
                        Question[count] = dr[0].ToString();
                        A[count] = dr[1].ToString();
                        B[count] = dr[2].ToString();
                        C[count] = dr[3].ToString();
                        D[count] = dr[4].ToString();
                        Answer[count] = dr[5].ToString();
                        //MessageBox.Show(dr[0].ToString() + "\n" + dr[1].ToString() + "\n" + dr[2].ToString() + "\n" + dr[3].ToString() + "\n" + dr[4].ToString() + "\n" + dr[5].ToString());
                        count++;
                        }
                }
                con.Close();
                // MessageBox.Show(count.ToString(),"Count value");
                Online_Exam_Answers.objectives = new string[count +1];
                //lastQuestion = count;
            }
            catch (Exception) { }
        }
        /// <summary>
        /// GET THE TOTAL NUMBER OF QUESTIONS THAT WAS LOADED
        /// </summary>
        /// <returns></returns>
        public static int getLast()
        {
            MySqlConnection con = new MyConnection().getConnection();
            string TotalQuestion = "SELECT COUNT(QuestionID) FROM questions";
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(TotalQuestion , con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            var last = 0;
            int x = dt.Rows.Count;
            if (x > 0)
                {
                foreach(DataRow dr in dt.Rows)
                    {
                    last =Int32.Parse( dr[0].ToString());
                    }
                }
            return lastQuestion=last;
        }
        public static int NumberOfQuestion()
            {
            MySqlConnection con = new MyConnection().getConnection();
            string TotalQuestionNo = "SELECT No_of_questions FROM set_exam";
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(TotalQuestionNo , con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            var Number = 0;
            int x = dt.Rows.Count;
            if (x > 0)
                {
                foreach (DataRow dr in dt.Rows)
                    {
                    Number = Int32.Parse(dr[0].ToString());
                    }
                }
            return Number;
            }
        }
    
}
