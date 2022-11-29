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
    public partial class ISL2Q1 : Form
    {

        private OleDbConnection conn = new OleDbConnection();
        public ISL2Q1()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\27715\Documents\IS Labs\BYTESIZE\DIPSYDATABASE.accdb; Persist Security Info = False;";

        }

        public int calcScore()
        {//calculating the score 
            int score = 0;
            if (radioButton2.Checked == true)
            {
                score++;
            }
            if (radioButton3.Checked == true)
            {
                score++;
            }
            if (radioButton6.Checked == true)
            {
                score++;
            }
            if (radioButton7.Checked == true)
            {
                score++;
            }
            if (radioButton9.Checked == true)
            {
                score++;
            }

            return score;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            //back to quiz page
            this.Hide();
            Resources.Quiz_Page f1 = new Resources.Quiz_Page();
            f1.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                //writing the sql query
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into Quiz(quiz_Name,quiz_Level,quiz_Number,quiz_Score,student_No) values(@qN,@qL,@qNo,@qS,@sN)", conn);
                //adding parameters
                cmd.Parameters.AddWithValue("@qName", "Information systems");
                cmd.Parameters.AddWithValue("@qL", 2);
                cmd.Parameters.AddWithValue("@qNo", 1);
                cmd.Parameters.AddWithValue("@qS", calcScore());
                cmd.Parameters.AddWithValue("@sN", LoginEx.Form1.studNum);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Score: " + calcScore().ToString(), "Completion");

                //go back to quiz page
                this.Hide();
                Resources.Quiz_Page f1 = new Resources.Quiz_Page();
                f1.Show();
            }
            catch (Exception ex)
            {
                //error if cmd fails to act
                MessageBox.Show("Error " + ex);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ISL2Q1_Load(object sender, EventArgs e)
        {

        }
    }
}
