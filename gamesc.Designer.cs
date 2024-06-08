namespace Dipllom_Gencha
{
    partial class gamesc
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
            this.diplomBaseDataSet3 = new Dipllom_Gencha.DiplomBaseDataSet3();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new Dipllom_Gencha.DiplomBaseDataSet3TableAdapters.gamesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.gamesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.diplomBaseDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomBaseDataSet4 = new Dipllom_Gencha.DiplomBaseDataSet4();
            this.gamesTableAdapter1 = new Dipllom_Gencha.DiplomBaseDataSet4TableAdapters.gamesTableAdapter();
            this.gamesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gamesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diplomBaseDataSet31 = new Dipllom_Gencha.DiplomBaseDataSet3();
            this.gamesTableAdapter2 = new Dipllom_Gencha.DiplomBaseDataSet3TableAdapters.gamesTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.game = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idgameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oponentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadiumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dategameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // diplomBaseDataSet3
            // 
            this.diplomBaseDataSet3.DataSetName = "DiplomBaseDataSet3";
            this.diplomBaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "games";
            this.gamesBindingSource.DataSource = this.diplomBaseDataSet3;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(12, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gamesBindingSource3
            // 
            this.gamesBindingSource3.DataMember = "games";
            this.gamesBindingSource3.DataSource = this.diplomBaseDataSet4BindingSource;
            // 
            // diplomBaseDataSet4BindingSource
            // 
            this.diplomBaseDataSet4BindingSource.DataSource = this.diplomBaseDataSet4;
            this.diplomBaseDataSet4BindingSource.Position = 0;
            // 
            // diplomBaseDataSet4
            // 
            this.diplomBaseDataSet4.DataSetName = "DiplomBaseDataSet4";
            this.diplomBaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesTableAdapter1
            // 
            this.gamesTableAdapter1.ClearBeforeFill = true;
            // 
            // gamesBindingSource2
            // 
            this.gamesBindingSource2.DataMember = "games";
            this.gamesBindingSource2.DataSource = this.diplomBaseDataSet4;
            // 
            // gamesBindingSource1
            // 
            this.gamesBindingSource1.DataMember = "games";
            this.gamesBindingSource1.DataSource = this.diplomBaseDataSet31;
            // 
            // diplomBaseDataSet31
            // 
            this.diplomBaseDataSet31.DataSetName = "DiplomBaseDataSet3";
            this.diplomBaseDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesTableAdapter2
            // 
            this.gamesTableAdapter2.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "games";
            this.bindingSource1.DataSource = this.diplomBaseDataSet31;
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.game.Location = new System.Drawing.Point(12, 16);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(157, 25);
            this.game.TabIndex = 7;
            this.game.Text = "Игры команды";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgameDataGridViewTextBoxColumn,
            this.oponentDataGridViewTextBoxColumn,
            this.stadiumDataGridViewTextBoxColumn,
            this.tournamentDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.dategameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gamesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 406);
            this.dataGridView1.TabIndex = 9;
            // 
            // idgameDataGridViewTextBoxColumn
            // 
            this.idgameDataGridViewTextBoxColumn.DataPropertyName = "id_game";
            this.idgameDataGridViewTextBoxColumn.HeaderText = "id";
            this.idgameDataGridViewTextBoxColumn.Name = "idgameDataGridViewTextBoxColumn";
            this.idgameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oponentDataGridViewTextBoxColumn
            // 
            this.oponentDataGridViewTextBoxColumn.DataPropertyName = "oponent";
            this.oponentDataGridViewTextBoxColumn.HeaderText = "Оппонент";
            this.oponentDataGridViewTextBoxColumn.Name = "oponentDataGridViewTextBoxColumn";
            // 
            // stadiumDataGridViewTextBoxColumn
            // 
            this.stadiumDataGridViewTextBoxColumn.DataPropertyName = "stadium";
            this.stadiumDataGridViewTextBoxColumn.HeaderText = "Стадион";
            this.stadiumDataGridViewTextBoxColumn.Name = "stadiumDataGridViewTextBoxColumn";
            // 
            // tournamentDataGridViewTextBoxColumn
            // 
            this.tournamentDataGridViewTextBoxColumn.DataPropertyName = "tournament";
            this.tournamentDataGridViewTextBoxColumn.HeaderText = "Турнир";
            this.tournamentDataGridViewTextBoxColumn.Name = "tournamentDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Счет";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // dategameDataGridViewTextBoxColumn
            // 
            this.dategameDataGridViewTextBoxColumn.DataPropertyName = "date_game";
            this.dategameDataGridViewTextBoxColumn.HeaderText = "Дата игры";
            this.dategameDataGridViewTextBoxColumn.Name = "dategameDataGridViewTextBoxColumn";
            // 
            // gamesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.game);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "gamesc";
            this.Text = "gamesc";
            this.Load += new System.EventHandler(this.gamesc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DiplomBaseDataSet3 diplomBaseDataSet3;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private DiplomBaseDataSet3TableAdapters.gamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource gamesBindingSource3;
        private System.Windows.Forms.BindingSource diplomBaseDataSet4BindingSource;
        private DiplomBaseDataSet4 diplomBaseDataSet4;
        private DiplomBaseDataSet4TableAdapters.gamesTableAdapter gamesTableAdapter1;
        private System.Windows.Forms.BindingSource gamesBindingSource2;
        private System.Windows.Forms.BindingSource gamesBindingSource1;
        private DiplomBaseDataSet3 diplomBaseDataSet31;
        private DiplomBaseDataSet3TableAdapters.gamesTableAdapter gamesTableAdapter2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label game;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oponentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadiumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dategameDataGridViewTextBoxColumn;
    }
}