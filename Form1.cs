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
        //constructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderPnl = new Panel();
            leftBorderPnl.Size = new Size(7, 60);
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
                leftBorderPnl.Location = new Point(0,currentBtn.Location.Y);
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
    }
}
