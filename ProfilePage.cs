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
    public partial class ProfilePage : Form
    {
        
        
        
        private OleDbConnection conn = new OleDbConnection();
        public ProfilePage()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\27715\Documents\IS Labs\BYTESIZE\DIPSYDATABASE.accdb; Persist Security Info = False;";

        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            btnEdit.Show();
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select firstName,surname,student_No,studentEmail from Student where student_No=@studNum", conn);

                //adding parameters
                cmd.Parameters.AddWithValue("@studNum", LoginEx.Form1.studNum);

                OleDbDataReader dr;
                dr = cmd.ExecuteReader();

                //running until reader is done
                while (dr.Read())
                {
                    //setting values from the database to the profile textboxes
                        txtFName.Text =dr.GetString(0);
                        txtLName.Text = dr.GetString(1);
                        txtStudNo.Text = Convert.ToString((dr.GetInt32(2)));
                        txtStudEmail.Text = dr.GetString(3);
                   
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //error if cmd fails to act
                MessageBox.Show("Error " + ex);
            }
            //making the textboxes uneditable until user clicks edit
            label1.Text = txtFName.Text +"'s " + "Profile";
            txtFName.ReadOnly = true;
            txtLName.ReadOnly = true;
            txtStudNo.ReadOnly = true;
            txtStudEmail.ReadOnly = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //making the textboxes editable 
            txtFName.ReadOnly = false;
            txtLName.ReadOnly = false;
            //student number is non editable, it is a primary key
            //txtStudNo.ReadOnly = false;
            txtStudEmail.ReadOnly = false;
            //hide the edit button
            btnEdit.Hide();
        }
        public Boolean Validation()
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
            return valid;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Update Student set firstName= @firstName,surname=@surname,studentEmail = @studentemail where student_No=@studNum", conn);

                    //adding parameters
                    cmd.Parameters.AddWithValue("@firstName", txtFName.Text);
                    cmd.Parameters.AddWithValue("@surname", txtLName.Text);
                    cmd.Parameters.AddWithValue("@studentemail", txtStudEmail.Text);
                    cmd.Parameters.AddWithValue("@studNum", LoginEx.Form1.studNum);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Update Successful", "Success");
                    //Go to student page
                    StudentPage f1 = new StudentPage();
                    f1.Show();
                    this.Hide();


                }
                catch (Exception ex)
                {
                    //error if cmd fails to act
                    MessageBox.Show("Error " + ex);
                }
            }
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Go to student page
            StudentPage f1 = new StudentPage();
            f1.Show();
            this.Hide();
            
        }
    }
}
