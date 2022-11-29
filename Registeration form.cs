using LoginEx;
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
using System.Data.SqlClient;

namespace Bytesize_App
{

    public partial class RegistrationForm : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public RegistrationForm()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=
; Persist Security Info = False;";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //go to login page
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //back to homepage
            HomePage f1 = new HomePage();
            f1.Show();
            this.Hide();
        }
        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {

            //Password visibility
            if (checkBox_Show_Hide.Checked)
            {
                txtpwd.UseSystemPasswordChar = true;
            }
            else
            {
                txtpwd.UseSystemPasswordChar = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Validation(object sender, CancelEventArgs e)
        {

            if (cbIS.Checked == false && cbMarketing.Checked == false)
            {
                MessageBox.Show("Choose at least one course");
            }
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                e.Cancel = true;
                txtFName.Focus();
                errorProvider1.SetError(txtFName, "Enter First Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFName, "");
            }
        }
        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtStudEmail.Text.Length > 0)

            {

                if (!rEMail.IsMatch(txtStudEmail.Text))

                {
                    txtStudEmail.Focus();
                    MessageBox.Show("Valid E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtStudEmail.SelectAll();

                    e.Cancel = true;

                }

            }
        }

        private void txtConfirmpwd_TextChanged(object sender, EventArgs e)
        {
            // confirm password
            if (txtConfirmpwd.Text == txtpwd.Text)
            {
                lblpwdmatch.ForeColor = Color.Green;
                lblpwdmatch.Text = "Passwords match";
                
            }
            else
            {
                lblpwdmatch.ForeColor = Color.Red;
                lblpwdmatch.Text = "Passwords do not match";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtStudNo.Text = "";
            txtStudEmail.Text = "";
            txtpwd.Text = "";
            txtConfirmpwd.Text = "";
            checkBox_Show_Hide.Checked = false;
            cbIS.Checked = false;
            cbMarketing.Checked = false;
            txtFName.Focus();
        }

        private void checkBox_Show_Hide_CheckedChanged_1(object sender, EventArgs e)
        {
            //Password visibility
            txtpwd.PasswordChar = '\0';
            if (checkBox_Show_Hide.Checked)
            {
                txtpwd.PasswordChar = '\0';
            }
            else
            {
                txtpwd.PasswordChar = '*';
            }
        }

        public Boolean Valid()
        {
            Boolean valid = true;
            //Name validation
            if (txtFName.Text.All(char.IsWhiteSpace) || !txtFName.Text.All(char.IsLetter))
            {
                valid = false;
                MessageBox.Show("Please enter a correct name", "Incorrect Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }

            //Surame check
            if (txtLName.Text.All(char.IsWhiteSpace) || !txtLName.Text.All(char.IsLetter))
            {
                valid = false;
                MessageBox.Show("Please enter a correct surname", "Incorrect Surname", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            //Check student Number
            if (txtStudNo.Text.All(char.IsWhiteSpace) || !txtStudNo.Text.All(char.IsDigit))
            {
                valid = false;
                MessageBox.Show("Please enter a correct student number", "Incorrect Student Number", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }


            //Check email
            if (txtStudEmail.Text.All(char.IsWhiteSpace))
            {
                valid = false;
                MessageBox.Show("Please enter an email address", "Missing Email Address", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            if (!txtStudEmail.Text.Contains("@"))
            {
                valid = false;
                MessageBox.Show("Email address must contain an @", "Incorrect Email Address", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }

            //Check password
            if (txtpwd.Text.Length < 8)
            {
                valid = false;
                MessageBox.Show("Password must be 6 characters or longer", "Incorrect password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            if (txtpwd.Text.All(char.IsWhiteSpace))
            {
                valid = false;
                MessageBox.Show("Please enter a password", "Missing password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            //check password correspondence
            if (txtConfirmpwd.Text != txtpwd.Text)
            {
                valid = false;
                MessageBox.Show("Passwords should match", "Passwords do not match", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }

            return valid;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult ans = MessageBox.Show("Confirm profile creation", "Attention", MessageBoxButtons.YesNo);

            if (ans == DialogResult.Yes) //if they confirm the profile creation do this
            {
                if (Valid() == true)
                {
                    try
                    {
                        //writing the sql query
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand("insert into Student values(@studentNo,@firstName,@surname,@studentEmail,@studentPwd,@studentCourse)", conn);
                        //adding parameters
                        cmd.Parameters.AddWithValue("@studentNo", txtStudNo.Text);
                        cmd.Parameters.AddWithValue("@firstName", txtFName.Text);
                        cmd.Parameters.AddWithValue("@surname", txtLName.Text);
                        cmd.Parameters.AddWithValue("@studentEmail", txtStudEmail.Text);
                        cmd.Parameters.AddWithValue("@studentPwd", txtConfirmpwd.Text);
                        //initialising course name
                        string course = "";
                        //setting the course name to the selected course
                        if (cbIS.Checked)
                        {
                            course = "Information Systems";
                        }
                        else if (cbMarketing.Checked)
                        {
                            course = "Marketing";
                        }
                        cmd.Parameters.AddWithValue("@studentCourse", course);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Registration Successful", "Success");
                        //go to login page and login
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                    catch (Exception ex)
                    {
                        //error if cmd fails to act
                        MessageBox.Show("Error " + ex);
                    }
                }

            }

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Password visibility
            txtConfirmpwd.PasswordChar = '\0';
            if (checkBox1.Checked)
            {
                txtConfirmpwd.PasswordChar = '\0';
            }
            else
            {
                txtConfirmpwd.PasswordChar = '*';
            }
        }

        private void txtStudNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


/* 
*/
