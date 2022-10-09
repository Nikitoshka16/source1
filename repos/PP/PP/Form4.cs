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

namespace PP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-1M7NQB8\SQLEXPRESS01;Initial Catalog=tvoi;Integrated Security=True";
            string query = @"select 
                            klient.namek,
                            klient.surnamek,
                            klient.fathersk,
                            chek.cumma,
                            chek.datachek,
                            bron.cutki,
                            room.numberroom,
                            room.price
                            from klient 
                            join bron on klient.klientID = bron.klientID
                            join room on room.numberroom = bron.numberroom
                            join chek on bron.bronID = chek.bronID
                            where klient.surnamek = '" + textBox1.Text + "'";

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in this.dataGridView1.CurrentRow.Cells)
            {
                if (item.ColumnIndex == 0)
                    this.textBox2.Text += item.Value.ToString();
                if (item.ColumnIndex == 1)
                    this.textBox3.Text += item.Value.ToString();
                if (item.ColumnIndex == 2)
                    this.textBox4.Text += item.Value.ToString();
                if (item.ColumnIndex == 3)
                    this.textBox5.Text += item.Value.ToString();
                if (item.ColumnIndex == 4)
                    this.textBox6.Text += item.Value.ToString();
                if (item.ColumnIndex == 5)
                    this.textBox7.Text += item.Value.ToString();
                if (item.ColumnIndex == 6)
                    this.textBox8.Text += item.Value.ToString();
                if (item.ColumnIndex == 7)
                    this.textBox9.Text += item.Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var a = new Word("письмо.docx");

            var items = new Dictionary<string, string>
            {
               { "<1>", textBox2.Text },
               { "<2>", textBox3.Text },
               { "<3>", textBox4.Text },
               { "<4>", textBox5.Text },
               { "<5>", textBox6.Text },
               { "<6>", textBox7.Text },
               { "<7>", textBox8.Text },
               { "<8>", textBox9.Text }

            };
            a.Process(items);

            MessageBox.Show("Документ создан");
        }
    }
}
