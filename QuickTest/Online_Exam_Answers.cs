using System;

using MySql.Data.MySqlClient;
using System.Data;

namespace QuickTest
    {
    class Online_Exam_Answers
        {
        MySqlConnection con = new MyConnection().getConnection();
      public static  string[] objectives;
        public Online_Exam_Answers()
            {
            con.Open();
            }
        public static int UserID;
        public static Double EssayScore=0.0;

        
        public static int GetUserID()
            {
            return UserID;
            }
        public static Double GetEssayScore()
            {
            return EssayScore;
            }
        public static void GetObjectives(int userId)
            {
            MySqlConnection con = new MyConnection().getConnection();
            con.Open();
             
            string query = "SELECT exam_answers.Answer FROM exam_answers WHERE exam_answers.UserID=" + userId + "  ";
            MySqlDataAdapter da = new MySqlDataAdapter(query , con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int x = 0;
            foreach (DataRow dr in dt.Rows)
                {
                x++;
                objectives[x] = dr[0].ToString();
                }
           
            }
        public void RecordUserAnswer(int userid , int questionid , string answer)
            {
            string CheckAnswer = "SELECT exam_answers.QuestionID FROM exam_answers WHERE exam_answers.QuestionID="+questionid+" AND exam_answers.UserID="+userid+"";
            MySqlDataAdapter da = new MySqlDataAdapter(CheckAnswer , con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int x = dt.Rows.Count;
            if (x > 0)
                {
                string updateAnswer = "UPDATE exam_answers SET exam_answers.Answer='" + answer + "' WHERE exam_answers.UserID="+userid+" AND exam_answers.QuestionID="+questionid+"";
                MySqlCommand cmdUpdate = new MySqlCommand(updateAnswer , con);
                cmdUpdate.ExecuteNonQuery();
                }
            else
                {
                string insertAnswer = "INSERT INTO exam_answers(exam_answers.UserID,exam_answers.QuestionID,exam_answers.Answer) VALUE(" + userid+","+questionid+",'"+answer+"') ";
                MySqlCommand cmdInsert = new MySqlCommand(insertAnswer , con);
                cmdInsert.ExecuteNonQuery();
                }
            }
        public void RecordUserQuestion(int questionid , string answer,int userid)
            {
            string insertQuestion = "INSERT INTO exam_questions(exam_questions.QuestionID,exam_questions.Answer,exam_questions.UserID) VALUE(" + questionid + ",'" + answer + "',"+ userid + ") ";
            MySqlCommand cmdQuestion = new MySqlCommand(insertQuestion , con);
            cmdQuestion.ExecuteNonQuery();
            }
        public static string GetEssayAnswer(int questionid)
            {
            MySqlConnection con = new MyConnection().getConnection();
            con.Open();
            string answer = "";
            string query = "SELECT answers.Answer FROM answers WHERE answers.QuestionID=" + questionid + "  ";
            MySqlDataAdapter da = new MySqlDataAdapter(query , con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
                {
                answer = dr[0].ToString();
                }
            return answer;
            }

        public int onlineObjectiveResult(int userid)
            {

            string result="SELECT exam_answers.Answer FROM exam_answers WHERE exam_answers.QuestionID IN(SELECT exam_questions.QuestionID FROM exam_questions WHERE exam_questions.UserID = "+ userid +" AND exam_questions.Answer = exam_questions.Answer)";
            MySqlDataAdapter adapter = new MySqlDataAdapter(result , con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int x = dt.Rows.Count;
            DeleteAnswers(userid); 
            return x;
            }
        public void DeleteAnswers(int userid)
            {
            string dele = "DELETE FROM exam_questions WHERE exam_questions.UserID=" + userid + "";
            MySqlCommand Delcmd = new MySqlCommand(dele , con);
            Delcmd.ExecuteNonQuery();
            }
        }
    }
