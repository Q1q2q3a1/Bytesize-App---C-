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
    public partial class HomePage : Form
    {
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=StudentAppt;Integrated Security=True";
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm f2 = new RegistrationForm();
            f2.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin f6 = new AdminLogin();
            f6.Show();
            this.Hide();
            /*
            //go to admin login page
            AdminLogin f6 = new AdminLogin();
            f6.Show();
            this.Hide();
            */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close application
            Application.Exit();
        }
    }
}
