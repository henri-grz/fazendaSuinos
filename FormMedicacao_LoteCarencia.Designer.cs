namespace fazendaSuinos
{
    partial class FormMedicacao_LoteCarencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicacao_LoteCarencia));
            this.pcbMeicamentos = new System.Windows.Forms.PictureBox();
            this.dataGridViewLote = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMeicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMeicamentos
            // 
            this.pcbMeicamentos.Image = ((System.Drawing.Image)(resources.GetObject("pcbMeicamentos.Image")));
            this.pcbMeicamentos.Location = new System.Drawing.Point(128, 21);
            this.pcbMeicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.pcbMeicamentos.Name = "pcbMeicamentos";
            this.pcbMeicamentos.Size = new System.Drawing.Size(614, 516);
            this.pcbMeicamentos.TabIndex = 61;
            this.pcbMeicamentos.TabStop = false;
            // 
            // dataGridViewLote
            // 
            this.dataGridViewLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLote.Location = new System.Drawing.Point(18, 66);
            this.dataGridViewLote.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLote.Name = "dataGridViewLote";
            this.dataGridViewLote.ReadOnly = true;
            this.dataGridViewLote.RowHeadersWidth = 51;
            this.dataGridViewLote.Size = new System.Drawing.Size(797, 398);
            this.dataGridViewLote.TabIndex = 62;
            this.dataGridViewLote.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLote_CellDoubleClick);
            // 
            // FormMedicacao_LoteCarencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 550);
            this.Controls.Add(this.dataGridViewLote);
            this.Controls.Add(this.pcbMeicamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMedicacao_LoteCarencia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda";
            ((System.ComponentModel.ISupportInitialize)(this.pcbMeicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMeicamentos;
        private System.Windows.Forms.DataGridView dataGridViewLote;
    }
}