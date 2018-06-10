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
    public partial class Director_1 : Form
    {

        static string[] ty = File.ReadAllLines("different_conn.txt", Encoding.UTF8);
        SqlConnection connection = new SqlConnection(ty[0]);
        //static string conn = @"Data Source=XAMELEON\MSSQLSERVER1;Initial Catalog=CONSTRUCTION_FIRM;Integrated Security=True";
        public Director_1()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Active_project_2". При необходимости она может быть перемещена или удалена.
            this.active_project_2TableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Active_project_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Director_workers". При необходимости она может быть перемещена или удалена.
            this.director_workersTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Director_workers);

        }

        //КНОПКА ДЛЯ СКАЛЯРНОЙ ФУНКЦИИ SALARY
        private void button1_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(conn))
           // {
                //проверка на число
                string Str1 = textBox1.Text.Trim();
                string Str2 = textBox2.Text.Trim();
                int Num1;
                int Num2;
                bool isNum1 = int.TryParse(Str1, out Num1);
                bool isNum2 = int.TryParse(Str2, out Num2);
                if (isNum1 && isNum2)
                {
                    // действие если строка - число
                    string salary_sql = "select dbo.Salary(" + textBox1.Text + "," + textBox2.Text + ")";
                    connection.Open();
                    SqlCommand command = new SqlCommand(salary_sql, connection);
                    string temp = Convert.ToString(command.ExecuteScalar());
                    if (temp == "")
                    {
                        MessageBox.Show("Проект не активен");
                    }
                    textBox3.Text = Convert.ToString(command.ExecuteScalar());
                    connection.Close();
                }
                else
                {
                    // действие если строка - не число
                    MessageBox.Show("Введите числа");
                }                
          //  }
        }

        //Кнопка ПОДРОБНО
        private void button2_Click(object sender, EventArgs e)
        {
            Director_2 adm = new Director_2();
            adm.Show();
            this.Hide();
        }

        //Закрытие окна
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
