namespace fazendaSuinos
{
    partial class FormAgendaTodos
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
            this.dataGridAgenda = new System.Windows.Forms.DataGridView();
            this.finalizadaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codAtividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAtividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVacinacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codRacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMortalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaSuinosDataSet = new fazendaSuinos.fazendaSuinosDataSet();
            this.agendaTableAdapter = new fazendaSuinos.fazendaSuinosDataSetTableAdapters.AgendaTableAdapter();
            this.contextMenuStripVisivel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tornarVisívelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDataSet)).BeginInit();
            this.contextMenuStripVisivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAgenda
            // 
            this.dataGridAgenda.AllowUserToAddRows = false;
            this.dataGridAgenda.AllowUserToDeleteRows = false;
            this.dataGridAgenda.AllowUserToResizeRows = false;
            this.dataGridAgenda.AutoGenerateColumns = false;
            this.dataGridAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.finalizadaDataGridViewCheckBoxColumn,
            this.codAtividadeDataGridViewTextBoxColumn,
            this.atividadeDataGridViewTextBoxColumn,
            this.dataAtividadeDataGridViewTextBoxColumn,
            this.codVacinacaoDataGridViewTextBoxColumn,
            this.codRacaoDataGridViewTextBoxColumn,
            this.codMortalidadeDataGridViewTextBoxColumn,
            this.codVisitaDataGridViewTextBoxColumn,
            this.codLoteDataGridViewTextBoxColumn});
            this.dataGridAgenda.DataSource = this.agendaBindingSource;
            this.dataGridAgenda.Location = new System.Drawing.Point(12, 12);
            this.dataGridAgenda.Name = "dataGridAgenda";
            this.dataGridAgenda.ReadOnly = true;
            this.dataGridAgenda.RowHeadersVisible = false;
            this.dataGridAgenda.RowHeadersWidth = 51;
            this.dataGridAgenda.RowTemplate.Height = 24;
            this.dataGridAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAgenda.Size = new System.Drawing.Size(843, 492);
            this.dataGridAgenda.TabIndex = 0;
            // 
            // finalizadaDataGridViewCheckBoxColumn
            // 
            this.finalizadaDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.finalizadaDataGridViewCheckBoxColumn.DataPropertyName = "Finalizada";
            this.finalizadaDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.finalizadaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.finalizadaDataGridViewCheckBoxColumn.Name = "finalizadaDataGridViewCheckBoxColumn";
            this.finalizadaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.finalizadaDataGridViewCheckBoxColumn.Width = 60;
            // 
            // codAtividadeDataGridViewTextBoxColumn
            // 
            this.codAtividadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codAtividadeDataGridViewTextBoxColumn.DataPropertyName = "CodAtividade";
            this.codAtividadeDataGridViewTextBoxColumn.HeaderText = "Cod";
            this.codAtividadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codAtividadeDataGridViewTextBoxColumn.Name = "codAtividadeDataGridViewTextBoxColumn";
            this.codAtividadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codAtividadeDataGridViewTextBoxColumn.Width = 60;
            // 
            // atividadeDataGridViewTextBoxColumn
            // 
            this.atividadeDataGridViewTextBoxColumn.DataPropertyName = "Atividade";
            this.atividadeDataGridViewTextBoxColumn.HeaderText = "Atividade";
            this.atividadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.atividadeDataGridViewTextBoxColumn.Name = "atividadeDataGridViewTextBoxColumn";
            this.atividadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAtividadeDataGridViewTextBoxColumn
            // 
            this.dataAtividadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataAtividadeDataGridViewTextBoxColumn.DataPropertyName = "DataAtividade";
            this.dataAtividadeDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataAtividadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataAtividadeDataGridViewTextBoxColumn.Name = "dataAtividadeDataGridViewTextBoxColumn";
            this.dataAtividadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataAtividadeDataGridViewTextBoxColumn.Width = 110;
            // 
            // codVacinacaoDataGridViewTextBoxColumn
            // 
            this.codVacinacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codVacinacaoDataGridViewTextBoxColumn.DataPropertyName = "CodVacinacao";
            this.codVacinacaoDataGridViewTextBoxColumn.HeaderText = "Vacinação";
            this.codVacinacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codVacinacaoDataGridViewTextBoxColumn.Name = "codVacinacaoDataGridViewTextBoxColumn";
            this.codVacinacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codVacinacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // codRacaoDataGridViewTextBoxColumn
            // 
            this.codRacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codRacaoDataGridViewTextBoxColumn.DataPropertyName = "CodRacao";
            this.codRacaoDataGridViewTextBoxColumn.HeaderText = "Alimentação";
            this.codRacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codRacaoDataGridViewTextBoxColumn.Name = "codRacaoDataGridViewTextBoxColumn";
            this.codRacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codRacaoDataGridViewTextBoxColumn.Width = 110;
            // 
            // codMortalidadeDataGridViewTextBoxColumn
            // 
            this.codMortalidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codMortalidadeDataGridViewTextBoxColumn.DataPropertyName = "CodMortalidade";
            this.codMortalidadeDataGridViewTextBoxColumn.HeaderText = "Mortalidade";
            this.codMortalidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codMortalidadeDataGridViewTextBoxColumn.Name = "codMortalidadeDataGridViewTextBoxColumn";
            this.codMortalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codMortalidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // codVisitaDataGridViewTextBoxColumn
            // 
            this.codVisitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codVisitaDataGridViewTextBoxColumn.DataPropertyName = "CodVisita";
            this.codVisitaDataGridViewTextBoxColumn.HeaderText = "Visita";
            this.codVisitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codVisitaDataGridViewTextBoxColumn.Name = "codVisitaDataGridViewTextBoxColumn";
            this.codVisitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codVisitaDataGridViewTextBoxColumn.Width = 60;
            // 
            // codLoteDataGridViewTextBoxColumn
            // 
            this.codLoteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codLoteDataGridViewTextBoxColumn.DataPropertyName = "CodLote";
            this.codLoteDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.codLoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codLoteDataGridViewTextBoxColumn.Name = "codLoteDataGridViewTextBoxColumn";
            this.codLoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLoteDataGridViewTextBoxColumn.Width = 60;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.fazendaSuinosDataSet;
            // 
            // fazendaSuinosDataSet
            // 
            this.fazendaSuinosDataSet.DataSetName = "fazendaSuinosDataSet";
            this.fazendaSuinosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStripVisivel
            // 
            this.contextMenuStripVisivel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripVisivel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tornarVisívelToolStripMenuItem});
            this.contextMenuStripVisivel.Name = "contextMenuStripVisivel";
            this.contextMenuStripVisivel.Size = new System.Drawing.Size(167, 28);
            // 
            // tornarVisívelToolStripMenuItem
            // 
            this.tornarVisívelToolStripMenuItem.Name = "tornarVisívelToolStripMenuItem";
            this.tornarVisívelToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.tornarVisívelToolStripMenuItem.Text = "Tornar Visível";
            this.tornarVisívelToolStripMenuItem.Click += new System.EventHandler(this.tornarVisívelToolStripMenuItem_Click);
            // 
            // FormAgendaTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 516);
            this.Controls.Add(this.dataGridAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgendaTodos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgendaTodos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAgendaTodos_FormClosed);
            this.Load += new System.EventHandler(this.FormAgendaTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDataSet)).EndInit();
            this.contextMenuStripVisivel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAgenda;
        private fazendaSuinosDataSet fazendaSuinosDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private fazendaSuinosDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finalizadaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVacinacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codRacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMortalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVisitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripVisivel;
        private System.Windows.Forms.ToolStripMenuItem tornarVisívelToolStripMenuItem;
    }
}