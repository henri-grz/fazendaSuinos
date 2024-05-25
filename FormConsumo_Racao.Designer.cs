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
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultarCodigoLote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGerar_Grafico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(139, 228);
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
            this.btnSalvar.Location = new System.Drawing.Point(329, 374);
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
            this.txtCodigoLote.Location = new System.Drawing.Point(268, 228);
            this.txtCodigoLote.Name = "txtCodigoLote";
            this.txtCodigoLote.Size = new System.Drawing.Size(99, 19);
            this.txtCodigoLote.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(265, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Código do Lote";
            // 
            // txtSemana
            // 
            this.txtSemana.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSemana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSemana.Location = new System.Drawing.Point(269, 310);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(99, 19);
            this.txtSemana.TabIndex = 62;
            // 
            // txtConsumo
            // 
            this.txtConsumo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtConsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConsumo.Location = new System.Drawing.Point(139, 309);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(99, 19);
            this.txtConsumo.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(265, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(135, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Consumo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(191, 374);
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
            this.btnConsultarCodigoLote.Location = new System.Drawing.Point(388, 225);
            this.btnConsultarCodigoLote.Name = "btnConsultarCodigoLote";
            this.btnConsultarCodigoLote.Size = new System.Drawing.Size(102, 22);
            this.btnConsultarCodigoLote.TabIndex = 57;
            this.btnConsultarCodigoLote.Text = "Consultar Lote";
            this.btnConsultarCodigoLote.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(135, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(159, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 37);
            this.label6.TabIndex = 55;
            this.label6.Text = "Consumo de ração";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.MenuBar;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend3";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(555, 144);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend3";
            series1.Name = "Consumo de Ração";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(574, 300);
            this.chart1.TabIndex = 67;
            this.chart1.Text = "chart1";
            // 
            // btnGerar_Grafico
            // 
            this.btnGerar_Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnGerar_Grafico.FlatAppearance.BorderSize = 0;
            this.btnGerar_Grafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar_Grafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar_Grafico.ForeColor = System.Drawing.Color.White;
            this.btnGerar_Grafico.Location = new System.Drawing.Point(556, 93);
            this.btnGerar_Grafico.Name = "btnGerar_Grafico";
            this.btnGerar_Grafico.Size = new System.Drawing.Size(106, 30);
            this.btnGerar_Grafico.TabIndex = 68;
            this.btnGerar_Grafico.Text = "Gerar Gráfico";
            this.btnGerar_Grafico.UseVisualStyleBackColor = false;
            this.btnGerar_Grafico.Click += new System.EventHandler(this.btnGerar_Grafico_Click);
            // 
            // FormConsumo_Racao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1324, 609);
            this.Controls.Add(this.btnGerar_Grafico);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCodigoLote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSemana);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultarCodigoLote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "FormConsumo_Racao";
            this.Text = "FormConsumo_Racao";
            this.Load += new System.EventHandler(this.FormConsumo_Racao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigoLote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultarCodigoLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnGerar_Grafico;
    }
}