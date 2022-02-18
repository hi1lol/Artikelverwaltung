using System;
using System.Collections.Generic;
using System.Text;

namespace Artikelverwaltung
{
    class Artikel
    {
        public string Artikelnummer { get; set; }
        public string Artikelbezeichnung { get; set; }
        public string Mengeneinheit { get; set; }
        public int Menge { get; set; }
        public double Preis { get; set; }

        public Artikel(string Artikelnummer, string Artikelbezeichnung, string Mengeneinheit, int Menge, double Preis) {
            this.Artikelbezeichnung = Artikelbezeichnung;
            this.Artikelnummer = Artikelnummer;
            this.Mengeneinheit = Mengeneinheit;
            this.Menge = Menge;
            this.Preis = Preis;
        }

        public override string ToString()
        {
            return "Artikelnummer: " + Artikelnummer + ", Artikelbezeichnung: " + Artikelbezeichnung +
                ", Einheit: " + Mengeneinheit + ", Menge: " + Menge + ", Preis: " + Preis;
        }
    }
}
