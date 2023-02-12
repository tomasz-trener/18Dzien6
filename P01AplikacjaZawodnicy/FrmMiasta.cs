﻿using P01AplikacjaZawodnicy.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaZawodnicy
{
    public partial class FrmMiasta : Form
    {
        ManagerMiast mm;
        public FrmMiasta(string connString)
        {
            InitializeComponent();

            mm = new ManagerMiast(connString);
            Odswiez();
            //foreach (var m in mm.TablicaMiast)
            //{
            //    lbDane.Items.Add(m.Nazwa);
            //}
        }

        private void Odswiez()
        {
            mm.WczytajMiasta();

            lbDane.DataSource = mm.TablicaMiast;
            lbDane.DisplayMember = "Nazwa";
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Miasto zaznaczone= (Miasto)lbDane.SelectedItem;
            mm.Usun(zaznaczone.Id);
            Odswiez();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Miasto zaznaczone = (Miasto)lbDane.SelectedItem;
            zaznaczone.Nazwa = txtNazwaMiasta.Text;

            mm.Edytuj(zaznaczone);
            Odswiez();
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
              Miasto zaznaczone = (Miasto)lbDane.SelectedItem;
              txtNazwaMiasta.Text = zaznaczone.Nazwa;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Czy chcesz dodac miasto?", "Pytanie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Miasto nowe = new Miasto();
                nowe.Nazwa = txtNazwaMiasta.Text;

                mm.Dodaj(nowe);
                Odswiez();
            }
        }
    }
}
