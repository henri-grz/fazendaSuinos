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
            this.panelBotoes.SuspendLayout();
            this.panelConsumo.SuspendLayout();
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
            this.panelConsumo.Location = new System.Drawing.Point(0, 150);
            this.panelConsumo.Name = "panelConsumo";
            this.panelConsumo.Size = new System.Drawing.Size(1662, 599);
            this.panelConsumo.TabIndex = 77;
            // 
            // panelFornecimento
            // 
            this.panelFornecimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFornecimento.Location = new System.Drawing.Point(0, 749);
            this.panelFornecimento.Name = "panelFornecimento";
            this.panelFornecimento.Size = new System.Drawing.Size(1662, 599);
            this.panelFornecimento.TabIndex = 78;
            // 
            // FormMedicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1662, 951);
            this.Controls.Add(this.panelFornecimento);
            this.Controls.Add(this.panelConsumo);
            this.Controls.Add(this.panelBotoes);
            this.Name = "FormMedicacao";
            this.Text = "FormMedicacao";
            this.panelBotoes.ResumeLayout(false);
            this.panelConsumo.ResumeLayout(false);
            this.panelConsumo.PerformLayout();
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
    }
}