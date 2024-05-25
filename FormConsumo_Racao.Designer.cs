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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panelBotoes = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).BeginInit();
            this.panelConsumo.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(303, 116);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerData.TabIndex = 66;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(815, 196);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 30);
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
            this.txtCodigoLote.Location = new System.Drawing.Point(432, 116);
            this.txtCodigoLote.Name = "txtCodigoLote";
            this.txtCodigoLote.Size = new System.Drawing.Size(99, 19);
            this.txtCodigoLote.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(429, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Código do Lote";
            // 
            // txtDiaCiclo
            // 
            this.txtDiaCiclo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDiaCiclo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaCiclo.Location = new System.Drawing.Point(822, 116);
            this.txtDiaCiclo.Name = "txtDiaCiclo";
            this.txtDiaCiclo.Size = new System.Drawing.Size(99, 19);
            this.txtDiaCiclo.TabIndex = 62;
            // 
            // txtConsumo
            // 
            this.txtConsumo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtConsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConsumo.Location = new System.Drawing.Point(692, 115);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(99, 19);
            this.txtConsumo.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(818, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Dia do Ciclo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(688, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
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
            this.btnLimpar.Location = new System.Drawing.Point(677, 196);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 30);
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
            this.btnConsultarCodigoLote.Location = new System.Drawing.Point(552, 113);
            this.btnConsultarCodigoLote.Name = "btnConsultarCodigoLote";
            this.btnConsultarCodigoLote.Size = new System.Drawing.Size(102, 22);
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
            this.label5.Location = new System.Drawing.Point(299, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(299, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Consumo de ração";
            // 
            // chartConsumo
            // 
            this.chartConsumo.BackColor = System.Drawing.SystemColors.MenuBar;
            chartArea1.Name = "ChartArea1";
            this.chartConsumo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend3";
            this.chartConsumo.Legends.Add(legend1);
            this.chartConsumo.Location = new System.Drawing.Point(303, 319);
            this.chartConsumo.Name = "chartConsumo";
            this.chartConsumo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend3";
            series1.Name = "Consumo de Ração";
            this.chartConsumo.Series.Add(series1);
            this.chartConsumo.Size = new System.Drawing.Size(618, 300);
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
            this.btnGerar_Grafico.Location = new System.Drawing.Point(432, 271);
            this.btnGerar_Grafico.Name = "btnGerar_Grafico";
            this.btnGerar_Grafico.Size = new System.Drawing.Size(106, 30);
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
            this.comboLoteGrafico.ItemHeight = 18;
            this.comboLoteGrafico.Location = new System.Drawing.Point(303, 275);
            this.comboLoteGrafico.Name = "comboLoteGrafico";
            this.comboLoteGrafico.Size = new System.Drawing.Size(100, 26);
            this.comboLoteGrafico.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(299, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
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
            this.panelConsumo.Location = new System.Drawing.Point(0, 150);
            this.panelConsumo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelConsumo.Name = "panelConsumo";
            this.panelConsumo.Size = new System.Drawing.Size(1327, 643);
            this.panelConsumo.TabIndex = 71;
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
            // panelFornecimento
            // 
            this.panelFornecimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFornecimento.Location = new System.Drawing.Point(0, 793);
            this.panelFornecimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFornecimento.Name = "panelFornecimento";
            this.panelFornecimento.Size = new System.Drawing.Size(1327, 640);
            this.panelFornecimento.TabIndex = 72;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnFornecimento);
            this.panelBotoes.Controls.Add(this.btnConsumo);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoes.Location = new System.Drawing.Point(0, 0);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(1327, 150);
            this.panelBotoes.TabIndex = 74;
            // 
            // FormConsumo_Racao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1327, 807);
            this.Controls.Add(this.panelFornecimento);
            this.Controls.Add(this.panelConsumo);
            this.Controls.Add(this.panelBotoes);
            this.Name = "FormConsumo_Racao";
            this.Text = "FormConsumo_Racao";
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).EndInit();
            this.panelConsumo.ResumeLayout(false);
            this.panelConsumo.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
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
    }
}