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
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQntVac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiasCarencia = new System.Windows.Forms.TextBox();
            this.btnConsultarCarencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpVacinacao
            // 
            this.dtpVacinacao.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dtpVacinacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpVacinacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVacinacao.Location = new System.Drawing.Point(383, 330);
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
            this.btnSalvar.Location = new System.Drawing.Point(1080, 547);
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
            this.txtMedicamento.Location = new System.Drawing.Point(383, 254);
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
            this.txtCodigoLote.Location = new System.Drawing.Point(856, 255);
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
            this.label7.Location = new System.Drawing.Point(851, 226);
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
            this.txtDiasUso.Location = new System.Drawing.Point(604, 331);
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
            this.label3.Location = new System.Drawing.Point(851, 302);
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
            this.label2.Location = new System.Drawing.Point(599, 302);
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
            this.label1.Location = new System.Drawing.Point(378, 225);
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
            this.btnLimpar.Location = new System.Drawing.Point(900, 547);
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
            this.btnConsultarCodigoLote.Location = new System.Drawing.Point(1076, 251);
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
            this.label5.Location = new System.Drawing.Point(378, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(691, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 46);
            this.label6.TabIndex = 38;
            this.label6.Text = "Medicação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtObservacao.Location = new System.Drawing.Point(383, 417);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(838, 82);
            this.txtObservacao.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(378, 388);
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
            this.txtQntVac.Location = new System.Drawing.Point(604, 255);
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
            this.label8.Location = new System.Drawing.Point(599, 225);
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
            this.txtDiasCarencia.Location = new System.Drawing.Point(856, 331);
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
            this.btnConsultarCarencia.Location = new System.Drawing.Point(1073, 327);
            this.btnConsultarCarencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarCarencia.Name = "btnConsultarCarencia";
            this.btnConsultarCarencia.Size = new System.Drawing.Size(148, 27);
            this.btnConsultarCarencia.TabIndex = 59;
            this.btnConsultarCarencia.Text = "Consultar Tabela";
            this.btnConsultarCarencia.UseVisualStyleBackColor = false;
            this.btnConsultarCarencia.Click += new System.EventHandler(this.btnConsultarCarencia_Click);
            // 
            // FormMedicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1765, 874);
            this.Controls.Add(this.btnConsultarCarencia);
            this.Controls.Add(this.txtDiasCarencia);
            this.Controls.Add(this.txtQntVac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpVacinacao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.txtCodigoLote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiasUso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultarCodigoLote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMedicacao";
            this.Text = "FormMedicacao";
            this.Load += new System.EventHandler(this.FormMedicacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQntVac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiasCarencia;
        private System.Windows.Forms.Button btnConsultarCarencia;
    }
}