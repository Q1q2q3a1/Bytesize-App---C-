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

namespace Bytesize_App
{
    public partial class AdminLogin : Form
    {
        OleDbCommand cmd;
        OleDbDataReader dr;
        private OleDbConnection conn = new OleDbConnection();
        public static string adminNum;
        public AdminLogin()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\27715\Documents\IS Labs\BYTESIZE\DIPSYDATABASE.accdb; Persist Security Info = False;";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome3_Click(object sender, EventArgs e)
        {
            //Back to homepage
            HomePage f1 = new HomePage();
            f1.Show();
            this.Hide();
        }

        public bool valid()
        {
            bool valid = true;
            //Check Admin Number
            if (textBox1.Text.All(char.IsWhiteSpace) || !textBox1.Text.All(char.IsDigit))
            {
                valid = false;
                MessageBox.Show("Please enter a correct admin number", "Incorrect Admin Number", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            //check password
            if (textBox2.Text.All(char.IsWhiteSpace))
            {
                valid = false;
                MessageBox.Show("Please enter a password", "Missing password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            return valid;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (valid() == true)
            {
                try
                {
                    conn.Open();
                    cmd = new OleDbCommand("select admin_No from Administrator where admin_No=@adminNo and adminPwd=@adminPwd", conn);
                    //adding parameters
                    cmd.Parameters.AddWithValue("@adminNo", textBox1.Text);
                    cmd.Parameters.AddWithValue("@adminPwd", textBox2.Text);
                    dr = cmd.ExecuteReader();

                    //if dr is empty then person exists, if not the they do not exist in the database
                    if (dr.HasRows)
                    {
                            //close the connection since we leaving the page
                            conn.Close();
                            adminNum = textBox1.Text;

                            //go to admin homepage
                            Form5 f5 = new Form5();
                            f5.Show();
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
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            textBox1.Text = "221100";
            textBox2.Text = "coolcats";

        }
    }
}
