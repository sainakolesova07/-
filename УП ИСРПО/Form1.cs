using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace УП_ИСРПО
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kolesovaSainaDataSet1.Polzovateli". При необходимости она может быть перемещена или удалена.
            this.polzovateliTableAdapter1.Fill(this.kolesovaSainaDataSet1.Polzovateli);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection KolesovaSainaConnectionString = new SqlConnection(@"Data Source=LAPTOP-LG6B5DKF;Initial Catalog=KolesovaSaina;Integrated Security=True");
            string query = "Select * FROM Polzovateli WHERE Login='" + comboBox1.Text + "'and Password='" + textBox1.Text + "'";
            KolesovaSainaConnectionString.Open();

            SqlCommand cmd = new SqlCommand(query, KolesovaSainaConnectionString);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    object Login = rdr.GetValue(0);
                    object Password = rdr.GetValue(1);
                    string login = Login.ToString();
                    string password = Password.ToString();
                    if (login == "Админстр")
                    {
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        this.Hide();
                    }
                    else if (login == "Продавец")
                    {
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        this.Hide();
                    }
                }  
            }
        }
    }
}
