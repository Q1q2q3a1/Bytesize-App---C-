using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Bytesize_App;

namespace LoginEx
{
    public partial class Form1 : Form
    {
        
        OleDbCommand cmd;
        OleDbDataReader dr;
        private OleDbConnection conn = new OleDbConnection();
        //global variable to use when logged in since it is the primary key
        public static string studNum;

        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\27715\Documents\IS Labs\BYTESIZE\DIPSYDATABASE.accdb; Persist Security Info = False;";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
           

        }

 

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //test data
            txtPword.Text = "polls";
            txtStudNum.Text = "2332000";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the email and password textboxes
            txtPword.Text = "";
            txtStudNum.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //back to homepage
            HomePage f1 = new HomePage();
            f1.Show();
            this.Hide();
        }
        public bool valid() {
            bool valid = true;
            //Check student Number
            if (txtStudNum.Text.All(char.IsWhiteSpace) || !txtStudNum.Text.All(char.IsDigit))
            {
                valid = false;
                MessageBox.Show("Please enter a correct student number", "Incorrect Student Number", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            //check password
            if (txtPword.Text.All(char.IsWhiteSpace))
            {
                valid = false;
                MessageBox.Show("Please enter a password", "Missing password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            return valid;
        }
            


        private void btnStudLogin_Click(object sender, EventArgs e)
        {
            if (valid() == true)
            {
                try
                {
                    conn.Open();
                    cmd = new OleDbCommand("select student_No from Student where student_No=@studNum and studentPwd=@studentPwd", conn);
                    //adding parameters
                    cmd.Parameters.AddWithValue("@studNum", txtStudNum.Text);
                    cmd.Parameters.AddWithValue("@studentPwd", txtPword.Text);
                    
                    dr = cmd.ExecuteReader();
                    
                    //if dr is empty then person exists, if not the they do not exist in the database
                        if (dr.HasRows)
                        {
                            //close the connection since we leaving the page
                            conn.Close();
                            //Giving the global variable the since it is the primary key
                            studNum = txtStudNum.Text;
                            //Go to student page
                            StudentPage f1 = new StudentPage();
                            f1.Show();
                            this.Hide();
                            

                        }
                        else
                        {
                            MessageBox.Show("Invalid Credentials, Please Re-Enter");
                        }
                    
                    conn.Close();
                  
                }
                catch (Exception ex)
                {
                    //error if cmd fails to act
                    MessageBox.Show("Error " + ex);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Password visibility
            if (checkBox1.Checked)
            {
                txtPword.PasswordChar = '\0';
            }
            else
            {
                txtPword.PasswordChar = '*';
            }
            
            
        }
    }
}