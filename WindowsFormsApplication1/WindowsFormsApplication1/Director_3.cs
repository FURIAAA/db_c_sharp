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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Director_3 : Form
    {
        static string[] ty = File.ReadAllLines("different_conn.txt", Encoding.UTF8);
        SqlConnection connection = new SqlConnection(ty[0]);
        //static string conn = @"Data Source=XAMELEON\MSSQLSERVER1;Initial Catalog=CONSTRUCTION_FIRM;Integrated Security=True";

        public Director_3()
        {
            InitializeComponent();
        }


        //КНОПКА НАЗАД
        private void button1_Click(object sender, EventArgs e)
        {
            Director_2 adm = new Director_2();
            adm.Show();
            this.Hide();
        }

        //КНОПКА ЗАКРЫТЬ
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void варианты_проектаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.варианты_проектаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONSTRUCTION_FIRMDataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Ответственный". При необходимости она может быть перемещена или удалена.
            this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Варианты_проекта". При необходимости она может быть перемещена или удалена.
            this.варианты_проектаTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Варианты_проекта);

        }

        //Кнопка ДОБАВИТЬ ДЛЯ ТАБЛИЦЫ ВАРИАНТЫ ПРОЕКТА-------------------------------------------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            string sqlex = "insert_var_proj";
           // using (SqlConnection connection = new SqlConnection(conn))
           // {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (textBox1.Text == "")
                {

                    SqlParameter type_project = new SqlParameter
                    {
                        ParameterName = "@type_project",
                        Value = textBox2.Text
                    };
                    command.Parameters.Add(type_project);

                    SqlParameter difficult = new SqlParameter
                    {
                        ParameterName = "@difficult",
                        Value = textBox3.Text
                    };
                    command.Parameters.Add(difficult);

                    
                    if (textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Добавьте параметры");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.варианты_проектаTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Варианты_проекта);
                        this.должностиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Должности);
                        this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
                        textBox2.Text = "";
                        textBox3.Text = "";
                        MessageBox.Show("Данные добавлены!");
                    }
                }
                else
                {
                    MessageBox.Show("Удалите ID тип проекта!");
                }

          //  }
        }

        //Кнопка УДАЛИТЬ ДЛЯ ТАБЛИЦЫ ВАРИАНТЫ ПРОЕКТА-------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            string sqlex = "delete_var_proj";
           // using (SqlConnection connection = new SqlConnection(conn))
           // {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter id_temp = new SqlParameter
                {
                    ParameterName = "@id_temp",
                    Value = textBox1.Text
                };

                textBox2.Text = "";
                textBox3.Text = "";
                command.Parameters.Add(id_temp);

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Добавьте параметры");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.варианты_проектаTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Варианты_проекта);
                    this.должностиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Должности);
                    this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
                    MessageBox.Show("Данные удалены!");
                    textBox1.Text = "";
                }
           // }
        }

        //Кнопка ИЗМЕНИТЬ ДЛЯ ТАБЛИЦЫ ВАРИАНТЫ ПРОЕКТА--------------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            string sqlex = "update_var_proj";
            //using (SqlConnection connection = new SqlConnection(conn))
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


                    if (textBox2.Text != "")
                    {
                        SqlParameter type_project = new SqlParameter
                        {
                            ParameterName = "@type_project",
                            Value = textBox2.Text
                        };
                        command.Parameters.Add(type_project);
                    }

                    SqlParameter difficult = new SqlParameter
                    {
                        ParameterName = "@difficult",
                        Value = textBox3.Text
                    };
                    command.Parameters.Add(difficult);


                    if (textBox2.Text == "" && textBox3.Text == "")
                    {
                        MessageBox.Show("Добавьте параметры");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.варианты_проектаTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Варианты_проекта);
                        this.должностиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Должности);
                        this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
                        textBox2.Text = "";
                        textBox3.Text = "";
                        MessageBox.Show("Данные обновлены!");
                    }
                }
                else
                {
                    MessageBox.Show("Введите ID тип проекта!");
                }
           // }
        }

        //Кнопка ДОБАВИТЬ ДЛЯ ТАБЛИЦЫ Должности-------------------------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {
            string sqlex = "insert_positions";
           // using (SqlConnection connection = new SqlConnection(conn))
           // {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (textBox4.Text == "")
                {

                    SqlParameter @name_position = new SqlParameter
                    {
                        ParameterName = "@name_position",
                        Value = textBox5.Text
                    };
                    command.Parameters.Add(@name_position);

                    SqlParameter schedule = new SqlParameter
                    {
                        ParameterName = "@schedule",
                        Value = textBox6.Text
                    };
                    command.Parameters.Add(schedule);

                    SqlParameter salary = new SqlParameter
                    {
                        ParameterName = "@salary",
                        Value = textBox7.Text
                    };
                    command.Parameters.Add(salary);


                    if (textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                    {
                        MessageBox.Show("Добавьте параметры");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.варианты_проектаTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Варианты_проекта);
                        this.должностиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Должности);
                        this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        MessageBox.Show("Данные добавлены!");
                    }
                }
                else
                {
                    MessageBox.Show("Удалите ID должности!");
                }

           // }
        }

        //Кнопка УДАЛИТЬ ДЛЯ ТАБЛИЦЫ ВАРИАНТЫ ПРОЕКТА-------------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            string sqlex = "delete_poisitons";
           // using (SqlConnection connection = new SqlConnection(conn))
           // {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter id_temp = new SqlParameter
                {
                    ParameterName = "@id_temp",
                    Value = textBox4.Text
                };

                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                command.Parameters.Add(id_temp);

                if (textBox4.Text == "")
                {
                    MessageBox.Show("Добавьте параметры");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.варианты_проектаTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Варианты_проекта);
                    this.должностиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Должности);
                    this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
                    MessageBox.Show("Данные удалены!");
                    textBox4.Text = "";
                }
           // }
        }

        //Кнопка ИЗМЕНИТЬ ДЛЯ ТАБЛИЦЫ ВАРИАНТЫ ПРОЕКТА--------------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            string sqlex = "update_positions";
           // using (SqlConnection connection = new SqlConnection(conn))
          //  {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (textBox4.Text != "")
                {

                    SqlParameter id_temp = new SqlParameter
                    {
                        ParameterName = "@id_temp",
                        Value = textBox4.Text
                    };
                    command.Parameters.Add(id_temp);


                    if (textBox5.Text != "")
                    {
                        SqlParameter name_position = new SqlParameter
                        {
                            ParameterName = "@name_position",
                            Value = textBox5.Text
                        };
                        command.Parameters.Add(name_position);
                    }

                    SqlParameter schedule = new SqlParameter
                    {
                        ParameterName = "@schedule",
                        Value = textBox6.Text
                    };
                    command.Parameters.Add(schedule);

                    SqlParameter salary = new SqlParameter
                    {
                        ParameterName = "@salary",
                        Value = textBox7.Text
                    };
                    command.Parameters.Add(salary);


                    if (textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "")
                    {
                        MessageBox.Show("Добавьте параметры");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.варианты_проектаTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Варианты_проекта);
                        this.должностиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Должности);
                        this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        MessageBox.Show("Данные обновлены!");
                    }
                }
                else
                {
                    MessageBox.Show("Введите ID должности!");
                }
          //  }
        }


        //заполнение ячеек
        private void варианты_проектаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = варианты_проектаDataGridView.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = варианты_проектаDataGridView.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = варианты_проектаDataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        //Сброс данных
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        //заполнение ячеек
        private void должностиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = должностиDataGridView.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = должностиDataGridView.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = должностиDataGridView.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = должностиDataGridView.CurrentRow.Cells[3].Value.ToString();
        }


        //Сброс данных
        private void button10_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

    }
}
