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
    public partial class Manager_1 : Form
    {
        static string[] ty = File.ReadAllLines("different_conn.txt", Encoding.UTF8);
        SqlConnection connection = new SqlConnection(ty[0]);
        //static string conn = @"Data Source=XAMELEON\MSSQLSERVER1;Initial Catalog=CONSTRUCTION_FIRM;Integrated Security=True";

        public Manager_1()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Medical_control_1". При необходимости она может быть перемещена или удалена.
            this.medical_control_1TableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Medical_control_1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Кнопка УДАЛИТЬ ДЛЯ ТАБЛИЦЫ СОТРУДНИКИ-------------------------------------------------------------
        private void button7_Click_1(object sender, EventArgs e)
        {
            string sqlex = "delete_workers";
           // using (SqlConnection connection = new SqlConnection(conn))
            //{
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter id_temp = new SqlParameter
                {
                    ParameterName = "@id_temp",
                    Value = textBox10.Text
                };

                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                command.Parameters.Add(id_temp);

                if (textBox10.Text == "")
                {
                    MessageBox.Show("Добавьте параметры");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Сотрудники);
                    this.medical_control_1TableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Medical_control_1);
                    MessageBox.Show("Данные удалены!");
                    textBox10.Text = "";
                }
           // }
        }

        //Кнопка ДОБАВИТЬ ДЛЯ ТАБЛИЦЫ СОТРУДНИКИ-------------------------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {
            string sqlex = "insert_workers";
          //  using (SqlConnection connection = new SqlConnection(conn))
           // {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (textBox10.Text == "")
                {

                    SqlParameter id_position = new SqlParameter
                    {
                        ParameterName = "@id_position",
                        Value = textBox11.Text
                    };
                    command.Parameters.Add(id_position);

                    SqlParameter id_proj = new SqlParameter
                    {
                        ParameterName = "@id_proj",
                        Value = textBox12.Text
                    };
                    command.Parameters.Add(id_proj);

                    SqlParameter surname = new SqlParameter
                    {
                        ParameterName = "@surname",
                        Value = textBox13.Text
                    };
                    command.Parameters.Add(surname);

                    SqlParameter name = new SqlParameter
                    {
                        ParameterName = "@name",
                        Value = textBox14.Text
                    };
                    command.Parameters.Add(name);

                    SqlParameter middlename = new SqlParameter
                    {
                        ParameterName = "@middlename",
                        Value = textBox15.Text
                    };
                    command.Parameters.Add(middlename);

                    SqlParameter birth = new SqlParameter
                    {
                        ParameterName = "@birth",
                        Value = textBox16.Text
                    };
                    command.Parameters.Add(birth);

                    SqlParameter med_card = new SqlParameter
                    {
                        ParameterName = "@med_card",
                        Value = textBox17.Text
                    };
                    command.Parameters.Add(med_card);


                    if (textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" ||
                        textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "")
                    {
                        MessageBox.Show("Добавьте параметры");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Сотрудники);
                        this.medical_control_1TableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Medical_control_1);
                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        textBox16.Text = "";
                        textBox17.Text = "";
                        MessageBox.Show("Данные добавлены!");
                    }
                }
                else
                {
                    MessageBox.Show("Удалите ID работника!");
                }

          //  }
        }

        //Кнопка ИЗМЕНИТЬ ДЛЯ ТАБЛИЦЫ СОТРУДНИКИ--------------------------------------------------------------
        private void button6_Click_1(object sender, EventArgs e)
        {
            string sqlex = "update_workers";
            //using (SqlConnection connection = new SqlConnection(conn))
           // {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (textBox10.Text != "")
                {

                    SqlParameter id_temp = new SqlParameter
                    {
                        ParameterName = "@id_temp",
                        Value = textBox10.Text
                    };
                    command.Parameters.Add(id_temp);


                    if (textBox11.Text != "")
                    {
                        SqlParameter id_position = new SqlParameter
                        {
                            ParameterName = "@id_position",
                            Value = textBox11.Text
                        };
                        command.Parameters.Add(id_position);
                    }

                    SqlParameter id_proj = new SqlParameter
                    {
                        ParameterName = "@id_proj",
                        Value = textBox12.Text
                    };
                    command.Parameters.Add(id_proj);

                    SqlParameter surname = new SqlParameter
                    {
                        ParameterName = "@surname",
                        Value = textBox13.Text
                    };
                    command.Parameters.Add(surname);

                    SqlParameter name = new SqlParameter
                    {
                        ParameterName = "@name",
                        Value = textBox14.Text
                    };
                    command.Parameters.Add(name);

                    SqlParameter middlename = new SqlParameter
                    {
                        ParameterName = "@middlename",
                        Value = textBox15.Text
                    };
                    command.Parameters.Add(middlename);

                    SqlParameter birth = new SqlParameter
                    {
                        ParameterName = "@birth",
                        Value = textBox16.Text
                    };
                    command.Parameters.Add(birth);

                    SqlParameter med_card = new SqlParameter
                    {
                        ParameterName = "@med_card",
                        Value = textBox17.Text
                    };
                    command.Parameters.Add(med_card);


                    if (textBox11.Text == "" && textBox12.Text == "" && textBox13.Text == "" && textBox14.Text == "" &&
                        textBox15.Text == "" && textBox16.Text == "" && textBox17.Text == "")
                    {
                        MessageBox.Show("Добавьте параметры");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Сотрудники);
                        this.medical_control_1TableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Medical_control_1);
                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        textBox16.Text = "";
                        textBox17.Text = "";
                        MessageBox.Show("Данные обновлены!");
                    }
                }
                else
                {
                    MessageBox.Show("Введите ID работника!");
                }
           // }
        }


        //Заполнение ячеек
        private void сотрудникиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox10.Text = сотрудникиDataGridView.CurrentRow.Cells[0].Value.ToString();
            textBox11.Text = сотрудникиDataGridView.CurrentRow.Cells[1].Value.ToString();
            textBox12.Text = сотрудникиDataGridView.CurrentRow.Cells[2].Value.ToString();
            textBox13.Text = сотрудникиDataGridView.CurrentRow.Cells[3].Value.ToString();
            textBox14.Text = сотрудникиDataGridView.CurrentRow.Cells[4].Value.ToString();
            textBox15.Text = сотрудникиDataGridView.CurrentRow.Cells[5].Value.ToString();
            textBox16.Text = сотрудникиDataGridView.CurrentRow.Cells[6].Value.ToString();
            textBox17.Text = сотрудникиDataGridView.CurrentRow.Cells[7].Value.ToString();
        }

        //Сброс данных
        private void button2_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
