namespace WindowsFormsApplication1
{
    partial class Director_1
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
            this.director_workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.director_workersTableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.Director_workersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager();
            this.director_workersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.active_project_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.active_project_2TableAdapter = new WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.Active_project_2TableAdapter();
            this.active_project_2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cONSTRUCTION_FIRMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.director_workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.director_workersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.active_project_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.active_project_2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cONSTRUCTION_FIRMDataSet1
            // 
            this.cONSTRUCTION_FIRMDataSet1.DataSetName = "CONSTRUCTION_FIRMDataSet1";
            this.cONSTRUCTION_FIRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // director_workersBindingSource
            // 
            this.director_workersBindingSource.DataMember = "Director_workers";
            this.director_workersBindingSource.DataSource = this.cONSTRUCTION_FIRMDataSet1;
            // 
            // director_workersTableAdapter
            // 
            this.director_workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.trigger_controlTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Варианты_проектаTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ОтветственныйTableAdapter = null;
            this.tableAdapterManager.Рабочий_планTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // director_workersDataGridView
            // 
            this.director_workersDataGridView.AutoGenerateColumns = false;
            this.director_workersDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.director_workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.director_workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.director_workersDataGridView.DataSource = this.director_workersBindingSource;
            this.director_workersDataGridView.Location = new System.Drawing.Point(15, 176);
            this.director_workersDataGridView.Name = "director_workersDataGridView";
            this.director_workersDataGridView.Size = new System.Drawing.Size(652, 138);
            this.director_workersDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn3.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Зарплата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Зарплата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Название проекта";
            this.dataGridViewTextBoxColumn5.HeaderText = "Название проекта";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Представление об активных проектах.";
            // 
            // active_project_2BindingSource
            // 
            this.active_project_2BindingSource.DataMember = "Active_project_2";
            this.active_project_2BindingSource.DataSource = this.cONSTRUCTION_FIRMDataSet1;
            // 
            // active_project_2TableAdapter
            // 
            this.active_project_2TableAdapter.ClearBeforeFill = true;
            // 
            // active_project_2DataGridView
            // 
            this.active_project_2DataGridView.AutoGenerateColumns = false;
            this.active_project_2DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.active_project_2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.active_project_2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.active_project_2DataGridView.DataSource = this.active_project_2BindingSource;
            this.active_project_2DataGridView.Location = new System.Drawing.Point(15, 29);
            this.active_project_2DataGridView.Name = "active_project_2DataGridView";
            this.active_project_2DataGridView.Size = new System.Drawing.Size(652, 113);
            this.active_project_2DataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Название проекта";
            this.dataGridViewTextBoxColumn6.HeaderText = "Название проекта";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Начало-конец работ";
            this.dataGridViewTextBoxColumn7.HeaderText = "Начало-конец работ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn8.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn9.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Ответственный за проект";
            this.dataGridViewTextBoxColumn10.HeaderText = "Ответственный за проект";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Представление всех сотрудников.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Общая зарплата рабочих за период (1, 2, 3, ... лет).";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Посчитать";
            this.toolTip1.SetToolTip(this.button1, "Вывести результат.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox1.Location = new System.Drawing.Point(120, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox1, "Данные должны быть числом.");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox2, "Данные должны быть числом.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Номер проекта";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(389, 370);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Период (в годах)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Общая зарплата рабочих";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Подробно";
            this.toolTip1.SetToolTip(this.button2, "Более подробная информация о базе данных.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Закрыть";
            this.toolTip1.SetToolTip(this.button3, "Закрыть приложение.");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Действия";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Director_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(693, 416);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.active_project_2DataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.director_workersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Director_1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Окно директора";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cONSTRUCTION_FIRMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.director_workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.director_workersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.active_project_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.active_project_2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CONSTRUCTION_FIRMDataSet1 cONSTRUCTION_FIRMDataSet1;
        private System.Windows.Forms.BindingSource director_workersBindingSource;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.Director_workersTableAdapter director_workersTableAdapter;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView director_workersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource active_project_2BindingSource;
        private CONSTRUCTION_FIRMDataSet1TableAdapters.Active_project_2TableAdapter active_project_2TableAdapter;
        private System.Windows.Forms.DataGridView active_project_2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
    }
}