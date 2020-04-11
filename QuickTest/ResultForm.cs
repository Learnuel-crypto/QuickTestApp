using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickTest
{
    public partial class ResultForm : Form
    {
        public ResultForm( )
        {
            InitializeComponent();
            lblName.Text = UserInfor.getUser();
            lblscore.Text = UserInfor.getUserScore().ToString() ;
            lblinfor.Text = UserInfor.UserFailed;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrm login = new LoginFrm();
            login.Show();
            this.Close();
        }
    }
}
