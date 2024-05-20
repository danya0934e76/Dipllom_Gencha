namespace Dipllom_Gencha
{
    partial class trainingc
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
            this.traning1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomBaseDataSet1 = new Dipllom_Gencha.DiplomBaseDataSet1();
            this.diplomBaseDataSet = new Dipllom_Gencha.DiplomBaseDataSet();
            this.diplomBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traning1TableAdapter = new Dipllom_Gencha.DiplomBaseDataSet1TableAdapters.traning1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idTrain = new System.Windows.Forms.TextBox();
            this.dayOfWeek = new System.Windows.Forms.TextBox();
            this.typeTrain = new System.Windows.Forms.TextBox();
            this.secondCoach = new System.Windows.Forms.TextBox();
            this.mainCoach = new System.Windows.Forms.TextBox();
            this.placeTrain = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.timeTrain = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // diplomBaseDataSet
            // 
            this.diplomBaseDataSet.DataSetName = "DiplomBaseDataSet";
            this.diplomBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diplomBaseDataSetBindingSource
            // 
            this.diplomBaseDataSetBindingSource.DataSource = this.diplomBaseDataSet;
            this.diplomBaseDataSetBindingSource.Position = 0;
            // 
            // traning1TableAdapter
            // 
            this.traning1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список тренировок";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(910, 210);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idTrain
            // 
            this.idTrain.Location = new System.Drawing.Point(180, 339);
            this.idTrain.Name = "idTrain";
            this.idTrain.Size = new System.Drawing.Size(118, 20);
            this.idTrain.TabIndex = 9;
            // 
            // dayOfWeek
            // 
            this.dayOfWeek.Location = new System.Drawing.Point(180, 378);
            this.dayOfWeek.Name = "dayOfWeek";
            this.dayOfWeek.Size = new System.Drawing.Size(118, 20);
            this.dayOfWeek.TabIndex = 10;
            // 
            // typeTrain
            // 
            this.typeTrain.Location = new System.Drawing.Point(180, 416);
            this.typeTrain.Name = "typeTrain";
            this.typeTrain.Size = new System.Drawing.Size(118, 20);
            this.typeTrain.TabIndex = 11;
            // 
            // secondCoach
            // 
            this.secondCoach.Location = new System.Drawing.Point(427, 416);
            this.secondCoach.Name = "secondCoach";
            this.secondCoach.Size = new System.Drawing.Size(118, 20);
            this.secondCoach.TabIndex = 14;
            // 
            // mainCoach
            // 
            this.mainCoach.Location = new System.Drawing.Point(427, 378);
            this.mainCoach.Name = "mainCoach";
            this.mainCoach.Size = new System.Drawing.Size(118, 20);
            this.mainCoach.TabIndex = 13;
            // 
            // placeTrain
            // 
            this.placeTrain.Location = new System.Drawing.Point(427, 339);
            this.placeTrain.Name = "placeTrain";
            this.placeTrain.Size = new System.Drawing.Size(118, 20);
            this.placeTrain.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 49);
            this.button2.TabIndex = 15;
            this.button2.Text = "добавить тренировку";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(578, 409);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(215, 33);
            this.change.TabIndex = 17;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(578, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // timeTrain
            // 
            this.timeTrain.Location = new System.Drawing.Point(180, 455);
            this.timeTrain.Name = "timeTrain";
            this.timeTrain.Size = new System.Drawing.Size(118, 20);
            this.timeTrain.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 178);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "День недели";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Время тренировки";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Главный тренер";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Тип тренировки";
            // 
            // trainingc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.timeTrain);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.change);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.secondCoach);
            this.Controls.Add(this.mainCoach);
            this.Controls.Add(this.placeTrain);
            this.Controls.Add(this.typeTrain);
            this.Controls.Add(this.dayOfWeek);
            this.Controls.Add(this.idTrain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "trainingc";
            this.Text = "trainingAC";
            this.Load += new System.EventHandler(this.trainingAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traning1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource diplomBaseDataSetBindingSource;
        private DiplomBaseDataSet diplomBaseDataSet;
        private DiplomBaseDataSet1 diplomBaseDataSet1;
        private System.Windows.Forms.BindingSource traning1BindingSource;
        private DiplomBaseDataSet1TableAdapters.traning1TableAdapter traning1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idTrain;
        private System.Windows.Forms.TextBox dayOfWeek;
        private System.Windows.Forms.TextBox typeTrain;
        private System.Windows.Forms.TextBox secondCoach;
        private System.Windows.Forms.TextBox mainCoach;
        private System.Windows.Forms.TextBox placeTrain;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
        private System.Windows.Forms.TextBox timeTrain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}