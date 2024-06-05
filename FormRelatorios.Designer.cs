namespace fazendaSuinos
{
    partial class FormRelatorios
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
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.clbSelecaoRelatorio = new System.Windows.Forms.CheckedListBox();
            this.btnSelecionarTodos = new System.Windows.Forms.Button();
            this.btnDesmarcarTodos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(539, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 37);
            this.label6.TabIndex = 41;
            this.label6.Text = "Relatórios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label9.Location = new System.Drawing.Point(287, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 24);
            this.label9.TabIndex = 77;
            this.label9.Text = "Gerar Relatório";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Modelos Prontos";
            // 
            // comboModelo
            // 
            this.comboModelo.BackColor = System.Drawing.Color.LightGray;
            this.comboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Items.AddRange(new object[] {
            "Entidades",
            "Objetos da Fazenda",
            "Estrutura da Fazenda (Propriedade, Pocilga e Lote)",
            "Todos os Lotes",
            "Detalhes do Lote (Detalhes, Alimentação, Medicação, Mortalidade e Peso Médio)",
            "Detalhes da Ração (Selecionar Lotes)",
            "Detalhes da Medicação (Selecionar Lotes)",
            "Detalhes do Peso Médio (Selecionar Lotes)",
            "Detalhes de Mortalidade (Selecionar Lotes)"});
            this.comboModelo.Location = new System.Drawing.Point(3, 39);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(657, 24);
            this.comboModelo.TabIndex = 79;
            this.comboModelo.SelectedIndexChanged += new System.EventHandler(this.comboModelo_SelectedIndexChanged);
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnGerar.FlatAppearance.BorderSize = 0;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(519, 133);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(141, 30);
            this.btnGerar.TabIndex = 80;
            this.btnGerar.Text = "Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // clbSelecaoRelatorio
            // 
            this.clbSelecaoRelatorio.CheckOnClick = true;
            this.clbSelecaoRelatorio.FormattingEnabled = true;
            this.clbSelecaoRelatorio.Location = new System.Drawing.Point(3, 11);
            this.clbSelecaoRelatorio.MultiColumn = true;
            this.clbSelecaoRelatorio.Name = "clbSelecaoRelatorio";
            this.clbSelecaoRelatorio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clbSelecaoRelatorio.Size = new System.Drawing.Size(657, 109);
            this.clbSelecaoRelatorio.TabIndex = 81;
            // 
            // btnSelecionarTodos
            // 
            this.btnSelecionarTodos.BackColor = System.Drawing.Color.LightGray;
            this.btnSelecionarTodos.FlatAppearance.BorderSize = 0;
            this.btnSelecionarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSelecionarTodos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelecionarTodos.Location = new System.Drawing.Point(3, 133);
            this.btnSelecionarTodos.Name = "btnSelecionarTodos";
            this.btnSelecionarTodos.Size = new System.Drawing.Size(112, 30);
            this.btnSelecionarTodos.TabIndex = 82;
            this.btnSelecionarTodos.Text = "Selecionar Todos";
            this.btnSelecionarTodos.UseVisualStyleBackColor = false;
            this.btnSelecionarTodos.Click += new System.EventHandler(this.btnSelecionarTodos_Click);
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.BackColor = System.Drawing.Color.LightGray;
            this.btnDesmarcarTodos.FlatAppearance.BorderSize = 0;
            this.btnDesmarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesmarcarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDesmarcarTodos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(121, 133);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(112, 30);
            this.btnDesmarcarTodos.TabIndex = 82;
            this.btnDesmarcarTodos.Text = "Desmarcar Todos";
            this.btnDesmarcarTodos.UseVisualStyleBackColor = false;
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(291, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 400);
            this.panel1.TabIndex = 83;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(663, 87);
            this.panel4.TabIndex = 85;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDesmarcarTodos);
            this.panel3.Controls.Add(this.btnSelecionarTodos);
            this.panel3.Controls.Add(this.clbSelecaoRelatorio);
            this.panel3.Controls.Add(this.btnGerar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 184);
            this.panel3.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboModelo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 66);
            this.panel2.TabIndex = 84;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1324, 806);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.CheckedListBox clbSelecaoRelatorio;
        private System.Windows.Forms.Button btnSelecionarTodos;
        private System.Windows.Forms.Button btnDesmarcarTodos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}