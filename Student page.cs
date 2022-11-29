using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytesize_App
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to logout?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // go back to homepage
                HomePage f1 = new HomePage();
                f1.Show();
                this.Hide();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //This butonn closes the student page 
            Application.Exit(); 

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            //this buttoin makes you return to ther home page
            HomePage f1 = new HomePage();
            f1.Show();
            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to logout?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // go back to homepage
                HomePage f1 = new HomePage();
                f1.Show();
                this.Hide();
            }
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            // go to quiz page
            //please help idk why it's showing an error
            Resources.Quiz_Page f10 = new Resources.Quiz_Page();
            f10.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //go to profile page
            ProfilePage f10 = new ProfilePage();
            f10.Show();
            this.Hide();
        }

        private void btnVProgress_Click(object sender, EventArgs e)
        {
            //go to progress page
            View_Progress f10 = new View_Progress();
            f10.Show();
            this.Hide();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            //Go to comment page
            MakeComment f1 = new MakeComment();
            f1.Show();
            this.Hide();
        }
    }
}
