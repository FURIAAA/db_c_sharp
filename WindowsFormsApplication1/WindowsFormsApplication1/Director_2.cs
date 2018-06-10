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
    public partial class Director_2 : Form
    {
        static string[] ty = File.ReadAllLines("different_conn.txt", Encoding.UTF8);
        SqlConnection connection = new SqlConnection(ty[0]);

        //static string conn = @"Data Source=XAMELEON\MSSQLSERVER1;Initial Catalog=CONSTRUCTION_FIRM;Integrated Security=True";

        public Director_2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet.Рабочий_план". При необходимости она может быть перемещена или удалена.
            this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Рабочий_план);

        }

        //КНОПКА ЗАКРЫТЬ
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Кнопка УДАЛИТЬ ДЛЯ ТАБЛИЦЫ РАБОЧИЙ ПЛАН-------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            string sqlex = "delete_w_plan";
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
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                command.Parameters.Add(id_temp);

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Добавьте параметры");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Рабочий_план);
                    this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Сотрудники);
                    MessageBox.Show("Данные удалены!");
                    textBox1.Text = "";
                }
           // }
        }


        //Кнопка ДОБАВИТЬ ДЛЯ ТАБЛИЦЫ РАБОЧИЙ ПЛАН--------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            string sqlex = "insert_w_plan";
           // using (SqlConnection connection = new SqlConnection(conn))
           // {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (textBox1.Text == "")
                {

                    SqlParameter id_type = new SqlParameter
                    {
                        ParameterName = "@id_type",
                        Value = textBox2.Text
                    };
                    command.Parameters.Add(id_type);

                    SqlParameter name_position = new SqlParameter
                    {
                        ParameterName = "@name_position",
                        Value = textBox3.Text
                    };
                    command.Parameters.Add(name_position);

                    SqlParameter start = new SqlParameter
                    {
                        ParameterName = "@start",
                        Value = textBox4.Text
                    };
                    command.Parameters.Add(start);

                    SqlParameter end = new SqlParameter
                    {
                        ParameterName = "@end",
                        Value = textBox5.Text
                    };
                    command.Parameters.Add(end);

                    SqlParameter contacts = new SqlParameter
                    {
                        ParameterName = "@contacts",
                        Value = textBox6.Text
                    };
                    command.Parameters.Add(contacts);

                    SqlParameter all_budget = new SqlParameter
                    {
                        ParameterName = "@all_budget",
                        Value = textBox7.Text
                    };
                    command.Parameters.Add(all_budget);

                    SqlParameter transport = new SqlParameter
                    {
                        ParameterName = "@transport",
                        Value = textBox8.Text
                    };
                    command.Parameters.Add(transport);

                    SqlParameter material = new SqlParameter
                    {
                        ParameterName = "@material",
                        Value = textBox9.Text
                    };
                    command.Parameters.Add(material);

                    if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
                        textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
                    {
                        MessageBox.Show("Добавьте параметры");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Рабочий_план);
                        this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Сотрудники);
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        MessageBox.Show("Данные добавлены!");
                    }
                }
                else
                {
                    MessageBox.Show("Удалите ID проекта!");
                }

           // }
        }




        //Кнопка ИЗМЕНИТЬ ДЛЯ ТАБЛИЦЫ РАБОЧИЙ ПЛАН--------------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            string sqlex = "update_w_plan";
           // using (SqlConnection connection = new SqlConnection(conn))
          //  {
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
                        SqlParameter id_type = new SqlParameter
                        {
                            ParameterName = "@id_type",
                            Value = textBox2.Text
                        };
                        command.Parameters.Add(id_type);
                    }

                    SqlParameter name_position = new SqlParameter
                    {
                        ParameterName = "@name_position",
                        Value = textBox3.Text
                    };
                    command.Parameters.Add(name_position);

                    SqlParameter start = new SqlParameter
                    {
                        ParameterName = "@start",
                        Value = textBox4.Text
                    };
                    command.Parameters.Add(start);

                    SqlParameter end = new SqlParameter
                    {
                        ParameterName = "@end",
                        Value = textBox5.Text
                    };
                    command.Parameters.Add(end);

                    SqlParameter contacts = new SqlParameter
                    {
                        ParameterName = "@contacts",
                        Value = textBox6.Text
                    };
                    command.Parameters.Add(contacts);

                    SqlParameter all_budget = new SqlParameter
                    {
                        ParameterName = "@all_budget",
                        Value = textBox7.Text
                    };
                    command.Parameters.Add(all_budget);

                    SqlParameter transport = new SqlParameter
                    {
                        ParameterName = "@transport",
                        Value = textBox8.Text
                    };
                    command.Parameters.Add(transport);

                    SqlParameter material = new SqlParameter
                    {
                        ParameterName = "@material",
                        Value = textBox9.Text
                    };
                    command.Parameters.Add(material);

                    if (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" &&
                        textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "" && textBox9.Text == "")
                    {
                        MessageBox.Show("Добавьте параметры");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Рабочий_план);
                        this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Сотрудники);
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        MessageBox.Show("Данные обновлены!");
                    }
                }
                else
                {
                    MessageBox.Show("Введите ID проекта!");
                }
           // }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Director_1 adm = new Director_1();
            adm.Show();
            this.Hide();
        }

        //Кнопка УДАЛИТЬ ДЛЯ ТАБЛИЦЫ СОТРУДНИКИ-------------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            string sqlex = "delete_workers";
            //using (SqlConnection connection = new SqlConnection(conn))
          //  {
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
                    this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Рабочий_план);
                    this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Сотрудники);
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
                        this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Рабочий_план);
                        this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Сотрудники);
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
        private void button6_Click(object sender, EventArgs e)
        {
            string sqlex = "update_workers";
           // using (SqlConnection connection = new SqlConnection(conn))
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
                        this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Рабочий_план);
                        this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet.Сотрудники);
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
         //   }
        }

        //КНОПКА НАЗАД
        private void button9_Click(object sender, EventArgs e)
        {
            Director_3 adm = new Director_3();
            adm.Show();
            this.Hide();
        }

        //заполнение ячеек
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        //КНОПКА СБРОСА
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        //заполнение ячеек
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox10.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox11.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox12.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox13.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox14.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox15.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox16.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBox17.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
        }

        //КНОПКА СБРОСА
        private void button11_Click(object sender, EventArgs e)
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
    }
}
