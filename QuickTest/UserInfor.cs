using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace QuickTest
    {
    class UserInfor
    {
        public UserInfor()
        {
            UsernamesAndPasswords();
        }
        int count = 0;
        MySqlConnection con = new MyConnection().getConnection();
        private static string Username="Username";
        private static int Userscore = 0;
        public static string UserFailed = "Test Completed and Submited ";
        private static string Name = "YOUR NAME";
        public static List<string> Users = new List<string>();
        public static List<string> Passwords = new List<string>();

        public static void setUser(string user)
        {
            Username = user;
        }
        public static string getUser()
        {
            return Username;
        }
        public static void setScore(int score)
        {
            Userscore = score;
        }
        public static int getUserScore()
        {
            return Userscore + Convert.ToInt32(Online_Exam_Answers.GetEssayScore());
        }
        public static void setName(string name)
        {
            Name = name;
        }
        public static string getName()
        {
            return Name;
        }
        /// <summary>
        /// THIS IS USED WHEN THE APPLICATION IS ONLINE TO LOAD THE USENAMES AND PASSWORD INTO THE LIST
        /// </summary>
        private void UsernamesAndPasswords()
        {
            try
            {
                String query = "SELECT * FROM userslogin";
                con.Open();
                MySqlCommand commdand = new MySqlCommand(query, con);
                MySqlDataReader reader = commdand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count++;
                        Users.Add(reader.GetString(2));
                        Passwords.Add(reader.GetString(3));

                    }
                }
                con.Close();
            }
            catch (Exception)
            {

            }
        } 
    }
}

