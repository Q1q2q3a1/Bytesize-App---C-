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
    public partial class MakeComment : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd;
        OleDbDataReader dr;
        bool non = false;
        List<int> qNums = new List<int>();
        public MakeComment()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\27715\Documents\IS Labs\BYTESIZE\DIPSYDATABASE.accdb; Persist Security Info = False;";

        }

        private void MakeComment_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand("select * from Quiz where student_No=@studNum order by quiz_Level", conn);
                //adding parameters
                
                
                cmd.Parameters.AddWithValue("@studNum", LoginEx.Form1.studNum);
                //testing with a person who does not exist
                //cmd.Parameters.AddWithValue("@studNum", 12222333);


                dr = cmd.ExecuteReader();

                //if dr is empty then person exists, if not the they do not exist in the database
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        qNums.Add(dr.GetInt32(0));
                        //putting the data in the combox
                        comboBox1.Items.Add(dr.GetString(1) + " [LEVEL: "+ dr.GetString(2)+", QUIZ: "+ dr.GetInt32(3).ToString() +", SCORE: "+ dr.GetInt32(4).ToString()+ "]");
                        
                    }

                }
                else
                {
                    MessageBox.Show("No quizzes started");
                    conn.Close();
                    non = true;
                   
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                //error if cmd fails to act
                MessageBox.Show("Error " + ex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            //Go to student page
            StudentPage f1 = new StudentPage();
            f1.Show();
            this.Hide();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (rtxtComment.Text!="")
                {
                    try
                    {
                        conn.Open();
                        cmd = new OleDbCommand("Update Quiz set student_Comment = @comment where quiz_No=@qNum", conn);
                        //adding parameters
                        cmd.Parameters.AddWithValue("@comment", rtxtComment.Text);
                        cmd.Parameters.AddWithValue("@qNum", qNums[comboBox1.SelectedIndex]);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Comment successfully submitted");
                        rtxtComment.Text = "";
                        comboBox1.SelectedIndex = -1;

                    }
                    catch (Exception ex)
                    {
                        //error if cmd fails to act
                        MessageBox.Show("Error " + ex);
                    }
                }

                else
                {
                    MessageBox.Show("Please type a comment or exit");
                }
            }
            else
            {
                MessageBox.Show("Please select a quiz");
            }
            
        }

        private void MakeComment_Activated(object sender, EventArgs e)
        {
            //if no quizzes started go back to student page
            if (non)
            {
                //Go to student page
                StudentPage f1 = new StudentPage();
                f1.Show();
                this.Hide();
            }
        }
    }
}
