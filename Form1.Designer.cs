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
            this.btnCadastros = new FontAwesome.Sharp.IconButton();
            this.btnMortalidade = new FontAwesome.Sharp.IconButton();
            this.btnPesoMedio = new FontAwesome.Sharp.IconButton();
            this.btnMedicacao = new FontAwesome.Sharp.IconButton();
            this.btnRacao = new FontAwesome.Sharp.IconButton();
            this.btnDetalhes = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.comboLoteMenu = new System.Windows.Forms.ComboBox();
            this.logoMenu = new System.Windows.Forms.PictureBox();
            this.fazendaSuinosDBDataSet = new fazendaSuinos.fazendaSuinosDBDataSet();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDBDataSet)).BeginInit();
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
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 845);
            this.panelMenu.TabIndex = 0;
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
            this.btnCadastros.Location = new System.Drawing.Point(0, 555);
            this.btnCadastros.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(30, 0, 8, 0);
            this.btnCadastros.Size = new System.Drawing.Size(200, 60);
            this.btnCadastros.TabIndex = 6;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
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
            this.btnMortalidade.Location = new System.Drawing.Point(0, 495);
            this.btnMortalidade.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnPesoMedio.Location = new System.Drawing.Point(0, 435);
            this.btnPesoMedio.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnMedicacao.Location = new System.Drawing.Point(0, 375);
            this.btnMedicacao.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnRacao.Location = new System.Drawing.Point(0, 315);
            this.btnRacao.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnDetalhes.Location = new System.Drawing.Point(0, 255);
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
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 34;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 195);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 8, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 60);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelLogo.Controls.Add(this.comboLoteMenu);
            this.panelLogo.Controls.Add(this.logoMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 195);
            this.panelLogo.TabIndex = 0;
            // 
            // comboLoteMenu
            // 
            this.comboLoteMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.comboLoteMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLoteMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoteMenu.ForeColor = System.Drawing.Color.White;
            this.comboLoteMenu.FormattingEnabled = true;
            this.comboLoteMenu.ItemHeight = 30;
            this.comboLoteMenu.Location = new System.Drawing.Point(27, 142);
            this.comboLoteMenu.Name = "comboLoteMenu";
            this.comboLoteMenu.Size = new System.Drawing.Size(147, 36);
            this.comboLoteMenu.TabIndex = 8;
            // 
            // logoMenu
            // 
            this.logoMenu.Image = global::fazendaSuinos.Properties.Resources.logo_rodolfo_horizontal;
            this.logoMenu.Location = new System.Drawing.Point(-2, 30);
            this.logoMenu.Name = "logoMenu";
            this.logoMenu.Size = new System.Drawing.Size(199, 92);
            this.logoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoMenu.TabIndex = 0;
            this.logoMenu.TabStop = false;
            // 
            // fazendaSuinosDBDataSet
            // 
            this.fazendaSuinosDBDataSet.DataSetName = "fazendaSuinosDBDataSet";
            this.fazendaSuinosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1340, 845);
            this.panelMain.TabIndex = 1;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDBDataSet)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.PictureBox logoMenu;
        private System.Windows.Forms.ComboBox comboLoteMenu;
        private fazendaSuinosDBDataSet fazendaSuinosDBDataSet;
        private System.Windows.Forms.Panel panelMain;
    }
}

