using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CheckInternetCon;

namespace QuickTest
    {
    public partial class QuickTestFrm : Form
    {
        /// <summary>
        /// global variables
        /// </summary>

        int hour = 1;
        int x = 0;
        int sec = 60;
        Random ran = new Random();
        List<int> items = new List<int>(0);
         
        List<String> button = new List<String>();
        int mins = 30;
        int Total = 0;
        string[] selectOptionAnswer = new string[61];
        int[] shown = new int[61];
        string[] Selected = new string[61];
        string[] UserAnswer = new string[61];
        bool connected = false;
        int clikedButton = 0;
        int totalQuestion ;
        Online_Exam_Answers onlineUserAnswer;
        public QuickTestFrm()
        {
            InitializeComponent();
            lblH.Text = "0"+hour;
            lblM.Text = mins.ToString();
            lblS.Text = sec.ToString();
            lblUser.Text = UserInfor.getUser();
            lblName.Text = UserInfor.getName().ToUpper();
            timer1.Start();
            Button(OnlineQuestions.NumberOfQuestion());
            if (InternetConnection.getConnection() == true)
            {
                connected = true;
                totalQuestion = OnlineQuestions.getLast();
                onlineUserAnswer = new Online_Exam_Answers();
            }

        }
        /// <summary>
        /// use to pick the question and return the number picked
        /// </summary>
        /// <returns></returns>
        private int PickQuestion()
        {

            try
            {
                 
                if (connected == true)
                {
                    x = ran.Next(1, totalQuestion);
                   
                    if (items.Count >= 1 && items.Contains(x))
                    {
                        do
                        {
                            x = ran.Next(1, totalQuestion);
                        } while (items.Contains(x) == true);
                        //MessageBox.Show(x.ToString() + " in loop was generated");
                        items.Add(x);
                        setQuestions(x);
                    }
                    else
                    {
                        items.Add(x);
                        setQuestions(x);
                       // MessageBox.Show(x.ToString() + " was generated");
                    }
                }
                else
                {
                    throw new Exception("something went wrong\nCheck Internet connection");
                    x = ran.Next(1, QuestionsAndAnswers.Questions.LastQuestion());

                    if (items.Count >= 1 && items.Contains(x))
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
                }
                return x;
            }
            catch(Exception)
            {
                return 0;
            }

        }
        /// <summary>
        /// SET THE BUTTON ACCORDING TO THE NUMBER OF THE QUESTIONS AVAILABLE OR SET
        /// </summary>
        /// <param name="button"></param>
       #region
        private void showButton(int button)
            {
            if (button == 1)
                {
                btn1.Visible = true;
                }
            if (button == 2)
                {
                btn2.Visible = true;
                }
            if (button == 3)
                {
                btn3.Visible = true;
                }
            if (button == 4)
                {
                btn4.Visible = true;
                }
            if (button == 5)
                {
                btn5.Visible = true;
                }
            if (button == 6)
                {
                btn6.Visible = true;
                }
            if (button == 7)
                {
                btn7.Visible = true;
                }
            if (button == 8)
                {
                btn8.Visible = true;
                }
            if (button == 9)
                {
                btn9.Visible = true;
                }
            if (button == 10)
                {
                btn10.Visible = true;
                }
            if (button == 11)
                {
                btn11.Visible = true;
                }
            if (button == 12)
                {
                btn12.Visible = true;
                }
            if (button == 13)
                {
                btn13.Visible = true;
                }
            if (button == 14)
                {
                btn14.Visible = true;
                }
            if (button == 15)
                {
                btn15.Visible = true;
                }
            if (button == 16)
                {
                btn16.Visible = true;
                }
            if (button == 17)
                {
                btn17.Visible = true;
                }
            if (button == 18)
                {
                btn18.Visible = true;
                }
            if (button == 19)
                {
                btn19.Visible = true;
                }
            if (button == 20)
                {
                btn20.Visible = true;
                }
            //30 to 40
            if (button == 21)
                {
                btn21.Visible = true;
                }
            if (button == 22)
                {
                btn22.Visible = true;
                }
            if (button == 23)
                {
                btn23.Visible = true;
                }
            if (button == 24)
                {
                btn24.Visible = true;
                }
            if (button == 25)
                {
                btn25.Visible = true;
                }
            if (button == 26)
                {
                btn26.Visible = true;
                }
            if (button == 27)
                {
                btn27.Visible = true;
                }
            if (button == 28)
                {
                btn28.Visible = true;
                }
            if (button == 29)
                {
                btn29.Visible = true;
                }
            if (button == 30)
                {
                btn30.Visible = true;
                }
            if (button == 31)
                {
                btn31.Visible = true;
                }
            if (button == 32)
                {
                btn32.Visible = true;
                }
            if (button == 33)
                {
                btn33.Visible = true;
                }
            if (button == 34)
                {
                btn34.Visible = true;
                }
            if (button == 35)
                {
                btn35.Visible = true;
                }
            if (button == 36)
                {
                btn36.Visible = true;
                }
            if (button == 37)
                {
                btn37.Visible = true;
                }
            if (button == 38)
                {
                btn38.Visible = true;
                }
            if (button == 39)
                {
                btn39.Visible = true;
                }
            if (button == 40)
                {
                btn40.Visible = true;
                }
            //41 to 60
            if (button == 41)
                {
                btn41.Visible = true;
                }
            if (button == 42)
                {
                btn42.Visible = true;
                }
            if (button == 43)
                {
                btn43.Visible = true;
                }
            if (button ==44)
                {
                btn44.Visible = true;
                }
            if (button == 45)
                {
                btn45.Visible = true;
                }
            if (button == 46)
                {
                btn46.Visible = true;
                }
            if (button == 47)
                {
                btn47.Visible = true;
                }
            if (button == 48)
                {
                btn48.Visible = true;
                }
            if (button == 49)
                {
                btn49.Visible = true;
                }
            if (button == 50)
                {
                btn50.Visible = true;
                }
            if (button == 51)
                {
                btn51.Visible = true;
                }
            if (button == 52)
                {
                btn52.Visible = true;
                }
            if (button == 53)
                {
                btn53.Visible = true;
                }
            if (button == 54)
                {
                btn54.Visible = true;
                }
            if (button == 55)
                {
                btn55.Visible = true;
                }
            if (button == 56)
                {
                btn56.Visible = true;
                }
            if (button == 57)
                {
                btn57.Visible = true;
                }
            if (button == 58)
                {
                btn58.Visible = true;
                }
            if (button == 59)
                {
                btn59.Visible = true;
                }
            if (button == 60)
                {
                btn60.Visible = true;
                }
            }
        #endregion
        private void Button(int number)
            {
            //MessageBox.Show(number.ToString() + " is the total question");

            for (int x=0; x<= number;x++)
                {
                
                showButton(x);
                }
            }

        /// <summary>
        /// get the option that was selected initially and return it
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private string GetSelected(int x)
        {
            return Selected[x];

        }

        /// <summary>
        /// used to set the question and options 
        /// </summary>
        /// <param name="x"></param>
        void setQuestions(int x)
        {
            try
            {
                if (connected == true && lblConInfor.Text == "Disconnected")
                {
                    MessageBox.Show("Disconnected: \nCheck Internet Connection", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (connected == true)
                {
                    //MessageBox.Show(OnlineQuestions.Question[x]+"\n"+ OnlineQuestions.A[x] +"\n" + OnlineQuestions.B[x] , "Selected Question" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    if (OnlineQuestions.Question[x] == null)
                        {
                        MessageBox.Show("Please check Internet Connection and Try Again" , "Network Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        Application.Exit();
                        }
                    txtQuestion.Text = OnlineQuestions.Question[x];
                    lblA.Text = OnlineQuestions.A[x];
                    lblB.Text = OnlineQuestions.B[x];
                    lblC.Text = OnlineQuestions.C[x];
                    lblD.Text = OnlineQuestions.D[x];
                    selectOptionAnswer[x] = OnlineQuestions.Answer[x];//store the selected question answer for final result calcualtion
                   
                }
                else
                {
                    txtQuestion.Text = QuestionsAndAnswers.Questions.GetQuestion(x);
                    lblA.Text = QuestionsAndAnswers.Questions.A;
                    lblB.Text = QuestionsAndAnswers.Questions.B;
                    lblC.Text = QuestionsAndAnswers.Questions.C;
                    lblD.Text = QuestionsAndAnswers.Questions.D;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Network Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }
        /// <summary>
        /// use a stored question number that was generated to retrieve the 
        /// answer to the question
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private string getQuestion(int x)
        {
            try
            {
                if (connected == true && lblConInfor.Text == "Disconnected")
                {
                    MessageBox.Show("Disconnected: \nCheck Internet Connection", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (connected == true )
                {
                    return selectOptionAnswer[x];

                }
                else
                {
                    QuestionsAndAnswers.Questions.GetQuestion(x);
                    return QuestionsAndAnswers.Questions.Answer;
                }
                
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return"";
            }
        }
        private void QuickTestFrm_Load(object sender, EventArgs e)
        { 
            Selected[0] = null;  
            btn1.PerformClick();//new code added
             
        }
        /// <summary>
        /// this is to reset the Options, show the one that was selected and if
        /// none was selected, display the options.
        /// </summary>
        void setChoosen()
        {
            if (GetSelected(clikedButton) == null)
            {
                radioa1.Checked = false;
                radiob1.Checked = false;
                radioc1.Checked = false;
                radiod1.Checked = false;
            }
            else
            {
                if (GetSelected(clikedButton) == radioa1.Text)
                {
                    radioa1.Checked = true;
                }
                else if (GetSelected(clikedButton) == radiob1.Text)
                {
                    radiob1.Checked = true;
                }
                else if (GetSelected(clikedButton) == radioc1.Text)
                {
                    radioc1.Checked = true;
                }
                else if (GetSelected(clikedButton) == radiod1.Text)
                {
                    radiod1.Checked = true;
                }
            }
        }
        /// <summary>
        /// Set the colour of the button when an option is selected
        /// </summary>
        /// <param name="x"></param>
        #region
        private void SetButtonColor(int x)
        {
            if (x == 1)
            {
                btn1.BackColor = Color.RoyalBlue;
            }
            else if (x == 2)
            {
                btn2.BackColor = Color.RoyalBlue;
            }
            else if (x == 3)
            {
                btn3.BackColor = Color.RoyalBlue;
            }
            else if (x == 4)
            {
                btn4.BackColor = Color.RoyalBlue;
            }
            else if (x == 5)
            {
                btn5.BackColor = Color.RoyalBlue;
            }
            else if (x == 6)
            {
                btn6.BackColor = Color.RoyalBlue;
            }
            else if (x == 7)
            {
                btn7.BackColor = Color.RoyalBlue;
            }
            else if (x == 8)
            {
                btn8.BackColor = Color.RoyalBlue;
            }
            else if (x == 9)
            {
                btn9.BackColor = Color.RoyalBlue;
            }
            else if (x == 10)
            {
                btn10.BackColor = Color.RoyalBlue;
            }
            else if (x == 11)
            {
                btn11.BackColor = Color.RoyalBlue;
            }
            else if (x == 12)
            {
                btn12.BackColor = Color.RoyalBlue;
            }
            else if (x == 13)
            {
                btn13.BackColor = Color.RoyalBlue;
            }
            else if (x == 14)
            {
                btn14.BackColor = Color.RoyalBlue;
            }
            else if (x == 15)
            {
                btn15.BackColor = Color.RoyalBlue;
            }
            else if (x == 16)
            {
                btn16.BackColor = Color.RoyalBlue;
            }
            else if (x == 17)
            {
                btn17.BackColor = Color.RoyalBlue;
            }
            else if (x == 18)
            {
                btn18.BackColor = Color.RoyalBlue;
            }
            else if (x == 19)
            {
                btn19.BackColor = Color.RoyalBlue;
            }
            else if (x == 20)
            {
                btn20.BackColor = Color.RoyalBlue;
                //21 downwards
            }
            else if (x == 21)
            {
                btn21.BackColor = Color.RoyalBlue;

            }
            else if (x == 22)
            {
                btn22.BackColor = Color.RoyalBlue;
            }
            else if (x == 23)
            {
                btn23.BackColor = Color.RoyalBlue;
            }
            else if (x == 24)
            {
                btn24.BackColor = Color.RoyalBlue;
            }
            else if (x == 25)
            {
                btn25.BackColor = Color.RoyalBlue;
            }
            else if (x == 26)
            {
                btn26.BackColor = Color.RoyalBlue;
            }
            else if (x == 27)
            {
                btn27.BackColor = Color.RoyalBlue;
            }
            else if (x == 28)
            {
                btn28.BackColor = Color.RoyalBlue;
            }
            else if (x == 29)
            {
                btn29.BackColor = Color.RoyalBlue;
            }
            else if (x == 30)
            {
                btn30.BackColor = Color.RoyalBlue;
            }
            else if (x == 31)
            {
                btn31.BackColor = Color.RoyalBlue;
            }
            else if (x == 32)
            {
                btn32.BackColor = Color.RoyalBlue;
            }
            else if (x == 33)
            {
                btn33.BackColor = Color.RoyalBlue;
            }
            else if (x == 34)
            {
                btn34.BackColor = Color.RoyalBlue;
            }
            else if (x == 35)
            {
                btn35.BackColor = Color.RoyalBlue;
            }
            else if (x == 36)
            {
                btn36.BackColor = Color.RoyalBlue;
            }
            else if (x == 37)
            {
                btn37.BackColor = Color.RoyalBlue;
            }
            else if (x == 38)
            {
                btn38.BackColor = Color.RoyalBlue;
            }
            else if (x == 39)
            {
                btn39.BackColor = Color.RoyalBlue;
            }
            else if (x == 40)
            {
                btn40.BackColor = Color.RoyalBlue;
                //40 downward
            }
            else if (x == 41)
            {
                btn41.BackColor = Color.RoyalBlue;

            }
            else if (x == 42)
            {
                btn42.BackColor = Color.RoyalBlue;
            }
            else if (x == 43)
            {
                btn43.BackColor = Color.RoyalBlue;
            }
            else if (x == 44)
            {
                btn44.BackColor = Color.RoyalBlue;
            }
            else if (x == 45)
            {
                btn45.BackColor = Color.RoyalBlue;
            }
            else if (x == 46)
            {
                btn46.BackColor = Color.RoyalBlue;
            }
            else if (x == 47)
            {
                btn47.BackColor = Color.RoyalBlue;
            }
            else if (x == 48)
            {
                btn48.BackColor = Color.RoyalBlue;
            }
            else if (x == 49)
            {
                btn49.BackColor = Color.RoyalBlue;
            }
            else if (x == 50)
            {
                btn50.BackColor = Color.RoyalBlue;
            }
            else if (x == 51)
            {
                btn51.BackColor = Color.RoyalBlue;
            }
            else if (x == 52)
            {
                btn52.BackColor = Color.RoyalBlue;
            }
            else if (x == 53)
            {
                btn53.BackColor = Color.RoyalBlue;
            }
            else if (x == 54)
            {
                btn54.BackColor = Color.RoyalBlue;
            }
            else if (x == 55)
            {
                btn55.BackColor = Color.RoyalBlue;
            }
            else if (x == 56)
            {
                btn56.BackColor = Color.RoyalBlue;
            }
            else if (x == 57)
            {
                btn57.BackColor = Color.RoyalBlue;
            }
            else if (x == 58)
            {
                btn58.BackColor = Color.RoyalBlue;
            }
            else if (x == 59)
            {
                btn59.BackColor = Color.RoyalBlue;
            }
            else if (x == 60)
            {
                btn60.BackColor = Color.RoyalBlue;
            }
        }
        #endregion
        private void DisableOptions()
            {
            radioa1.Visible = false;
            radiob1.Visible = false;
            radioc1.Visible = false;
            radiod1.Visible = false;
            }
        private void EnableOptions()
            {
            radioa1.Visible = true;
            radiob1.Visible = true;
            radioc1.Visible = true;
            radiod1.Visible = true;
            }
        private void btn1_Click(object sender, EventArgs e)
        {
            clikedButton = 1;
            lblquestionNO.Text = btn1.Text;
            setChoosen();//get the option that was selected initially  
    
            if (button.Contains(btn1.Text) == false)
            {
                button.Add(btn1.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());//store the question answer using the button as the ID
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if(string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }

            }

        private void btn2_Click(object sender, EventArgs e)
        {
            clikedButton = 2; 
            lblquestionNO.Text = btn2.Text;
            setChoosen(); 
            if (button.Contains(btn2.Text) == false)
            {
                button.Add(btn2.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());//store the question answer using the button as the ID
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn3_Click(object sender, EventArgs e)
        {
            clikedButton = 3; 
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn3.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn3.Text) == false)
            {
                shown[clikedButton] = PickQuestion();//add the question number to the array
                button.Add(btn3.Text);
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());//store the question answer using the button as the ID
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn4_Click(object sender, EventArgs e)
        {
            clikedButton = 4;
            lblquestionNO.Text = btn4.Text;
            setChoosen();
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn4.Text) == false)
            {
                button.Add(btn4.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());//store the question answer using the button as the ID
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }
        /// <summary>
        /// get the user answer if any
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private string getUserAnswer(int x)
        {
            return UserAnswer[x];
        }
        private void radioa1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioa1.Checked == true)
            {
                Selected[clikedButton] = radioa1.Text;//add the selected option to the array
                                                      // MessageBox.Show(Selected[clikedButton].ToString() + " Was Added");
                SetButtonColor(clikedButton);
                if (connected == true)
                    {
                    onlineUserAnswer.RecordUserAnswer(Online_Exam_Answers.GetUserID() , clikedButton , radioa1.Text);
                    }
                }
        }

        private void radiob1_CheckedChanged(object sender, EventArgs e)
        {

            if (radiob1.Checked == true)
            {
                Selected[clikedButton] = radiob1.Text;//add the selected option to the array
                //MessageBox.Show(Selected[clikedButton].ToString() + " Was Added");
                SetButtonColor(clikedButton);
                if (connected == true)
                    {
                    onlineUserAnswer.RecordUserAnswer(Online_Exam_Answers.GetUserID() , clikedButton , radiob1.Text);
                    }
                }
        }

        private void radioc1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioc1.Checked == true)
            {
                Selected[clikedButton] = radioc1.Text;//add the selected option to the array
                                                      // MessageBox.Show(Selected[clikedButton].ToString() + " Was Added");
                SetButtonColor(clikedButton);
                if (connected == true)
                    {
                    onlineUserAnswer.RecordUserAnswer(Online_Exam_Answers.GetUserID() , clikedButton , radioc1.Text);
                    }
                }
        }

        private void radiod1_CheckedChanged(object sender, EventArgs e)
        {

            if (radiod1.Checked == true)
            {
                Selected[clikedButton] = radiod1.Text;
                //MessageBox.Show(Selected[clikedButton].ToString() + " Was Added");
                SetButtonColor(clikedButton);
            }

        }
        /// <summary>
        /// calculate the total score 
        /// </summary>
        /// <returns></returns>
        private int FinalResult()
        {
            if (connected == true)
            {
                Online_Exam_Answers.GetObjectives(Online_Exam_Answers.GetUserID());
                
                
            }
            else
            {
                for (int i = 0; i < shown.Length; i++)
                {
                    // MessageBox.Show("Method Called");
                    if (GetSelected(i) == getQuestion(shown[i]))
                    {
                        Total = Total + 1;
                    }
                }
            }
            return Total;
        }
        void ResetTest()
        {
            Total = 0;
            clikedButton = 0;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            clikedButton = 5;
            lblquestionNO.Text = btn5.Text;
            setChoosen();
            if (button.Contains(btn5.Text) == false)
            {
                button.Add(btn5.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());//store the question answer using the button as the ID
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn6_Click(object sender, EventArgs e)
        {
            clikedButton = 6;
            lblquestionNO.Text = btn6.Text;
            setChoosen();
            if (button.Contains(btn6.Text) == false)
            {
                button.Add(btn6.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());//store the question answer using the button as the ID
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn7_Click(object sender, EventArgs e)
        {
            clikedButton = 7;
            lblquestionNO.Text = btn7.Text;
            setChoosen();
            if (button.Contains(btn7.Text) == false)
            {
                button.Add(btn7.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());//store the question answer using the button as the ID
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn8_Click(object sender, EventArgs e)
        {
            clikedButton = 8;
            lblquestionNO.Text = btn8.Text;
            setChoosen();
            if (button.Contains(btn8.Text) == false)
                {
                button.Add(btn8.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());//store the question answer using the button as the ID
                }
            else
                {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
                }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn9_Click(object sender, EventArgs e)
        {
            clikedButton = 9;
            lblquestionNO.Text = btn9.Text;
            setChoosen();
            if (button.Contains(btn9.Text) == false)
            {
                button.Add(btn9.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x),Online_Exam_Answers.GetUserID());//store the question answer using the button as the ID
                }

            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn10_Click(object sender, EventArgs e)
        {
            clikedButton = 10;
            lblquestionNO.Text = btn10.Text;
            setChoosen();
            if (button.Contains(btn10.Text) == false)
            {
                button.Add(btn10.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
            }

            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn11_Click(object sender, EventArgs e)
        {
            clikedButton = 11;
            lblquestionNO.Text = btn11.Text;
            setChoosen();
            if (button.Contains(btn11.Text) == false)
            {
                button.Add(btn11.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }

            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn12_Click(object sender, EventArgs e)
        {
            clikedButton = 12;
            lblquestionNO.Text = btn12.Text;
            setChoosen();
            if (button.Contains(btn12.Text) == false)
            {
                button.Add(btn12.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn13_Click(object sender , EventArgs e)
            {
            clikedButton = 13;
            lblquestionNO.Text = btn13.Text;
            setChoosen();
            if (button.Contains(btn13.Text) == false)
                {
                button.Add(btn13.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
                {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
                }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn14_Click(object sender, EventArgs e)
        {
            clikedButton = 14;
            lblquestionNO.Text = btn14.Text;
            setChoosen();
            if (button.Contains(btn14.Text) == false)
            {
                button.Add(btn14.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn15_Click(object sender, EventArgs e)
        {
            clikedButton = 15;
            lblquestionNO.Text = btn15.Text;
            setChoosen();
            if (button.Contains(btn15.Text) == false)
            {
                button.Add(btn15.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            clikedButton = 16;
            lblquestionNO.Text = btn16.Text;
            setChoosen();
            if (button.Contains(btn16.Text) == false)
            {
                button.Add(btn16.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn17_Click(object sender, EventArgs e)
        {
            clikedButton = 17;
            lblquestionNO.Text = btn17.Text;
            setChoosen();
            if (button.Contains(btn17.Text) == false)
            {
                button.Add(btn17.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn18_Click(object sender, EventArgs e)
        {
            clikedButton = 18;
            lblquestionNO.Text = btn18.Text;
            setChoosen();
            if (button.Contains(btn18.Text) == false)
            {
                button.Add(btn18.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn19_Click(object sender, EventArgs e)
        {
            clikedButton = 19;
            lblquestionNO.Text = btn19.Text;
            setChoosen();
            if (button.Contains(btn19.Text) == false)
            {
                button.Add(btn19.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn20_Click(object sender, EventArgs e)
        {
            clikedButton = 20;
            lblquestionNO.Text = btn20.Text;
            setChoosen();
            if (button.Contains(btn20.Text) == false)
            {
                button.Add(btn20.Text);
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {

                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(connected==true && lblConInfor.Text == "Disconnected")
                {
                    throw new Exception("Disconnected: \nCheck Internet Connection");
                }
                if (connected == true)
                {
                    //ADD INSERT CODE HERE TO INSERT THE RESULT IN TO THE DATABASE
                    UserInfor.setScore(onlineUserAnswer.onlineObjectiveResult(Online_Exam_Answers.GetUserID()));
                    this.Hide();
                    var resultfrm = new ResultForm();
                    Total = 0;
                    Online_Exam_Answers.EssayScore = 0;
                    resultfrm.ShowDialog();
                    this.Close();
                }
                else
                {
                    //UserInfor.setScore(FinalResult());
                    //this.Hide();
                    //var resultfrm = new ResultForm();
                    //Total = 0;
                    //resultfrm.ShowDialog();
                    //this.Close(); 
                    throw new Exception("Check your internet connection and Try again");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn21_Click(object sender, EventArgs e)
        {
            clikedButton = 21;
            lblquestionNO.Text = btn21.Text;
            setChoosen();
            if (button.Contains(btn21.Text) == false)
            {
                button.Add(btn21.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn22_Click(object sender, EventArgs e)
        {
            clikedButton = 22;
            lblquestionNO.Text = btn22.Text;
            setChoosen();
            if (button.Contains(btn22.Text) == false)
            {
                button.Add(btn22.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn23_Click(object sender, EventArgs e)
        {
            clikedButton = 23;
            lblquestionNO.Text = btn23.Text;
            setChoosen();
            if (button.Contains(btn23.Text) == false)
            {
                button.Add(btn23.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn24_Click(object sender, EventArgs e)
        {
            clikedButton = 24;
            lblquestionNO.Text = btn24.Text;
            setChoosen();
            if (button.Contains(btn24.Text) == false)
            {
                button.Add(btn24.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn25_Click(object sender, EventArgs e)
        {
            clikedButton = 25;
            lblquestionNO.Text = btn25.Text;
            setChoosen();
            if (button.Contains(btn25.Text) == false)
            {
                button.Add(btn25.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn26_Click(object sender, EventArgs e)
        {
            clikedButton = 26;
            lblquestionNO.Text = btn26.Text;
            setChoosen();
            if (button.Contains(btn26.Text) == false)
            {
                button.Add(btn26.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn27_Click(object sender, EventArgs e)
        {
            clikedButton = 27;
            lblquestionNO.Text = btn27.Text;
            setChoosen();
            if (button.Contains(btn27.Text) == false)
            {
                button.Add(btn27.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn28_Click(object sender, EventArgs e)
        {
            clikedButton = 28;
            lblquestionNO.Text = btn28.Text;
            setChoosen();
            if (button.Contains(btn28.Text) == false)
            {
                button.Add(btn28.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn29_Click(object sender, EventArgs e)
        {
            clikedButton = 29;
            lblquestionNO.Text = btn29.Text;
            setChoosen();
            
            if (button.Contains(btn29.Text) == false)
            {
                button.Add(btn29.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn30_Click(object sender, EventArgs e)
        {
            clikedButton = 30;
            lblquestionNO.Text = btn30.Text;
            setChoosen();
            
            if (button.Contains(btn30.Text) == false)
            {
                button.Add(btn30.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array at the index of the clickedButton
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn31_Click(object sender, EventArgs e)
        {
            clikedButton = 31;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn31.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn31.Text) == false)
            {
                button.Add(btn31.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn32_Click(object sender, EventArgs e)
        {
            clikedButton = 32;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn32.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn32.Text) == false)
            {
                button.Add(btn32.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn33_Click(object sender, EventArgs e)
        {
            clikedButton = 33;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn33.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn33.Text) == false)
            {
                button.Add(btn33.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn34_Click(object sender, EventArgs e)
        {
            clikedButton = 34;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn34.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn34.Text) == false)
            {
                button.Add(btn34.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn35_Click(object sender, EventArgs e)
        {
            clikedButton = 35;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn35.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn35.Text) == false)
            {
                button.Add(btn35.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn36_Click(object sender, EventArgs e)
        {
            clikedButton = 36;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn36.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn36.Text) == false)
            {
                button.Add(btn36.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
            if (string.IsNullOrEmpty(lblA.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblB.Text) && string.IsNullOrEmpty(lblC.Text) && string.IsNullOrEmpty(lblD.Text))
                {
                btnTypeAnswer.Visible = true;
                DisableOptions();
                }
            else
                {
                btnTypeAnswer.Visible = false;
                EnableOptions();
                }
            }

        private void btn37_Click(object sender, EventArgs e)
        {
            clikedButton = 37;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn37.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn37.Text) == false)
            {
                button.Add(btn37.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            clikedButton = 38;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn38.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn38.Text) == false)
            {
                button.Add(btn38.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
            }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn39_Click(object sender, EventArgs e)
        {
            clikedButton = 39;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn39.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn39.Text) == false)
            {
                button.Add(btn39.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            clikedButton = 40;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn40.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn40.Text) == false)
            {
                shown[clikedButton] = PickQuestion();//add the question number to the array
                button.Add(btn40.Text);
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            clikedButton = 41;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn41.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn41.Text) == false)
            {
                button.Add(btn41.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            clikedButton = 42;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn42.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn42.Text) == false)
            {
                button.Add(btn42.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            clikedButton = 43;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn43.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn43.Text) == false)
            {
                button.Add(btn43.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            clikedButton = 44;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn44.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn44.Text) == false)
            {
                button.Add(btn44.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            clikedButton = 45;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn45.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn45.Text) == false)
            {
                button.Add(btn45.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn46_Click(object sender, EventArgs e)
        {
            clikedButton = 46;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn46.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn46.Text) == false)
            {
                button.Add(btn46.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn47_Click(object sender, EventArgs e)
        {
            clikedButton = 47;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn47.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn47.Text) == false)
            {
                button.Add(btn47.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn48_Click(object sender, EventArgs e)
        {
            clikedButton = 48;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn48.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn48.Text) == false)
            {
                button.Add(btn48.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn49_Click(object sender, EventArgs e)
        {
            clikedButton = 49;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn49.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn49.Text) == false)
            {
                button.Add(btn49.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            clikedButton = 50;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn50.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn50.Text) == false)
            {
                button.Add(btn50.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn51_Click(object sender, EventArgs e)
        {
            clikedButton = 51;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn51.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn51.Text) == false)
            {
                button.Add(btn51.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn52_Click(object sender, EventArgs e)
        {
            clikedButton = 52;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn52.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn52.Text) == false)
            {
                button.Add(btn52.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn53_Click(object sender, EventArgs e)
        {
            clikedButton = 53;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn53.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn53.Text) == false)
            {
                button.Add(btn53.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn54_Click(object sender, EventArgs e)
        {
            clikedButton = 54;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn54.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn54.Text) == false)
            {
                button.Add(btn54.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn55_Click(object sender, EventArgs e)
        {
            clikedButton = 55;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn55.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn55.Text) == false)
            {
                button.Add(btn55.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn56_Click(object sender, EventArgs e)
        {
            clikedButton = 56;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn56.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn56.Text) == false)
            {
                button.Add(btn56.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn57_Click(object sender, EventArgs e)
        {
            clikedButton = 57;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn57.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn57.Text) == false)
            {
                button.Add(btn57.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn58_Click(object sender, EventArgs e)
        {
            clikedButton = 58;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn58.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn58.Text) == false)
            {
                button.Add(btn58.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn59_Click(object sender, EventArgs e)
        {
            clikedButton = 59;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn59.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn59.Text) == false)
            {
                button.Add(btn59.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void btn60_Click(object sender, EventArgs e)
        {
            clikedButton = 60;
            setChoosen();//display the option that was shooson 
            lblquestionNO.Text = btn60.Text;
            //Option.Add(clikedButton.ToString());
            if (button.Contains(btn60.Text) == false)
            {
                button.Add(btn60.Text);
                shown[clikedButton] = PickQuestion();//add the question number to the array 
                onlineUserAnswer.RecordUserQuestion(clikedButton , getQuestion(x) , Online_Exam_Answers.GetUserID());
                }
            else
            {
                setQuestions(shown[clikedButton]);//get the question that was add to the array
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //check the internet connection
            if (InternetConnection.getConnection() == true)
            {
                lblConInfor.Text = "Connected";
                lblConInfor.ForeColor = Color.White;
            }
            else
            {
                lblConInfor.Text = "Disconnected";
                lblConInfor.ForeColor = Color.Red;
            }

            
            //TEST TIMER
            sec--;
            lblS.Text = sec < 10 ? "0" + sec.ToString() : sec.ToString();
            if (sec == 0)
            {
                mins -= 1;
                sec = 60;
                lblM.Text = mins<10? "0"+mins.ToString(): mins.ToString();
            }
            if (mins == 0 && hour!=0)
            {
                hour -= 1;
                mins = 59;
                sec = 60;

                lblM.Text = mins.ToString(); //new code added
                lblH.Text = hour < 10 ? "0" + hour.ToString() : hour.ToString();
            }

            if(hour==0 && mins >= 10 && mins < 16)
            {
                lblnotice.Text = mins.ToString()+" :REMAINING...";
                lblnotice.Visible = true;
            }
            if (hour == 0 && mins >= 5 && mins < 11)
            {
                lblnotice.ForeColor = Color.Yellow;
                lblnotice.Text =mins<10? "0"+ mins.ToString() + " :Get Ready to Submit": mins.ToString() + " :Get Ready to Submit";
                lblnotice.Visible = true;
            }
            if (hour == 0 && mins <=5)
            {
                lblnotice.ForeColor = Color.Red;
                lblnotice.Text = mins < 10 ? "0" + mins.ToString() + " :PLEASE SUBMIT" : mins.ToString() + " :PLEASE SUBMIT";
                lblnotice.Visible = true;
            }
            //stop the timer
            if (hour==0 &&  mins==0 && lblS.Text == "00")
            {
                timer1.Stop();
                UserInfor.UserFailed = "TIME UP!, TEST NOT SUBMITED";
                var result = new ResultForm();
                this.Hide();
                result.Show();
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Logout?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {
                var login = new LoginFrm();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioa1_Click(object sender , EventArgs e)
            {
            }
        private void radiob1_Click(object sender , EventArgs e)
            {
            }

        private void radioc1_Click(object sender , EventArgs e)
            {
            }

        private void btnTypeAnswer_Click(object sender , EventArgs e)
            {
            var essay = new Essay_Answer(clikedButton);
            SetButtonColor(clikedButton);
            essay.ShowDialog();
            }
        }
}
