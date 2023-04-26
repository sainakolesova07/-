using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_ИСРПО
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kolesovaSainaDataSet5.Komplectaciya". При необходимости она может быть перемещена или удалена.
            this.komplectaciyaTableAdapter.Fill(this.kolesovaSainaDataSet5.Komplectaciya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kolesovaSainaDataSet4.Avtomobil". При необходимости она может быть перемещена или удалена.
            this.avtomobilTableAdapter.Fill(this.kolesovaSainaDataSet4.Avtomobil);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены что хотите удалить?", "Выход", MessageBoxButtons.YesNo);
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены что хотите удалить?", "Выход", MessageBoxButtons.YesNo);
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);

            }
        }
    }
}
