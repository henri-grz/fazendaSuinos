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
            this.btnFazenda = new System.Windows.Forms.Button();
            this.btnAcoesCorretivas = new System.Windows.Forms.Button();
            this.panelBotoesTipo = new System.Windows.Forms.Panel();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.campoValorFiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboAtributo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionarFiltro = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panelBotoesTipo.SuspendLayout();
            this.panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntidades
            // 
            this.btnEntidades.FlatAppearance.BorderSize = 0;
            this.btnEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnEntidades.Location = new System.Drawing.Point(174, 65);
            this.btnEntidades.Name = "btnEntidades";
            this.btnEntidades.Size = new System.Drawing.Size(200, 60);
            this.btnEntidades.TabIndex = 0;
            this.btnEntidades.Text = "Entidades";
            this.btnEntidades.UseVisualStyleBackColor = true;
            // 
            // btnFazenda
            // 
            this.btnFazenda.FlatAppearance.BorderSize = 0;
            this.btnFazenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnFazenda.Location = new System.Drawing.Point(513, 65);
            this.btnFazenda.Name = "btnFazenda";
            this.btnFazenda.Size = new System.Drawing.Size(200, 60);
            this.btnFazenda.TabIndex = 1;
            this.btnFazenda.Text = "Fazenda";
            this.btnFazenda.UseVisualStyleBackColor = true;
            // 
            // btnAcoesCorretivas
            // 
            this.btnAcoesCorretivas.FlatAppearance.BorderSize = 0;
            this.btnAcoesCorretivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcoesCorretivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcoesCorretivas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAcoesCorretivas.Location = new System.Drawing.Point(851, 65);
            this.btnAcoesCorretivas.Name = "btnAcoesCorretivas";
            this.btnAcoesCorretivas.Size = new System.Drawing.Size(289, 60);
            this.btnAcoesCorretivas.TabIndex = 2;
            this.btnAcoesCorretivas.Text = "Ações Corretivas";
            this.btnAcoesCorretivas.UseVisualStyleBackColor = true;
            // 
            // panelBotoesTipo
            // 
            this.panelBotoesTipo.Controls.Add(this.btnAcoesCorretivas);
            this.panelBotoesTipo.Controls.Add(this.btnFazenda);
            this.panelBotoesTipo.Controls.Add(this.btnEntidades);
            this.panelBotoesTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoesTipo.Location = new System.Drawing.Point(0, 0);
            this.panelBotoesTipo.Name = "panelBotoesTipo";
            this.panelBotoesTipo.Size = new System.Drawing.Size(1340, 128);
            this.panelBotoesTipo.TabIndex = 3;
            // 
            // panelFiltro
            // 
            this.panelFiltro.Controls.Add(this.btnLimpar);
            this.panelFiltro.Controls.Add(this.btnConsultar);
            this.panelFiltro.Controls.Add(this.dataGridView1);
            this.panelFiltro.Controls.Add(this.btnAdicionarFiltro);
            this.panelFiltro.Controls.Add(this.campoValorFiltro);
            this.panelFiltro.Controls.Add(this.label3);
            this.panelFiltro.Controls.Add(this.comboAtributo);
            this.panelFiltro.Controls.Add(this.label2);
            this.panelFiltro.Controls.Add(this.label1);
            this.panelFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltro.Location = new System.Drawing.Point(0, 128);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(1340, 490);
            this.panelFiltro.TabIndex = 4;
            // 
            // campoValorFiltro
            // 
            this.campoValorFiltro.BackColor = System.Drawing.SystemColors.MenuBar;
            this.campoValorFiltro.Location = new System.Drawing.Point(449, 133);
            this.campoValorFiltro.Name = "campoValorFiltro";
            this.campoValorFiltro.Size = new System.Drawing.Size(564, 20);
            this.campoValorFiltro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(445, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // comboAtributo
            // 
            this.comboAtributo.BackColor = System.Drawing.SystemColors.Menu;
            this.comboAtributo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAtributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAtributo.FormattingEnabled = true;
            this.comboAtributo.ItemHeight = 20;
            this.comboAtributo.Location = new System.Drawing.Point(204, 127);
            this.comboAtributo.Name = "comboAtributo";
            this.comboAtributo.Size = new System.Drawing.Size(170, 26);
            this.comboAtributo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(200, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Atributo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(198, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta";
            // 
            // btnAdicionarFiltro
            // 
            this.btnAdicionarFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionarFiltro.AutoEllipsis = true;
            this.btnAdicionarFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionarFiltro.FlatAppearance.BorderSize = 0;
            this.btnAdicionarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarFiltro.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdicionarFiltro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAdicionarFiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdicionarFiltro.Location = new System.Drawing.Point(1032, 123);
            this.btnAdicionarFiltro.Name = "btnAdicionarFiltro";
            this.btnAdicionarFiltro.Size = new System.Drawing.Size(45, 38);
            this.btnAdicionarFiltro.TabIndex = 5;
            this.btnAdicionarFiltro.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(873, 165);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(973, 200);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 30);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(838, 200);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 30);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // FormCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 845);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelBotoesTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastros";
            this.ShowInTaskbar = false;
            this.Text = "FormCadastros";
            this.panelBotoesTipo.ResumeLayout(false);
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntidades;
        private System.Windows.Forms.Button btnFazenda;
        private System.Windows.Forms.Button btnAcoesCorretivas;
        private System.Windows.Forms.Panel panelBotoesTipo;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.ComboBox comboAtributo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoValorFiltro;
        private FontAwesome.Sharp.IconButton btnAdicionarFiltro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}