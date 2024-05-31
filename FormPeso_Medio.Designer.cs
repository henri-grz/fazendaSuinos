namespace fazendaSuinos
{
    partial class FormPeso_Medio
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
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtCodigoLote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaCiclo = new System.Windows.Forms.TextBox();
            this.txtPesoMedio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultarCodigoLote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridPesoMedio = new System.Windows.Forms.DataGridView();
            this.codPesoMedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoMedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaCicloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoMedioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaSuinosDataSet = new fazendaSuinos.fazendaSuinosDataSet();
            this.peso_MedioTableAdapter = new fazendaSuinos.fazendaSuinosDataSetTableAdapters.Peso_MedioTableAdapter();
            this.txtCodPesagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesoMedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoMedioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(290, 265);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerData.TabIndex = 54;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(795, 322);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(106, 30);
            this.btnIncluir.TabIndex = 53;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigoLote
            // 
            this.txtCodigoLote.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodigoLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoLote.Location = new System.Drawing.Point(418, 265);
            this.txtCodigoLote.Name = "txtCodigoLote";
            this.txtCodigoLote.Size = new System.Drawing.Size(99, 19);
            this.txtCodigoLote.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(416, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Código do Lote";
            // 
            // txtDiaCiclo
            // 
            this.txtDiaCiclo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDiaCiclo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaCiclo.Location = new System.Drawing.Point(802, 265);
            this.txtDiaCiclo.Name = "txtDiaCiclo";
            this.txtDiaCiclo.Size = new System.Drawing.Size(99, 19);
            this.txtDiaCiclo.TabIndex = 49;
            // 
            // txtPesoMedio
            // 
            this.txtPesoMedio.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPesoMedio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPesoMedio.Location = new System.Drawing.Point(672, 264);
            this.txtPesoMedio.Name = "txtPesoMedio";
            this.txtPesoMedio.Size = new System.Drawing.Size(99, 19);
            this.txtPesoMedio.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(798, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Dia do Ciclo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(668, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Peso Médio";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(534, 322);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 30);
            this.btnLimpar.TabIndex = 44;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConsultarCodigoLote
            // 
            this.btnConsultarCodigoLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarCodigoLote.FlatAppearance.BorderSize = 0;
            this.btnConsultarCodigoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCodigoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCodigoLote.ForeColor = System.Drawing.Color.White;
            this.btnConsultarCodigoLote.Location = new System.Drawing.Point(538, 261);
            this.btnConsultarCodigoLote.Name = "btnConsultarCodigoLote";
            this.btnConsultarCodigoLote.Size = new System.Drawing.Size(102, 22);
            this.btnConsultarCodigoLote.TabIndex = 43;
            this.btnConsultarCodigoLote.Text = "Consultar Lote";
            this.btnConsultarCodigoLote.UseVisualStyleBackColor = false;
            this.btnConsultarCodigoLote.Click += new System.EventHandler(this.btnConsultarCodigoLote_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(285, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(500, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 37);
            this.label6.TabIndex = 40;
            this.label6.Text = "Peso Médio";
            // 
            // dataGridPesoMedio
            // 
            this.dataGridPesoMedio.AllowUserToAddRows = false;
            this.dataGridPesoMedio.AllowUserToDeleteRows = false;
            this.dataGridPesoMedio.AutoGenerateColumns = false;
            this.dataGridPesoMedio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPesoMedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPesoMedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPesoMedioDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.pesoMedioDataGridViewTextBoxColumn,
            this.diaCicloDataGridViewTextBoxColumn,
            this.codLoteDataGridViewTextBoxColumn});
            this.dataGridPesoMedio.DataSource = this.pesoMedioBindingSource;
            this.dataGridPesoMedio.Location = new System.Drawing.Point(277, 395);
            this.dataGridPesoMedio.Name = "dataGridPesoMedio";
            this.dataGridPesoMedio.ReadOnly = true;
            this.dataGridPesoMedio.RowHeadersVisible = false;
            this.dataGridPesoMedio.Size = new System.Drawing.Size(624, 268);
            this.dataGridPesoMedio.TabIndex = 55;
            this.dataGridPesoMedio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPesoMedio_CellContentClick);
            this.dataGridPesoMedio.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridPesoMedio_DataBindingComplete);
            // 
            // codPesoMedioDataGridViewTextBoxColumn
            // 
            this.codPesoMedioDataGridViewTextBoxColumn.DataPropertyName = "CodPeso_Medio";
            this.codPesoMedioDataGridViewTextBoxColumn.HeaderText = "CodPeso_Medio";
            this.codPesoMedioDataGridViewTextBoxColumn.Name = "codPesoMedioDataGridViewTextBoxColumn";
            this.codPesoMedioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoMedioDataGridViewTextBoxColumn
            // 
            this.pesoMedioDataGridViewTextBoxColumn.DataPropertyName = "PesoMedio";
            this.pesoMedioDataGridViewTextBoxColumn.HeaderText = "PesoMedio";
            this.pesoMedioDataGridViewTextBoxColumn.Name = "pesoMedioDataGridViewTextBoxColumn";
            this.pesoMedioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaCicloDataGridViewTextBoxColumn
            // 
            this.diaCicloDataGridViewTextBoxColumn.DataPropertyName = "Dia_Ciclo";
            this.diaCicloDataGridViewTextBoxColumn.HeaderText = "Dia_Ciclo";
            this.diaCicloDataGridViewTextBoxColumn.Name = "diaCicloDataGridViewTextBoxColumn";
            this.diaCicloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codLoteDataGridViewTextBoxColumn
            // 
            this.codLoteDataGridViewTextBoxColumn.DataPropertyName = "CodLote";
            this.codLoteDataGridViewTextBoxColumn.HeaderText = "CodLote";
            this.codLoteDataGridViewTextBoxColumn.Name = "codLoteDataGridViewTextBoxColumn";
            this.codLoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoMedioBindingSource
            // 
            this.pesoMedioBindingSource.DataMember = "Peso_Medio";
            this.pesoMedioBindingSource.DataSource = this.fazendaSuinosDataSet;
            // 
            // fazendaSuinosDataSet
            // 
            this.fazendaSuinosDataSet.DataSetName = "fazendaSuinosDataSet";
            this.fazendaSuinosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peso_MedioTableAdapter
            // 
            this.peso_MedioTableAdapter.ClearBeforeFill = true;
            // 
            // txtCodPesagem
            // 
            this.txtCodPesagem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodPesagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodPesagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodPesagem.Location = new System.Drawing.Point(290, 201);
            this.txtCodPesagem.Name = "txtCodPesagem";
            this.txtCodPesagem.ReadOnly = true;
            this.txtCodPesagem.Size = new System.Drawing.Size(99, 19);
            this.txtCodPesagem.TabIndex = 57;
            this.txtCodPesagem.TextChanged += new System.EventHandler(this.txtCodPesagem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(285, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Código da Pesagem";
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(665, 322);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(106, 30);
            this.btnGravar.TabIndex = 58;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // FormPeso_Medio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1327, 807);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtCodPesagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPesoMedio);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtCodigoLote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiaCiclo);
            this.Controls.Add(this.txtPesoMedio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultarCodigoLote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "FormPeso_Medio";
            this.Text = "FormPeso_Medio";
            this.Load += new System.EventHandler(this.FormPeso_Medio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesoMedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoMedioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtCodigoLote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaCiclo;
        private System.Windows.Forms.TextBox txtPesoMedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultarCodigoLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridPesoMedio;
        private fazendaSuinosDataSet fazendaSuinosDataSet;
        private System.Windows.Forms.BindingSource pesoMedioBindingSource;
        private fazendaSuinosDataSetTableAdapters.Peso_MedioTableAdapter peso_MedioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPesoMedioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoMedioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaCicloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCodPesagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGravar;
    }
}