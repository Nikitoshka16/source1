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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tvoiDataSet1.bron". При необходимости она может быть перемещена или удалена.
            this.bronTableAdapter.Fill(this.tvoiDataSet1.bron);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1M7NQB8\SQLEXPRESS01;Initial Catalog=tvoi;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand("insert into bron Values(" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + ", '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "' )", con);

            cm.ExecuteNonQuery();
            MessageBox.Show("Бронь добавлена", "Успех!");
            Form2 ad = new Form2();
            ad.Show();
            this.Close();
        }

        int selectedRow;
        private void button2_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in this.dataGridView1.CurrentRow.Cells)
            {
                if (item.ColumnIndex == 0)
                    this.textBox1.Text += item.Value.ToString();
                if (item.ColumnIndex == 1)
                    this.textBox2.Text += item.Value.ToString();
                if (item.ColumnIndex == 2)
                    this.textBox3.Text += item.Value.ToString();
                if (item.ColumnIndex == 3)
                    this.textBox4.Text += item.Value.ToString();
                if (item.ColumnIndex == 4)
                    this.textBox5.Text += item.Value.ToString();
                if (item.ColumnIndex == 5)
                    this.textBox6.Text += item.Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }
    }
}
