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
    public partial class Engineer_1 : Form
    {

        static string[] ty = File.ReadAllLines("different_conn.txt", Encoding.UTF8);
        SqlConnection connection = new SqlConnection(ty[0]);
        //static string conn = @"Data Source=XAMELEON\MSSQLSERVER1;Initial Catalog=CONSTRUCTION_FIRM;Integrated Security=True";

        public Engineer_1()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Active_project". При необходимости она может быть перемещена или удалена.
            this.active_projectTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Active_project);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.trigger_control". При необходимости она может быть перемещена или удалена.
            this.trigger_controlTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.trigger_control);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Medical_control_1". При необходимости она может быть перемещена или удалена.
            this.medical_control_1TableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Medical_control_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Ing_project". При необходимости она может быть перемещена или удалена.
            this.ing_projectTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ing_project);

        }

        //Закрыть окно
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Кнопка ПОДРОБНО
        private void button2_Click(object sender, EventArgs e)
        {
            Engineer_2 adm = new Engineer_2();
            adm.Show();
            this.Hide();
        }

        //CLR функция Value_workers-------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            string sqlex = "Value_workers";
           // using (SqlConnection connection = new SqlConnection(conn))
            //{
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (textBox1.Text != "")
                {
                    SqlParameter id_temp = new SqlParameter
                    {
                        ParameterName = "@id_temp",
                        Value = textBox1.Text
                    };

                    command.Parameters.Add(id_temp);

                    string temp = Convert.ToString(command.ExecuteScalar());
                    if (temp == "")
                    {
                        MessageBox.Show("Проект не активен");
                    }
                    textBox2.Text = Convert.ToString(command.ExecuteScalar());
                    connection.Close();

                }
                else
                {
                    MessageBox.Show("Добавьте значение.");
                }
          //  }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
