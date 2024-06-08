namespace Dipllom_Gencha
{
    partial class trainingf
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.traning1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomBaseDataSet1 = new Dipllom_Gencha.DiplomBaseDataSet1();
            this.traning1TableAdapter = new Dipllom_Gencha.DiplomBaseDataSet1TableAdapters.traning1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.idtrainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofweekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typetrainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetrainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plaсeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maincoachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondcoachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список тренировок";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtrainingDataGridViewTextBoxColumn,
            this.dayofweekDataGridViewTextBoxColumn,
            this.typetrainingDataGridViewTextBoxColumn,
            this.timetrainingDataGridViewTextBoxColumn,
            this.plaсeDataGridViewTextBoxColumn,
            this.maincoachDataGridViewTextBoxColumn,
            this.secondcoachDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.traning1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(899, 381);
            this.dataGridView1.TabIndex = 2;
            // 
            // traning1BindingSource
            // 
            this.traning1BindingSource.DataMember = "traning1";
            this.traning1BindingSource.DataSource = this.diplomBaseDataSet1;
            // 
            // diplomBaseDataSet1
            // 
            this.diplomBaseDataSet1.DataSetName = "DiplomBaseDataSet1";
            this.diplomBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traning1TableAdapter
            // 
            this.traning1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(23, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dayofweekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typetrainingDataGridViewTextBoxColumn
            // 
            this.typetrainingDataGridViewTextBoxColumn.DataPropertyName = "type_training";
            this.typetrainingDataGridViewTextBoxColumn.HeaderText = "Тип тренировки";
            this.typetrainingDataGridViewTextBoxColumn.Name = "typetrainingDataGridViewTextBoxColumn";
            this.typetrainingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timetrainingDataGridViewTextBoxColumn
            // 
            this.timetrainingDataGridViewTextBoxColumn.DataPropertyName = "time_training";
            this.timetrainingDataGridViewTextBoxColumn.HeaderText = "Время тренировки";
            this.timetrainingDataGridViewTextBoxColumn.Name = "timetrainingDataGridViewTextBoxColumn";
            this.timetrainingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plaсeDataGridViewTextBoxColumn
            // 
            this.plaсeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plaсeDataGridViewTextBoxColumn.DataPropertyName = "mesto_tr";
            this.plaсeDataGridViewTextBoxColumn.HeaderText = "Место";
            this.plaсeDataGridViewTextBoxColumn.Name = "plaсeDataGridViewTextBoxColumn";
            this.plaсeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maincoachDataGridViewTextBoxColumn
            // 
            this.maincoachDataGridViewTextBoxColumn.DataPropertyName = "main_coach";
            this.maincoachDataGridViewTextBoxColumn.HeaderText = "Главный тренер ";
            this.maincoachDataGridViewTextBoxColumn.Name = "maincoachDataGridViewTextBoxColumn";
            this.maincoachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondcoachDataGridViewTextBoxColumn
            // 
            this.secondcoachDataGridViewTextBoxColumn.DataPropertyName = "second_coach";
            this.secondcoachDataGridViewTextBoxColumn.HeaderText = "Тренер подготовки";
            this.secondcoachDataGridViewTextBoxColumn.Name = "secondcoachDataGridViewTextBoxColumn";
            this.secondcoachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainingf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "trainingf";
            this.Text = "training";
            this.Load += new System.EventHandler(this.training_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DiplomBaseDataSet1 diplomBaseDataSet1;
        private System.Windows.Forms.BindingSource traning1BindingSource;
        private DiplomBaseDataSet1TableAdapters.traning1TableAdapter traning1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typetrainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timetrainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plaсeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maincoachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondcoachDataGridViewTextBoxColumn;
    }
}