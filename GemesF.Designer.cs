namespace Dipllom_Gencha
{
    partial class GemesF
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
            this.game = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diplomBaseDataSet3 = new Dipllom_Gencha.DiplomBaseDataSet3();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new Dipllom_Gencha.DiplomBaseDataSet3TableAdapters.gamesTableAdapter();
            this.idgameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oponentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadiumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.game.Location = new System.Drawing.Point(29, 25);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(157, 25);
            this.game.TabIndex = 10;
            this.game.Text = "Игры команды";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(13, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgameDataGridViewTextBoxColumn,
            this.oponentDataGridViewTextBoxColumn,
            this.stadiumDataGridViewTextBoxColumn,
            this.tournamentDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(897, 337);
            this.dataGridView1.TabIndex = 9;
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
            this.idgameDataGridViewTextBoxColumn.HeaderText = "id";
            this.idgameDataGridViewTextBoxColumn.Name = "idgameDataGridViewTextBoxColumn";
            this.idgameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oponentDataGridViewTextBoxColumn
            // 
            this.oponentDataGridViewTextBoxColumn.DataPropertyName = "oponent";
            this.oponentDataGridViewTextBoxColumn.HeaderText = "Оппонент";
            this.oponentDataGridViewTextBoxColumn.Name = "oponentDataGridViewTextBoxColumn";
            this.oponentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stadiumDataGridViewTextBoxColumn
            // 
            this.stadiumDataGridViewTextBoxColumn.DataPropertyName = "stadium";
            this.stadiumDataGridViewTextBoxColumn.HeaderText = "Стадион";
            this.stadiumDataGridViewTextBoxColumn.Name = "stadiumDataGridViewTextBoxColumn";
            this.stadiumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tournamentDataGridViewTextBoxColumn
            // 
            this.tournamentDataGridViewTextBoxColumn.DataPropertyName = "tournament";
            this.tournamentDataGridViewTextBoxColumn.HeaderText = "Турнир";
            this.tournamentDataGridViewTextBoxColumn.Name = "tournamentDataGridViewTextBoxColumn";
            this.tournamentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Счет";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GemesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.game);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GemesF";
            this.Text = "GemesF";
            this.Load += new System.EventHandler(this.GemesF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomBaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label game;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DiplomBaseDataSet3 diplomBaseDataSet3;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private DiplomBaseDataSet3TableAdapters.gamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oponentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadiumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
    }
}