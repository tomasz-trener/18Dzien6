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
    public partial class FrmSzczegoly : Form
    {
        Zawodnik zawodnik;
        ManagerZawodnikow mz;
        public FrmSzczegoly(Zawodnik zawodnik, ManagerZawodnikow mz)
        {
            InitializeComponent();

            this.mz = mz;
            this.zawodnik = zawodnik;

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;

            dtpDataUr.Value = zawodnik.DataUrodzenia;
            numWaga.Value = zawodnik.Waga;
            numWzrost.Value = zawodnik.Wzrost;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            zawodnik.DataUrodzenia = dtpDataUr.Value;
            zawodnik.Waga = Convert.ToInt32(numWaga.Value);
            zawodnik.Wzrost = Convert.ToInt32(numWzrost.Value);

            mz.Edytuj(zawodnik);
            
        }
    }
}
