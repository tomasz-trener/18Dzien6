using P04BibliotekaPolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaZawodnicy
{
    internal class ManagerMiast
    {

        private string connString;
        private Miasto[] tablicaMiast;
        PolaczenieZBaza pzb;

        public Miasto[] TablicaMiast
        {
            get{ return tablicaMiast; }
        }

        public ManagerMiast(string connString)
        {
            this.connString = connString;
            pzb = new PolaczenieZBaza(connString);
        }


        public void WczytajMiasta()
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            object[][] wynik = pzb.WykonajZapytanie("select id_miasta, nazwa_miasta from miasta");

            Miasto[] tab = new Miasto[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                Miasto m = new Miasto();
                m.Id = (int)wynik[i][0];
                m.Nazwa = (string)wynik[i][1];

                tab[i] = m;
            }

            tablicaMiast = tab;
        }

        public void Usun(int id)
        {
            string sql = $"delete miasta where id_miasta={id}";
            pzb.WykonajZapytanie(sql);
        }

        public void Edytuj(Miasto m)
        {
            string szablon = @"update miasta set
                               nazwa_miasta='{0}'
                               where id_miasta={1}";

            string sql = string.Format(szablon,
                    m.Nazwa, m.Id);

            pzb.WykonajZapytanie(sql);
        }

        public void Dodaj(Miasto m)
        {
            string szablon = "insert into miasta values ('{0}')";
            string sql = string.Format(szablon, m.Nazwa);
            pzb.WykonajZapytanie(sql);
        }

    }
}
