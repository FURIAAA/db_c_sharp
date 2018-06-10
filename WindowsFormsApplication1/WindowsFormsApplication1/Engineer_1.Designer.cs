namespace WindowsFormsApplication1
{
    partial class Engineer_1
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
            this.cONSTRUCTION_FIRMDataSet1 = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1();
            this.ing_projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ing_projectTableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.Ing_projectTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager();
            this.trigger_controlTableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.trigger_controlTableAdapter();
            this.ing_projectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.medical_control_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_control_1TableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.Medical_control_1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trigger_controlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trigger_controlDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.active_projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.active_projectTableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.Active_projectTableAdapter();
            this.active_projectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cONSTRUCTION_FIRMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ing_projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ing_projectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_control_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trigger_controlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trigger_controlDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.active_projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.active_projectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cONSTRUCTION_FIRMDataSet1
            // 
            this.cONSTRUCTION_FIRMDataSet1.DataSetName = "CONSTRUCTION_FIRMDataSet1";
            this.cONSTRUCTION_FIRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ing_projectBindingSource
            // 
            this.ing_projectBindingSource.DataMember = "Ing_project";
            this.ing_projectBindingSource.DataSource = this.cONSTRUCTION_FIRMDataSet1;
            // 
            // ing_projectTableAdapter
            // 
            this.ing_projectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.trigger_controlTableAdapter = this.trigger_controlTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Варианты_проектаTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ОтветственныйTableAdapter = null;
            this.tableAdapterManager.Рабочий_планTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // trigger_controlTableAdapter
            // 
            this.trigger_controlTableAdapter.ClearBeforeFill = true;
            // 
            // ing_projectDataGridView
            // 
            this.ing_projectDataGridView.AutoGenerateColumns = false;
            this.ing_projectDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ing_projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ing_projectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ing_projectDataGridView.DataSource = this.ing_projectBindingSource;
            this.ing_projectDataGridView.Location = new System.Drawing.Point(15, 29);
            this.ing_projectDataGridView.Name = "ing_projectDataGridView";
            this.ing_projectDataGridView.Size = new System.Drawing.Size(579, 163);
            this.ing_projectDataGridView.TabIndex = 79;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название проекта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название проекта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Начало-конец работ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Начало-конец работ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Тип проекта";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип проекта";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Сложность проекта";
            this.dataGridViewTextBoxColumn4.HeaderText = "Сложность проекта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Представление о сложности проектах.";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "Закрыть";
            this.toolTip1.SetToolTip(this.button1, "Закрыть приложение.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 83;
            this.button2.Text = "Подробно";
            this.toolTip1.SetToolTip(this.button2, "Более подробная информация о базе данных.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trigger_controlBindingSource
            // 
            this.trigger_controlBindingSource.DataMember = "trigger_control";
            this.trigger_controlBindingSource.DataSource = this.cONSTRUCTION_FIRMDataSet1;
            // 
            // trigger_controlDataGridView
            // 
            this.trigger_controlDataGridView.AutoGenerateColumns = false;
            this.trigger_controlDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.trigger_controlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trigger_controlDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.trigger_controlDataGridView.DataSource = this.trigger_controlBindingSource;
            this.trigger_controlDataGridView.Location = new System.Drawing.Point(12, 459);
            this.trigger_controlDataGridView.Name = "trigger_controlDataGridView";
            this.trigger_controlDataGridView.Size = new System.Drawing.Size(579, 91);
            this.trigger_controlDataGridView.TabIndex = 83;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID срабатывания";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID срабатывания";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Время срабатывания";
            this.dataGridViewTextBoxColumn10.HeaderText = "Время срабатывания";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Пользователь";
            this.dataGridViewTextBoxColumn11.HeaderText = "Пользователь";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Триггер";
            this.dataGridViewTextBoxColumn12.HeaderText = "Триггер";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(9, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Таблица срабатывания триггеров.";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(567, 619);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 92;
            this.button4.Text = "Выйти";
            this.toolTip1.SetToolTip(this.button4, "Закрыть приложение.");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // active_projectBindingSource
            // 
            this.active_projectBindingSource.DataMember = "Active_project";
            this.active_projectBindingSource.DataSource = this.cONSTRUCTION_FIRMDataSet1;
            // 
            // active_projectTableAdapter
            // 
            this.active_projectTableAdapter.ClearBeforeFill = true;
            // 
            // active_projectDataGridView
            // 
            this.active_projectDataGridView.AutoGenerateColumns = false;
            this.active_projectDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.active_projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.active_projectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.active_projectDataGridView.DataSource = this.active_projectBindingSource;
            this.active_projectDataGridView.Location = new System.Drawing.Point(12, 231);
            this.active_projectDataGridView.Name = "active_projectDataGridView";
            this.active_projectDataGridView.Size = new System.Drawing.Size(582, 192);
            this.active_projectDataGridView.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Название проекта";
            this.dataGridViewTextBoxColumn5.HeaderText = "Название проекта";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Начало-конец работ";
            this.dataGridViewTextBoxColumn6.HeaderText = "Начало-конец работ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn7.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn8.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "Представление об активных проектах и работающих сотрудниках.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 608);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 86;
            this.button3.Text = "Рассчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 608);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 87;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(254, 608);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 88;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(12, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "CLR-функция (кол-во рабочих над проектом).";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 592);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "ID проекта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Кол-во работников";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 574);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Действия";
            // 
            // Engineer_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(716, 649);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.active_projectDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trigger_controlDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ing_projectDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Engineer_1";
            this.Text = "Окно гл. инженера";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cONSTRUCTION_FIRMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ing_projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ing_projectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_control_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trigger_controlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trigger_controlDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.active_projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.active_projectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CONSTRUCTION_FIRMDataSet1 cONSTRUCTION_FIRMDataSet1;
        private System.Windows.Forms.BindingSource ing_projectBindingSource;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.Ing_projectTableAdapter ing_projectTableAdapter;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ing_projectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource medical_control_1BindingSource;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.Medical_control_1TableAdapter medical_control_1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.trigger_controlTableAdapter trigger_controlTableAdapter;
        private System.Windows.Forms.BindingSource trigger_controlBindingSource;
        private System.Windows.Forms.DataGridView trigger_controlDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource active_projectBindingSource;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.Active_projectTableAdapter active_projectTableAdapter;
        private System.Windows.Forms.DataGridView active_projectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
    }
}