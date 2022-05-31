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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Mobitel> mobiteli = Mobitel.DohvatiMobitele();
            dataGridViewMobiteli.DataSource = mobiteli;
            List<Pojava> pojave = Pojava.DohvatiPojave();
            dataGridViewPojave.DataSource = pojave;
        }

        private void buttonPromjenaDopuštenosti_Click(object sender, EventArgs e)
        {
            Mobitel selectedMobitel = dataGridViewMobiteli.CurrentRow.DataBoundItem as Mobitel;
            if (selectedMobitel.Dopuštenost == 0)
            {
                selectedMobitel.Dopuštenost = 1;
                Mobitel.PromjenaDopuštenostiFrom0To1(selectedMobitel.IdMobitela);
                List<Mobitel> mobiteli = Mobitel.DohvatiMobitele();
                dataGridViewMobiteli.DataSource = mobiteli;
            }
            else
            {
                selectedMobitel.Dopuštenost = 0;
                Mobitel.PromjenaDopuštenostiFrom1To0(selectedMobitel.IdMobitela);
                List<Mobitel> mobiteli = Mobitel.DohvatiMobitele();
                dataGridViewMobiteli.DataSource = mobiteli;
            }
        }

        private void buttonBrisanjePojave_Click(object sender, EventArgs e)
        {
            Pojava selectedPojava = dataGridViewPojave.CurrentRow.DataBoundItem as Pojava;
            Pojava.BrisanjePojave(selectedPojava.IdPojave);
            List<Pojava> pojave = Pojava.DohvatiPojave();
            dataGridViewPojave.DataSource = pojave;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Pojava> pojave = Pojava.DohvatiPojavePoIdMobitela(int.Parse(textBoxPretraživanje.Text));
            dataGridViewPojave.DataSource = pojave;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Pojava> pojave = Pojava.DohvatiPojave();
            dataGridViewPojave.DataSource = pojave;
        }
    }
}
