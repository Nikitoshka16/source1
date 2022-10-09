using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cspn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1M7NQB8\SQLEXPRESS01;Initial Catalog=cspn;Integrated Security=True");
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM users WHERE login = '" + textBox1.Text + " ' and password = '" + textBox2.Text + "'", con);

            sda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
