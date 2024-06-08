namespace Dipllom_Gencha
{
    partial class GamesP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diplomBaseDataSet4 = new Dipllom_Gencha.DiplomBaseDataSet4();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new Dipllom_Gencha.DiplomBaseDataSet4TableAdapters.gamesTableAdapter();
            this.game = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idgameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oponentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadiumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dategameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.DataSource = this.gamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(897, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // diplomBaseDataSet4
            // 
            this.diplomBaseDataSet4.DataSetName = "DiplomBaseDataSet4";
            this.diplomBaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "games";
            this.gamesBindingSource.DataSource = this.diplomBaseDataSet4;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.game.Location = new System.Drawing.Point(29, 33);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(157, 25);
            this.game.TabIndex = 7;
            this.game.Text = "Игры команды";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(12, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.oponentDataGridViewTextBoxColumn.HeaderText = "Оппонент ";
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
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Счет матча";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // dategameDataGridViewTextBoxColumn
            // 
            this.dategameDataGridViewTextBoxColumn.DataPropertyName = "date_game";
            this.dategameDataGridViewTextBoxColumn.HeaderText = "Дата Игры";
            this.dategameDataGridViewTextBoxColumn.Name = "dategameDataGridViewTextBoxColumn";
            // 
            // GamesP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.game);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GamesP";
            this.Text = "GamesP";
            this.Load += new System.EventHandler(this.GamesP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DiplomBaseDataSet4 diplomBaseDataSet4;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private DiplomBaseDataSet4TableAdapters.gamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.Label game;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oponentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadiumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dategameDataGridViewTextBoxColumn;
    }
}