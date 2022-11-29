
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
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
            /*
            conn.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from student", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            */
        }
    }
}

