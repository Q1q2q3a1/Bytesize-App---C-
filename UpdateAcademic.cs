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

    public partial class UpdateAcademic : Form
    {
        OleDbCommand cmd;
        OleDbDataReader dr;
        private OleDbConnection conn = new OleDbConnection();
        //Lists to store what we initially fetch from the database
        List<string> academicEmails = new List<string>();
        List<string> firstNames = new List<string>();
        List<string> surnames = new List<string>();
        public UpdateAcademic()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\27715\Documents\IS Labs\BYTESIZE\DIPSYDATABASE.accdb; Persist Security Info = False;";

        }

        private void UpdateAcademic_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            try
            {
                conn.Open();
                cmd = new OleDbCommand("select firstName,surname,academicEmail from Academic", conn);
                

                dr = cmd.ExecuteReader();

                //if dr is empty then person exists, if not the they do not exist in the database
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //adding all the academics to the combobox
                        comboBox1.Items.Add(dr.GetString(0) + " " + dr.GetString(1));
                        firstNames.Add(dr.GetString(0));
                        surnames.Add(dr.GetString(1));
                        academicEmails.Add(dr.GetString(2));
                    }

                }
                else
                {
                    MessageBox.Show("No Academics in the ByteSize database");
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                //error if cmd fails to act
                MessageBox.Show("Error " + ex);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnEdit.Show();
            if (comboBox1.SelectedIndex != -1)
            {
                txtFName.Text = firstNames[comboBox1.SelectedIndex];
                txtLName.Text = surnames[comboBox1.SelectedIndex];
                txtacEmail.Text = academicEmails[comboBox1.SelectedIndex];

                txtacEmail.ReadOnly = true;
                txtFName.ReadOnly = true;
                txtLName.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Please select an academic");
            }
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Hide();
            txtacEmail.ReadOnly = false;
            txtFName.ReadOnly = false;
            txtLName.ReadOnly = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go to admin homepage
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
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
            if (txtacEmail.Text.All(char.IsWhiteSpace))
            {
                valid = false;
                MessageBox.Show("Please enter an email address", "Missing Email Address", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            if (!txtacEmail.Text.Contains("@"))
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
                    OleDbCommand cmd = new OleDbCommand("Update Academic set firstName= @firstName,surname=@surname,academicEmail = @acemail where academic_No=@acNo", conn);

                    //adding parameters
                    cmd.Parameters.AddWithValue("@firstName", txtFName.Text);
                    cmd.Parameters.AddWithValue("@surname", txtLName.Text);
                    cmd.Parameters.AddWithValue("@acemail", txtacEmail.Text);
                    //the selected item index corresposnds with the numbers in the database
                    cmd.Parameters.AddWithValue("@acNo", comboBox1.SelectedIndex+1);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Update Successful", "Success");
                    //go to admin homepage
                    Form5 f5 = new Form5();
                    f5.Show();
                    this.Hide();


                }
                catch (Exception ex)
                {
                    //error if cmd fails to act
                    MessageBox.Show("Error " + ex);
                }
            }
        }
    }
}
