namespace fazendaSuinos
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMortalidade = new FontAwesome.Sharp.IconButton();
            this.btnPesoMedio = new FontAwesome.Sharp.IconButton();
            this.btnMedicacao = new FontAwesome.Sharp.IconButton();
            this.btnRacao = new FontAwesome.Sharp.IconButton();
            this.btnDetalhes = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnCadastros = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.btnCadastros);
            this.panelMenu.Controls.Add(this.btnMortalidade);
            this.panelMenu.Controls.Add(this.btnPesoMedio);
            this.panelMenu.Controls.Add(this.btnMedicacao);
            this.panelMenu.Controls.Add(this.btnRacao);
            this.panelMenu.Controls.Add(this.btnDetalhes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 643);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMortalidade
            // 
            this.btnMortalidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMortalidade.FlatAppearance.BorderSize = 0;
            this.btnMortalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMortalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMortalidade.ForeColor = System.Drawing.Color.White;
            this.btnMortalidade.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.btnMortalidade.IconColor = System.Drawing.Color.White;
            this.btnMortalidade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMortalidade.IconSize = 34;
            this.btnMortalidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMortalidade.Location = new System.Drawing.Point(0, 340);
            this.btnMortalidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMortalidade.Name = "btnMortalidade";
            this.btnMortalidade.Padding = new System.Windows.Forms.Padding(30, 0, 8, 0);
            this.btnMortalidade.Size = new System.Drawing.Size(200, 60);
            this.btnMortalidade.TabIndex = 5;
            this.btnMortalidade.Text = "Mortalidade";
            this.btnMortalidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMortalidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMortalidade.UseVisualStyleBackColor = true;
            this.btnMortalidade.Click += new System.EventHandler(this.btnMortalidade_Click);
            // 
            // btnPesoMedio
            // 
            this.btnPesoMedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesoMedio.FlatAppearance.BorderSize = 0;
            this.btnPesoMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesoMedio.ForeColor = System.Drawing.Color.White;
            this.btnPesoMedio.IconChar = FontAwesome.Sharp.IconChar.WeightHanging;
            this.btnPesoMedio.IconColor = System.Drawing.Color.White;
            this.btnPesoMedio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesoMedio.IconSize = 34;
            this.btnPesoMedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesoMedio.Location = new System.Drawing.Point(0, 280);
            this.btnPesoMedio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesoMedio.Name = "btnPesoMedio";
            this.btnPesoMedio.Padding = new System.Windows.Forms.Padding(30, 0, 8, 0);
            this.btnPesoMedio.Size = new System.Drawing.Size(200, 60);
            this.btnPesoMedio.TabIndex = 4;
            this.btnPesoMedio.Text = "Peso Médio";
            this.btnPesoMedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesoMedio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesoMedio.UseVisualStyleBackColor = true;
            this.btnPesoMedio.Click += new System.EventHandler(this.btnPesoMedio_Click);
            // 
            // btnMedicacao
            // 
            this.btnMedicacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicacao.FlatAppearance.BorderSize = 0;
            this.btnMedicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicacao.ForeColor = System.Drawing.Color.White;
            this.btnMedicacao.IconChar = FontAwesome.Sharp.IconChar.Capsules;
            this.btnMedicacao.IconColor = System.Drawing.Color.White;
            this.btnMedicacao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMedicacao.IconSize = 34;
            this.btnMedicacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicacao.Location = new System.Drawing.Point(0, 220);
            this.btnMedicacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMedicacao.Name = "btnMedicacao";
            this.btnMedicacao.Padding = new System.Windows.Forms.Padding(30, 0, 8, 0);
            this.btnMedicacao.Size = new System.Drawing.Size(200, 60);
            this.btnMedicacao.TabIndex = 3;
            this.btnMedicacao.Text = "Medicação";
            this.btnMedicacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicacao.UseVisualStyleBackColor = true;
            this.btnMedicacao.Click += new System.EventHandler(this.btnMedicacao_Click);
            // 
            // btnRacao
            // 
            this.btnRacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRacao.FlatAppearance.BorderSize = 0;
            this.btnRacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacao.ForeColor = System.Drawing.Color.White;
            this.btnRacao.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.btnRacao.IconColor = System.Drawing.Color.White;
            this.btnRacao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRacao.IconSize = 34;
            this.btnRacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRacao.Location = new System.Drawing.Point(0, 160);
            this.btnRacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRacao.Name = "btnRacao";
            this.btnRacao.Padding = new System.Windows.Forms.Padding(30, 0, 8, 0);
            this.btnRacao.Size = new System.Drawing.Size(200, 60);
            this.btnRacao.TabIndex = 2;
            this.btnRacao.Text = "Ração";
            this.btnRacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRacao.UseVisualStyleBackColor = true;
            this.btnRacao.Click += new System.EventHandler(this.btnRacao_Click);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetalhes.FlatAppearance.BorderSize = 0;
            this.btnDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhes.ForeColor = System.Drawing.Color.White;
            this.btnDetalhes.IconChar = FontAwesome.Sharp.IconChar.SquarePollHorizontal;
            this.btnDetalhes.IconColor = System.Drawing.Color.White;
            this.btnDetalhes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalhes.IconSize = 34;
            this.btnDetalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalhes.Location = new System.Drawing.Point(0, 100);
            this.btnDetalhes.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Padding = new System.Windows.Forms.Padding(30, 0, 8, 0);
            this.btnDetalhes.Size = new System.Drawing.Size(200, 60);
            this.btnDetalhes.TabIndex = 1;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btnCadastros
            // 
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.White;
            this.btnCadastros.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnCadastros.IconColor = System.Drawing.Color.White;
            this.btnCadastros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastros.IconSize = 34;
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.Location = new System.Drawing.Point(0, 400);
            this.btnCadastros.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(30, 0, 8, 0);
            this.btnCadastros.Size = new System.Drawing.Size(200, 60);
            this.btnCadastros.TabIndex = 6;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastros.UseVisualStyleBackColor = true;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 643);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDetalhes;
        private FontAwesome.Sharp.IconButton btnMortalidade;
        private FontAwesome.Sharp.IconButton btnPesoMedio;
        private FontAwesome.Sharp.IconButton btnMedicacao;
        private FontAwesome.Sharp.IconButton btnRacao;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnCadastros;
    }
}

