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
using System.IO;

namespace WindowsFormsApplication1
{

    public partial class Auth : Form
    {
               
        static string[] ty = File.ReadAllLines("different_conn.txt", Encoding.UTF8);
        SqlConnection connection = new SqlConnection(ty[0]);

        //static string conn = @"Data Source=XAMELEON\MSSQLSERVER1;Initial Catalog=CONSTRUCTION_FIRM;Integrated Security=True";

        public Auth()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "director" && textBox2.Text == "director")
            {
                Director_1 adm = new Director_1();
                adm.Show();
            }
            else if (textBox1.Text == "engineer" && textBox2.Text == "engineer")
            {
                Engineer_1 adm = new Engineer_1();
                adm.Show();
            }
            else if (textBox1.Text == "manager" && textBox2.Text == "manager")
            {
                Manager_1 adm = new Manager_1();
                adm.Show();
            }

            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Неверный логин или пароль!"); 
            }
        }

    }
}
