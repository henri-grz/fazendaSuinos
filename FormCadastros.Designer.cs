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
            this.btnAdicionarFiltroAcoes = new FontAwesome.Sharp.IconButton();
            this.campoFiltroValorAcoes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboAtributoAcoes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelCadastroEntidade = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.campoCodigo = new System.Windows.Forms.TextBox();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.campoCPF = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboSetor = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboEspecialidade = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboPrivilegios = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIncluirEntidade = new FontAwesome.Sharp.IconButton();
            this.btnGravarEntidade = new FontAwesome.Sharp.IconButton();
            this.btnConsultarAcoes = new System.Windows.Forms.Button();
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
            this.btnEntidades.Location = new System.Drawing.Point(199, 57);
            this.btnEntidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntidades.Name = "btnEntidades";
            this.btnEntidades.Size = new System.Drawing.Size(267, 74);
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
            this.panel3Botoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3Botoes.Name = "panel3Botoes";
            this.panel3Botoes.Size = new System.Drawing.Size(1467, 148);
            this.panel3Botoes.TabIndex = 1;
            // 
            // btnAcoesCorretivas
            // 
            this.btnAcoesCorretivas.FlatAppearance.BorderSize = 0;
            this.btnAcoesCorretivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcoesCorretivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcoesCorretivas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAcoesCorretivas.Location = new System.Drawing.Point(1055, 57);
            this.btnAcoesCorretivas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcoesCorretivas.Name = "btnAcoesCorretivas";
            this.btnAcoesCorretivas.Size = new System.Drawing.Size(392, 74);
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
            this.btnFazenda.Location = new System.Drawing.Point(627, 57);
            this.btnFazenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFazenda.Name = "btnFazenda";
            this.btnFazenda.Size = new System.Drawing.Size(267, 74);
            this.btnFazenda.TabIndex = 1;
            this.btnFazenda.Text = "Fazenda";
            this.btnFazenda.UseVisualStyleBackColor = true;
            this.btnFazenda.Click += new System.EventHandler(this.btnFazenda_Click);
            // 
            // panelFiltroEntidade
            // 
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
            this.panelFiltroEntidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFiltroEntidade.Name = "panelFiltroEntidade";
            this.panelFiltroEntidade.Size = new System.Drawing.Size(1467, 497);
            this.panelFiltroEntidade.TabIndex = 2;
            this.panelFiltroEntidade.Visible = false;
            // 
            // dataGridEntidade
            // 
            this.dataGridEntidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntidade.Location = new System.Drawing.Point(229, 288);
            this.dataGridEntidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridEntidade.Name = "dataGridEntidade";
            this.dataGridEntidade.Size = new System.Drawing.Size(913, 185);
            this.dataGridEntidade.TabIndex = 8;
            // 
            // btnLimparEntidade
            // 
            this.btnLimparEntidade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimparEntidade.FlatAppearance.BorderSize = 0;
            this.btnLimparEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparEntidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparEntidade.Location = new System.Drawing.Point(819, 213);
            this.btnLimparEntidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparEntidade.Name = "btnLimparEntidade";
            this.btnLimparEntidade.Size = new System.Drawing.Size(141, 37);
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
            this.btnConsultarEntidade.Location = new System.Drawing.Point(1001, 213);
            this.btnConsultarEntidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultarEntidade.Name = "btnConsultarEntidade";
            this.btnConsultarEntidade.Size = new System.Drawing.Size(141, 37);
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
            this.btnAdicionarFiltroEntidade.Location = new System.Drawing.Point(1102, 141);
            this.btnAdicionarFiltroEntidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionarFiltroEntidade.Name = "btnAdicionarFiltroEntidade";
            this.btnAdicionarFiltroEntidade.Size = new System.Drawing.Size(40, 37);
            this.btnAdicionarFiltroEntidade.TabIndex = 5;
            this.btnAdicionarFiltroEntidade.UseVisualStyleBackColor = true;
            // 
            // campoFiltroValorEntidade
            // 
            this.campoFiltroValorEntidade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoFiltroValorEntidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoFiltroValorEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFiltroValorEntidade.Location = new System.Drawing.Point(520, 148);
            this.campoFiltroValorEntidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoFiltroValorEntidade.Name = "campoFiltroValorEntidade";
            this.campoFiltroValorEntidade.Size = new System.Drawing.Size(573, 19);
            this.campoFiltroValorEntidade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(514, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // comboAtributoEntidade
            // 
            this.comboAtributoEntidade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboAtributoEntidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAtributoEntidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAtributoEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAtributoEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAtributoEntidade.FormattingEnabled = true;
            this.comboAtributoEntidade.ItemHeight = 20;
            this.comboAtributoEntidade.Location = new System.Drawing.Point(241, 144);
            this.comboAtributoEntidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAtributoEntidade.Name = "comboAtributoEntidade";
            this.comboAtributoEntidade.Size = new System.Drawing.Size(223, 26);
            this.comboAtributoEntidade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(236, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label1.Location = new System.Drawing.Point(224, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.panelFiltroFazenda.Location = new System.Drawing.Point(0, 994);
            this.panelFiltroFazenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFiltroFazenda.Name = "panelFiltroFazenda";
            this.panelFiltroFazenda.Size = new System.Drawing.Size(1467, 497);
            this.panelFiltroFazenda.TabIndex = 9;
            this.panelFiltroFazenda.Visible = false;
            // 
            // dataGridFazenda
            // 
            this.dataGridFazenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFazenda.Location = new System.Drawing.Point(229, 288);
            this.dataGridFazenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridFazenda.Name = "dataGridFazenda";
            this.dataGridFazenda.Size = new System.Drawing.Size(913, 185);
            this.dataGridFazenda.TabIndex = 8;
            // 
            // btnLimparFazenda
            // 
            this.btnLimparFazenda.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimparFazenda.FlatAppearance.BorderSize = 0;
            this.btnLimparFazenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFazenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparFazenda.Location = new System.Drawing.Point(819, 213);
            this.btnLimparFazenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparFazenda.Name = "btnLimparFazenda";
            this.btnLimparFazenda.Size = new System.Drawing.Size(141, 37);
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
            this.btnConsultarFazenda.Location = new System.Drawing.Point(1001, 213);
            this.btnConsultarFazenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultarFazenda.Name = "btnConsultarFazenda";
            this.btnConsultarFazenda.Size = new System.Drawing.Size(141, 37);
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
            this.btnAdicionarFiltroFazenda.Location = new System.Drawing.Point(1102, 141);
            this.btnAdicionarFiltroFazenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionarFiltroFazenda.Name = "btnAdicionarFiltroFazenda";
            this.btnAdicionarFiltroFazenda.Size = new System.Drawing.Size(40, 37);
            this.btnAdicionarFiltroFazenda.TabIndex = 5;
            this.btnAdicionarFiltroFazenda.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(520, 148);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 19);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(514, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.comboAtributoFazenda.Location = new System.Drawing.Point(241, 144);
            this.comboAtributoFazenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAtributoFazenda.Name = "comboAtributoFazenda";
            this.comboAtributoFazenda.Size = new System.Drawing.Size(223, 26);
            this.comboAtributoFazenda.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(236, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label6.Location = new System.Drawing.Point(224, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.panelFiltros.Location = new System.Drawing.Point(0, 148);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1467, 497);
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
            this.panelFiltroAcoes.Location = new System.Drawing.Point(0, 497);
            this.panelFiltroAcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFiltroAcoes.Name = "panelFiltroAcoes";
            this.panelFiltroAcoes.Size = new System.Drawing.Size(1467, 497);
            this.panelFiltroAcoes.TabIndex = 10;
            this.panelFiltroAcoes.Visible = false;
            // 
            // dataGridAcoes
            // 
            this.dataGridAcoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAcoes.Location = new System.Drawing.Point(229, 288);
            this.dataGridAcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridAcoes.Name = "dataGridAcoes";
            this.dataGridAcoes.Size = new System.Drawing.Size(913, 185);
            this.dataGridAcoes.TabIndex = 8;
            // 
            // btnLimparAcoes
            // 
            this.btnLimparAcoes.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimparAcoes.FlatAppearance.BorderSize = 0;
            this.btnLimparAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAcoes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparAcoes.Location = new System.Drawing.Point(819, 213);
            this.btnLimparAcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparAcoes.Name = "btnLimparAcoes";
            this.btnLimparAcoes.Size = new System.Drawing.Size(141, 37);
            this.btnLimparAcoes.TabIndex = 7;
            this.btnLimparAcoes.Text = "Limpar";
            this.btnLimparAcoes.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarFiltroAcoes
            // 
            this.btnAdicionarFiltroAcoes.FlatAppearance.BorderSize = 0;
            this.btnAdicionarFiltroAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarFiltroAcoes.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdicionarFiltroAcoes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAdicionarFiltroAcoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdicionarFiltroAcoes.IconSize = 35;
            this.btnAdicionarFiltroAcoes.Location = new System.Drawing.Point(1102, 141);
            this.btnAdicionarFiltroAcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionarFiltroAcoes.Name = "btnAdicionarFiltroAcoes";
            this.btnAdicionarFiltroAcoes.Size = new System.Drawing.Size(40, 37);
            this.btnAdicionarFiltroAcoes.TabIndex = 5;
            this.btnAdicionarFiltroAcoes.UseVisualStyleBackColor = true;
            // 
            // campoFiltroValorAcoes
            // 
            this.campoFiltroValorAcoes.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoFiltroValorAcoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoFiltroValorAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFiltroValorAcoes.Location = new System.Drawing.Point(520, 148);
            this.campoFiltroValorAcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoFiltroValorAcoes.Name = "campoFiltroValorAcoes";
            this.campoFiltroValorAcoes.Size = new System.Drawing.Size(573, 19);
            this.campoFiltroValorAcoes.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(514, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.comboAtributoAcoes.Location = new System.Drawing.Point(241, 144);
            this.comboAtributoAcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAtributoAcoes.Name = "comboAtributoAcoes";
            this.comboAtributoAcoes.Size = new System.Drawing.Size(223, 26);
            this.comboAtributoAcoes.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(236, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label9.Location = new System.Drawing.Point(224, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Consulta Acoes";
            // 
            // panelCadastroEntidade
            // 
            this.panelCadastroEntidade.Controls.Add(this.btnGravarEntidade);
            this.panelCadastroEntidade.Controls.Add(this.btnIncluirEntidade);
            this.panelCadastroEntidade.Controls.Add(this.button1);
            this.panelCadastroEntidade.Controls.Add(this.comboPrivilegios);
            this.panelCadastroEntidade.Controls.Add(this.label18);
            this.panelCadastroEntidade.Controls.Add(this.comboEspecialidade);
            this.panelCadastroEntidade.Controls.Add(this.label17);
            this.panelCadastroEntidade.Controls.Add(this.comboSetor);
            this.panelCadastroEntidade.Controls.Add(this.label16);
            this.panelCadastroEntidade.Controls.Add(this.campoTelefone);
            this.panelCadastroEntidade.Controls.Add(this.label15);
            this.panelCadastroEntidade.Controls.Add(this.campoCPF);
            this.panelCadastroEntidade.Controls.Add(this.label14);
            this.panelCadastroEntidade.Controls.Add(this.campoNome);
            this.panelCadastroEntidade.Controls.Add(this.label13);
            this.panelCadastroEntidade.Controls.Add(this.campoCodigo);
            this.panelCadastroEntidade.Controls.Add(this.label12);
            this.panelCadastroEntidade.Controls.Add(this.comboBox1);
            this.panelCadastroEntidade.Controls.Add(this.label11);
            this.panelCadastroEntidade.Controls.Add(this.label10);
            this.panelCadastroEntidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastroEntidade.Location = new System.Drawing.Point(0, 645);
            this.panelCadastroEntidade.Name = "panelCadastroEntidade";
            this.panelCadastroEntidade.Size = new System.Drawing.Size(1467, 600);
            this.panelCadastroEntidade.TabIndex = 10;
            this.panelCadastroEntidade.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(224, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Dados Entidades";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Location = new System.Drawing.Point(241, 144);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label11.Location = new System.Drawing.Point(236, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tipo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label12.Location = new System.Drawing.Point(516, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Código";
            // 
            // campoCodigo
            // 
            this.campoCodigo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoCodigo.Enabled = false;
            this.campoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCodigo.Location = new System.Drawing.Point(520, 144);
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.Size = new System.Drawing.Size(147, 19);
            this.campoCodigo.TabIndex = 6;
            // 
            // campoNome
            // 
            this.campoNome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(241, 230);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(426, 19);
            this.campoNome.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label13.Location = new System.Drawing.Point(237, 200);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Nome";
            // 
            // campoCPF
            // 
            this.campoCPF.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCPF.Location = new System.Drawing.Point(722, 230);
            this.campoCPF.Name = "campoCPF";
            this.campoCPF.Size = new System.Drawing.Size(178, 19);
            this.campoCPF.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label14.Location = new System.Drawing.Point(718, 200);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "CPF";
            // 
            // campoTelefone
            // 
            this.campoTelefone.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTelefone.Location = new System.Drawing.Point(964, 230);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(178, 19);
            this.campoTelefone.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label15.Location = new System.Drawing.Point(960, 200);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Telefone";
            // 
            // comboSetor
            // 
            this.comboSetor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboSetor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSetor.FormattingEnabled = true;
            this.comboSetor.ItemHeight = 20;
            this.comboSetor.Location = new System.Drawing.Point(240, 337);
            this.comboSetor.Margin = new System.Windows.Forms.Padding(4);
            this.comboSetor.Name = "comboSetor";
            this.comboSetor.Size = new System.Drawing.Size(223, 26);
            this.comboSetor.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label16.Location = new System.Drawing.Point(235, 309);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "Setor";
            // 
            // comboEspecialidade
            // 
            this.comboEspecialidade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboEspecialidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEspecialidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEspecialidade.FormattingEnabled = true;
            this.comboEspecialidade.ItemHeight = 20;
            this.comboEspecialidade.Location = new System.Drawing.Point(520, 337);
            this.comboEspecialidade.Margin = new System.Windows.Forms.Padding(4);
            this.comboEspecialidade.Name = "comboEspecialidade";
            this.comboEspecialidade.Size = new System.Drawing.Size(380, 26);
            this.comboEspecialidade.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label17.Location = new System.Drawing.Point(515, 309);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 20);
            this.label17.TabIndex = 15;
            this.label17.Text = "Especialidade";
            // 
            // comboPrivilegios
            // 
            this.comboPrivilegios.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboPrivilegios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPrivilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrivilegios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPrivilegios.FormattingEnabled = true;
            this.comboPrivilegios.ItemHeight = 20;
            this.comboPrivilegios.Location = new System.Drawing.Point(964, 337);
            this.comboPrivilegios.Margin = new System.Windows.Forms.Padding(4);
            this.comboPrivilegios.Name = "comboPrivilegios";
            this.comboPrivilegios.Size = new System.Drawing.Size(178, 26);
            this.comboPrivilegios.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label18.Location = new System.Drawing.Point(959, 309);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 20);
            this.label18.TabIndex = 17;
            this.label18.Text = "Privilégios";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(627, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
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
            this.btnIncluirEntidade.Location = new System.Drawing.Point(1001, 436);
            this.btnIncluirEntidade.Name = "btnIncluirEntidade";
            this.btnIncluirEntidade.Size = new System.Drawing.Size(141, 37);
            this.btnIncluirEntidade.TabIndex = 22;
            this.btnIncluirEntidade.Text = "Incluir";
            this.btnIncluirEntidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirEntidade.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIncluirEntidade.UseVisualStyleBackColor = false;
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
            this.btnGravarEntidade.Location = new System.Drawing.Point(817, 436);
            this.btnGravarEntidade.Name = "btnGravarEntidade";
            this.btnGravarEntidade.Size = new System.Drawing.Size(141, 37);
            this.btnGravarEntidade.TabIndex = 23;
            this.btnGravarEntidade.Text = "Gravar";
            this.btnGravarEntidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarEntidade.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGravarEntidade.UseVisualStyleBackColor = false;
            // 
            // btnConsultarAcoes
            // 
            this.btnConsultarAcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultarAcoes.FlatAppearance.BorderSize = 0;
            this.btnConsultarAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAcoes.ForeColor = System.Drawing.Color.White;
            this.btnConsultarAcoes.Location = new System.Drawing.Point(1001, 213);
            this.btnConsultarAcoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarAcoes.Name = "btnConsultarAcoes";
            this.btnConsultarAcoes.Size = new System.Drawing.Size(141, 37);
            this.btnConsultarAcoes.TabIndex = 6;
            this.btnConsultarAcoes.Text = "Consultar";
            this.btnConsultarAcoes.UseVisualStyleBackColor = false;
            // 
            // FormCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 1040);
            this.Controls.Add(this.panelCadastroEntidade);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panel3Botoes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboEspecialidade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboSetor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox campoCPF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox campoCodigo;
        private System.Windows.Forms.ComboBox comboPrivilegios;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconButton btnIncluirEntidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConsultarAcoes;
        private FontAwesome.Sharp.IconButton btnGravarEntidade;
    }
}