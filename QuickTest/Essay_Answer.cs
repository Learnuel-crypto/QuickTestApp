using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuickTest
    {
    public partial class Essay_Answer : Form
        {
        MySqlConnection con = new MyConnection().getConnection();
        Online_Exam_Answers onlineuser = new
             Online_Exam_Answers();
        int Userquestionid;
        public Essay_Answer()
            {
            InitializeComponent();
            
            }
        public Essay_Answer(int questionid)
            {
            InitializeComponent();
            
            Userquestionid = questionid;
            }

        private void btnClear_Click(object sender , EventArgs e)
            {
            txtAnswer.Clear();
            this.ActiveControl = txtAnswer;
            
            }

        private void btnClose_Click(object sender , EventArgs e)
            {
            this.Close();
            }

        private void btnSubmit_Click(object sender , EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtAnswer.Text))
                    {
                    if(MessageBox.Show("You have typed nothing as answer","confirm submit" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                        this.Close();
                        }

                    else
                        {

                        }
                    }
                else
                    {
                    onlineuser.RecordUserAnswer(Online_Exam_Answers.GetUserID() , Userquestionid , txtAnswer.Text);
                    //string[] userText;
                    //string[] answers;
                    //int textLength = 0;
                    // userText = txtAnswer.Text.Split('.' , ' ' , ',' , ';');
                    //answers=Online_Exam_Answers.GetEssayAnswer(Userquestionid).Split(' ' , ',' , ';' , '.');
                    //if (userText.Length > answers.Length)
                    //    {
                    //    textLength = userText.Length;
                    //    }
                    //else
                    //    {
                    //    textLength = answers.Length;
                    //    }
                    
                    this.Close();
                    }
                
                }
            catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
       
        }
    }
