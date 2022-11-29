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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // go to admin profile view
            AdminAcc f1 = new AdminAcc();
            f1.Show();
            this.Hide();
        }

        private void createNewAcademicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open Academic Registration form
            CreateAcademic f1 = new CreateAcademic();
            f1.Show();
            this.Hide();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateAcademicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open Academic Update form
            UpdateAcademic f1 = new UpdateAcademic();
            f1.Show();
            this.Hide();
        }

        private void updateFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //go to update feedback page
            
            UpdateFeedback f1 = new UpdateFeedback();
            f1.Show();
            this.Hide();
        }
    }
}
