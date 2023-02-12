﻿using System;
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
    public partial class FrmSzczegoly : Form
    {
        Zawodnik zawodnik;
        ManagerZawodnikow mz;
        FrmZawodnicy frmZawodnicy;
        public FrmSzczegoly(Zawodnik zawodnik, ManagerZawodnikow mz, FrmZawodnicy frmZawodnicy)
        {
            InitializeComponent();

            this.mz = mz;
            this.zawodnik = zawodnik;
            this.frmZawodnicy = frmZawodnicy;

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;

            dtpDataUr.Value = zawodnik.DataUrodzenia;
            numWaga.Value = zawodnik.Waga;
            numWzrost.Value = zawodnik.Wzrost;
        }

        private void btnZapisz_Click(object sender, EventArgs e) 
        {
            DialogResult dr=
                MessageBox.Show("Czy napewno chcesz zapisac zmiany? ", "Pytanie",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                zawodnik.Imie = txtImie.Text;
                zawodnik.Nazwisko = txtNazwisko.Text;
                zawodnik.Kraj = txtKraj.Text;
                zawodnik.DataUrodzenia = dtpDataUr.Value;
                zawodnik.Waga = Convert.ToInt32(numWaga.Value);
                zawodnik.Wzrost = Convert.ToInt32(numWzrost.Value);

                mz.Edytuj(zawodnik);
                frmZawodnicy.Odswiez();
                this.Close();
            }

            

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}