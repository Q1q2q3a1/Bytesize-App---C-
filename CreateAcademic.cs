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
    public partial class CreateAcademic : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public CreateAcademic()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\27715\Documents\IS Labs\BYTESIZE\DIPSYDATABASE.accdb; Persist Security Info = False;";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clearing textboxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        public Boolean Valid()
        {
            Boolean valid = true;
            //Name validation
            if (textBox1.Text.All(char.IsWhiteSpace) || !textBox1.Text.All(char.IsLetter))
            {
                valid = false;
                MessageBox.Show("Please enter a correct name", "Incorrect Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }

            //Surame check
            if (textBox2.Text.All(char.IsWhiteSpace) || !textBox2.Text.All(char.IsLetter))
            {
                valid = false;
                MessageBox.Show("Please enter a correct surname", "Incorrect Surname", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            //Check email
            if (textBox3.Text.All(char.IsWhiteSpace))
            {
                valid = false;
                MessageBox.Show("Please enter an email address", "Missing Email Address", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            if (!textBox3.Text.Contains("@"))
            {
                valid = false;
                MessageBox.Show("Email address must contain an @", "Incorrect Email Address", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }



            return valid;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Valid() == true)
            {
                DialogResult ans = MessageBox.Show("Confirm profile creation", "Attention", MessageBoxButtons.YesNo);

                if (ans == DialogResult.Yes) //if they confirm the profile creation do this
                {

                    try
                    {
                        //writing the sql query
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand("insert into Academic(firstName,surname,academicEmail) values(@firstName,@surname,@academicEmail)", conn);
                        //adding parameters

                        cmd.Parameters.AddWithValue("@firstName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@surname", textBox2.Text);
                        cmd.Parameters.AddWithValue("@academicEmail", textBox3.Text);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Academic profile creation Successful", "Success");
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

        private void button1_Click(object sender, EventArgs e)
        {
            //go to admin homepage
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void CreateAcademic_Load(object sender, EventArgs e)
        {

        }
    }
}

