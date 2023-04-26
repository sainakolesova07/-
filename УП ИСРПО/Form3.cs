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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID_Avtomobilya = textBox1.Text;
            string Nazvanie = textBox2.Text;
            string Svet = textBox3.Text;
            string God_vupyska = textBox4.Text;
            string ID_Postavki = textBox5.Text;
            string Scena = textBox6.Text;

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-LG6B5DKF;Initial Catalog=KolesovaSaina;Integrated Security=True");
            con.Open();
            string query = "INSERT INTO Avtomobil (ID_Avtomobilya,Nazvanie,Svet,God_vupyska,ID_Postavki,Scena) VALUES ('" + ID_Avtomobilya + "','" + Nazvanie + "','" + Svet + "','" + God_vupyska + "','" + ID_Postavki + "','" + Scena + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
