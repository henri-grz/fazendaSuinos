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
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMeicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMeicamentos
            // 
            this.pcbMeicamentos.Image = ((System.Drawing.Image)(resources.GetObject("pcbMeicamentos.Image")));
            this.pcbMeicamentos.Location = new System.Drawing.Point(96, 17);
            this.pcbMeicamentos.Name = "pcbMeicamentos";
            this.pcbMeicamentos.Size = new System.Drawing.Size(460, 419);
            this.pcbMeicamentos.TabIndex = 61;
            this.pcbMeicamentos.TabStop = false;
            // 
            // dataGridViewLote
            // 
            this.dataGridViewLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLote.Location = new System.Drawing.Point(14, 54);
            this.dataGridViewLote.Name = "dataGridViewLote";
            this.dataGridViewLote.ReadOnly = true;
            this.dataGridViewLote.RowHeadersWidth = 51;
            this.dataGridViewLote.Size = new System.Drawing.Size(598, 323);
            this.dataGridViewLote.TabIndex = 62;
            this.dataGridViewLote.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLote_CellDoubleClick);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(14, 54);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(598, 323);
            this.dataGridViewProdutos.TabIndex = 124;
            this.dataGridViewProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellDoubleClick);
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(14, 54);
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.ReadOnly = true;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(598, 323);
            this.dataGridViewFornecedor.TabIndex = 125;
            this.dataGridViewFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedor_CellDoubleClick);
            // 
            // FormMedicacao_LoteCarencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 447);
            this.Controls.Add(this.dataGridViewFornecedor);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.dataGridViewLote);
            this.Controls.Add(this.pcbMeicamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMedicacao_LoteCarencia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda";
            ((System.ComponentModel.ISupportInitialize)(this.pcbMeicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMeicamentos;
        private System.Windows.Forms.DataGridView dataGridViewLote;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridView dataGridViewFornecedor;
    }
}