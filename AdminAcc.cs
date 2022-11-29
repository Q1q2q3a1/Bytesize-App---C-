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
    public partial class AdminAcc : Form
    {
        public AdminAcc()
        {
            InitializeComponent();
        }

        private void AdminAcc_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // go back to admin homepage view
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
