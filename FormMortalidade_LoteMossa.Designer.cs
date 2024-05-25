namespace fazendaSuinos
{
    partial class FormMortalidade_LoteMossa
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
            this.imgMossa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMossa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLote
            // 
            this.dataGridViewLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLote.Location = new System.Drawing.Point(14, 54);
            this.dataGridViewLote.Name = "dataGridViewLote";
            this.dataGridViewLote.ReadOnly = true;
            this.dataGridViewLote.RowHeadersWidth = 51;
            this.dataGridViewLote.Size = new System.Drawing.Size(598, 323);
            this.dataGridViewLote.TabIndex = 63;
            this.dataGridViewLote.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLote_CellDoubleClick);
            // 
            // imgMossa
            // 
            this.imgMossa.Image = global::fazendaSuinos.Properties.Resources.mossa;
            this.imgMossa.Location = new System.Drawing.Point(74, 15);
            this.imgMossa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgMossa.Name = "imgMossa";
            this.imgMossa.Size = new System.Drawing.Size(485, 414);
            this.imgMossa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMossa.TabIndex = 64;
            this.imgMossa.TabStop = false;
            // 
            // FormMortalidade_LoteMossa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 447);
            this.Controls.Add(this.imgMossa);
            this.Controls.Add(this.dataGridViewLote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMortalidade_LoteMossa";
            this.ShowIcon = false;
            this.Text = "Ajuda";
            this.Load += new System.EventHandler(this.FormMortalidade_LoteMossa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMossa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLote;
        private System.Windows.Forms.PictureBox imgMossa;
    }
}