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
    public partial class UpdateFeedback : Form
    {
        
        
        private OleDbConnection conn = new OleDbConnection();
        public UpdateFeedback()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\27715\Documents\IS Labs\BYTESIZE\DIPSYDATABASE.accdb; Persist Security Info = False;";


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //go to admin homepage
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (valid() == true)
                {

                    try
                    {
                        //writing the sql query
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand("update Courses set feedback_Status=@fs where course_Name=@cs", conn);
                        //adding parameters
                        cmd.Parameters.AddWithValue("@fs", "feedback received");
                        string coursename = "";
                        //chosing which course name's status to update
                        if (checkBox2.Checked == true)
                        {
                            coursename ="Information systems";
                        }
                        else
                        {
                            coursename = "Marketing";
                        }

                        cmd.Parameters.AddWithValue("@cs", coursename);

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Feedback successfully update");
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
            else
            {
                MessageBox.Show("If no feedback has not been received, click the Back button ");
            }
        }
        public bool valid()
        {
            bool valid = true;
            if (checkBox2.Checked==false && checkBox3.Checked==false)
            {
                valid = false;
                MessageBox.Show("Please select a course", "No course chosen", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }
            if (checkBox2.Checked == true && checkBox3.Checked == true)
            {
                valid = false;
                MessageBox.Show("Please select only one course", "Too many courses chosen", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return valid;
            }

            return valid;
        }
    }
}
