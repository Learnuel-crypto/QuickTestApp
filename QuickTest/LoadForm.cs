using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckInternetCon;

namespace QuickTest
{
    
    public partial class LoadForm : Form
    {
        int count = 20;
        bool error = false;

        public LoadForm()
        {
            InitializeComponent();
            try
                {
                if (InternetConnection.getConnection() == true)
                    {
                    OnlineQuestions questions = new OnlineQuestions();
                    timer1.Start();
                    }
                else
                    {
                    error = true;
                    throw new Exception("Internet connection is required");
                   
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Network Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                
                }
                    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++; 
            lblcount.Text = count < 10 ? "0"+count.ToString() : count.ToString();
            if (count == 100)
            {
                var login = new LoginFrm();
                timer1.Stop();
                this.Hide();
                login.Show();
                 
            }
            
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            if (error == true)
                {
                Application.Exit();
                }

            //if (InternetConnection.getConnection() == true)
            //{
            //    new Thread(() =>
            //    {
            //        UserInfor users = new UserInfor();
            //        //OnlineQuestions questions = new OnlineQuestions();
            //    }).Start();
            //}
        }
    }
}
