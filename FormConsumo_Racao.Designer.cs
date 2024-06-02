namespace fazendaSuinos
{
    partial class FormConsumo_Racao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodigoLote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaCiclo = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultarCodigoLote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartConsumo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGerar_Grafico = new System.Windows.Forms.Button();
            this.comboLoteGrafico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConsumo = new System.Windows.Forms.Panel();
            this.btnFornecimento = new System.Windows.Forms.Button();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.panelFornecimento = new System.Windows.Forms.Panel();
            this.btnConsultarFornecedorForn = new System.Windows.Forms.Button();
            this.dtpValidadeForn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodFornecedorForn = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUnidadeForn = new System.Windows.Forms.TextBox();
            this.btnConsultarProdutoForn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTipoForn = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCategoriaForn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProdutoForn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFornRacao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConsultarLoteForn = new System.Windows.Forms.Button();
            this.btnLimparcampos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGravarForn = new System.Windows.Forms.Button();
            this.txtCodLoteForn = new System.Windows.Forms.TextBox();
            this.txtQuantidadeForn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodProdForn = new System.Windows.Forms.TextBox();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridFornecimento = new System.Windows.Forms.DataGridView();
            this.fazendaSuinosDataSet = new fazendaSuinos.fazendaSuinosDataSet();
            this.fornecimentoRacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecimentoRacaoTableAdapter = new fazendaSuinos.fazendaSuinosDataSetTableAdapters.FornecimentoRacaoTableAdapter();
            this.codFornecimentoRacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnIncluirForn = new System.Windows.Forms.Button();
            this.txtCodFornecimento = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).BeginInit();
            this.panelConsumo.SuspendLayout();
            this.panelFornecimento.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoRacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(404, 143);
            this.dateTimePickerData.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerData.TabIndex = 66;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(1087, 241);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 37);
            this.btnSalvar.TabIndex = 65;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigoLote
            // 
            this.txtCodigoLote.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodigoLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoLote.Location = new System.Drawing.Point(576, 143);
            this.txtCodigoLote.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoLote.Name = "txtCodigoLote";
            this.txtCodigoLote.Size = new System.Drawing.Size(132, 23);
            this.txtCodigoLote.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(572, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Código do Lote";
            // 
            // txtDiaCiclo
            // 
            this.txtDiaCiclo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDiaCiclo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaCiclo.Location = new System.Drawing.Point(1096, 143);
            this.txtDiaCiclo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaCiclo.Name = "txtDiaCiclo";
            this.txtDiaCiclo.Size = new System.Drawing.Size(132, 23);
            this.txtDiaCiclo.TabIndex = 62;
            // 
            // txtConsumo
            // 
            this.txtConsumo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtConsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConsumo.Location = new System.Drawing.Point(923, 142);
            this.txtConsumo.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(132, 23);
            this.txtConsumo.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(1091, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Dia do Ciclo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(917, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Consumo (kg)";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(903, 241);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(141, 37);
            this.btnLimpar.TabIndex = 58;
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
            this.btnConsultarCodigoLote.Location = new System.Drawing.Point(736, 139);
            this.btnConsultarCodigoLote.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarCodigoLote.Name = "btnConsultarCodigoLote";
            this.btnConsultarCodigoLote.Size = new System.Drawing.Size(136, 27);
            this.btnConsultarCodigoLote.TabIndex = 57;
            this.btnConsultarCodigoLote.Text = "Consultar Lote";
            this.btnConsultarCodigoLote.UseVisualStyleBackColor = false;
            this.btnConsultarCodigoLote.Click += new System.EventHandler(this.btnConsultarCodigoLote_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(399, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(399, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 29);
            this.label6.TabIndex = 55;
            this.label6.Text = "Consumo de Ração";
            // 
            // chartConsumo
            // 
            this.chartConsumo.BackColor = System.Drawing.SystemColors.MenuBar;
            chartArea8.Name = "ChartArea1";
            this.chartConsumo.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend3";
            this.chartConsumo.Legends.Add(legend8);
            this.chartConsumo.Location = new System.Drawing.Point(404, 393);
            this.chartConsumo.Margin = new System.Windows.Forms.Padding(4);
            this.chartConsumo.Name = "chartConsumo";
            this.chartConsumo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend3";
            series8.Name = "Consumo de Ração";
            this.chartConsumo.Series.Add(series8);
            this.chartConsumo.Size = new System.Drawing.Size(824, 369);
            this.chartConsumo.TabIndex = 67;
            this.chartConsumo.Text = "Gráfico de Consumo";
            // 
            // btnGerar_Grafico
            // 
            this.btnGerar_Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnGerar_Grafico.FlatAppearance.BorderSize = 0;
            this.btnGerar_Grafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar_Grafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar_Grafico.ForeColor = System.Drawing.Color.White;
            this.btnGerar_Grafico.Location = new System.Drawing.Point(576, 334);
            this.btnGerar_Grafico.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerar_Grafico.Name = "btnGerar_Grafico";
            this.btnGerar_Grafico.Size = new System.Drawing.Size(141, 37);
            this.btnGerar_Grafico.TabIndex = 68;
            this.btnGerar_Grafico.Text = "Gerar Gráfico";
            this.btnGerar_Grafico.UseVisualStyleBackColor = false;
            this.btnGerar_Grafico.Click += new System.EventHandler(this.btnGerar_Grafico_Click);
            // 
            // comboLoteGrafico
            // 
            this.comboLoteGrafico.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboLoteGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoteGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLoteGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLoteGrafico.ItemHeight = 24;
            this.comboLoteGrafico.Location = new System.Drawing.Point(404, 338);
            this.comboLoteGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.comboLoteGrafico.Name = "comboLoteGrafico";
            this.comboLoteGrafico.Size = new System.Drawing.Size(132, 32);
            this.comboLoteGrafico.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(399, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "Lote";
            // 
            // panelConsumo
            // 
            this.panelConsumo.Controls.Add(this.label1);
            this.panelConsumo.Controls.Add(this.dateTimePickerData);
            this.panelConsumo.Controls.Add(this.label6);
            this.panelConsumo.Controls.Add(this.comboLoteGrafico);
            this.panelConsumo.Controls.Add(this.label5);
            this.panelConsumo.Controls.Add(this.btnGerar_Grafico);
            this.panelConsumo.Controls.Add(this.btnConsultarCodigoLote);
            this.panelConsumo.Controls.Add(this.chartConsumo);
            this.panelConsumo.Controls.Add(this.btnLimpar);
            this.panelConsumo.Controls.Add(this.label2);
            this.panelConsumo.Controls.Add(this.btnSalvar);
            this.panelConsumo.Controls.Add(this.label3);
            this.panelConsumo.Controls.Add(this.txtCodigoLote);
            this.panelConsumo.Controls.Add(this.txtConsumo);
            this.panelConsumo.Controls.Add(this.label7);
            this.panelConsumo.Controls.Add(this.txtDiaCiclo);
            this.panelConsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConsumo.Location = new System.Drawing.Point(0, 1158);
            this.panelConsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelConsumo.Name = "panelConsumo";
            this.panelConsumo.Size = new System.Drawing.Size(1446, 791);
            this.panelConsumo.TabIndex = 71;
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
            // panelFornecimento
            // 
            this.panelFornecimento.Controls.Add(this.txtCodFornecimento);
            this.panelFornecimento.Controls.Add(this.label18);
            this.panelFornecimento.Controls.Add(this.btnIncluirForn);
            this.panelFornecimento.Controls.Add(this.dataGridFornecimento);
            this.panelFornecimento.Controls.Add(this.btnConsultarFornecedorForn);
            this.panelFornecimento.Controls.Add(this.dtpValidadeForn);
            this.panelFornecimento.Controls.Add(this.label10);
            this.panelFornecimento.Controls.Add(this.txtCodFornecedorForn);
            this.panelFornecimento.Controls.Add(this.label17);
            this.panelFornecimento.Controls.Add(this.txtUnidadeForn);
            this.panelFornecimento.Controls.Add(this.btnConsultarProdutoForn);
            this.panelFornecimento.Controls.Add(this.label16);
            this.panelFornecimento.Controls.Add(this.label15);
            this.panelFornecimento.Controls.Add(this.txtTipoForn);
            this.panelFornecimento.Controls.Add(this.label14);
            this.panelFornecimento.Controls.Add(this.txtCategoriaForn);
            this.panelFornecimento.Controls.Add(this.label13);
            this.panelFornecimento.Controls.Add(this.txtProdutoForn);
            this.panelFornecimento.Controls.Add(this.label12);
            this.panelFornecimento.Controls.Add(this.dtpFornRacao);
            this.panelFornecimento.Controls.Add(this.label4);
            this.panelFornecimento.Controls.Add(this.label8);
            this.panelFornecimento.Controls.Add(this.btnConsultarLoteForn);
            this.panelFornecimento.Controls.Add(this.btnLimparcampos);
            this.panelFornecimento.Controls.Add(this.label9);
            this.panelFornecimento.Controls.Add(this.btnGravarForn);
            this.panelFornecimento.Controls.Add(this.txtCodLoteForn);
            this.panelFornecimento.Controls.Add(this.txtQuantidadeForn);
            this.panelFornecimento.Controls.Add(this.label11);
            this.panelFornecimento.Controls.Add(this.txtCodProdForn);
            this.panelFornecimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFornecimento.Location = new System.Drawing.Point(0, 185);
            this.panelFornecimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFornecimento.Name = "panelFornecimento";
            this.panelFornecimento.Size = new System.Drawing.Size(1446, 973);
            this.panelFornecimento.TabIndex = 72;
            // 
            // btnConsultarFornecedorForn
            // 
            this.btnConsultarFornecedorForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarFornecedorForn.FlatAppearance.BorderSize = 0;
            this.btnConsultarFornecedorForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFornecedorForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFornecedorForn.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFornecedorForn.Location = new System.Drawing.Point(1077, 410);
            this.btnConsultarFornecedorForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarFornecedorForn.Name = "btnConsultarFornecedorForn";
            this.btnConsultarFornecedorForn.Size = new System.Drawing.Size(196, 27);
            this.btnConsultarFornecedorForn.TabIndex = 97;
            this.btnConsultarFornecedorForn.Text = "Consultar Fornecedor";
            this.btnConsultarFornecedorForn.UseVisualStyleBackColor = false;
            this.btnConsultarFornecedorForn.Click += new System.EventHandler(this.btnConsultarFornecedorForn_Click_1);
            // 
            // dtpValidadeForn
            // 
            this.dtpValidadeForn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidadeForn.Location = new System.Drawing.Point(1097, 304);
            this.dtpValidadeForn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpValidadeForn.Name = "dtpValidadeForn";
            this.dtpValidadeForn.Size = new System.Drawing.Size(176, 22);
            this.dtpValidadeForn.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(861, 380);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 25);
            this.label10.TabIndex = 92;
            this.label10.Text = "Código do Fornecedor";
            // 
            // txtCodFornecedorForn
            // 
            this.txtCodFornecedorForn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodFornecedorForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodFornecedorForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodFornecedorForn.Location = new System.Drawing.Point(867, 410);
            this.txtCodFornecedorForn.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodFornecedorForn.Name = "txtCodFornecedorForn";
            this.txtCodFornecedorForn.Size = new System.Drawing.Size(177, 23);
            this.txtCodFornecedorForn.TabIndex = 91;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label17.Location = new System.Drawing.Point(623, 372);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 25);
            this.label17.TabIndex = 89;
            this.label17.Text = "Unidade";
            // 
            // txtUnidadeForn
            // 
            this.txtUnidadeForn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtUnidadeForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidadeForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnidadeForn.Location = new System.Drawing.Point(629, 410);
            this.txtUnidadeForn.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidadeForn.Name = "txtUnidadeForn";
            this.txtUnidadeForn.Size = new System.Drawing.Size(177, 23);
            this.txtUnidadeForn.TabIndex = 90;
            // 
            // btnConsultarProdutoForn
            // 
            this.btnConsultarProdutoForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarProdutoForn.FlatAppearance.BorderSize = 0;
            this.btnConsultarProdutoForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProdutoForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProdutoForn.ForeColor = System.Drawing.Color.White;
            this.btnConsultarProdutoForn.Location = new System.Drawing.Point(805, 200);
            this.btnConsultarProdutoForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarProdutoForn.Name = "btnConsultarProdutoForn";
            this.btnConsultarProdutoForn.Size = new System.Drawing.Size(107, 27);
            this.btnConsultarProdutoForn.TabIndex = 88;
            this.btnConsultarProdutoForn.Text = "Consultar";
            this.btnConsultarProdutoForn.UseVisualStyleBackColor = false;
            this.btnConsultarProdutoForn.Click += new System.EventHandler(this.btnConsultarProdutoForn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label16.Location = new System.Drawing.Point(1092, 273);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 25);
            this.label16.TabIndex = 86;
            this.label16.Text = "Validade";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label15.Location = new System.Drawing.Point(861, 274);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 25);
            this.label15.TabIndex = 84;
            this.label15.Text = "Tipo";
            // 
            // txtTipoForn
            // 
            this.txtTipoForn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTipoForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTipoForn.Location = new System.Drawing.Point(867, 302);
            this.txtTipoForn.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoForn.Name = "txtTipoForn";
            this.txtTipoForn.ReadOnly = true;
            this.txtTipoForn.Size = new System.Drawing.Size(177, 23);
            this.txtTipoForn.TabIndex = 85;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label14.Location = new System.Drawing.Point(624, 273);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 25);
            this.label14.TabIndex = 82;
            this.label14.Text = "Categoria";
            // 
            // txtCategoriaForn
            // 
            this.txtCategoriaForn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCategoriaForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoriaForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCategoriaForn.Location = new System.Drawing.Point(629, 301);
            this.txtCategoriaForn.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoriaForn.Name = "txtCategoriaForn";
            this.txtCategoriaForn.ReadOnly = true;
            this.txtCategoriaForn.Size = new System.Drawing.Size(177, 23);
            this.txtCategoriaForn.TabIndex = 83;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label13.Location = new System.Drawing.Point(399, 274);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 25);
            this.label13.TabIndex = 80;
            this.label13.Text = "Produto";
            // 
            // txtProdutoForn
            // 
            this.txtProdutoForn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtProdutoForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdutoForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProdutoForn.Location = new System.Drawing.Point(404, 302);
            this.txtProdutoForn.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdutoForn.Name = "txtProdutoForn";
            this.txtProdutoForn.ReadOnly = true;
            this.txtProdutoForn.Size = new System.Drawing.Size(177, 23);
            this.txtProdutoForn.TabIndex = 81;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label12.Location = new System.Drawing.Point(603, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 25);
            this.label12.TabIndex = 79;
            this.label12.Text = "Código do Produto";
            // 
            // dtpFornRacao
            // 
            this.dtpFornRacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFornRacao.Location = new System.Drawing.Point(404, 201);
            this.dtpFornRacao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFornRacao.Name = "dtpFornRacao";
            this.dtpFornRacao.Size = new System.Drawing.Size(132, 22);
            this.dtpFornRacao.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(399, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 29);
            this.label4.TabIndex = 67;
            this.label4.Text = "Fornecimento de Ração";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(399, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 68;
            this.label8.Text = "Data";
            // 
            // btnConsultarLoteForn
            // 
            this.btnConsultarLoteForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarLoteForn.FlatAppearance.BorderSize = 0;
            this.btnConsultarLoteForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarLoteForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLoteForn.ForeColor = System.Drawing.Color.White;
            this.btnConsultarLoteForn.Location = new System.Drawing.Point(1165, 202);
            this.btnConsultarLoteForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarLoteForn.Name = "btnConsultarLoteForn";
            this.btnConsultarLoteForn.Size = new System.Drawing.Size(108, 27);
            this.btnConsultarLoteForn.TabIndex = 69;
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
            this.btnLimparcampos.Location = new System.Drawing.Point(798, 484);
            this.btnLimparcampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparcampos.Name = "btnLimparcampos";
            this.btnLimparcampos.Size = new System.Drawing.Size(141, 37);
            this.btnLimparcampos.TabIndex = 70;
            this.btnLimparcampos.Text = "Limpar";
            this.btnLimparcampos.UseVisualStyleBackColor = false;
            this.btnLimparcampos.Click += new System.EventHandler(this.btnLimparcampos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label9.Location = new System.Drawing.Point(397, 372);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 71;
            this.label9.Text = "Quantidade";
            // 
            // btnGravarForn
            // 
            this.btnGravarForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnGravarForn.FlatAppearance.BorderSize = 0;
            this.btnGravarForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarForn.ForeColor = System.Drawing.Color.White;
            this.btnGravarForn.Location = new System.Drawing.Point(965, 484);
            this.btnGravarForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravarForn.Name = "btnGravarForn";
            this.btnGravarForn.Size = new System.Drawing.Size(141, 37);
            this.btnGravarForn.TabIndex = 77;
            this.btnGravarForn.Text = "Gravar";
            this.btnGravarForn.UseVisualStyleBackColor = false;
            this.btnGravarForn.Visible = false;
            this.btnGravarForn.Click += new System.EventHandler(this.btnGravarForn_Click);
            // 
            // txtCodLoteForn
            // 
            this.txtCodLoteForn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodLoteForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodLoteForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodLoteForn.Location = new System.Drawing.Point(965, 204);
            this.txtCodLoteForn.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodLoteForn.Name = "txtCodLoteForn";
            this.txtCodLoteForn.Size = new System.Drawing.Size(177, 23);
            this.txtCodLoteForn.TabIndex = 76;
            // 
            // txtQuantidadeForn
            // 
            this.txtQuantidadeForn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQuantidadeForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidadeForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidadeForn.Location = new System.Drawing.Point(404, 410);
            this.txtQuantidadeForn.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeForn.Name = "txtQuantidadeForn";
            this.txtQuantidadeForn.Size = new System.Drawing.Size(177, 23);
            this.txtQuantidadeForn.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label11.Location = new System.Drawing.Point(961, 175);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 25);
            this.label11.TabIndex = 75;
            this.label11.Text = "Código do Lote";
            // 
            // txtCodProdForn
            // 
            this.txtCodProdForn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodProdForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodProdForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodProdForn.Location = new System.Drawing.Point(608, 202);
            this.txtCodProdForn.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProdForn.Name = "txtCodProdForn";
            this.txtCodProdForn.Size = new System.Drawing.Size(177, 23);
            this.txtCodProdForn.TabIndex = 74;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnFornecimento);
            this.panelBotoes.Controls.Add(this.btnConsumo);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoes.Location = new System.Drawing.Point(0, 0);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(1446, 185);
            this.panelBotoes.TabIndex = 74;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridFornecimento
            // 
            this.dataGridFornecimento.AllowUserToAddRows = false;
            this.dataGridFornecimento.AllowUserToDeleteRows = false;
            this.dataGridFornecimento.AutoGenerateColumns = false;
            this.dataGridFornecimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFornecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codFornecimentoRacaoDataGridViewTextBoxColumn,
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
            this.dataGridFornecimento.DataSource = this.fornecimentoRacaoBindingSource;
            this.dataGridFornecimento.Location = new System.Drawing.Point(404, 591);
            this.dataGridFornecimento.Name = "dataGridFornecimento";
            this.dataGridFornecimento.ReadOnly = true;
            this.dataGridFornecimento.RowHeadersVisible = false;
            this.dataGridFornecimento.RowHeadersWidth = 51;
            this.dataGridFornecimento.RowTemplate.Height = 24;
            this.dataGridFornecimento.Size = new System.Drawing.Size(869, 330);
            this.dataGridFornecimento.TabIndex = 127;
            this.dataGridFornecimento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFornecimento_CellContentClick);
            // 
            // fazendaSuinosDataSet
            // 
            this.fazendaSuinosDataSet.DataSetName = "fazendaSuinosDataSet";
            this.fazendaSuinosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecimentoRacaoBindingSource
            // 
            this.fornecimentoRacaoBindingSource.DataMember = "FornecimentoRacao";
            this.fornecimentoRacaoBindingSource.DataSource = this.fazendaSuinosDataSet;
            // 
            // fornecimentoRacaoTableAdapter
            // 
            this.fornecimentoRacaoTableAdapter.ClearBeforeFill = true;
            // 
            // codFornecimentoRacaoDataGridViewTextBoxColumn
            // 
            this.codFornecimentoRacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codFornecimentoRacaoDataGridViewTextBoxColumn.DataPropertyName = "CodFornecimentoRacao";
            this.codFornecimentoRacaoDataGridViewTextBoxColumn.FillWeight = 75.9632F;
            this.codFornecimentoRacaoDataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.codFornecimentoRacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codFornecimentoRacaoDataGridViewTextBoxColumn.Name = "codFornecimentoRacaoDataGridViewTextBoxColumn";
            this.codFornecimentoRacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFornecimentoRacaoDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataFornDataGridViewTextBoxColumn
            // 
            this.dataFornDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataFornDataGridViewTextBoxColumn.DataPropertyName = "DataForn";
            this.dataFornDataGridViewTextBoxColumn.FillWeight = 90.51307F;
            this.dataFornDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataFornDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataFornDataGridViewTextBoxColumn.Name = "dataFornDataGridViewTextBoxColumn";
            this.dataFornDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.FillWeight = 133.8093F;
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.FillWeight = 63.46687F;
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categ.";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Width = 60;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.FillWeight = 133.8093F;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validadeDataGridViewTextBoxColumn
            // 
            this.validadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.validadeDataGridViewTextBoxColumn.DataPropertyName = "Validade";
            this.validadeDataGridViewTextBoxColumn.FillWeight = 84.6225F;
            this.validadeDataGridViewTextBoxColumn.HeaderText = "Validade";
            this.validadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.validadeDataGridViewTextBoxColumn.Name = "validadeDataGridViewTextBoxColumn";
            this.validadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.FillWeight = 72.85739F;
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quant.";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 60;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.FillWeight = 55.10499F;
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Un.";
            this.unidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn.Width = 50;
            // 
            // codLoteDataGridViewTextBoxColumn
            // 
            this.codLoteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codLoteDataGridViewTextBoxColumn.DataPropertyName = "CodLote";
            this.codLoteDataGridViewTextBoxColumn.FillWeight = 65.50558F;
            this.codLoteDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.codLoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codLoteDataGridViewTextBoxColumn.Name = "codLoteDataGridViewTextBoxColumn";
            this.codLoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLoteDataGridViewTextBoxColumn.Width = 50;
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.FillWeight = 120.196F;
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            this.codProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codProdutoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codFornecedorDataGridViewTextBoxColumn
            // 
            this.codFornecedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codFornecedorDataGridViewTextBoxColumn.DataPropertyName = "CodFornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.FillWeight = 157.2568F;
            this.codFornecedorDataGridViewTextBoxColumn.HeaderText = "Forn.";
            this.codFornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codFornecedorDataGridViewTextBoxColumn.Name = "codFornecedorDataGridViewTextBoxColumn";
            this.codFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFornecedorDataGridViewTextBoxColumn.Width = 60;
            // 
            // btnIncluirForn
            // 
            this.btnIncluirForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnIncluirForn.FlatAppearance.BorderSize = 0;
            this.btnIncluirForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirForn.ForeColor = System.Drawing.Color.White;
            this.btnIncluirForn.Location = new System.Drawing.Point(1132, 484);
            this.btnIncluirForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluirForn.Name = "btnIncluirForn";
            this.btnIncluirForn.Size = new System.Drawing.Size(141, 37);
            this.btnIncluirForn.TabIndex = 128;
            this.btnIncluirForn.Text = "Incluir";
            this.btnIncluirForn.UseVisualStyleBackColor = false;
            // 
            // txtCodFornecimento
            // 
            this.txtCodFornecimento.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodFornecimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodFornecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodFornecimento.Location = new System.Drawing.Point(402, 116);
            this.txtCodFornecimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodFornecimento.Name = "txtCodFornecimento";
            this.txtCodFornecimento.ReadOnly = true;
            this.txtCodFornecimento.Size = new System.Drawing.Size(177, 23);
            this.txtCodFornecimento.TabIndex = 130;
            this.txtCodFornecimento.TextChanged += new System.EventHandler(this.txtCodFornecimento_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label18.Location = new System.Drawing.Point(398, 87);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(226, 25);
            this.label18.TabIndex = 129;
            this.label18.Text = "Código do Fornecimento";
            // 
            // FormConsumo_Racao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1467, 922);
            this.Controls.Add(this.panelConsumo);
            this.Controls.Add(this.panelFornecimento);
            this.Controls.Add(this.panelBotoes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConsumo_Racao";
            this.Text = "FormConsumo_Racao";
            this.Load += new System.EventHandler(this.FormConsumo_Racao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).EndInit();
            this.panelConsumo.ResumeLayout(false);
            this.panelConsumo.PerformLayout();
            this.panelFornecimento.ResumeLayout(false);
            this.panelFornecimento.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoRacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigoLote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaCiclo;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultarCodigoLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConsumo;
        private System.Windows.Forms.Button btnGerar_Grafico;
        private System.Windows.Forms.ComboBox comboLoteGrafico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelConsumo;
        private System.Windows.Forms.Button btnFornecimento;
        private System.Windows.Forms.Button btnConsumo;
        private System.Windows.Forms.Panel panelFornecimento;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFornRacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConsultarLoteForn;
        private System.Windows.Forms.Button btnLimparcampos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGravarForn;
        public System.Windows.Forms.TextBox txtCodLoteForn;
        public System.Windows.Forms.TextBox txtQuantidadeForn;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCodProdForn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUnidadeForn;
        private System.Windows.Forms.Button btnConsultarProdutoForn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtTipoForn;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtCategoriaForn;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtProdutoForn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodFornecedorForn;
        public System.Windows.Forms.DateTimePicker dtpValidadeForn;
        private System.Windows.Forms.Button btnConsultarFornecedorForn;
        private System.Windows.Forms.DataGridView dataGridFornecimento;
        private fazendaSuinosDataSet fazendaSuinosDataSet;
        private System.Windows.Forms.BindingSource fornecimentoRacaoBindingSource;
        private fazendaSuinosDataSetTableAdapters.FornecimentoRacaoTableAdapter fornecimentoRacaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFornecimentoRacaoDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button btnIncluirForn;
        public System.Windows.Forms.TextBox txtCodFornecimento;
        private System.Windows.Forms.Label label18;
    }
}