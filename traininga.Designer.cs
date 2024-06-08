namespace Dipllom_Gencha
{
    partial class traininga
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
            this.diplomBaseDataSet1 = new Dipllom_Gencha.DiplomBaseDataSet1();
            this.traning1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traning1TableAdapter = new Dipllom_Gencha.DiplomBaseDataSet1TableAdapters.traning1TableAdapter();
            this.deleteB = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.traning1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.diplomBaseDataSet2 = new Dipllom_Gencha.DiplomBaseDataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeTrain = new System.Windows.Forms.MaskedTextBox();
            this.secondCoach = new System.Windows.Forms.ComboBox();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainCoach = new System.Windows.Forms.ComboBox();
            this.placeTrain = new System.Windows.Forms.ComboBox();
            this.typeTrain = new System.Windows.Forms.ComboBox();
            this.dayOfWeek = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.traning1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coachTableAdapter = new Dipllom_Gencha.DiplomBaseDataSet1TableAdapters.coachTableAdapter();
            this.traning1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.traning1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.traning1TableAdapter1 = new Dipllom_Gencha.DiplomBaseDataSet2TableAdapters.traning1TableAdapter();
            this.idtrainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofweekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typetrainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetrainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestotrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maincoachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondcoachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diplomBaseDataSet1
            // 
            this.diplomBaseDataSet1.DataSetName = "DiplomBaseDataSet1";
            this.diplomBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traning1BindingSource
            // 
            this.traning1BindingSource.DataMember = "traning1";
            this.traning1BindingSource.DataSource = this.diplomBaseDataSet1;
            // 
            // traning1TableAdapter
            // 
            this.traning1TableAdapter.ClearBeforeFill = true;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(616, 359);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(215, 20);
            this.deleteB.TabIndex = 30;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.IndianRed;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(616, 385);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(215, 33);
            this.delete.TabIndex = 28;
            this.delete.Text = "Удалить тренировку";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Location = new System.Drawing.Point(63, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(488, 37);
            this.button2.TabIndex = 25;
            this.button2.Text = "добавить тренировку";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Список тренировок";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtrainingDataGridViewTextBoxColumn,
            this.dayofweekDataGridViewTextBoxColumn,
            this.typetrainingDataGridViewTextBoxColumn,
            this.timetrainingDataGridViewTextBoxColumn,
            this.mestotrDataGridViewTextBoxColumn,
            this.maincoachDataGridViewTextBoxColumn,
            this.secondcoachDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.traning1BindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(17, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 210);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // traning1BindingSource4
            // 
            this.traning1BindingSource4.DataMember = "traning1";
            this.traning1BindingSource4.DataSource = this.diplomBaseDataSet2;
            // 
            // diplomBaseDataSet2
            // 
            this.diplomBaseDataSet2.DataSetName = "DiplomBaseDataSet2";
            this.diplomBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeTrain);
            this.panel1.Controls.Add(this.secondCoach);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.mainCoach);
            this.panel1.Controls.Add(this.placeTrain);
            this.panel1.Controls.Add(this.typeTrain);
            this.panel1.Controls.Add(this.dayOfWeek);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(17, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 208);
            this.panel1.TabIndex = 29;
            // 
            // timeTrain
            // 
            this.timeTrain.Location = new System.Drawing.Point(168, 112);
            this.timeTrain.Mask = "90:00";
            this.timeTrain.Name = "timeTrain";
            this.timeTrain.Size = new System.Drawing.Size(37, 20);
            this.timeTrain.TabIndex = 13;
            this.timeTrain.ValidatingType = typeof(System.DateTime);
            // 
            // secondCoach
            // 
            this.secondCoach.DataSource = this.coachBindingSource;
            this.secondCoach.DisplayMember = "name_coach";
            this.secondCoach.FormattingEnabled = true;
            this.secondCoach.Location = new System.Drawing.Point(415, 109);
            this.secondCoach.Name = "secondCoach";
            this.secondCoach.Size = new System.Drawing.Size(125, 21);
            this.secondCoach.TabIndex = 12;
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "coach";
            this.coachBindingSource.DataSource = this.diplomBaseDataSet1;
            // 
            // mainCoach
            // 
            this.mainCoach.DataSource = this.coachBindingSource;
            this.mainCoach.DisplayMember = "name_coach";
            this.mainCoach.FormattingEnabled = true;
            this.mainCoach.Location = new System.Drawing.Point(415, 75);
            this.mainCoach.Name = "mainCoach";
            this.mainCoach.Size = new System.Drawing.Size(125, 21);
            this.mainCoach.TabIndex = 11;
            // 
            // placeTrain
            // 
            this.placeTrain.FormattingEnabled = true;
            this.placeTrain.Items.AddRange(new object[] {
            "Зал Power",
            " СК Сиутат   ",
            "Парк де Ла Крета де Колл",
            "Practis room",
            "Индивидуально"});
            this.placeTrain.Location = new System.Drawing.Point(415, 29);
            this.placeTrain.Name = "placeTrain";
            this.placeTrain.Size = new System.Drawing.Size(125, 21);
            this.placeTrain.TabIndex = 9;
            // 
            // typeTrain
            // 
            this.typeTrain.FormattingEnabled = true;
            this.typeTrain.Items.AddRange(new object[] {
            "Беговая ",
            "Тренажерный зал",
            "Тренировка на поле",
            "Теория ",
            "Предигровая ",
            "индивидуальная подготовка"});
            this.typeTrain.Location = new System.Drawing.Point(168, 75);
            this.typeTrain.Name = "typeTrain";
            this.typeTrain.Size = new System.Drawing.Size(125, 21);
            this.typeTrain.TabIndex = 8;
            // 
            // dayOfWeek
            // 
            this.dayOfWeek.FormattingEnabled = true;
            this.dayOfWeek.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.dayOfWeek.Location = new System.Drawing.Point(168, 32);
            this.dayOfWeek.Name = "dayOfWeek";
            this.dayOfWeek.Size = new System.Drawing.Size(125, 21);
            this.dayOfWeek.TabIndex = 7;
            this.dayOfWeek.SelectedIndexChanged += new System.EventHandler(this.dayOfWeek_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Тип тренировки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Тренер подготовки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Главный тренер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Место";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Время тренировки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "День недели";
            // 
            // traning1BindingSource1
            // 
            this.traning1BindingSource1.DataMember = "traning1";
            this.traning1BindingSource1.DataSource = this.diplomBaseDataSet1;
            // 
            // coachTableAdapter
            // 
            this.coachTableAdapter.ClearBeforeFill = true;
            // 
            // traning1BindingSource2
            // 
            this.traning1BindingSource2.DataMember = "traning1";
            this.traning1BindingSource2.DataSource = this.diplomBaseDataSet1;
            // 
            // traning1BindingSource3
            // 
            this.traning1BindingSource3.DataMember = "traning1";
            this.traning1BindingSource3.DataSource = this.diplomBaseDataSet1;
            // 
            // traning1TableAdapter1
            // 
            this.traning1TableAdapter1.ClearBeforeFill = true;
            // 
            // idtrainingDataGridViewTextBoxColumn
            // 
            this.idtrainingDataGridViewTextBoxColumn.DataPropertyName = "id_training";
            this.idtrainingDataGridViewTextBoxColumn.HeaderText = "id";
            this.idtrainingDataGridViewTextBoxColumn.Name = "idtrainingDataGridViewTextBoxColumn";
            this.idtrainingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dayofweekDataGridViewTextBoxColumn
            // 
            this.dayofweekDataGridViewTextBoxColumn.DataPropertyName = "day_of_week";
            this.dayofweekDataGridViewTextBoxColumn.HeaderText = "День недели";
            this.dayofweekDataGridViewTextBoxColumn.Name = "dayofweekDataGridViewTextBoxColumn";
            // 
            // typetrainingDataGridViewTextBoxColumn
            // 
            this.typetrainingDataGridViewTextBoxColumn.DataPropertyName = "type_training";
            this.typetrainingDataGridViewTextBoxColumn.HeaderText = "Тип Тренировки";
            this.typetrainingDataGridViewTextBoxColumn.Name = "typetrainingDataGridViewTextBoxColumn";
            // 
            // timetrainingDataGridViewTextBoxColumn
            // 
            this.timetrainingDataGridViewTextBoxColumn.DataPropertyName = "time_training";
            this.timetrainingDataGridViewTextBoxColumn.HeaderText = "Время Тренировки";
            this.timetrainingDataGridViewTextBoxColumn.Name = "timetrainingDataGridViewTextBoxColumn";
            // 
            // mestotrDataGridViewTextBoxColumn
            // 
            this.mestotrDataGridViewTextBoxColumn.DataPropertyName = "mesto_tr";
            this.mestotrDataGridViewTextBoxColumn.HeaderText = "Место";
            this.mestotrDataGridViewTextBoxColumn.Name = "mestotrDataGridViewTextBoxColumn";
            // 
            // maincoachDataGridViewTextBoxColumn
            // 
            this.maincoachDataGridViewTextBoxColumn.DataPropertyName = "main_coach";
            this.maincoachDataGridViewTextBoxColumn.HeaderText = "Главный тренер";
            this.maincoachDataGridViewTextBoxColumn.Name = "maincoachDataGridViewTextBoxColumn";
            // 
            // secondcoachDataGridViewTextBoxColumn
            // 
            this.secondcoachDataGridViewTextBoxColumn.DataPropertyName = "second_coach";
            this.secondcoachDataGridViewTextBoxColumn.HeaderText = "Тренер подготовки";
            this.secondcoachDataGridViewTextBoxColumn.Name = "secondcoachDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Введите id тренировки для удаления";
            // 
            // traininga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "traininga";
            this.Text = "traininga";
            this.Load += new System.EventHandler(this.traininga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DiplomBaseDataSet1 diplomBaseDataSet1;
        private System.Windows.Forms.BindingSource traning1BindingSource;
        private DiplomBaseDataSet1TableAdapters.traning1TableAdapter traning1TableAdapter;
        private System.Windows.Forms.TextBox deleteB;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox timeTrain;
        private System.Windows.Forms.ComboBox secondCoach;
        private System.Windows.Forms.ComboBox mainCoach;
        private System.Windows.Forms.ComboBox placeTrain;
        private System.Windows.Forms.ComboBox typeTrain;
        private System.Windows.Forms.ComboBox dayOfWeek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource traning1BindingSource1;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private DiplomBaseDataSet1TableAdapters.coachTableAdapter coachTableAdapter;
        private System.Windows.Forms.BindingSource traning1BindingSource2;
        private System.Windows.Forms.BindingSource traning1BindingSource3;
        private DiplomBaseDataSet2 diplomBaseDataSet2;
        private System.Windows.Forms.BindingSource traning1BindingSource4;
        private DiplomBaseDataSet2TableAdapters.traning1TableAdapter traning1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typetrainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timetrainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestotrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maincoachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondcoachDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}