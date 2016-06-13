using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoGlowne : Form
    {
        int numerPanelu = 0;
        List<Panel> listaPaneli = new List<Panel>();
        Dane dane = new Dane();

        public OknoGlowne()
        {
            InitializeComponent();
        }

        private void btnDalej_Click(object sender, EventArgs e)
        {
            //warunek sprawdzający czy dane zostały wprowadzone
            if ((numerPanelu == 0 && textBoxImie.Text == "") || (numerPanelu == 1 && textBoxNazwisko.Text == "") || (numerPanelu == 2 && textBoxAdres.Text == "") || (numerPanelu == 3 && textBoxTelefon.Text == ""))
            {
                MessageBox.Show("Nie wprowadziłeś danych !", "Błąd");
            }
            else {
                if (numerPanelu < listaPaneli.Count - 1)
                {
                    foreach (var panel in listaPaneli)
                    {
                        panel.Visible = false;
                    }
                    listaPaneli[++numerPanelu].Visible = true;
                }

                //dane wprowadzone do TextBox'ów
                dane.Imie = textBoxImie.Text;
                dane.Nazwisko = textBoxNazwisko.Text;
                dane.Adres = textBoxAdres.Text;
                dane.Telefon = textBoxTelefon.Text;

                //dane pobrane do Label'i
                labelWartoscImie.Text = dane.Imie;
                labelWartoscNazwisko.Text = dane.Nazwisko;
                labelWartoscAdres.Text = dane.Adres;
                labelWartoscTelefon.Text = dane.Telefon;

                //warunki ukrywające/pokazujące przyciki i tekst
                if (numerPanelu == listaPaneli.Count-1)
                {
                    labelWprowadzDane.Visible = false;
                    labelTwojeDane.Visible = true;
                    btnDalej.Visible = false;
                    btnZakoncz.Visible = true;
                }

                if (numerPanelu != 0)
                {
                    btnWtecz.Visible = true;
                }
            }
        }

        private void btnWtecz_Click(object sender, EventArgs e)
        {
            if (numerPanelu > 0)
            {
                foreach (var panel in listaPaneli)
                {
                    panel.Visible = false;
                }
                listaPaneli[--numerPanelu].Visible = true;
            }

            //warunki ukrywające/pokazujące przyciki i tekst
            if (numerPanelu < listaPaneli.Count - 1)
            {
                labelWprowadzDane.Visible = true;
                labelTwojeDane.Visible = false;
                btnDalej.Visible = true;
                btnZakoncz.Visible = false;
            }
            if (numerPanelu == 0)
            {
                btnWtecz.Visible = false;
            }
        }

        private void btnZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OknoGlowne_Load(object sender, EventArgs e)
        {
            listaPaneli.Add(panel1);
            listaPaneli.Add(panel2);
            listaPaneli.Add(panel3);
            listaPaneli.Add(panel4);
            listaPaneli.Add(panel5);
            listaPaneli[numerPanelu].BringToFront();

            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
           
                 
        }
    }
}


