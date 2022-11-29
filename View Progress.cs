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
    public partial class View_Progress : Form
    {
        OleDbCommand cmd;
        OleDbDataReader dr;
        private OleDbConnection conn = new OleDbConnection();
        
        public View_Progress()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\27715\Documents\IS Labs\BYTESIZE\DIPSYDATABASE.accdb; Persist Security Info = False;";

        }

        public void MarketingReport(string[] quiz){
            //Level 1
            //Quiz one
            if (quiz[2] == "1" && quiz[3] == "1")
            {
                label8.Text = "Quiz 1: " + quiz[4];
            }
            
            //Level 1
            //Quiz two
            if (quiz[2] == "1" && quiz[3] == "2")
            {
                label11.Text = "Quiz 2: " + quiz[4];
            }
            

            //Level 2
            //Quiz one
            if (quiz[2] == "2" && quiz[3] == "1")
            {
                label16.Text = "Quiz 1: " + quiz[4];
            }
            

            //Level 2
            //Quiz two
            if (quiz[2] == "2" && quiz[3] == "2")
            {
                label19.Text = "Quiz 2: " + quiz[4];
            }
            
            //Level 3
            //Quiz one
            if (quiz[2] == "3" && quiz[3] == "1")
            {
                label15.Text = "Quiz 1: " + quiz[4];
            }
            

            //Level 3
            //Quiz two
            if (quiz[2] == "3" && quiz[3] == "2")
            {
                label10.Text = "Quiz 2: " + quiz[4];
            }
            



        }
        public void ISReport(string[] quiz)
        {
            //Level 1
            //Quiz one
            if (quiz[2] == "1" && quiz[3] == "1")
            {
                label14.Text = "Quiz 1: " + quiz[4];
            }
            

            //Level 1
            //Quiz two
            if (quiz[2] == "1" && quiz[3] == "2")
            {
                label18.Text = "Quiz 2: " + quiz[4];
            }
            
            //Level 2
            //Quiz one
            if (quiz[2] == "2" && quiz[3] == "1")
            {
                label13.Text = "Quiz 1: " + quiz[4];
            }
            

            //Level 2
            //Quiz two
            if (quiz[2] == "2" && quiz[3] == "2")
            {
                label17.Text = "Quiz 2: " + quiz[4];
            }
            
            //Level 3
            //Quiz one
            if (quiz[2] == "3" && quiz[3] == "1")
            {
                label12.Text = "Quiz 1: " + quiz[4];
            }
            
            //Level 3
            //Quiz two
            if (quiz[2] == "3" && quiz[3] == "2")
            {
                label9.Text = "Quiz 2: " + quiz[4];
            }
            

        }

        private void View_Progress_Load(object sender, EventArgs e)
        {
            string[] quiz = new string[6];
            try
            {
                conn.Open();
                cmd = new OleDbCommand("select * from Quiz where student_No=@studNum", conn);
                //adding parameters
                cmd.Parameters.AddWithValue("@studNum", LoginEx.Form1.studNum);

                dr = cmd.ExecuteReader();

                //if dr is empty then person exists, if not the they do not exist in the database
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //adding the row the the quiz array which will be analysed to edit the labels
                        quiz[0] = dr.GetInt32(0).ToString();
                        quiz[1] = dr.GetString(1);
                        quiz[2] = dr.GetString(2);
                        quiz[3] = dr.GetInt32(3).ToString();
                        quiz[4] = dr.GetInt32(4).ToString();
                        quiz[5] = dr.GetInt32(5).ToString();
                        if (quiz[1] == "Information systems")
                        {
                            ISReport(quiz);
                        }
                        else //if (quiz[1] == "Marketing")
                        {
                            MarketingReport(quiz);
                        }
                        
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



            //Create report
            try
            {

            }catch
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Go to student page
            StudentPage f1 = new StudentPage();
            f1.Show();
            this.Hide();
        }
    }
}
