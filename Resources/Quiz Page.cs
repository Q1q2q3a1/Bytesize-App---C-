using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytesize_App.Resources
{
    public partial class Quiz_Page : Form
    {
        public Quiz_Page()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Go to student page
            StudentPage f1 = new StudentPage();
            f1.Show();
            this.Hide();
        }

        private void btnL1Q1M_Click(object sender, EventArgs e)
        {
            //Go to marketing level 1 quiz 1
            MarketingL1Q1 f1 = new MarketingL1Q1();
            f1.Show();
            this.Hide();
        }

        private void btnL1Q1IS_Click(object sender, EventArgs e)
        {
            //go back to IS level 1 quiz 1
            this.Hide();
            ISL1Q1 f1 = new ISL1Q1();
            f1.Show();
        }

        private void btnL1Q2IS_Click(object sender, EventArgs e)
        {
            //go back to IS level 1 quiz 2
            this.Hide();
            ISL1Q2 f1 = new ISL1Q2();
            f1.Show();
        }

        private void btnL2Q1IS_Click(object sender, EventArgs e)
        {
            //go back to IS level 2 quiz 1
            this.Hide();
            ISL2Q1 f1 = new ISL2Q1();
            f1.Show();
        }

        private void btnL2Q2IS_Click(object sender, EventArgs e)
        {
            //go back to IS level 2 quiz 2
            this.Hide();
            ISL2Q2 f1 = new ISL2Q2();
            f1.Show();
        }

        private void btnL3Q1IS_Click(object sender, EventArgs e)
        {
            //go back to IS level 3 quiz 1
            this.Hide();
            ISL3Q1 f1 = new ISL3Q1();
            f1.Show();
        }

        private void btnL3Q2IS_Click(object sender, EventArgs e)
        {
            //go back to IS level 3 quiz 2
            this.Hide();
            ISL3Q3 f1 = new ISL3Q3();
            f1.Show();
        }

        private void btnL1Q2M_Click(object sender, EventArgs e)
        {
            //Go to marketing level 1 quiz 2
            MarkLvl1 f1 = new MarkLvl1();
            f1.Show();
            this.Hide();
        }

        private void btnL2Q1M_Click(object sender, EventArgs e)
        {
            //Go to marketing level 2 quiz 1
            MarketingL2Q1 f1 = new MarketingL2Q1();
            f1.Show();
            this.Hide();
        }

        private void btnL2Q2M_Click(object sender, EventArgs e)
        {
            //Go to marketing level 2 quiz 2
            MarketingL2Q2 f1 = new MarketingL2Q2();
            f1.Show();
            this.Hide();
        }

        private void btnL3Q1M_Click(object sender, EventArgs e)
        {
            //Go to marketing level 3 quiz 1
            MarketingL3Q1 f1 = new MarketingL3Q1();
            f1.Show();
            this.Hide();
        }

        private void btnL3Q2M_Click(object sender, EventArgs e)
        {
            //Go to marketing level 3 quiz 2
            MarketingL3Q2 f1 = new MarketingL3Q2();
            f1.Show();
            this.Hide();
        }
    }
    
}
