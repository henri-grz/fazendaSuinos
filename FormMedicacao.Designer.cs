namespace fazendaSuinos
{
    partial class FormMedicacao
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
            this.dtpVacinacao = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtMedicamento = new System.Windows.Forms.ComboBox();
            this.txtCodigoLote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiasUso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultarCodigoLote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQntVac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiasCarencia = new System.Windows.Forms.TextBox();
            this.btnConsultarCarencia = new System.Windows.Forms.Button();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnFornecimento = new System.Windows.Forms.Button();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panelConsumo = new System.Windows.Forms.Panel();
            this.panelFornecimento = new System.Windows.Forms.Panel();
            this.btnIncluirForn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCodFornecimento = new System.Windows.Forms.TextBox();
            this.dataGridFornecimento = new System.Windows.Forms.DataGridView();
            this.codFornecimentoMedicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecimentoMedicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaSuinosDataSet = new fazendaSuinos.fazendaSuinosDataSet();
            this.btnConsultarFornecedorForn = new System.Windows.Forms.Button();
            this.dtpValidadeMed = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodFornecedorMed = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUnidadeMed = new System.Windows.Forms.TextBox();
            this.btnConsultarProdutoForn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTipoMed = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCategoriaMed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProdutoMed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFornMed = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConsultarLoteForn = new System.Windows.Forms.Button();
            this.btnLimparForn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSalvarForn = new System.Windows.Forms.Button();
            this.txtCodigoloteFMed = new System.Windows.Forms.TextBox();
            this.txtQuantidadeMed = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCodigoProdFMed = new System.Windows.Forms.TextBox();
            this.fornecimentoMedicamentoTableAdapter = new fazendaSuinos.fazendaSuinosDataSetTableAdapters.FornecimentoMedicamentoTableAdapter();
            this.panelBotoes.SuspendLayout();
            this.panelConsumo.SuspendLayout();
            this.panelFornecimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoMedicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpVacinacao
            // 
            this.dtpVacinacao.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dtpVacinacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpVacinacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVacinacao.Location = new System.Drawing.Point(381, 207);
            this.dtpVacinacao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVacinacao.Name = "dtpVacinacao";
            this.dtpVacinacao.Size = new System.Drawing.Size(177, 24);
            this.dtpVacinacao.TabIndex = 53;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(1079, 425);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 37);
            this.btnSalvar.TabIndex = 52;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMedicamento.FormattingEnabled = true;
            this.txtMedicamento.Items.AddRange(new object[] {
            "Agroplus",
            "Zelotril Plus",
            "Excenel Rtu Ez",
            "Stark",
            "Farmaflor Injetavel",
            "Profenac Injetavel",
            "Diclobase",
            "Farmaxilin 50",
            "Agesperin",
            "Selko-Ph",
            "V 12",
            "Lingueto Plus Aerosol",
            "Redtail",
            "Lincomax 44",
            "Salisin",
            "B-lacmox",
            "Lincospecmax",
            ""});
            this.txtMedicamento.Location = new System.Drawing.Point(381, 132);
            this.txtMedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(177, 24);
            this.txtMedicamento.TabIndex = 50;
            // 
            // txtCodigoLote
            // 
            this.txtCodigoLote.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodigoLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoLote.Location = new System.Drawing.Point(855, 133);
            this.txtCodigoLote.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoLote.Name = "txtCodigoLote";
            this.txtCodigoLote.Size = new System.Drawing.Size(177, 23);
            this.txtCodigoLote.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(849, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Código do Lote";
            // 
            // txtDiasUso
            // 
            this.txtDiasUso.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDiasUso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiasUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiasUso.Location = new System.Drawing.Point(603, 208);
            this.txtDiasUso.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiasUso.Name = "txtDiasUso";
            this.txtDiasUso.Size = new System.Drawing.Size(177, 23);
            this.txtDiasUso.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(849, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Carência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(597, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Dias de Uso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(376, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Medicamento";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(899, 425);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(141, 37);
            this.btnLimpar.TabIndex = 42;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnConsultarCodigoLote
            // 
            this.btnConsultarCodigoLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarCodigoLote.FlatAppearance.BorderSize = 0;
            this.btnConsultarCodigoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCodigoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCodigoLote.ForeColor = System.Drawing.Color.White;
            this.btnConsultarCodigoLote.Location = new System.Drawing.Point(1075, 128);
            this.btnConsultarCodigoLote.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarCodigoLote.Name = "btnConsultarCodigoLote";
            this.btnConsultarCodigoLote.Size = new System.Drawing.Size(145, 27);
            this.btnConsultarCodigoLote.TabIndex = 41;
            this.btnConsultarCodigoLote.Text = "Consultar Lotes";
            this.btnConsultarCodigoLote.UseVisualStyleBackColor = false;
            this.btnConsultarCodigoLote.Click += new System.EventHandler(this.btnConsultarCodigoLote_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(376, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Data";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtObservacao.Location = new System.Drawing.Point(381, 294);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(839, 82);
            this.txtObservacao.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(376, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Observação";
            // 
            // txtQntVac
            // 
            this.txtQntVac.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQntVac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQntVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQntVac.Location = new System.Drawing.Point(603, 133);
            this.txtQntVac.Margin = new System.Windows.Forms.Padding(4);
            this.txtQntVac.Name = "txtQntVac";
            this.txtQntVac.Size = new System.Drawing.Size(177, 23);
            this.txtQntVac.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(597, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Quantidade Vacinados";
            // 
            // txtDiasCarencia
            // 
            this.txtDiasCarencia.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDiasCarencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiasCarencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiasCarencia.Location = new System.Drawing.Point(855, 208);
            this.txtDiasCarencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiasCarencia.Name = "txtDiasCarencia";
            this.txtDiasCarencia.Size = new System.Drawing.Size(177, 23);
            this.txtDiasCarencia.TabIndex = 58;
            // 
            // btnConsultarCarencia
            // 
            this.btnConsultarCarencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarCarencia.FlatAppearance.BorderSize = 0;
            this.btnConsultarCarencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCarencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCarencia.ForeColor = System.Drawing.Color.White;
            this.btnConsultarCarencia.Location = new System.Drawing.Point(1071, 204);
            this.btnConsultarCarencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarCarencia.Name = "btnConsultarCarencia";
            this.btnConsultarCarencia.Size = new System.Drawing.Size(148, 27);
            this.btnConsultarCarencia.TabIndex = 59;
            this.btnConsultarCarencia.Text = "Consultar Tabela";
            this.btnConsultarCarencia.UseVisualStyleBackColor = false;
            this.btnConsultarCarencia.Click += new System.EventHandler(this.btnConsultarCarencia_Click);
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnFornecimento);
            this.panelBotoes.Controls.Add(this.btnConsumo);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoes.Location = new System.Drawing.Point(0, 0);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(1455, 185);
            this.panelBotoes.TabIndex = 75;
            // 
            // btnFornecimento
            // 
            this.btnFornecimento.FlatAppearance.BorderSize = 0;
            this.btnFornecimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnFornecimento.Location = new System.Drawing.Point(629, 66);
            this.btnFornecimento.Margin = new System.Windows.Forms.Padding(4);
            this.btnFornecimento.Name = "btnFornecimento";
            this.btnFornecimento.Size = new System.Drawing.Size(392, 74);
            this.btnFornecimento.TabIndex = 73;
            this.btnFornecimento.Text = "Fornecimento";
            this.btnFornecimento.UseVisualStyleBackColor = true;
            this.btnFornecimento.Click += new System.EventHandler(this.btnFornecimento_Click);
            // 
            // btnConsumo
            // 
            this.btnConsumo.FlatAppearance.BorderSize = 0;
            this.btnConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsumo.Location = new System.Drawing.Point(255, 66);
            this.btnConsumo.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(267, 74);
            this.btnConsumo.TabIndex = 72;
            this.btnConsumo.Text = "Consumo";
            this.btnConsumo.UseVisualStyleBackColor = true;
            this.btnConsumo.Click += new System.EventHandler(this.btnConsumo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label9.Location = new System.Drawing.Point(376, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(324, 29);
            this.label9.TabIndex = 76;
            this.label9.Text = "Consumo de medicamento";
            // 
            // panelConsumo
            // 
            this.panelConsumo.Controls.Add(this.label9);
            this.panelConsumo.Controls.Add(this.btnConsultarCarencia);
            this.panelConsumo.Controls.Add(this.txtDiasCarencia);
            this.panelConsumo.Controls.Add(this.txtQntVac);
            this.panelConsumo.Controls.Add(this.label8);
            this.panelConsumo.Controls.Add(this.txtObservacao);
            this.panelConsumo.Controls.Add(this.label4);
            this.panelConsumo.Controls.Add(this.dtpVacinacao);
            this.panelConsumo.Controls.Add(this.btnSalvar);
            this.panelConsumo.Controls.Add(this.txtMedicamento);
            this.panelConsumo.Controls.Add(this.txtCodigoLote);
            this.panelConsumo.Controls.Add(this.label7);
            this.panelConsumo.Controls.Add(this.txtDiasUso);
            this.panelConsumo.Controls.Add(this.label3);
            this.panelConsumo.Controls.Add(this.label2);
            this.panelConsumo.Controls.Add(this.label1);
            this.panelConsumo.Controls.Add(this.btnLimpar);
            this.panelConsumo.Controls.Add(this.btnConsultarCodigoLote);
            this.panelConsumo.Controls.Add(this.label5);
            this.panelConsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConsumo.Location = new System.Drawing.Point(0, 1172);
            this.panelConsumo.Margin = new System.Windows.Forms.Padding(4);
            this.panelConsumo.Name = "panelConsumo";
            this.panelConsumo.Size = new System.Drawing.Size(1455, 737);
            this.panelConsumo.TabIndex = 77;
            // 
            // panelFornecimento
            // 
            this.panelFornecimento.Controls.Add(this.btnIncluirForn);
            this.panelFornecimento.Controls.Add(this.label20);
            this.panelFornecimento.Controls.Add(this.txtCodFornecimento);
            this.panelFornecimento.Controls.Add(this.dataGridFornecimento);
            this.panelFornecimento.Controls.Add(this.btnConsultarFornecedorForn);
            this.panelFornecimento.Controls.Add(this.dtpValidadeMed);
            this.panelFornecimento.Controls.Add(this.label10);
            this.panelFornecimento.Controls.Add(this.txtCodFornecedorMed);
            this.panelFornecimento.Controls.Add(this.label17);
            this.panelFornecimento.Controls.Add(this.txtUnidadeMed);
            this.panelFornecimento.Controls.Add(this.btnConsultarProdutoForn);
            this.panelFornecimento.Controls.Add(this.label16);
            this.panelFornecimento.Controls.Add(this.label15);
            this.panelFornecimento.Controls.Add(this.txtTipoMed);
            this.panelFornecimento.Controls.Add(this.label14);
            this.panelFornecimento.Controls.Add(this.txtCategoriaMed);
            this.panelFornecimento.Controls.Add(this.label13);
            this.panelFornecimento.Controls.Add(this.txtProdutoMed);
            this.panelFornecimento.Controls.Add(this.label12);
            this.panelFornecimento.Controls.Add(this.dtpFornMed);
            this.panelFornecimento.Controls.Add(this.label6);
            this.panelFornecimento.Controls.Add(this.label11);
            this.panelFornecimento.Controls.Add(this.btnConsultarLoteForn);
            this.panelFornecimento.Controls.Add(this.btnLimparForn);
            this.panelFornecimento.Controls.Add(this.label18);
            this.panelFornecimento.Controls.Add(this.btnSalvarForn);
            this.panelFornecimento.Controls.Add(this.txtCodigoloteFMed);
            this.panelFornecimento.Controls.Add(this.txtQuantidadeMed);
            this.panelFornecimento.Controls.Add(this.label19);
            this.panelFornecimento.Controls.Add(this.txtCodigoProdFMed);
            this.panelFornecimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFornecimento.Location = new System.Drawing.Point(0, 185);
            this.panelFornecimento.Margin = new System.Windows.Forms.Padding(4);
            this.panelFornecimento.Name = "panelFornecimento";
            this.panelFornecimento.Size = new System.Drawing.Size(1455, 987);
            this.panelFornecimento.TabIndex = 78;
            // 
            // btnIncluirForn
            // 
            this.btnIncluirForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnIncluirForn.FlatAppearance.BorderSize = 0;
            this.btnIncluirForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirForn.ForeColor = System.Drawing.Color.White;
            this.btnIncluirForn.Location = new System.Drawing.Point(1082, 501);
            this.btnIncluirForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluirForn.Name = "btnIncluirForn";
            this.btnIncluirForn.Size = new System.Drawing.Size(141, 37);
            this.btnIncluirForn.TabIndex = 129;
            this.btnIncluirForn.Text = "Incluir";
            this.btnIncluirForn.UseVisualStyleBackColor = false;
            this.btnIncluirForn.Click += new System.EventHandler(this.btnIncluirForn_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label20.Location = new System.Drawing.Point(376, 86);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(226, 25);
            this.label20.TabIndex = 128;
            this.label20.Text = "Código do Fornecimento";
            // 
            // txtCodFornecimento
            // 
            this.txtCodFornecimento.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodFornecimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodFornecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodFornecimento.Location = new System.Drawing.Point(381, 117);
            this.txtCodFornecimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodFornecimento.Name = "txtCodFornecimento";
            this.txtCodFornecimento.ReadOnly = true;
            this.txtCodFornecimento.Size = new System.Drawing.Size(177, 23);
            this.txtCodFornecimento.TabIndex = 127;
            this.txtCodFornecimento.TextChanged += new System.EventHandler(this.txtCodFornecimento_TextChanged);
            // 
            // dataGridFornecimento
            // 
            this.dataGridFornecimento.AllowUserToAddRows = false;
            this.dataGridFornecimento.AllowUserToDeleteRows = false;
            this.dataGridFornecimento.AutoGenerateColumns = false;
            this.dataGridFornecimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFornecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codFornecimentoMedicamentoDataGridViewTextBoxColumn,
            this.dataFornDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.validadeDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.codLoteDataGridViewTextBoxColumn,
            this.codProdutoDataGridViewTextBoxColumn,
            this.codFornecedorDataGridViewTextBoxColumn});
            this.dataGridFornecimento.DataSource = this.fornecimentoMedicamentoBindingSource;
            this.dataGridFornecimento.Location = new System.Drawing.Point(380, 602);
            this.dataGridFornecimento.Name = "dataGridFornecimento";
            this.dataGridFornecimento.ReadOnly = true;
            this.dataGridFornecimento.RowHeadersVisible = false;
            this.dataGridFornecimento.RowHeadersWidth = 51;
            this.dataGridFornecimento.RowTemplate.Height = 24;
            this.dataGridFornecimento.Size = new System.Drawing.Size(843, 330);
            this.dataGridFornecimento.TabIndex = 126;
            this.dataGridFornecimento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFornecimento_CellContentClick);
            this.dataGridFornecimento.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridFornecimento_DataBindingComplete);
            // 
            // codFornecimentoMedicamentoDataGridViewTextBoxColumn
            // 
            this.codFornecimentoMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "CodFornecimentoMedicamento";
            this.codFornecimentoMedicamentoDataGridViewTextBoxColumn.HeaderText = "CodFornecimentoMedicamento";
            this.codFornecimentoMedicamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codFornecimentoMedicamentoDataGridViewTextBoxColumn.Name = "codFornecimentoMedicamentoDataGridViewTextBoxColumn";
            this.codFornecimentoMedicamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFornDataGridViewTextBoxColumn
            // 
            this.dataFornDataGridViewTextBoxColumn.DataPropertyName = "DataForn";
            this.dataFornDataGridViewTextBoxColumn.HeaderText = "DataForn";
            this.dataFornDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataFornDataGridViewTextBoxColumn.Name = "dataFornDataGridViewTextBoxColumn";
            this.dataFornDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validadeDataGridViewTextBoxColumn
            // 
            this.validadeDataGridViewTextBoxColumn.DataPropertyName = "Validade";
            this.validadeDataGridViewTextBoxColumn.HeaderText = "Validade";
            this.validadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.validadeDataGridViewTextBoxColumn.Name = "validadeDataGridViewTextBoxColumn";
            this.validadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codLoteDataGridViewTextBoxColumn
            // 
            this.codLoteDataGridViewTextBoxColumn.DataPropertyName = "CodLote";
            this.codLoteDataGridViewTextBoxColumn.HeaderText = "CodLote";
            this.codLoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codLoteDataGridViewTextBoxColumn.Name = "codLoteDataGridViewTextBoxColumn";
            this.codLoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            this.codProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codFornecedorDataGridViewTextBoxColumn
            // 
            this.codFornecedorDataGridViewTextBoxColumn.DataPropertyName = "CodFornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.HeaderText = "CodFornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codFornecedorDataGridViewTextBoxColumn.Name = "codFornecedorDataGridViewTextBoxColumn";
            this.codFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecimentoMedicamentoBindingSource
            // 
            this.fornecimentoMedicamentoBindingSource.DataMember = "FornecimentoMedicamento";
            this.fornecimentoMedicamentoBindingSource.DataSource = this.fazendaSuinosDataSet;
            // 
            // fazendaSuinosDataSet
            // 
            this.fazendaSuinosDataSet.DataSetName = "fazendaSuinosDataSet";
            this.fazendaSuinosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnConsultarFornecedorForn
            // 
            this.btnConsultarFornecedorForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarFornecedorForn.FlatAppearance.BorderSize = 0;
            this.btnConsultarFornecedorForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFornecedorForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFornecedorForn.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFornecedorForn.Location = new System.Drawing.Point(1027, 416);
            this.btnConsultarFornecedorForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarFornecedorForn.Name = "btnConsultarFornecedorForn";
            this.btnConsultarFornecedorForn.Size = new System.Drawing.Size(196, 27);
            this.btnConsultarFornecedorForn.TabIndex = 125;
            this.btnConsultarFornecedorForn.Text = "Consultar Fornecedor";
            this.btnConsultarFornecedorForn.UseVisualStyleBackColor = false;
            this.btnConsultarFornecedorForn.Click += new System.EventHandler(this.btnConsultarFornecedorForn_Click);
            // 
            // dtpValidadeMed
            // 
            this.dtpValidadeMed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidadeMed.Location = new System.Drawing.Point(1044, 310);
            this.dtpValidadeMed.Margin = new System.Windows.Forms.Padding(4);
            this.dtpValidadeMed.Name = "dtpValidadeMed";
            this.dtpValidadeMed.Size = new System.Drawing.Size(176, 22);
            this.dtpValidadeMed.TabIndex = 122;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(824, 388);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 25);
            this.label10.TabIndex = 121;
            this.label10.Text = "Código do Fornecedor";
            // 
            // txtCodFornecedorMed
            // 
            this.txtCodFornecedorMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodFornecedorMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodFornecedorMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodFornecedorMed.Location = new System.Drawing.Point(829, 419);
            this.txtCodFornecedorMed.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodFornecedorMed.Name = "txtCodFornecedorMed";
            this.txtCodFornecedorMed.Size = new System.Drawing.Size(177, 23);
            this.txtCodFornecedorMed.TabIndex = 120;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label17.Location = new System.Drawing.Point(596, 380);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 25);
            this.label17.TabIndex = 118;
            this.label17.Text = "Unidade";
            // 
            // txtUnidadeMed
            // 
            this.txtUnidadeMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtUnidadeMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidadeMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnidadeMed.Location = new System.Drawing.Point(603, 419);
            this.txtUnidadeMed.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidadeMed.Name = "txtUnidadeMed";
            this.txtUnidadeMed.Size = new System.Drawing.Size(177, 23);
            this.txtUnidadeMed.TabIndex = 119;
            // 
            // btnConsultarProdutoForn
            // 
            this.btnConsultarProdutoForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarProdutoForn.FlatAppearance.BorderSize = 0;
            this.btnConsultarProdutoForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProdutoForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProdutoForn.ForeColor = System.Drawing.Color.White;
            this.btnConsultarProdutoForn.Location = new System.Drawing.Point(755, 206);
            this.btnConsultarProdutoForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarProdutoForn.Name = "btnConsultarProdutoForn";
            this.btnConsultarProdutoForn.Size = new System.Drawing.Size(108, 27);
            this.btnConsultarProdutoForn.TabIndex = 117;
            this.btnConsultarProdutoForn.Text = "Consultar";
            this.btnConsultarProdutoForn.UseVisualStyleBackColor = false;
            this.btnConsultarProdutoForn.Click += new System.EventHandler(this.btnConsultarProdutoForn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label16.Location = new System.Drawing.Point(1040, 282);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 25);
            this.label16.TabIndex = 116;
            this.label16.Text = "Validade";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label15.Location = new System.Drawing.Point(824, 282);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 25);
            this.label15.TabIndex = 114;
            this.label15.Text = "Tipo";
            // 
            // txtTipoMed
            // 
            this.txtTipoMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTipoMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTipoMed.Location = new System.Drawing.Point(829, 310);
            this.txtTipoMed.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoMed.Name = "txtTipoMed";
            this.txtTipoMed.ReadOnly = true;
            this.txtTipoMed.Size = new System.Drawing.Size(177, 23);
            this.txtTipoMed.TabIndex = 115;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label14.Location = new System.Drawing.Point(597, 282);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 25);
            this.label14.TabIndex = 112;
            this.label14.Text = "Categoria";
            // 
            // txtCategoriaMed
            // 
            this.txtCategoriaMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCategoriaMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoriaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCategoriaMed.Location = new System.Drawing.Point(603, 310);
            this.txtCategoriaMed.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoriaMed.Name = "txtCategoriaMed";
            this.txtCategoriaMed.ReadOnly = true;
            this.txtCategoriaMed.Size = new System.Drawing.Size(177, 23);
            this.txtCategoriaMed.TabIndex = 113;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label13.Location = new System.Drawing.Point(376, 282);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 25);
            this.label13.TabIndex = 110;
            this.label13.Text = "Produto";
            // 
            // txtProdutoMed
            // 
            this.txtProdutoMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtProdutoMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdutoMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProdutoMed.Location = new System.Drawing.Point(381, 310);
            this.txtProdutoMed.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdutoMed.Name = "txtProdutoMed";
            this.txtProdutoMed.ReadOnly = true;
            this.txtProdutoMed.Size = new System.Drawing.Size(177, 23);
            this.txtProdutoMed.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label12.Location = new System.Drawing.Point(543, 175);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 25);
            this.label12.TabIndex = 109;
            this.label12.Text = "Código do Produto";
            // 
            // dtpFornMed
            // 
            this.dtpFornMed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFornMed.Location = new System.Drawing.Point(381, 206);
            this.dtpFornMed.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFornMed.Name = "dtpFornMed";
            this.dtpFornMed.Size = new System.Drawing.Size(132, 22);
            this.dtpFornMed.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(376, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 29);
            this.label6.TabIndex = 98;
            this.label6.Text = "Fornecimento de Medicação";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label11.Location = new System.Drawing.Point(376, 176);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 25);
            this.label11.TabIndex = 99;
            this.label11.Text = "Data";
            // 
            // btnConsultarLoteForn
            // 
            this.btnConsultarLoteForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarLoteForn.FlatAppearance.BorderSize = 0;
            this.btnConsultarLoteForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarLoteForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLoteForn.ForeColor = System.Drawing.Color.White;
            this.btnConsultarLoteForn.Location = new System.Drawing.Point(1108, 207);
            this.btnConsultarLoteForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarLoteForn.Name = "btnConsultarLoteForn";
            this.btnConsultarLoteForn.Size = new System.Drawing.Size(115, 27);
            this.btnConsultarLoteForn.TabIndex = 100;
            this.btnConsultarLoteForn.Text = "Consultar";
            this.btnConsultarLoteForn.UseVisualStyleBackColor = false;
            this.btnConsultarLoteForn.Click += new System.EventHandler(this.btnConsultarLoteForn_Click);
            // 
            // btnLimparForn
            // 
            this.btnLimparForn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimparForn.FlatAppearance.BorderSize = 0;
            this.btnLimparForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparForn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparForn.Location = new System.Drawing.Point(750, 501);
            this.btnLimparForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparForn.Name = "btnLimparForn";
            this.btnLimparForn.Size = new System.Drawing.Size(141, 37);
            this.btnLimparForn.TabIndex = 101;
            this.btnLimparForn.Text = "Limpar";
            this.btnLimparForn.UseVisualStyleBackColor = false;
            this.btnLimparForn.Click += new System.EventHandler(this.btnLimparcampos_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label18.Location = new System.Drawing.Point(375, 380);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 25);
            this.label18.TabIndex = 102;
            this.label18.Text = "Quantidade";
            // 
            // btnSalvarForn
            // 
            this.btnSalvarForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSalvarForn.FlatAppearance.BorderSize = 0;
            this.btnSalvarForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarForn.ForeColor = System.Drawing.Color.White;
            this.btnSalvarForn.Location = new System.Drawing.Point(916, 501);
            this.btnSalvarForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarForn.Name = "btnSalvarForn";
            this.btnSalvarForn.Size = new System.Drawing.Size(141, 37);
            this.btnSalvarForn.TabIndex = 107;
            this.btnSalvarForn.Text = "Gravar";
            this.btnSalvarForn.UseVisualStyleBackColor = false;
            this.btnSalvarForn.Visible = false;
            this.btnSalvarForn.Click += new System.EventHandler(this.btnSalvarFornMed_Click);
            // 
            // txtCodigoloteFMed
            // 
            this.txtCodigoloteFMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodigoloteFMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoloteFMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoloteFMed.Location = new System.Drawing.Point(901, 207);
            this.txtCodigoloteFMed.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoloteFMed.Name = "txtCodigoloteFMed";
            this.txtCodigoloteFMed.Size = new System.Drawing.Size(177, 23);
            this.txtCodigoloteFMed.TabIndex = 106;
            // 
            // txtQuantidadeMed
            // 
            this.txtQuantidadeMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQuantidadeMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidadeMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidadeMed.Location = new System.Drawing.Point(381, 419);
            this.txtQuantidadeMed.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeMed.Name = "txtQuantidadeMed";
            this.txtQuantidadeMed.Size = new System.Drawing.Size(177, 23);
            this.txtQuantidadeMed.TabIndex = 103;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label19.Location = new System.Drawing.Point(897, 177);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 25);
            this.label19.TabIndex = 105;
            this.label19.Text = "Código do Lote";
            // 
            // txtCodigoProdFMed
            // 
            this.txtCodigoProdFMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodigoProdFMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoProdFMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoProdFMed.Location = new System.Drawing.Point(548, 206);
            this.txtCodigoProdFMed.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProdFMed.Name = "txtCodigoProdFMed";
            this.txtCodigoProdFMed.Size = new System.Drawing.Size(177, 23);
            this.txtCodigoProdFMed.TabIndex = 104;
            // 
            // fornecimentoMedicamentoTableAdapter
            // 
            this.fornecimentoMedicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FormMedicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 922);
            this.Controls.Add(this.panelConsumo);
            this.Controls.Add(this.panelFornecimento);
            this.Controls.Add(this.panelBotoes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMedicacao";
            this.Text = "FormMedicacao";
            this.Load += new System.EventHandler(this.FormMedicacao_Load);
            this.panelBotoes.ResumeLayout(false);
            this.panelConsumo.ResumeLayout(false);
            this.panelConsumo.PerformLayout();
            this.panelFornecimento.ResumeLayout(false);
            this.panelFornecimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoMedicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpVacinacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox txtMedicamento;
        private System.Windows.Forms.TextBox txtCodigoLote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiasUso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultarCodigoLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQntVac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiasCarencia;
        private System.Windows.Forms.Button btnConsultarCarencia;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnFornecimento;
        private System.Windows.Forms.Button btnConsumo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelConsumo;
        private System.Windows.Forms.Panel panelFornecimento;
        private System.Windows.Forms.Button btnConsultarFornecedorForn;
        public System.Windows.Forms.DateTimePicker dtpValidadeMed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodFornecedorMed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUnidadeMed;
        private System.Windows.Forms.Button btnConsultarProdutoForn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtTipoMed;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtCategoriaMed;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtProdutoMed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFornMed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConsultarLoteForn;
        private System.Windows.Forms.Button btnLimparForn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSalvarForn;
        private System.Windows.Forms.TextBox txtCodigoloteFMed;
        private System.Windows.Forms.TextBox txtQuantidadeMed;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCodigoProdFMed;
        private System.Windows.Forms.DataGridView dataGridFornecimento;
        private fazendaSuinosDataSet fazendaSuinosDataSet;
        private System.Windows.Forms.BindingSource fornecimentoMedicamentoBindingSource;
        private fazendaSuinosDataSetTableAdapters.FornecimentoMedicamentoTableAdapter fornecimentoMedicamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFornecimentoMedicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFornDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCodFornecimento;
        private System.Windows.Forms.Button btnIncluirForn;
    }
}