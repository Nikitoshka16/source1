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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-1M7NQB8\SQLEXPRESS01;Initial Catalog=cspn;Integrated Security=True";
            string query = @"select 
                            klient.klientID,
                            klient.name,
                            klient.surname,
                            klient.fathers,
                            klient.age,
                            klient.passport,
                            klient.telephone,
                            docK.namedocK,
                            docU.namedocU,
                            docK.nalichie,
                            docU.nadobnost
                            from klient join docK on klient.klientID = docK.klientID
                            join zaiv on klient.klientID = zaiv.klientID
                            join usluga on usluga.uslugaID = zaiv.uslugaID
                            join docU on docU.uslugaID = usluga.uslugaID
                            where docK.namedocK = docU.namedocU and klient.surname = '" + textBox1.Text + "'";

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
    }
}
