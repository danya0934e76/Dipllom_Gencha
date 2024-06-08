namespace Dipllom_Gencha
{
    partial class coach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coach));
            this.coachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diplomBaseDataSet = new Dipllom_Gencha.DiplomBaseDataSet();
            this.playersTableAdapter = new Dipllom_Gencha.DiplomBaseDataSetTableAdapters.playersTableAdapter();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachTableAdapter = new Dipllom_Gencha.DiplomBaseDataSetTableAdapters.coachTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.coachBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.diplomBaseDataSet1 = new Dipllom_Gencha.DiplomBaseDataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.training = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playersTableAdapter1 = new Dipllom_Gencha.DiplomBaseDataSet1TableAdapters.playersTableAdapter();
            this.coachTableAdapter1 = new Dipllom_Gencha.DiplomBaseDataSet1TableAdapters.coachTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.idcoachesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecoachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecoachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agecoachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameplayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberplayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryplayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageplayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // coachBindingSource1
            // 
            this.coachBindingSource1.DataMember = "coach";
            this.coachBindingSource1.DataSource = this.diplomBaseDataSet;
            this.coachBindingSource1.CurrentChanged += new System.EventHandler(this.coachBindingSource1_CurrentChanged);
            // 
            // diplomBaseDataSet
            // 
            this.diplomBaseDataSet.DataSetName = "DiplomBaseDataSet";
            this.diplomBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "players";
            this.playersBindingSource.DataSource = this.diplomBaseDataSet;
            this.playersBindingSource.CurrentChanged += new System.EventHandler(this.playersBindingSource_CurrentChanged);
            // 
            // coachTableAdapter
            // 
            this.coachTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcoachesDataGridViewTextBoxColumn,
            this.namecoachDataGridViewTextBoxColumn,
            this.typecoachDataGridViewTextBoxColumn,
            this.agecoachDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.coachBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(17, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(439, 175);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // coachBindingSource2
            // 
            this.coachBindingSource2.DataMember = "coach";
            this.coachBindingSource2.DataSource = this.diplomBaseDataSet1;
            // 
            // diplomBaseDataSet1
            // 
            this.diplomBaseDataSet1.DataSetName = "DiplomBaseDataSet1";
            this.diplomBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(279, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Футболисты клуба:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(396, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "Список игр";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 208);
            this.label2.TabIndex = 27;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 413);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // training
            // 
            this.training.BackColor = System.Drawing.SystemColors.Info;
            this.training.Location = new System.Drawing.Point(786, 541);
            this.training.Name = "training";
            this.training.Size = new System.Drawing.Size(123, 36);
            this.training.TabIndex = 23;
            this.training.Text = "Список тренировок";
            this.training.UseVisualStyleBackColor = false;
            this.training.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameplayerDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.numberplayerDataGridViewTextBoxColumn,
            this.countryplayerDataGridViewTextBoxColumn,
            this.ageplayerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(274, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(635, 221);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // playersBindingSource1
            // 
            this.playersBindingSource1.DataMember = "players";
            this.playersBindingSource1.DataSource = this.diplomBaseDataSet1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-8, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1087, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "coach";
            this.coachBindingSource.DataSource = this.diplomBaseDataSet;
            this.coachBindingSource.CurrentChanged += new System.EventHandler(this.coachBindingSource_CurrentChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(17, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(142, 413);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Список тренеров:";
            // 
            // playersTableAdapter1
            // 
            this.playersTableAdapter1.ClearBeforeFill = true;
            // 
            // coachTableAdapter1
            // 
            this.coachTableAdapter1.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(201, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(526, 42);
            this.label6.TabIndex = 46;
            this.label6.Text = "Футбольный клуб Барселона";
            // 
            // idcoachesDataGridViewTextBoxColumn
            // 
            this.idcoachesDataGridViewTextBoxColumn.DataPropertyName = "id_coaches";
            this.idcoachesDataGridViewTextBoxColumn.HeaderText = "id";
            this.idcoachesDataGridViewTextBoxColumn.Name = "idcoachesDataGridViewTextBoxColumn";
            this.idcoachesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namecoachDataGridViewTextBoxColumn
            // 
            this.namecoachDataGridViewTextBoxColumn.DataPropertyName = "name_coach";
            this.namecoachDataGridViewTextBoxColumn.HeaderText = "ФИО тренера ";
            this.namecoachDataGridViewTextBoxColumn.Name = "namecoachDataGridViewTextBoxColumn";
            this.namecoachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typecoachDataGridViewTextBoxColumn
            // 
            this.typecoachDataGridViewTextBoxColumn.DataPropertyName = "type_coach";
            this.typecoachDataGridViewTextBoxColumn.HeaderText = "Обязанность";
            this.typecoachDataGridViewTextBoxColumn.Name = "typecoachDataGridViewTextBoxColumn";
            this.typecoachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agecoachDataGridViewTextBoxColumn
            // 
            this.agecoachDataGridViewTextBoxColumn.DataPropertyName = "age_coach";
            this.agecoachDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.agecoachDataGridViewTextBoxColumn.Name = "agecoachDataGridViewTextBoxColumn";
            this.agecoachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameplayerDataGridViewTextBoxColumn
            // 
            this.nameplayerDataGridViewTextBoxColumn.DataPropertyName = "name_player";
            this.nameplayerDataGridViewTextBoxColumn.HeaderText = "ФИО футболиста";
            this.nameplayerDataGridViewTextBoxColumn.Name = "nameplayerDataGridViewTextBoxColumn";
            this.nameplayerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Позиция";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberplayerDataGridViewTextBoxColumn
            // 
            this.numberplayerDataGridViewTextBoxColumn.DataPropertyName = "number_player";
            this.numberplayerDataGridViewTextBoxColumn.HeaderText = "Номер на футболке";
            this.numberplayerDataGridViewTextBoxColumn.Name = "numberplayerDataGridViewTextBoxColumn";
            this.numberplayerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryplayerDataGridViewTextBoxColumn
            // 
            this.countryplayerDataGridViewTextBoxColumn.DataPropertyName = "country_player";
            this.countryplayerDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryplayerDataGridViewTextBoxColumn.Name = "countryplayerDataGridViewTextBoxColumn";
            this.countryplayerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageplayerDataGridViewTextBoxColumn
            // 
            this.ageplayerDataGridViewTextBoxColumn.DataPropertyName = "age_player";
            this.ageplayerDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.ageplayerDataGridViewTextBoxColumn.Name = "ageplayerDataGridViewTextBoxColumn";
            this.ageplayerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.training);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "coach";
            this.Text = "coach";
            this.Load += new System.EventHandler(this.coach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource coachBindingSource1;
        private DiplomBaseDataSet diplomBaseDataSet;
        private DiplomBaseDataSetTableAdapters.playersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private DiplomBaseDataSetTableAdapters.coachTableAdapter coachTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button training;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private DiplomBaseDataSet1 diplomBaseDataSet1;
        private System.Windows.Forms.BindingSource playersBindingSource1;
        private DiplomBaseDataSet1TableAdapters.playersTableAdapter playersTableAdapter1;
        private System.Windows.Forms.BindingSource coachBindingSource2;
        private DiplomBaseDataSet1TableAdapters.coachTableAdapter coachTableAdapter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcoachesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecoachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecoachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agecoachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameplayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberplayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryplayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageplayerDataGridViewTextBoxColumn;
    }
}