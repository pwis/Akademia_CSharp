using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public class Dane
    {
        private string imie;
        private string nazwisko;
        private string adres;
        private string telefon;

        //propercje do pobierania/przypisywania wprowadzonych przez uzytkownika danych
        public string Imie
        {
            get
            {
                return imie;
            }
            set
            {
                imie = value;
            }
        }

        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
            }
        }

        public string Adres
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
            }
        }

        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
            }
        }
    }
}
