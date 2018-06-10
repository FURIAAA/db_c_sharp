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
    public partial class Engineer_2 : Form
    {

        static string[] ty = File.ReadAllLines("different_conn.txt", Encoding.UTF8);
        SqlConnection connection = new SqlConnection(ty[0]);
        //static string conn = @"Data Source=XAMELEON\MSSQLSERVER1;Initial Catalog=CONSTRUCTION_FIRM;Integrated Security=True";

        public Engineer_2()
        {
            InitializeComponent();
        }

        //Закрытие окна
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Кнопка НАЗАД
        private void button2_Click(object sender, EventArgs e)
        {
            Engineer_1 adm = new Engineer_1();
            adm.Show();
            this.Hide();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONSTRUCTION_FIRMDataSet1);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Рабочий_план". При необходимости она может быть перемещена или удалена.
            this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Рабочий_план);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Ответственный". При необходимости она может быть перемещена или удалена.
            this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cONSTRUCTION_FIRMDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Сотрудники);

        }


        //Кнопка ДОБАВИТЬ ДЛЯ ТАБЛИЦЫ Ответственный-------------------------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {
            string sqlex = "insert_respon";
          //  using (SqlConnection connection = new SqlConnection(conn))
          //  {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                 SqlParameter id_proj = new SqlParameter
                    {
                        ParameterName = "@id_proj",
                        Value = textBox4.Text
                    };
                    command.Parameters.Add(id_proj);

                    SqlParameter id_worker = new SqlParameter
                    {
                        ParameterName = "@id_worker",
                        Value = textBox5.Text
                    };
                    command.Parameters.Add(id_worker);

                    SqlParameter respon = new SqlParameter
                    {
                        ParameterName = "@respon",
                        Value = textBox6.Text
                    };
                    command.Parameters.Add(respon);


                    if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                    {
                        MessageBox.Show("Добавьте параметры");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
                        this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Сотрудники);
                        this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Рабочий_план);
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        MessageBox.Show("Данные добавлены!");
                    }
             
           // }
        }

        //Кнопка УДАЛИТЬ ДЛЯ ТАБЛИЦЫ Ответственный-------------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            string sqlex = "delete_respon";
           // using (SqlConnection connection = new SqlConnection(conn))
           // {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter id_proj = new SqlParameter
                {
                    ParameterName = "@id_proj",
                    Value = textBox4.Text
                };

                SqlParameter id_worker = new SqlParameter
                {
                    ParameterName = "@id_worker",
                    Value = textBox5.Text
                };

                command.Parameters.Add(id_proj);
                command.Parameters.Add(id_worker);
                                
                if (textBox4.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Добавьте параметры");
                }
                else
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
                    this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Сотрудники);
                    this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Рабочий_план);
                    MessageBox.Show("Данные удалены!");
                    textBox4.Text = "";
                    textBox5.Text = "";

                }
           // }
        }

        //Кнопка ИЗМЕНИТЬ ДЛЯ ТАБЛИЦЫ Ответственный--------------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            string sqlex = "update_respon";
            //using (SqlConnection connection = new SqlConnection(conn))
           // {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlex, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (textBox4.Text != "" && textBox5.Text != "")
                {

                    SqlParameter id_proj = new SqlParameter
                    {
                        ParameterName = "@id_proj",
                        Value = textBox4.Text
                    };
                    command.Parameters.Add(id_proj);

                    SqlParameter id_worker = new SqlParameter
                    {
                        ParameterName = "@id_worker",
                        Value = textBox5.Text
                    };
                    command.Parameters.Add(id_worker);

                    SqlParameter respon = new SqlParameter
                    {
                        ParameterName = "@respon",
                        Value = textBox6.Text
                    };
                    command.Parameters.Add(respon);

                    command.ExecuteNonQuery();
                    connection.Close();
                    this.ответственныйTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Ответственный);
                    this.сотрудникиTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Сотрудники);
                    this.рабочий_планTableAdapter.Fill(this.cONSTRUCTION_FIRMDataSet1.Рабочий_план);
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    MessageBox.Show("Данные обновлены!");
                }
                else
                {
                    MessageBox.Show("Добавьте параметры");
                }
           // }
        }

        //Сброс данных
        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        //заполнение ячеек
        private void ответственныйDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = ответственныйDataGridView.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = ответственныйDataGridView.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = ответственныйDataGridView.CurrentRow.Cells[2].Value.ToString();
        }

    }
}
