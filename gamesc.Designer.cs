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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.game = new System.Windows.Forms.Label();
            this.diplomBaseDataSet3 = new Dipllom_Gencha.DiplomBaseDataSet3();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new Dipllom_Gencha.DiplomBaseDataSet3TableAdapters.gamesTableAdapter();
            this.idgameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oponentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadiumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet3)).BeginInit();
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
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(931, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.game.Location = new System.Drawing.Point(251, 9);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(157, 25);
            this.game.TabIndex = 1;
            this.game.Text = "Игры команды";
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
            // idgameDataGridViewTextBoxColumn
            // 
            this.idgameDataGridViewTextBoxColumn.DataPropertyName = "id_game";
            this.idgameDataGridViewTextBoxColumn.HeaderText = "id_game";
            this.idgameDataGridViewTextBoxColumn.Name = "idgameDataGridViewTextBoxColumn";
            this.idgameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oponentDataGridViewTextBoxColumn
            // 
            this.oponentDataGridViewTextBoxColumn.DataPropertyName = "oponent";
            this.oponentDataGridViewTextBoxColumn.HeaderText = "oponent";
            this.oponentDataGridViewTextBoxColumn.Name = "oponentDataGridViewTextBoxColumn";
            // 
            // stadiumDataGridViewTextBoxColumn
            // 
            this.stadiumDataGridViewTextBoxColumn.DataPropertyName = "stadium";
            this.stadiumDataGridViewTextBoxColumn.HeaderText = "stadium";
            this.stadiumDataGridViewTextBoxColumn.Name = "stadiumDataGridViewTextBoxColumn";
            // 
            // tournamentDataGridViewTextBoxColumn
            // 
            this.tournamentDataGridViewTextBoxColumn.DataPropertyName = "tournament";
            this.tournamentDataGridViewTextBoxColumn.HeaderText = "tournament";
            this.tournamentDataGridViewTextBoxColumn.Name = "tournamentDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gamesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.game);
            this.Controls.Add(this.dataGridView1);
            this.Name = "gamesc";
            this.Text = "gamesc";
            this.Load += new System.EventHandler(this.gamesc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label game;
        private DiplomBaseDataSet3 diplomBaseDataSet3;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private DiplomBaseDataSet3TableAdapters.gamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oponentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadiumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}