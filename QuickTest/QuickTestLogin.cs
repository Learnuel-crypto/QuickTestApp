using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserPasswordGen;
using CheckInternetCon;
using MySql.Data.MySqlClient;
using System.Runtime;
using System.Runtime.InteropServices;
 
namespace QuickTest
{
    public partial class LoginFrm : Form
    {
         
        int view = 0;
        MySqlConnection con = new MyConnection().getConnection();
        public LoginFrm()
        {
            InitializeComponent(); 
            
        }


        private void txtusername_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                panLine2.BackColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
                lblpassword.Visible = false; 
            } 
            
                panLine1.BackColor = Color.LightBlue;
                txtusername.Text = "";
                lblUsername.Visible = true; 
        }
        //connection string

        //try
        //{
        //    conn = new MySqlConnection();
        //    conn.ConnectionString = connString;
        //    conn.Open();
        //    MessageBox.Show("Conntion succesful");
        //}
        //catch (MySql.Data.MySqlClient.MySqlException ex)
        //{

        //    MessageBox.Show(ex.Message);
        //}

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                panLine1.BackColor = Color.Silver;
                txtusername.Text = "Username";
                lblUsername.Visible = false;
            }
            
            panLine2.BackColor = Color.LightBlue;
            txtPassword.Text = "";
            lblpassword.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //InternetGetConnectedState(out Des, 0).ToString()
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (InternetConnection.getConnection() == false)
            {
                //validate inputs
                try
                {
                    if (string.IsNullOrEmpty(txtusername.Text) || txtusername.Text == "Username")
                    {
                        throw new Exception("Enter Username");

                    }
                    if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                    {
                        throw new Exception("Enter Password");
                    }
                    else if (txtPassword.Text.Length == 12 && txtPassword.Text.Substring(0, 8) == UserLogin.GET_UserPass)
                    {
                        UserInfor.setUser(txtusername.Text);
                        this.Hide();
                        var Test = new QuickTestFrm();
                        Test.Show();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Incorrect Username or Password ");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            { 
                try
                {
                    ///CODE THE ONLINE LOGIN HERE
                    if (string.IsNullOrEmpty(txtusername.Text) || txtusername.Text == "Username")
                    {
                        throw new Exception("Enter Username");

                    }
                    if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                    {
                        throw new Exception("Enter Password");
                    }
                    else if(string.IsNullOrEmpty(txtusername.Text)==false && string.IsNullOrEmpty(txtPassword.Text)==false) 
                    {
                        //if (UserInfor.Passwords.Contains(txtPassword.Text) && UserInfor.Users.Contains(txtusername.Text) )
                        //UserInfor.setUser(txtusername.Text);
                        if (InternetConnection.getConnection() == false)
                            {
                            throw new Exception("No Internet Connection");
                            }
                        string LoginUser = "SELECT userslogin.UserID,userslogin.UserName,userslogin.Password FROM userslogin WHERE userslogin.UserName='" + txtusername.Text + "' AND userslogin.Password ='" + txtPassword.Text + "'";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(LoginUser , con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        int x = dt.Rows.Count;
                        if (x<2 && x>0)
                            { 
                            foreach(DataRow dr in dt.Rows)
                                {
                                Online_Exam_Answers.UserID=Int32.Parse(dr[0].ToString());
                                UserInfor.setUser(dr[1].ToString());
                                }
                            this.Hide();
                            DName();
                            var Test = new QuickTestFrm();
                            Test.Show();
                            this.Close();
                            }
                        else
                            {
                            throw new Exception("Incorrect Username or Password ");
                            }
                        
                        }
                    else
                    {
                        throw new Exception("Incorrect Username or Password ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if(view == 0)
            {
                btnview.Image = Image.FromFile(@"Images\Invisible.PNG");
                txtPassword.UseSystemPasswordChar = false;
                view = 1;
            }else if (view == 1)
            {
                btnview.Image = Image.FromFile(@"Images\Visible.PNG");
                txtPassword.UseSystemPasswordChar = true;
                view = 0;
            }
            this.ActiveControl = txtPassword;
              
        }
       
        private void LoginFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (InternetConnection.getConnection() == false)
                {
                    try
                    {
                        if (string.IsNullOrEmpty(txtusername.Text) || txtusername.Text == "Username")
                        {
                            throw new Exception("Enter Username");

                        }
                        if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                        {
                            throw new Exception("Enter Password");
                        }
                        else if (txtPassword.Text.Length == 12 && txtPassword.Text.Substring(0, 8) == UserLogin.GET_UserPass)
                        {
                            UserInfor.setUser(txtusername.Text);
                            this.Hide();
                            DName();
                            var Test = new QuickTestFrm();
                            Test.Show();
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Incorrect Username or Password ");
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    try
                    {
                        //CODE THE ONLINE LOGING HERE
                        if (string.IsNullOrEmpty(txtusername.Text) || txtusername.Text == "Username")
                        {
                            throw new Exception("Enter Username");

                        }
                        if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                        {
                            throw new Exception("Enter Password");
                        }
                        else if (UserInfor.Passwords.Contains(txtPassword.Text) && UserInfor.Users.Contains(txtusername.Text))
                        {
                            UserInfor.setUser(txtusername.Text);
                            this.Hide();
                            DName();
                            var Test = new QuickTestFrm();
                            Test.Show();
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Incorrect Username or Password ");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        /// <summary>
        /// get the Name of the user when they login successfully
        /// </summary>
        private void DName()
        {
            try
            {
                String query = "SELECT FirstName,LastName FROM users where UserID IN (SELECT UserID FROM userslogin where "
                    + "UserName ='" + txtusername.Text + "' and  Password='" + txtPassword.Text + "')";
                con.Open();
                MySqlCommand commdand = new MySqlCommand(query, con);
                MySqlDataReader reader = commdand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserInfor.setName(reader.GetString(0) + " " + reader.GetString(1));
                    }
                }
                con.Close();
            }
            catch (Exception)
            {

            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (InternetConnection.getConnection() == false)
                {
                    try
                    {
                        if (string.IsNullOrEmpty(txtusername.Text) || txtusername.Text == "Username")
                        {
                            throw new Exception("Enter Username");

                        }
                        if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                        {
                            throw new Exception("Enter Password");
                        }
                        else if (txtPassword.Text.Length == 12 && txtPassword.Text.Substring(0, 8) == UserLogin.GET_UserPass)
                        {
                            UserInfor.setUser(txtusername.Text);
                            this.Hide();
                            DName();
                            var Test = new QuickTestFrm();
                            Test.Show();
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Incorrect Username or Password ");
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    try
                    {
                        //CODE THE ONLINE LOGIN HERE
                        if (string.IsNullOrEmpty(txtusername.Text) || txtusername.Text == "Username")
                        {
                            throw new Exception("Enter Username");

                        }
                        if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                        {
                            throw new Exception("Enter Password");
                        }
                        else if (UserInfor.Passwords.Contains(txtPassword.Text) && UserInfor.Users.Contains(txtusername.Text))
                        {
                            UserInfor.setUser(txtusername.Text);
                            this.Hide();
                            var Test = new QuickTestFrm();
                            Test.Show();
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Incorrect Username or Password ");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
