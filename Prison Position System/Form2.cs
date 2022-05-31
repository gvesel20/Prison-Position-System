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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonDodajTlocrt_Click(object sender, EventArgs e)
        {
            int IdTlocrta = int.Parse(textBoxIdTlocrta.Text);
            int Širina = int.Parse(textBoxŠirina.Text);
            int Dužina = int.Parse(textBoxDužina.Text);
            int Aktivan = 0;
            if (checkBoxAktivan.Checked == true)
            {
                Aktivan = 1;
                Tlocrt.UpdateAktivnostiTlocrta();
            }
            Tlocrt.DodavanjeTlocrta(IdTlocrta, Širina, Dužina, Aktivan);
        }
    }
}
