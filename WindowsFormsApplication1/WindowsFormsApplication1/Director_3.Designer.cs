namespace WindowsFormsApplication1
{
    partial class Director_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cONSTRUCTION_FIRMDataSet1 = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1();
            this.варианты_проектаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.варианты_проектаTableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.Варианты_проектаTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager();
            this.должностиTableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.ДолжностиTableAdapter();
            this.ответственныйTableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.ОтветственныйTableAdapter();
            this.варианты_проектаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ответственныйBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ответственныйDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cONSTRUCTION_FIRMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.варианты_проектаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.варианты_проектаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ответственныйBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ответственныйDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(721, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Закрыть";
            this.toolTip1.SetToolTip(this.button2, "Закрыть приложение.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cONSTRUCTION_FIRMDataSet1
            // 
            this.cONSTRUCTION_FIRMDataSet1.DataSetName = "CONSTRUCTION_FIRMDataSet1";
            this.cONSTRUCTION_FIRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // варианты_проектаBindingSource
            // 
            this.варианты_проектаBindingSource.DataMember = "Варианты проекта";
            this.варианты_проектаBindingSource.DataSource = this.cONSTRUCTION_FIRMDataSet1;
            // 
            // варианты_проектаTableAdapter
            // 
            this.варианты_проектаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.trigger_controlTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Варианты_проектаTableAdapter = this.варианты_проектаTableAdapter;
            this.tableAdapterManager.ДолжностиTableAdapter = this.должностиTableAdapter;
            this.tableAdapterManager.ОтветственныйTableAdapter = this.ответственныйTableAdapter;
            this.tableAdapterManager.Рабочий_планTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // ответственныйTableAdapter
            // 
            this.ответственныйTableAdapter.ClearBeforeFill = true;
            // 
            // варианты_проектаDataGridView
            // 
            this.варианты_проектаDataGridView.AutoGenerateColumns = false;
            this.варианты_проектаDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.варианты_проектаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.варианты_проектаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.варианты_проектаDataGridView.DataSource = this.варианты_проектаBindingSource;
            this.варианты_проектаDataGridView.Location = new System.Drawing.Point(15, 29);
            this.варианты_проектаDataGridView.Name = "варианты_проектаDataGridView";
            this.варианты_проектаDataGridView.Size = new System.Drawing.Size(381, 137);
            this.варианты_проектаDataGridView.TabIndex = 3;
            this.варианты_проектаDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.варианты_проектаDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID тип проекта";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID тип проекта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип проекта";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип проекта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Сложность реализации";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сложность реализации";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(12, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Таблица \"Варианты проекта\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(423, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Таблица \"Ответственный\"";
            // 
            // ответственныйBindingSource
            // 
            this.ответственныйBindingSource.DataMember = "Ответственный";
            this.ответственныйBindingSource.DataSource = this.cONSTRUCTION_FIRMDataSet1;
            // 
            // ответственныйDataGridView
            // 
            this.ответственныйDataGridView.AutoGenerateColumns = false;
            this.ответственныйDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ответственныйDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ответственныйDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ответственныйDataGridView.DataSource = this.ответственныйBindingSource;
            this.ответственныйDataGridView.Location = new System.Drawing.Point(426, 26);
            this.ответственныйDataGridView.Name = "ответственныйDataGridView";
            this.ответственныйDataGridView.Size = new System.Drawing.Size(370, 140);
            this.ответственныйDataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID проекта";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID проекта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID работника";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID работника";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ответственный за проект";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ответственный за проект";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Таблица \"Должности\"";
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.cONSTRUCTION_FIRMDataSet1;
            // 
            // должностиDataGridView
            // 
            this.должностиDataGridView.AutoGenerateColumns = false;
            this.должностиDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.должностиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.должностиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.должностиDataGridView.DataSource = this.должностиBindingSource;
            this.должностиDataGridView.Location = new System.Drawing.Point(15, 285);
            this.должностиDataGridView.Name = "должностиDataGridView";
            this.должностиDataGridView.Size = new System.Drawing.Size(449, 175);
            this.должностиDataGridView.TabIndex = 39;
            this.должностиDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.должностиDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID должности";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID должности";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Название должности";
            this.dataGridViewTextBoxColumn8.HeaderText = "Название должности";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "График работы";
            this.dataGridViewTextBoxColumn9.HeaderText = "График работы";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Зарплата";
            this.dataGridViewTextBoxColumn10.HeaderText = "Зарплата";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label16.Location = new System.Drawing.Point(12, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "Действия:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label15.Location = new System.Drawing.Point(12, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 17);
            this.label15.TabIndex = 50;
            this.label15.Text = "Поля:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(267, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 49;
            this.button4.Text = "Изменить";
            this.toolTip1.SetToolTip(this.button4, "Необходимо нажать на \"ID тип проекта\" (обязательно), ячейки заполнятся данными. Н" +
        "еобходимую ячейку изменить.");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "ID тип проекта";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(261, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 20);
            this.textBox3.TabIndex = 47;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox3, "Данные должны быть числом.");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 46;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox2, "Данные должны строкой.");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox1, "Данные должны быть числом.");
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "Удалить";
            this.toolTip1.SetToolTip(this.button3, "Необходимо заполнить только \"ID тип проекта\".");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Сложность реализации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Тип проекта";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(90, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 41;
            this.button5.Text = "Добавить";
            this.toolTip1.SetToolTip(this.button5, "Необходимо заполнить все поля кроме \"ID тип проекта\".");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(267, 522);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 60;
            this.button6.Text = "Изменить";
            this.toolTip1.SetToolTip(this.button6, "Необходимо нажать на \"ID проекта\" (обязательно), ячейки заполнятся данными. Необх" +
        "одимую ячейку изменить.");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(62, 483);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 20);
            this.textBox4.TabIndex = 58;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox4, "Данные должны быть числом.");
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(161, 483);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 20);
            this.textBox5.TabIndex = 57;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox5, "Данные должны строкой.");
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(261, 483);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(82, 20);
            this.textBox6.TabIndex = 56;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox6, "Данные должны быть числом.");
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(179, 522);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 55;
            this.button7.Text = "Удалить";
            this.toolTip1.SetToolTip(this.button7, "Необходимо заполнить только \"ID должности\".");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(90, 522);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 52;
            this.button8.Text = "Добавить";
            this.toolTip1.SetToolTip(this.button8, "Необходимо заполнить все поля кроме \"ID должности\".");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(361, 483);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(81, 20);
            this.textBox7.TabIndex = 64;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox7, "Данные должны быть числом.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(12, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Действия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(12, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Поля:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "ID должности";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "График работы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Название должности";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(373, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Зарплата";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(361, 224);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 65;
            this.button9.Text = "Сброс";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(364, 522);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 66;
            this.button10.Text = "Сброс";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Director_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(816, 557);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.должностиDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ответственныйDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.варианты_проектаDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Director_3";
            this.Text = "Окно директора.";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cONSTRUCTION_FIRMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.варианты_проектаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.варианты_проектаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ответственныйBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ответственныйDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private CONSTRUCTION_FIRMDataSet1 cONSTRUCTION_FIRMDataSet1;
        private System.Windows.Forms.BindingSource варианты_проектаBindingSource;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.Варианты_проектаTableAdapter варианты_проектаTableAdapter;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView варианты_проектаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.ОтветственныйTableAdapter ответственныйTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ответственныйBindingSource;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.DataGridView ответственныйDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private System.Windows.Forms.DataGridView должностиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}