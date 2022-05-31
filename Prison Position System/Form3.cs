using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prison_Position_System.Klase;

namespace Prison_Position_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonPojava_Click(object sender, EventArgs e)
        {
            int KoordinataX = int.Parse(textBoxX.Text);
            int KoordinataY = int.Parse(textBoxY.Text);
            int IdMobitela = int.Parse(textBoxIdMobitela.Text);
            if (Pojava.DohvacanjeIdMobitela(IdMobitela) == 0)
            {
                Mobitel.DodavanjeMobitela(IdMobitela, 0);
            }
            Pojava.DodavanjePojave(KoordinataX, KoordinataY, Pojava.DohvacanjeIdTlocrta(), IdMobitela);
        }
    }
}
