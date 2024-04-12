using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace fazendaSuinos
{
    public partial class FormMainMenu : Form
    {
        //campos
        private IconButton currentBtn;
        private Panel leftBorderPnl;
        private Form currentChildForm;
        //constructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderPnl = new Panel();
            leftBorderPnl.Size = new Size(7, 74);
            panelMenu.Controls.Add(leftBorderPnl);
        }
        //Structs
        private struct RGBColors
        {
            public static Color verdeClaro = Color.FromArgb(0, 180, 180);
            //public static Color color2 = Color.FromArgb(249, 118, 176);
            //public static Color color3 = Color.FromArgb(253, 138, 114);
            //public static Color color4 = Color.FromArgb(95, 77, 221);
            //public static Color color5 = Color.FromArgb(249, 88, 155);
        }

        //Funcoes
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //botao
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0,50,50);
                //currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borda da esquerda do botao
                leftBorderPnl.BackColor = color;
                leftBorderPnl.Location = new Point(0, currentBtn.Location.Y);
                leftBorderPnl.Visible = true;
                leftBorderPnl.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 70, 70);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.AutoScroll = true;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.verdeClaro);
        }

        private void btnRacao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.verdeClaro);
        }

        private void btnMedicacao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.verdeClaro);
        }

        private void btnPesoMedio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.verdeClaro);
        }

        private void btnMortalidade_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.verdeClaro);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.verdeClaro);
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.verdeClaro);
            OpenChildForm(new FormCadastros());
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazendaSuinosDBDataSet.Lote'. Você pode movê-la ou removê-la conforme necessário.
            //loteTableAdapter.Fill(this.fazendaSuinosDBDataSet.Lote);

        }
    }
}
