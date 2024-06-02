namespace fazendaSuinos
{
    partial class FormConsumo_Racao_Lote
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
            this.dataGridViewLote = new System.Windows.Forms.DataGridView();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLote
            // 
            this.dataGridViewLote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLote.Location = new System.Drawing.Point(25, 76);
            this.dataGridViewLote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewLote.Name = "dataGridViewLote";
            this.dataGridViewLote.ReadOnly = true;
            this.dataGridViewLote.RowHeadersWidth = 51;
            this.dataGridViewLote.Size = new System.Drawing.Size(797, 398);
            this.dataGridViewLote.TabIndex = 65;
            this.dataGridViewLote.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLote_CellDoubleClick);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(25, 76);
            this.dataGridViewProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(797, 398);
            this.dataGridViewProdutos.TabIndex = 124;
            this.dataGridViewProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellDoubleClick);
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(25, 76);
            this.dataGridViewFornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.ReadOnly = true;
            this.dataGridViewFornecedor.RowHeadersWidth = 51;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(797, 398);
            this.dataGridViewFornecedor.TabIndex = 125;
            this.dataGridViewFornecedor.Visible = false;
            this.dataGridViewFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedor_CellDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(797, 398);
            this.dataGridView1.TabIndex = 126;
            this.dataGridView1.Visible = false;
            // 
            // FormConsumo_Racao_Lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewFornecedor);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.dataGridViewLote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsumo_Racao_Lote";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lote";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLote;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridView dataGridViewFornecedor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}