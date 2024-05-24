namespace fazendaSuinos
{
    partial class FormPeso_Medio
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
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodigoLote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.txtPesoMedio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultarCodigoLote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewLote = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(230, 255);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerData.TabIndex = 54;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(420, 401);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 30);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigoLote
            // 
            this.txtCodigoLote.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCodigoLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoLote.Location = new System.Drawing.Point(359, 255);
            this.txtCodigoLote.Name = "txtCodigoLote";
            this.txtCodigoLote.Size = new System.Drawing.Size(99, 19);
            this.txtCodigoLote.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(356, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Código do Lote";
            // 
            // txtSemana
            // 
            this.txtSemana.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSemana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSemana.Location = new System.Drawing.Point(360, 337);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(99, 19);
            this.txtSemana.TabIndex = 49;
            // 
            // txtPesoMedio
            // 
            this.txtPesoMedio.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPesoMedio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPesoMedio.Location = new System.Drawing.Point(230, 336);
            this.txtPesoMedio.Name = "txtPesoMedio";
            this.txtPesoMedio.Size = new System.Drawing.Size(99, 19);
            this.txtPesoMedio.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(356, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(226, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Peso médio";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(282, 401);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 30);
            this.btnLimpar.TabIndex = 44;
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
            this.btnConsultarCodigoLote.Location = new System.Drawing.Point(479, 252);
            this.btnConsultarCodigoLote.Name = "btnConsultarCodigoLote";
            this.btnConsultarCodigoLote.Size = new System.Drawing.Size(102, 22);
            this.btnConsultarCodigoLote.TabIndex = 43;
            this.btnConsultarCodigoLote.Text = "Consultar Lote";
            this.btnConsultarCodigoLote.UseVisualStyleBackColor = false;
            this.btnConsultarCodigoLote.Click += new System.EventHandler(this.btnConsultarCodigoLote_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(226, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(263, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 37);
            this.label6.TabIndex = 40;
            this.label6.Text = "Peso Médio";
            // 
            // dataGridViewLote
            // 
            this.dataGridViewLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLote.Location = new System.Drawing.Point(678, 207);
            this.dataGridViewLote.Name = "dataGridViewLote";
            this.dataGridViewLote.Size = new System.Drawing.Size(391, 186);
            this.dataGridViewLote.TabIndex = 55;
            // 
            // FormPeso_Medio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1324, 609);
            this.Controls.Add(this.dataGridViewLote);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCodigoLote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSemana);
            this.Controls.Add(this.txtPesoMedio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultarCodigoLote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "FormPeso_Medio";
            this.Text = "FormPeso_Medio";
            this.Load += new System.EventHandler(this.FormPeso_Medio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigoLote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.TextBox txtPesoMedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultarCodigoLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewLote;
    }
}