namespace fazendaSuinos
{
    partial class FormCadastros
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
            this.btnEntidades = new System.Windows.Forms.Button();
            this.panel3Botoes = new System.Windows.Forms.Panel();
            this.btnAcoesCorretivas = new System.Windows.Forms.Button();
            this.btnFazenda = new System.Windows.Forms.Button();
            this.panelFiltroEntidade = new System.Windows.Forms.Panel();
            this.btnFiltro1 = new FontAwesome.Sharp.IconButton();
            this.dataGridEntidade = new System.Windows.Forms.DataGridView();
            this.btnLimparEntidade = new System.Windows.Forms.Button();
            this.btnConsultarEntidade = new System.Windows.Forms.Button();
            this.btnAdicionarFiltroEntidade = new FontAwesome.Sharp.IconButton();
            this.campoFiltroValorEntidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboAtributoEntidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFiltroFazenda = new System.Windows.Forms.Panel();
            this.dataGridFazenda = new System.Windows.Forms.DataGridView();
            this.btnLimparFazenda = new System.Windows.Forms.Button();
            this.btnConsultarFazenda = new System.Windows.Forms.Button();
            this.btnAdicionarFiltroFazenda = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboAtributoFazenda = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.panelFiltroAcoes = new System.Windows.Forms.Panel();
            this.dataGridAcoes = new System.Windows.Forms.DataGridView();
            this.btnLimparAcoes = new System.Windows.Forms.Button();
            this.btnConsultarAcoes = new System.Windows.Forms.Button();
            this.btnAdicionarFiltroAcoes = new FontAwesome.Sharp.IconButton();
            this.campoFiltroValorAcoes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboAtributoAcoes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelCadastroEntidade = new System.Windows.Forms.Panel();
            this.campoCEP = new System.Windows.Forms.TextBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.campoCNPJ = new System.Windows.Forms.TextBox();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.campoRazaoSocial = new System.Windows.Forms.TextBox();
            this.labelRazaoSocial = new System.Windows.Forms.Label();
            this.btnGravarEntidade = new FontAwesome.Sharp.IconButton();
            this.btnIncluirEntidade = new FontAwesome.Sharp.IconButton();
            this.btnLimparCadastro = new System.Windows.Forms.Button();
            this.comboPrivilegios = new System.Windows.Forms.ComboBox();
            this.labelPrivilegios = new System.Windows.Forms.Label();
            this.comboEspecialidade = new System.Windows.Forms.ComboBox();
            this.labelEspecialidade = new System.Windows.Forms.Label();
            this.comboSetor = new System.Windows.Forms.ComboBox();
            this.labelSetor = new System.Windows.Forms.Label();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.campoCPF = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.campoCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.comboTipoEntidade = new System.Windows.Forms.ComboBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelDadosEntidades = new System.Windows.Forms.Label();
            this.btnFiltro3 = new FontAwesome.Sharp.IconButton();
            this.btnFiltro2 = new FontAwesome.Sharp.IconButton();
            this.panel3Botoes.SuspendLayout();
            this.panelFiltroEntidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntidade)).BeginInit();
            this.panelFiltroFazenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFazenda)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.panelFiltroAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcoes)).BeginInit();
            this.panelCadastroEntidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntidades
            // 
            this.btnEntidades.FlatAppearance.BorderSize = 0;
            this.btnEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnEntidades.Location = new System.Drawing.Point(149, 46);
            this.btnEntidades.Name = "btnEntidades";
            this.btnEntidades.Size = new System.Drawing.Size(200, 60);
            this.btnEntidades.TabIndex = 0;
            this.btnEntidades.Text = "Entidades";
            this.btnEntidades.UseVisualStyleBackColor = true;
            this.btnEntidades.Click += new System.EventHandler(this.btnEntidades_Click);
            // 
            // panel3Botoes
            // 
            this.panel3Botoes.Controls.Add(this.btnAcoesCorretivas);
            this.panel3Botoes.Controls.Add(this.btnFazenda);
            this.panel3Botoes.Controls.Add(this.btnEntidades);
            this.panel3Botoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3Botoes.Location = new System.Drawing.Point(0, 0);
            this.panel3Botoes.Name = "panel3Botoes";
            this.panel3Botoes.Size = new System.Drawing.Size(1138, 120);
            this.panel3Botoes.TabIndex = 1;
            // 
            // btnAcoesCorretivas
            // 
            this.btnAcoesCorretivas.FlatAppearance.BorderSize = 0;
            this.btnAcoesCorretivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcoesCorretivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcoesCorretivas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAcoesCorretivas.Location = new System.Drawing.Point(791, 46);
            this.btnAcoesCorretivas.Name = "btnAcoesCorretivas";
            this.btnAcoesCorretivas.Size = new System.Drawing.Size(294, 60);
            this.btnAcoesCorretivas.TabIndex = 2;
            this.btnAcoesCorretivas.Text = "Ações Corretivas";
            this.btnAcoesCorretivas.UseVisualStyleBackColor = true;
            this.btnAcoesCorretivas.Click += new System.EventHandler(this.btnAcoesCorretivas_Click);
            // 
            // btnFazenda
            // 
            this.btnFazenda.FlatAppearance.BorderSize = 0;
            this.btnFazenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnFazenda.Location = new System.Drawing.Point(470, 46);
            this.btnFazenda.Name = "btnFazenda";
            this.btnFazenda.Size = new System.Drawing.Size(200, 60);
            this.btnFazenda.TabIndex = 1;
            this.btnFazenda.Text = "Fazenda";
            this.btnFazenda.UseVisualStyleBackColor = true;
            this.btnFazenda.Click += new System.EventHandler(this.btnFazenda_Click);
            // 
            // panelFiltroEntidade
            // 
            this.panelFiltroEntidade.Controls.Add(this.btnFiltro2);
            this.panelFiltroEntidade.Controls.Add(this.btnFiltro3);
            this.panelFiltroEntidade.Controls.Add(this.btnFiltro1);
            this.panelFiltroEntidade.Controls.Add(this.dataGridEntidade);
            this.panelFiltroEntidade.Controls.Add(this.btnLimparEntidade);
            this.panelFiltroEntidade.Controls.Add(this.btnConsultarEntidade);
            this.panelFiltroEntidade.Controls.Add(this.btnAdicionarFiltroEntidade);
            this.panelFiltroEntidade.Controls.Add(this.campoFiltroValorEntidade);
            this.panelFiltroEntidade.Controls.Add(this.label3);
            this.panelFiltroEntidade.Controls.Add(this.comboAtributoEntidade);
            this.panelFiltroEntidade.Controls.Add(this.label2);
            this.panelFiltroEntidade.Controls.Add(this.label1);
            this.panelFiltroEntidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltroEntidade.Location = new System.Drawing.Point(0, 0);
            this.panelFiltroEntidade.Name = "panelFiltroEntidade";
            this.panelFiltroEntidade.Size = new System.Drawing.Size(1138, 404);
            this.panelFiltroEntidade.TabIndex = 2;
            this.panelFiltroEntidade.Visible = false;
            // 
            // btnFiltro1
            // 
            this.btnFiltro1.AutoSize = true;
            this.btnFiltro1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnFiltro1.FlatAppearance.BorderSize = 0;
            this.btnFiltro1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro1.ForeColor = System.Drawing.Color.White;
            this.btnFiltro1.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.btnFiltro1.IconColor = System.Drawing.Color.White;
            this.btnFiltro1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltro1.IconSize = 25;
            this.btnFiltro1.Location = new System.Drawing.Point(183, 172);
            this.btnFiltro1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltro1.Name = "btnFiltro1";
            this.btnFiltro1.Size = new System.Drawing.Size(131, 31);
            this.btnFiltro1.TabIndex = 9;
            this.btnFiltro1.Text = "Especialidade";
            this.btnFiltro1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltro1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFiltro1.UseVisualStyleBackColor = false;
            this.btnFiltro1.Visible = false;
            this.btnFiltro1.Click += new System.EventHandler(this.btnFiltro1_Click);
            // 
            // dataGridEntidade
            // 
            this.dataGridEntidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntidade.Location = new System.Drawing.Point(172, 234);
            this.dataGridEntidade.Name = "dataGridEntidade";
            this.dataGridEntidade.RowHeadersWidth = 51;
            this.dataGridEntidade.Size = new System.Drawing.Size(685, 150);
            this.dataGridEntidade.TabIndex = 8;
            // 
            // btnLimparEntidade
            // 
            this.btnLimparEntidade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimparEntidade.FlatAppearance.BorderSize = 0;
            this.btnLimparEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparEntidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparEntidade.Location = new System.Drawing.Point(614, 173);
            this.btnLimparEntidade.Name = "btnLimparEntidade";
            this.btnLimparEntidade.Size = new System.Drawing.Size(106, 30);
            this.btnLimparEntidade.TabIndex = 7;
            this.btnLimparEntidade.Text = "Limpar";
            this.btnLimparEntidade.UseVisualStyleBackColor = false;
            // 
            // btnConsultarEntidade
            // 
            this.btnConsultarEntidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarEntidade.FlatAppearance.BorderSize = 0;
            this.btnConsultarEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEntidade.ForeColor = System.Drawing.Color.White;
            this.btnConsultarEntidade.Location = new System.Drawing.Point(751, 173);
            this.btnConsultarEntidade.Name = "btnConsultarEntidade";
            this.btnConsultarEntidade.Size = new System.Drawing.Size(106, 30);
            this.btnConsultarEntidade.TabIndex = 6;
            this.btnConsultarEntidade.Text = "Consultar";
            this.btnConsultarEntidade.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarFiltroEntidade
            // 
            this.btnAdicionarFiltroEntidade.FlatAppearance.BorderSize = 0;
            this.btnAdicionarFiltroEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarFiltroEntidade.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdicionarFiltroEntidade.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAdicionarFiltroEntidade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdicionarFiltroEntidade.IconSize = 35;
            this.btnAdicionarFiltroEntidade.Location = new System.Drawing.Point(826, 115);
            this.btnAdicionarFiltroEntidade.Name = "btnAdicionarFiltroEntidade";
            this.btnAdicionarFiltroEntidade.Size = new System.Drawing.Size(30, 30);
            this.btnAdicionarFiltroEntidade.TabIndex = 5;
            this.btnAdicionarFiltroEntidade.UseVisualStyleBackColor = true;
            this.btnAdicionarFiltroEntidade.Click += new System.EventHandler(this.btnAdicionarFiltroEntidade_Click);
            // 
            // campoFiltroValorEntidade
            // 
            this.campoFiltroValorEntidade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoFiltroValorEntidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoFiltroValorEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFiltroValorEntidade.Location = new System.Drawing.Point(390, 120);
            this.campoFiltroValorEntidade.Name = "campoFiltroValorEntidade";
            this.campoFiltroValorEntidade.Size = new System.Drawing.Size(430, 19);
            this.campoFiltroValorEntidade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(386, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // comboAtributoEntidade
            // 
            this.comboAtributoEntidade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboAtributoEntidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAtributoEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAtributoEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAtributoEntidade.ItemHeight = 18;
            this.comboAtributoEntidade.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "CPF",
            "CNPJ",
            "Telefone",
            "CEP",
            "Setor",
            "Tipo",
            "Especialidade",
            "Privilégios"});
            this.comboAtributoEntidade.Location = new System.Drawing.Point(181, 117);
            this.comboAtributoEntidade.Name = "comboAtributoEntidade";
            this.comboAtributoEntidade.Size = new System.Drawing.Size(168, 26);
            this.comboAtributoEntidade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(177, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Atributo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(168, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Entidades";
            // 
            // panelFiltroFazenda
            // 
            this.panelFiltroFazenda.Controls.Add(this.dataGridFazenda);
            this.panelFiltroFazenda.Controls.Add(this.btnLimparFazenda);
            this.panelFiltroFazenda.Controls.Add(this.btnConsultarFazenda);
            this.panelFiltroFazenda.Controls.Add(this.btnAdicionarFiltroFazenda);
            this.panelFiltroFazenda.Controls.Add(this.textBox1);
            this.panelFiltroFazenda.Controls.Add(this.label4);
            this.panelFiltroFazenda.Controls.Add(this.comboAtributoFazenda);
            this.panelFiltroFazenda.Controls.Add(this.label5);
            this.panelFiltroFazenda.Controls.Add(this.label6);
            this.panelFiltroFazenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltroFazenda.Location = new System.Drawing.Point(0, 808);
            this.panelFiltroFazenda.Name = "panelFiltroFazenda";
            this.panelFiltroFazenda.Size = new System.Drawing.Size(1138, 404);
            this.panelFiltroFazenda.TabIndex = 9;
            this.panelFiltroFazenda.Visible = false;
            // 
            // dataGridFazenda
            // 
            this.dataGridFazenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFazenda.Location = new System.Drawing.Point(172, 234);
            this.dataGridFazenda.Name = "dataGridFazenda";
            this.dataGridFazenda.RowHeadersWidth = 51;
            this.dataGridFazenda.Size = new System.Drawing.Size(685, 150);
            this.dataGridFazenda.TabIndex = 8;
            // 
            // btnLimparFazenda
            // 
            this.btnLimparFazenda.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimparFazenda.FlatAppearance.BorderSize = 0;
            this.btnLimparFazenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFazenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparFazenda.Location = new System.Drawing.Point(614, 173);
            this.btnLimparFazenda.Name = "btnLimparFazenda";
            this.btnLimparFazenda.Size = new System.Drawing.Size(106, 30);
            this.btnLimparFazenda.TabIndex = 7;
            this.btnLimparFazenda.Text = "Limpar";
            this.btnLimparFazenda.UseVisualStyleBackColor = false;
            // 
            // btnConsultarFazenda
            // 
            this.btnConsultarFazenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarFazenda.FlatAppearance.BorderSize = 0;
            this.btnConsultarFazenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFazenda.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFazenda.Location = new System.Drawing.Point(751, 173);
            this.btnConsultarFazenda.Name = "btnConsultarFazenda";
            this.btnConsultarFazenda.Size = new System.Drawing.Size(106, 30);
            this.btnConsultarFazenda.TabIndex = 6;
            this.btnConsultarFazenda.Text = "Consultar";
            this.btnConsultarFazenda.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarFiltroFazenda
            // 
            this.btnAdicionarFiltroFazenda.FlatAppearance.BorderSize = 0;
            this.btnAdicionarFiltroFazenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarFiltroFazenda.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdicionarFiltroFazenda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAdicionarFiltroFazenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdicionarFiltroFazenda.IconSize = 35;
            this.btnAdicionarFiltroFazenda.Location = new System.Drawing.Point(826, 115);
            this.btnAdicionarFiltroFazenda.Name = "btnAdicionarFiltroFazenda";
            this.btnAdicionarFiltroFazenda.Size = new System.Drawing.Size(30, 30);
            this.btnAdicionarFiltroFazenda.TabIndex = 5;
            this.btnAdicionarFiltroFazenda.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(390, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 19);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(386, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // comboAtributoFazenda
            // 
            this.comboAtributoFazenda.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboAtributoFazenda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAtributoFazenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAtributoFazenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAtributoFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAtributoFazenda.FormattingEnabled = true;
            this.comboAtributoFazenda.ItemHeight = 20;
            this.comboAtributoFazenda.Location = new System.Drawing.Point(181, 117);
            this.comboAtributoFazenda.Name = "comboAtributoFazenda";
            this.comboAtributoFazenda.Size = new System.Drawing.Size(168, 26);
            this.comboAtributoFazenda.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(177, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Atributo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(168, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Consulta Fazenda";
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.panelFiltroFazenda);
            this.panelFiltros.Controls.Add(this.panelFiltroAcoes);
            this.panelFiltros.Controls.Add(this.panelFiltroEntidade);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 120);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1138, 404);
            this.panelFiltros.TabIndex = 9;
            // 
            // panelFiltroAcoes
            // 
            this.panelFiltroAcoes.Controls.Add(this.dataGridAcoes);
            this.panelFiltroAcoes.Controls.Add(this.btnLimparAcoes);
            this.panelFiltroAcoes.Controls.Add(this.btnConsultarAcoes);
            this.panelFiltroAcoes.Controls.Add(this.btnAdicionarFiltroAcoes);
            this.panelFiltroAcoes.Controls.Add(this.campoFiltroValorAcoes);
            this.panelFiltroAcoes.Controls.Add(this.label7);
            this.panelFiltroAcoes.Controls.Add(this.comboAtributoAcoes);
            this.panelFiltroAcoes.Controls.Add(this.label8);
            this.panelFiltroAcoes.Controls.Add(this.label9);
            this.panelFiltroAcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltroAcoes.Location = new System.Drawing.Point(0, 404);
            this.panelFiltroAcoes.Name = "panelFiltroAcoes";
            this.panelFiltroAcoes.Size = new System.Drawing.Size(1138, 404);
            this.panelFiltroAcoes.TabIndex = 10;
            this.panelFiltroAcoes.Visible = false;
            // 
            // dataGridAcoes
            // 
            this.dataGridAcoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAcoes.Location = new System.Drawing.Point(172, 234);
            this.dataGridAcoes.Name = "dataGridAcoes";
            this.dataGridAcoes.RowHeadersWidth = 51;
            this.dataGridAcoes.Size = new System.Drawing.Size(685, 150);
            this.dataGridAcoes.TabIndex = 8;
            // 
            // btnLimparAcoes
            // 
            this.btnLimparAcoes.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimparAcoes.FlatAppearance.BorderSize = 0;
            this.btnLimparAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAcoes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparAcoes.Location = new System.Drawing.Point(614, 173);
            this.btnLimparAcoes.Name = "btnLimparAcoes";
            this.btnLimparAcoes.Size = new System.Drawing.Size(106, 30);
            this.btnLimparAcoes.TabIndex = 7;
            this.btnLimparAcoes.Text = "Limpar";
            this.btnLimparAcoes.UseVisualStyleBackColor = false;
            // 
            // btnConsultarAcoes
            // 
            this.btnConsultarAcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarAcoes.FlatAppearance.BorderSize = 0;
            this.btnConsultarAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAcoes.ForeColor = System.Drawing.Color.White;
            this.btnConsultarAcoes.Location = new System.Drawing.Point(751, 173);
            this.btnConsultarAcoes.Name = "btnConsultarAcoes";
            this.btnConsultarAcoes.Size = new System.Drawing.Size(106, 30);
            this.btnConsultarAcoes.TabIndex = 6;
            this.btnConsultarAcoes.Text = "Consultar";
            this.btnConsultarAcoes.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarFiltroAcoes
            // 
            this.btnAdicionarFiltroAcoes.FlatAppearance.BorderSize = 0;
            this.btnAdicionarFiltroAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarFiltroAcoes.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdicionarFiltroAcoes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAdicionarFiltroAcoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdicionarFiltroAcoes.IconSize = 35;
            this.btnAdicionarFiltroAcoes.Location = new System.Drawing.Point(826, 115);
            this.btnAdicionarFiltroAcoes.Name = "btnAdicionarFiltroAcoes";
            this.btnAdicionarFiltroAcoes.Size = new System.Drawing.Size(30, 30);
            this.btnAdicionarFiltroAcoes.TabIndex = 5;
            this.btnAdicionarFiltroAcoes.UseVisualStyleBackColor = true;
            // 
            // campoFiltroValorAcoes
            // 
            this.campoFiltroValorAcoes.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoFiltroValorAcoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoFiltroValorAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFiltroValorAcoes.Location = new System.Drawing.Point(390, 120);
            this.campoFiltroValorAcoes.Name = "campoFiltroValorAcoes";
            this.campoFiltroValorAcoes.Size = new System.Drawing.Size(430, 19);
            this.campoFiltroValorAcoes.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(386, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Valor";
            // 
            // comboAtributoAcoes
            // 
            this.comboAtributoAcoes.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboAtributoAcoes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAtributoAcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAtributoAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAtributoAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAtributoAcoes.FormattingEnabled = true;
            this.comboAtributoAcoes.ItemHeight = 20;
            this.comboAtributoAcoes.Location = new System.Drawing.Point(181, 117);
            this.comboAtributoAcoes.Name = "comboAtributoAcoes";
            this.comboAtributoAcoes.Size = new System.Drawing.Size(168, 26);
            this.comboAtributoAcoes.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(177, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Atributo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label9.Location = new System.Drawing.Point(168, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Consulta Acoes";
            // 
            // panelCadastroEntidade
            // 
            this.panelCadastroEntidade.Controls.Add(this.campoCEP);
            this.panelCadastroEntidade.Controls.Add(this.labelCEP);
            this.panelCadastroEntidade.Controls.Add(this.campoCNPJ);
            this.panelCadastroEntidade.Controls.Add(this.labelCNPJ);
            this.panelCadastroEntidade.Controls.Add(this.campoRazaoSocial);
            this.panelCadastroEntidade.Controls.Add(this.labelRazaoSocial);
            this.panelCadastroEntidade.Controls.Add(this.btnGravarEntidade);
            this.panelCadastroEntidade.Controls.Add(this.btnIncluirEntidade);
            this.panelCadastroEntidade.Controls.Add(this.btnLimparCadastro);
            this.panelCadastroEntidade.Controls.Add(this.comboPrivilegios);
            this.panelCadastroEntidade.Controls.Add(this.labelPrivilegios);
            this.panelCadastroEntidade.Controls.Add(this.comboEspecialidade);
            this.panelCadastroEntidade.Controls.Add(this.labelEspecialidade);
            this.panelCadastroEntidade.Controls.Add(this.comboSetor);
            this.panelCadastroEntidade.Controls.Add(this.labelSetor);
            this.panelCadastroEntidade.Controls.Add(this.campoTelefone);
            this.panelCadastroEntidade.Controls.Add(this.labelTelefone);
            this.panelCadastroEntidade.Controls.Add(this.campoCPF);
            this.panelCadastroEntidade.Controls.Add(this.labelCPF);
            this.panelCadastroEntidade.Controls.Add(this.campoNome);
            this.panelCadastroEntidade.Controls.Add(this.labelNome);
            this.panelCadastroEntidade.Controls.Add(this.campoCodigo);
            this.panelCadastroEntidade.Controls.Add(this.labelCodigo);
            this.panelCadastroEntidade.Controls.Add(this.comboTipoEntidade);
            this.panelCadastroEntidade.Controls.Add(this.labelTipo);
            this.panelCadastroEntidade.Controls.Add(this.labelDadosEntidades);
            this.panelCadastroEntidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastroEntidade.Location = new System.Drawing.Point(0, 524);
            this.panelCadastroEntidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCadastroEntidade.Name = "panelCadastroEntidade";
            this.panelCadastroEntidade.Size = new System.Drawing.Size(1138, 488);
            this.panelCadastroEntidade.TabIndex = 10;
            this.panelCadastroEntidade.Visible = false;
            // 
            // campoCEP
            // 
            this.campoCEP.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCEP.Location = new System.Drawing.Point(182, 276);
            this.campoCEP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.campoCEP.Name = "campoCEP";
            this.campoCEP.Size = new System.Drawing.Size(134, 19);
            this.campoCEP.TabIndex = 31;
            this.campoCEP.Visible = false;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelCEP.Location = new System.Drawing.Point(177, 251);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(41, 20);
            this.labelCEP.TabIndex = 30;
            this.labelCEP.Text = "CEP";
            this.labelCEP.Visible = false;
            // 
            // campoCNPJ
            // 
            this.campoCNPJ.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCNPJ.Location = new System.Drawing.Point(543, 198);
            this.campoCNPJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.campoCNPJ.Name = "campoCNPJ";
            this.campoCNPJ.Size = new System.Drawing.Size(134, 19);
            this.campoCNPJ.TabIndex = 27;
            this.campoCNPJ.Visible = false;
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelCNPJ.Location = new System.Drawing.Point(539, 173);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(49, 20);
            this.labelCNPJ.TabIndex = 26;
            this.labelCNPJ.Text = "CNPJ";
            this.labelCNPJ.Visible = false;
            // 
            // campoRazaoSocial
            // 
            this.campoRazaoSocial.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoRazaoSocial.Location = new System.Drawing.Point(182, 198);
            this.campoRazaoSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.campoRazaoSocial.Name = "campoRazaoSocial";
            this.campoRazaoSocial.Size = new System.Drawing.Size(320, 19);
            this.campoRazaoSocial.TabIndex = 25;
            this.campoRazaoSocial.Visible = false;
            // 
            // labelRazaoSocial
            // 
            this.labelRazaoSocial.AutoSize = true;
            this.labelRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelRazaoSocial.Location = new System.Drawing.Point(179, 173);
            this.labelRazaoSocial.Name = "labelRazaoSocial";
            this.labelRazaoSocial.Size = new System.Drawing.Size(103, 20);
            this.labelRazaoSocial.TabIndex = 24;
            this.labelRazaoSocial.Text = "Razão Social";
            this.labelRazaoSocial.Visible = false;
            // 
            // btnGravarEntidade
            // 
            this.btnGravarEntidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnGravarEntidade.FlatAppearance.BorderSize = 0;
            this.btnGravarEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarEntidade.ForeColor = System.Drawing.Color.White;
            this.btnGravarEntidade.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnGravarEntidade.IconColor = System.Drawing.Color.White;
            this.btnGravarEntidade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGravarEntidade.IconSize = 25;
            this.btnGravarEntidade.Location = new System.Drawing.Point(613, 354);
            this.btnGravarEntidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGravarEntidade.Name = "btnGravarEntidade";
            this.btnGravarEntidade.Size = new System.Drawing.Size(106, 30);
            this.btnGravarEntidade.TabIndex = 23;
            this.btnGravarEntidade.Text = "Gravar";
            this.btnGravarEntidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarEntidade.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGravarEntidade.UseVisualStyleBackColor = false;
            // 
            // btnIncluirEntidade
            // 
            this.btnIncluirEntidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnIncluirEntidade.FlatAppearance.BorderSize = 0;
            this.btnIncluirEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirEntidade.ForeColor = System.Drawing.Color.White;
            this.btnIncluirEntidade.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnIncluirEntidade.IconColor = System.Drawing.Color.White;
            this.btnIncluirEntidade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIncluirEntidade.IconSize = 25;
            this.btnIncluirEntidade.Location = new System.Drawing.Point(751, 354);
            this.btnIncluirEntidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIncluirEntidade.Name = "btnIncluirEntidade";
            this.btnIncluirEntidade.Size = new System.Drawing.Size(106, 30);
            this.btnIncluirEntidade.TabIndex = 22;
            this.btnIncluirEntidade.Text = "Incluir";
            this.btnIncluirEntidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirEntidade.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIncluirEntidade.UseVisualStyleBackColor = false;
            // 
            // btnLimparCadastro
            // 
            this.btnLimparCadastro.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimparCadastro.FlatAppearance.BorderSize = 0;
            this.btnLimparCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparCadastro.Location = new System.Drawing.Point(470, 354);
            this.btnLimparCadastro.Name = "btnLimparCadastro";
            this.btnLimparCadastro.Size = new System.Drawing.Size(106, 30);
            this.btnLimparCadastro.TabIndex = 20;
            this.btnLimparCadastro.Text = "Limpar";
            this.btnLimparCadastro.UseVisualStyleBackColor = false;
            this.btnLimparCadastro.Click += new System.EventHandler(this.btnLimparCadastro_Click);
            // 
            // comboPrivilegios
            // 
            this.comboPrivilegios.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboPrivilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrivilegios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPrivilegios.FormattingEnabled = true;
            this.comboPrivilegios.ItemHeight = 18;
            this.comboPrivilegios.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário",
            "Usuário"});
            this.comboPrivilegios.Location = new System.Drawing.Point(723, 274);
            this.comboPrivilegios.Name = "comboPrivilegios";
            this.comboPrivilegios.Size = new System.Drawing.Size(134, 26);
            this.comboPrivilegios.TabIndex = 18;
            this.comboPrivilegios.Visible = false;
            // 
            // labelPrivilegios
            // 
            this.labelPrivilegios.AutoSize = true;
            this.labelPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrivilegios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelPrivilegios.Location = new System.Drawing.Point(719, 251);
            this.labelPrivilegios.Name = "labelPrivilegios";
            this.labelPrivilegios.Size = new System.Drawing.Size(78, 20);
            this.labelPrivilegios.TabIndex = 17;
            this.labelPrivilegios.Text = "Privilégios";
            this.labelPrivilegios.Visible = false;
            // 
            // comboEspecialidade
            // 
            this.comboEspecialidade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEspecialidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEspecialidade.FormattingEnabled = true;
            this.comboEspecialidade.ItemHeight = 18;
            this.comboEspecialidade.Items.AddRange(new object[] {
            "Operacional",
            "Infraestrutura",
            "Tecnologia da Informação",
            "Alimentação",
            "Vacinação e infecções"});
            this.comboEspecialidade.Location = new System.Drawing.Point(390, 274);
            this.comboEspecialidade.Name = "comboEspecialidade";
            this.comboEspecialidade.Size = new System.Drawing.Size(286, 26);
            this.comboEspecialidade.TabIndex = 16;
            this.comboEspecialidade.Visible = false;
            // 
            // labelEspecialidade
            // 
            this.labelEspecialidade.AutoSize = true;
            this.labelEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecialidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelEspecialidade.Location = new System.Drawing.Point(386, 251);
            this.labelEspecialidade.Name = "labelEspecialidade";
            this.labelEspecialidade.Size = new System.Drawing.Size(108, 20);
            this.labelEspecialidade.TabIndex = 15;
            this.labelEspecialidade.Text = "Especialidade";
            this.labelEspecialidade.Visible = false;
            // 
            // comboSetor
            // 
            this.comboSetor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSetor.FormattingEnabled = true;
            this.comboSetor.ItemHeight = 18;
            this.comboSetor.Items.AddRange(new object[] {
            "Administrativo",
            "Saúde",
            "Financeiro",
            "RH",
            "Marketing"});
            this.comboSetor.Location = new System.Drawing.Point(180, 274);
            this.comboSetor.Name = "comboSetor";
            this.comboSetor.Size = new System.Drawing.Size(168, 26);
            this.comboSetor.TabIndex = 14;
            this.comboSetor.Visible = false;
            // 
            // labelSetor
            // 
            this.labelSetor.AutoSize = true;
            this.labelSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelSetor.Location = new System.Drawing.Point(176, 251);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(48, 20);
            this.labelSetor.TabIndex = 13;
            this.labelSetor.Text = "Setor";
            this.labelSetor.Visible = false;
            // 
            // campoTelefone
            // 
            this.campoTelefone.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTelefone.Location = new System.Drawing.Point(724, 198);
            this.campoTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(134, 19);
            this.campoTelefone.TabIndex = 12;
            this.campoTelefone.Visible = false;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelTelefone.Location = new System.Drawing.Point(721, 173);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(71, 20);
            this.labelTelefone.TabIndex = 11;
            this.labelTelefone.Text = "Telefone";
            this.labelTelefone.Visible = false;
            // 
            // campoCPF
            // 
            this.campoCPF.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCPF.Location = new System.Drawing.Point(543, 198);
            this.campoCPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.campoCPF.Name = "campoCPF";
            this.campoCPF.Size = new System.Drawing.Size(134, 19);
            this.campoCPF.TabIndex = 10;
            this.campoCPF.Visible = false;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelCPF.Location = new System.Drawing.Point(539, 173);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(40, 20);
            this.labelCPF.TabIndex = 9;
            this.labelCPF.Text = "CPF";
            this.labelCPF.Visible = false;
            // 
            // campoNome
            // 
            this.campoNome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(182, 198);
            this.campoNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(320, 19);
            this.campoNome.TabIndex = 8;
            this.campoNome.Visible = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelNome.Location = new System.Drawing.Point(179, 173);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(51, 20);
            this.labelNome.TabIndex = 7;
            this.labelNome.Text = "Nome";
            this.labelNome.Visible = false;
            // 
            // campoCodigo
            // 
            this.campoCodigo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoCodigo.Enabled = false;
            this.campoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCodigo.Location = new System.Drawing.Point(390, 117);
            this.campoCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.Size = new System.Drawing.Size(110, 19);
            this.campoCodigo.TabIndex = 6;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelCodigo.Location = new System.Drawing.Point(387, 93);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(59, 20);
            this.labelCodigo.TabIndex = 5;
            this.labelCodigo.Text = "Código";
            // 
            // comboTipoEntidade
            // 
            this.comboTipoEntidade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboTipoEntidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTipoEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoEntidade.FormattingEnabled = true;
            this.comboTipoEntidade.ItemHeight = 18;
            this.comboTipoEntidade.Items.AddRange(new object[] {
            "Administrador",
            "Fornecedor",
            "Gerente",
            "Produtor",
            "Técnico",
            "Visita"});
            this.comboTipoEntidade.Location = new System.Drawing.Point(181, 117);
            this.comboTipoEntidade.Name = "comboTipoEntidade";
            this.comboTipoEntidade.Size = new System.Drawing.Size(168, 26);
            this.comboTipoEntidade.TabIndex = 4;
            this.comboTipoEntidade.SelectedIndexChanged += new System.EventHandler(this.comboTipoEntidade_SelectedIndexChanged);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelTipo.Location = new System.Drawing.Point(177, 94);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(39, 20);
            this.labelTipo.TabIndex = 3;
            this.labelTipo.Text = "Tipo";
            // 
            // labelDadosEntidades
            // 
            this.labelDadosEntidades.AutoSize = true;
            this.labelDadosEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosEntidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelDadosEntidades.Location = new System.Drawing.Point(168, 47);
            this.labelDadosEntidades.Name = "labelDadosEntidades";
            this.labelDadosEntidades.Size = new System.Drawing.Size(153, 24);
            this.labelDadosEntidades.TabIndex = 1;
            this.labelDadosEntidades.Text = "Dados Entidades";
            // 
            // btnFiltro3
            // 
            this.btnFiltro3.AutoSize = true;
            this.btnFiltro3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnFiltro3.FlatAppearance.BorderSize = 0;
            this.btnFiltro3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro3.ForeColor = System.Drawing.Color.White;
            this.btnFiltro3.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.btnFiltro3.IconColor = System.Drawing.Color.White;
            this.btnFiltro3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltro3.IconSize = 25;
            this.btnFiltro3.Location = new System.Drawing.Point(469, 172);
            this.btnFiltro3.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltro3.Name = "btnFiltro3";
            this.btnFiltro3.Size = new System.Drawing.Size(131, 31);
            this.btnFiltro3.TabIndex = 10;
            this.btnFiltro3.Text = "Especialidade";
            this.btnFiltro3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltro3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFiltro3.UseVisualStyleBackColor = false;
            this.btnFiltro3.Visible = false;
            this.btnFiltro3.Click += new System.EventHandler(this.btnFiltro3_Click);
            // 
            // btnFiltro2
            // 
            this.btnFiltro2.AutoSize = true;
            this.btnFiltro2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnFiltro2.FlatAppearance.BorderSize = 0;
            this.btnFiltro2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro2.ForeColor = System.Drawing.Color.White;
            this.btnFiltro2.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.btnFiltro2.IconColor = System.Drawing.Color.White;
            this.btnFiltro2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltro2.IconSize = 25;
            this.btnFiltro2.Location = new System.Drawing.Point(326, 172);
            this.btnFiltro2.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltro2.Name = "btnFiltro2";
            this.btnFiltro2.Size = new System.Drawing.Size(131, 31);
            this.btnFiltro2.TabIndex = 10;
            this.btnFiltro2.Text = "Especialidade";
            this.btnFiltro2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltro2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFiltro2.UseVisualStyleBackColor = false;
            this.btnFiltro2.Visible = false;
            this.btnFiltro2.Click += new System.EventHandler(this.btnFiltro2_Click);
            // 
            // FormCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.panelCadastroEntidade);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panel3Botoes);
            this.Name = "FormCadastros";
            this.Text = "Cadastros";
            this.panel3Botoes.ResumeLayout(false);
            this.panelFiltroEntidade.ResumeLayout(false);
            this.panelFiltroEntidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntidade)).EndInit();
            this.panelFiltroFazenda.ResumeLayout(false);
            this.panelFiltroFazenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFazenda)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltroAcoes.ResumeLayout(false);
            this.panelFiltroAcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcoes)).EndInit();
            this.panelCadastroEntidade.ResumeLayout(false);
            this.panelCadastroEntidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntidades;
        private System.Windows.Forms.Panel panel3Botoes;
        private System.Windows.Forms.Button btnAcoesCorretivas;
        private System.Windows.Forms.Button btnFazenda;
        private System.Windows.Forms.Panel panelFiltroEntidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboAtributoEntidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoFiltroValorEntidade;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAdicionarFiltroEntidade;
        private System.Windows.Forms.Button btnLimparEntidade;
        private System.Windows.Forms.Button btnConsultarEntidade;
        private System.Windows.Forms.DataGridView dataGridEntidade;
        private System.Windows.Forms.Panel panelFiltroFazenda;
        private System.Windows.Forms.DataGridView dataGridFazenda;
        private System.Windows.Forms.Button btnLimparFazenda;
        private System.Windows.Forms.Button btnConsultarFazenda;
        private FontAwesome.Sharp.IconButton btnAdicionarFiltroFazenda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboAtributoFazenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Panel panelFiltroAcoes;
        private System.Windows.Forms.DataGridView dataGridAcoes;
        private System.Windows.Forms.Button btnLimparAcoes;
        private FontAwesome.Sharp.IconButton btnAdicionarFiltroAcoes;
        private System.Windows.Forms.TextBox campoFiltroValorAcoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboAtributoAcoes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelCadastroEntidade;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.ComboBox comboTipoEntidade;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelDadosEntidades;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox campoCPF;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox campoCodigo;
        private System.Windows.Forms.ComboBox comboPrivilegios;
        private System.Windows.Forms.Label labelPrivilegios;
        private FontAwesome.Sharp.IconButton btnIncluirEntidade;
        private System.Windows.Forms.Button btnLimparCadastro;
        private System.Windows.Forms.Button btnConsultarAcoes;
        private FontAwesome.Sharp.IconButton btnGravarEntidade;
        private System.Windows.Forms.TextBox campoCNPJ;
        private System.Windows.Forms.Label labelCNPJ;
        private System.Windows.Forms.TextBox campoRazaoSocial;
        private System.Windows.Forms.Label labelRazaoSocial;
        private System.Windows.Forms.TextBox campoCEP;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.ComboBox comboEspecialidade;
        private System.Windows.Forms.Label labelEspecialidade;
        private System.Windows.Forms.ComboBox comboSetor;
        private System.Windows.Forms.Label labelSetor;
        private System.Windows.Forms.Label labelCPF;
        private FontAwesome.Sharp.IconButton btnFiltro1;
        private FontAwesome.Sharp.IconButton btnFiltro2;
        private FontAwesome.Sharp.IconButton btnFiltro3;
    }
}