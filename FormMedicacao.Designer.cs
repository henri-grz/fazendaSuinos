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
            this.btnLimparcampos = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSalvarFornMed = new System.Windows.Forms.Button();
            this.txtCodigoloteFMed = new System.Windows.Forms.TextBox();
            this.txtQuantidadeMed = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCodigoProdFMed = new System.Windows.Forms.TextBox();
            this.panelBotoes.SuspendLayout();
            this.panelConsumo.SuspendLayout();
            this.panelFornecimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpVacinacao
            // 
            this.dtpVacinacao.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dtpVacinacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpVacinacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVacinacao.Location = new System.Drawing.Point(286, 168);
            this.dtpVacinacao.Name = "dtpVacinacao";
            this.dtpVacinacao.Size = new System.Drawing.Size(134, 21);
            this.dtpVacinacao.TabIndex = 53;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(809, 345);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 30);
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
            this.txtMedicamento.Location = new System.Drawing.Point(286, 107);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(134, 21);
            this.txtMedicamento.TabIndex = 50;
            // 
            // txtCodigoLote
            // 
            this.txtCodigoLote.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodigoLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoLote.Location = new System.Drawing.Point(641, 108);
            this.txtCodigoLote.Name = "txtCodigoLote";
            this.txtCodigoLote.Size = new System.Drawing.Size(133, 19);
            this.txtCodigoLote.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(637, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Código do Lote";
            // 
            // txtDiasUso
            // 
            this.txtDiasUso.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDiasUso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiasUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiasUso.Location = new System.Drawing.Point(452, 169);
            this.txtDiasUso.Name = "txtDiasUso";
            this.txtDiasUso.Size = new System.Drawing.Size(133, 19);
            this.txtDiasUso.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(637, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Carência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(448, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Dias de Uso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(282, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
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
            this.btnLimpar.Location = new System.Drawing.Point(674, 345);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 30);
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
            this.btnConsultarCodigoLote.Location = new System.Drawing.Point(806, 104);
            this.btnConsultarCodigoLote.Name = "btnConsultarCodigoLote";
            this.btnConsultarCodigoLote.Size = new System.Drawing.Size(109, 22);
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
            this.label5.Location = new System.Drawing.Point(282, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Data";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtObservacao.Location = new System.Drawing.Point(286, 239);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(630, 67);
            this.txtObservacao.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(282, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Observação";
            // 
            // txtQntVac
            // 
            this.txtQntVac.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQntVac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQntVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQntVac.Location = new System.Drawing.Point(452, 108);
            this.txtQntVac.Name = "txtQntVac";
            this.txtQntVac.Size = new System.Drawing.Size(133, 19);
            this.txtQntVac.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(448, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "Quantidade Vacinados";
            // 
            // txtDiasCarencia
            // 
            this.txtDiasCarencia.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDiasCarencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiasCarencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiasCarencia.Location = new System.Drawing.Point(641, 169);
            this.txtDiasCarencia.Name = "txtDiasCarencia";
            this.txtDiasCarencia.Size = new System.Drawing.Size(133, 19);
            this.txtDiasCarencia.TabIndex = 58;
            // 
            // btnConsultarCarencia
            // 
            this.btnConsultarCarencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarCarencia.FlatAppearance.BorderSize = 0;
            this.btnConsultarCarencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCarencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCarencia.ForeColor = System.Drawing.Color.White;
            this.btnConsultarCarencia.Location = new System.Drawing.Point(803, 166);
            this.btnConsultarCarencia.Name = "btnConsultarCarencia";
            this.btnConsultarCarencia.Size = new System.Drawing.Size(111, 22);
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
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(2);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(1662, 150);
            this.panelBotoes.TabIndex = 75;
            // 
            // btnFornecimento
            // 
            this.btnFornecimento.FlatAppearance.BorderSize = 0;
            this.btnFornecimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnFornecimento.Location = new System.Drawing.Point(472, 54);
            this.btnFornecimento.Name = "btnFornecimento";
            this.btnFornecimento.Size = new System.Drawing.Size(294, 60);
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
            this.btnConsumo.Location = new System.Drawing.Point(191, 54);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(200, 60);
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
            this.label9.Location = new System.Drawing.Point(282, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 24);
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
            this.panelConsumo.Location = new System.Drawing.Point(0, 749);
            this.panelConsumo.Name = "panelConsumo";
            this.panelConsumo.Size = new System.Drawing.Size(1662, 599);
            this.panelConsumo.TabIndex = 77;
            // 
            // panelFornecimento
            // 
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
            this.panelFornecimento.Controls.Add(this.btnLimparcampos);
            this.panelFornecimento.Controls.Add(this.label18);
            this.panelFornecimento.Controls.Add(this.btnSalvarFornMed);
            this.panelFornecimento.Controls.Add(this.txtCodigoloteFMed);
            this.panelFornecimento.Controls.Add(this.txtQuantidadeMed);
            this.panelFornecimento.Controls.Add(this.label19);
            this.panelFornecimento.Controls.Add(this.txtCodigoProdFMed);
            this.panelFornecimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFornecimento.Location = new System.Drawing.Point(0, 150);
            this.panelFornecimento.Name = "panelFornecimento";
            this.panelFornecimento.Size = new System.Drawing.Size(1662, 599);
            this.panelFornecimento.TabIndex = 78;
            // 
            // btnConsultarFornecedorForn
            // 
            this.btnConsultarFornecedorForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarFornecedorForn.FlatAppearance.BorderSize = 0;
            this.btnConsultarFornecedorForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFornecedorForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFornecedorForn.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFornecedorForn.Location = new System.Drawing.Point(770, 278);
            this.btnConsultarFornecedorForn.Name = "btnConsultarFornecedorForn";
            this.btnConsultarFornecedorForn.Size = new System.Drawing.Size(147, 22);
            this.btnConsultarFornecedorForn.TabIndex = 125;
            this.btnConsultarFornecedorForn.Text = "Consultar Fornecedor";
            this.btnConsultarFornecedorForn.UseVisualStyleBackColor = false;
            this.btnConsultarFornecedorForn.Click += new System.EventHandler(this.btnConsultarFornecedorForn_Click);
            // 
            // dtpValidadeMed
            // 
            this.dtpValidadeMed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidadeMed.Location = new System.Drawing.Point(783, 192);
            this.dtpValidadeMed.Name = "dtpValidadeMed";
            this.dtpValidadeMed.Size = new System.Drawing.Size(133, 20);
            this.dtpValidadeMed.TabIndex = 122;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(618, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 121;
            this.label10.Text = "Código do Fornecedor";
            // 
            // txtCodFornecedorMed
            // 
            this.txtCodFornecedorMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodFornecedorMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodFornecedorMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodFornecedorMed.Location = new System.Drawing.Point(622, 280);
            this.txtCodFornecedorMed.Name = "txtCodFornecedorMed";
            this.txtCodFornecedorMed.Size = new System.Drawing.Size(133, 19);
            this.txtCodFornecedorMed.TabIndex = 120;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label17.Location = new System.Drawing.Point(447, 249);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 118;
            this.label17.Text = "Unidade";
            // 
            // txtUnidadeMed
            // 
            this.txtUnidadeMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtUnidadeMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidadeMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnidadeMed.Location = new System.Drawing.Point(452, 280);
            this.txtUnidadeMed.Name = "txtUnidadeMed";
            this.txtUnidadeMed.Size = new System.Drawing.Size(133, 19);
            this.txtUnidadeMed.TabIndex = 119;
            // 
            // btnConsultarProdutoForn
            // 
            this.btnConsultarProdutoForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarProdutoForn.FlatAppearance.BorderSize = 0;
            this.btnConsultarProdutoForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProdutoForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProdutoForn.ForeColor = System.Drawing.Color.White;
            this.btnConsultarProdutoForn.Location = new System.Drawing.Point(566, 107);
            this.btnConsultarProdutoForn.Name = "btnConsultarProdutoForn";
            this.btnConsultarProdutoForn.Size = new System.Drawing.Size(81, 22);
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
            this.label16.Location = new System.Drawing.Point(780, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 116;
            this.label16.Text = "Validade";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label15.Location = new System.Drawing.Point(618, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 20);
            this.label15.TabIndex = 114;
            this.label15.Text = "Tipo";
            // 
            // txtTipoMed
            // 
            this.txtTipoMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTipoMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTipoMed.Location = new System.Drawing.Point(622, 192);
            this.txtTipoMed.Name = "txtTipoMed";
            this.txtTipoMed.Size = new System.Drawing.Size(133, 19);
            this.txtTipoMed.TabIndex = 115;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label14.Location = new System.Drawing.Point(448, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 112;
            this.label14.Text = "Categoria";
            // 
            // txtCategoriaMed
            // 
            this.txtCategoriaMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCategoriaMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoriaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCategoriaMed.Location = new System.Drawing.Point(452, 192);
            this.txtCategoriaMed.Name = "txtCategoriaMed";
            this.txtCategoriaMed.Size = new System.Drawing.Size(133, 19);
            this.txtCategoriaMed.TabIndex = 113;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label13.Location = new System.Drawing.Point(282, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 110;
            this.label13.Text = "Produto";
            // 
            // txtProdutoMed
            // 
            this.txtProdutoMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtProdutoMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdutoMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProdutoMed.Location = new System.Drawing.Point(286, 192);
            this.txtProdutoMed.Name = "txtProdutoMed";
            this.txtProdutoMed.Size = new System.Drawing.Size(133, 19);
            this.txtProdutoMed.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label12.Location = new System.Drawing.Point(407, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 109;
            this.label12.Text = "Código do Produto";
            // 
            // dtpFornMed
            // 
            this.dtpFornMed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFornMed.Location = new System.Drawing.Point(286, 107);
            this.dtpFornMed.Name = "dtpFornMed";
            this.dtpFornMed.Size = new System.Drawing.Size(100, 20);
            this.dtpFornMed.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(282, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 24);
            this.label6.TabIndex = 98;
            this.label6.Text = "Fornecimento de ração";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label11.Location = new System.Drawing.Point(282, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
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
            this.btnConsultarLoteForn.Location = new System.Drawing.Point(831, 108);
            this.btnConsultarLoteForn.Name = "btnConsultarLoteForn";
            this.btnConsultarLoteForn.Size = new System.Drawing.Size(86, 22);
            this.btnConsultarLoteForn.TabIndex = 100;
            this.btnConsultarLoteForn.Text = "Consultar";
            this.btnConsultarLoteForn.UseVisualStyleBackColor = false;
            this.btnConsultarLoteForn.Click += new System.EventHandler(this.btnConsultarLoteForn_Click);
            // 
            // btnLimparcampos
            // 
            this.btnLimparcampos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimparcampos.FlatAppearance.BorderSize = 0;
            this.btnLimparcampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparcampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparcampos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparcampos.Location = new System.Drawing.Point(686, 349);
            this.btnLimparcampos.Name = "btnLimparcampos";
            this.btnLimparcampos.Size = new System.Drawing.Size(106, 30);
            this.btnLimparcampos.TabIndex = 101;
            this.btnLimparcampos.Text = "Limpar";
            this.btnLimparcampos.UseVisualStyleBackColor = false;
            this.btnLimparcampos.Click += new System.EventHandler(this.btnLimparcampos_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label18.Location = new System.Drawing.Point(281, 249);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 20);
            this.label18.TabIndex = 102;
            this.label18.Text = "Quantidade (kg)";
            // 
            // btnSalvarFornMed
            // 
            this.btnSalvarFornMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSalvarFornMed.FlatAppearance.BorderSize = 0;
            this.btnSalvarFornMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFornMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFornMed.ForeColor = System.Drawing.Color.White;
            this.btnSalvarFornMed.Location = new System.Drawing.Point(811, 349);
            this.btnSalvarFornMed.Name = "btnSalvarFornMed";
            this.btnSalvarFornMed.Size = new System.Drawing.Size(106, 30);
            this.btnSalvarFornMed.TabIndex = 107;
            this.btnSalvarFornMed.Text = "Salvar";
            this.btnSalvarFornMed.UseVisualStyleBackColor = false;
            this.btnSalvarFornMed.Click += new System.EventHandler(this.btnSalvarFornMed_Click);
            // 
            // txtCodigoloteFMed
            // 
            this.txtCodigoloteFMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodigoloteFMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoloteFMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoloteFMed.Location = new System.Drawing.Point(676, 108);
            this.txtCodigoloteFMed.Name = "txtCodigoloteFMed";
            this.txtCodigoloteFMed.Size = new System.Drawing.Size(133, 19);
            this.txtCodigoloteFMed.TabIndex = 106;
            // 
            // txtQuantidadeMed
            // 
            this.txtQuantidadeMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQuantidadeMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidadeMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidadeMed.Location = new System.Drawing.Point(286, 280);
            this.txtQuantidadeMed.Name = "txtQuantidadeMed";
            this.txtQuantidadeMed.Size = new System.Drawing.Size(133, 19);
            this.txtQuantidadeMed.TabIndex = 103;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label19.Location = new System.Drawing.Point(673, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 20);
            this.label19.TabIndex = 105;
            this.label19.Text = "Código do Lote";
            // 
            // txtCodigoProdFMed
            // 
            this.txtCodigoProdFMed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodigoProdFMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoProdFMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoProdFMed.Location = new System.Drawing.Point(411, 107);
            this.txtCodigoProdFMed.Name = "txtCodigoProdFMed";
            this.txtCodigoProdFMed.Size = new System.Drawing.Size(133, 19);
            this.txtCodigoProdFMed.TabIndex = 104;
            // 
            // FormMedicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1662, 749);
            this.Controls.Add(this.panelConsumo);
            this.Controls.Add(this.panelFornecimento);
            this.Controls.Add(this.panelBotoes);
            this.Name = "FormMedicacao";
            this.Text = "FormMedicacao";
            this.panelBotoes.ResumeLayout(false);
            this.panelConsumo.ResumeLayout(false);
            this.panelConsumo.PerformLayout();
            this.panelFornecimento.ResumeLayout(false);
            this.panelFornecimento.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtpValidadeMed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodFornecedorMed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUnidadeMed;
        private System.Windows.Forms.Button btnConsultarProdutoForn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTipoMed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCategoriaMed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProdutoMed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFornMed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConsultarLoteForn;
        private System.Windows.Forms.Button btnLimparcampos;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSalvarFornMed;
        private System.Windows.Forms.TextBox txtCodigoloteFMed;
        private System.Windows.Forms.TextBox txtQuantidadeMed;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCodigoProdFMed;
    }
}