namespace WindowsFormsApplication1
{
    partial class Manager_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cONSTRUCTION_FIRMDataSet1 = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1();
            this.medical_control_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_control_1TableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.Medical_control_1TableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager();
            this.сотрудникиTableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.СотрудникиTableAdapter();
            this.medical_control_1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cONSTRUCTION_FIRMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_control_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_control_1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(10, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Функция, возвращающая таблицу (необходимо пройти мед. обследование).";
            // 
            // cONSTRUCTION_FIRMDataSet1
            // 
            this.cONSTRUCTION_FIRMDataSet1.DataSetName = "CONSTRUCTION_FIRMDataSet1";
            this.cONSTRUCTION_FIRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medical_control_1BindingSource
            // 
            this.medical_control_1BindingSource.DataMember = "Medical_control_1";
            this.medical_control_1BindingSource.DataSource = this.cONSTRUCTION_FIRMDataSet1;
            // 
            // medical_control_1TableAdapter
            // 
            this.medical_control_1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.trigger_controlTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Варианты_проектаTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ОтветственныйTableAdapter = null;
            this.tableAdapterManager.Рабочий_планTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // medical_control_1DataGridView
            // 
            this.medical_control_1DataGridView.AutoGenerateColumns = false;
            this.medical_control_1DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.medical_control_1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medical_control_1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.medical_control_1DataGridView.DataSource = this.medical_control_1BindingSource;
            this.medical_control_1DataGridView.Location = new System.Drawing.Point(9, 309);
            this.medical_control_1DataGridView.Name = "medical_control_1DataGridView";
            this.medical_control_1DataGridView.Size = new System.Drawing.Size(456, 150);
            this.medical_control_1DataGridView.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Мед.справка";
            this.dataGridViewTextBoxColumn3.HeaderText = "Мед.справка";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn4.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.cONSTRUCTION_FIRMDataSet1;
            // 
            // сотрудникиDataGridView
            // 
            this.сотрудникиDataGridView.AutoGenerateColumns = false;
            this.сотрудникиDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.сотрудникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сотрудникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.сотрудникиDataGridView.DataSource = this.сотрудникиBindingSource;
            this.сотрудникиDataGridView.Location = new System.Drawing.Point(11, 29);
            this.сотрудникиDataGridView.Name = "сотрудникиDataGridView";
            this.сотрудникиDataGridView.Size = new System.Drawing.Size(837, 168);
            this.сотрудникиDataGridView.TabIndex = 84;
            this.сотрудникиDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.сотрудникиDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID работника";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID работника";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID должности";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID должности";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID проекта";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID проекта";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn8.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn9.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn10.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Медицинская карта";
            this.dataGridViewTextBoxColumn12.HeaderText = "Медицинская карта";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Таблица \"Сотрудники\".";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 86;
            this.button1.Text = "Закрыть";
            this.toolTip1.SetToolTip(this.button1, "Закрыть проект.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(54, 217);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(82, 20);
            this.textBox10.TabIndex = 102;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox10, "Данные должны быть числом.");
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(153, 217);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(82, 20);
            this.textBox11.TabIndex = 101;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox11, "Данные должны быть числом.");
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(253, 217);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(82, 20);
            this.textBox12.TabIndex = 100;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox12, "Данные должны быть числом.");
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(353, 217);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(82, 20);
            this.textBox13.TabIndex = 99;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox13, "Данные должны быть строкой.");
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(455, 217);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(82, 20);
            this.textBox14.TabIndex = 98;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox14, "Данные должны быть строкой.");
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(555, 217);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(82, 20);
            this.textBox15.TabIndex = 97;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox15, "Данные должны быть строкой.");
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(259, 256);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 96;
            this.button6.Text = "Изменить";
            this.toolTip1.SetToolTip(this.button6, "Необходимо заполнить \"ID работника\" (обязательно), остальные необязательно (но хо" +
        "тя бы один).\r\n");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(654, 217);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(81, 20);
            this.textBox16.TabIndex = 94;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox16, "Данные должны быть датой.");
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(751, 217);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(82, 20);
            this.textBox17.TabIndex = 93;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox17, "Данные должны быть ДА или НЕТ.");
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(171, 256);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 92;
            this.button7.Text = "Удалить";
            this.toolTip1.SetToolTip(this.button7, "Необходимо заполнить только поле \"ID работника\".");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(82, 256);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 89;
            this.button8.Text = "Добавить";
            this.toolTip1.SetToolTip(this.button8, "Необходимо заполнить все поля кроме \"ID работника\".");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label17.Location = new System.Drawing.Point(4, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 17);
            this.label17.TabIndex = 109;
            this.label17.Text = "Действия:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label18.Location = new System.Drawing.Point(4, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 17);
            this.label18.TabIndex = 108;
            this.label18.Text = "Поля:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(748, 201);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 13);
            this.label20.TabIndex = 107;
            this.label20.Text = "Медицинская карта";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(651, 201);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 13);
            this.label21.TabIndex = 106;
            this.label21.Text = "Дата рождения";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(568, 201);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 105;
            this.label22.Text = "Отчество";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(476, 201);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 104;
            this.label23.Text = "Имя";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(363, 201);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 103;
            this.label24.Text = "Фамилия";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(58, 201);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 13);
            this.label25.TabIndex = 95;
            this.label25.Text = "ID работника";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(261, 201);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 91;
            this.label26.Text = "ID проекта";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(158, 201);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 13);
            this.label27.TabIndex = 90;
            this.label27.Text = "ID должности";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 110;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 111;
            this.label3.Text = "Действия";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 112;
            this.button3.Text = "Выйти";
            this.toolTip1.SetToolTip(this.button3, "Закрыть проект.");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Manager_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(864, 464);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.сотрудникиDataGridView);
            this.Controls.Add(this.medical_control_1DataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Manager_1";
            this.Text = "Окно менеджера по персоналу.";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cONSTRUCTION_FIRMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_control_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_control_1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CONSTRUCTION_FIRMDataSet1 cONSTRUCTION_FIRMDataSet1;
        private System.Windows.Forms.BindingSource medical_control_1BindingSource;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.Medical_control_1TableAdapter medical_control_1TableAdapter;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView medical_control_1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.DataGridView сотрудникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}