using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Artikelverwaltung
{
    class Artikel : IEquatable<Artikel>
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
        public Artikel() { }

        public override string ToString()
        {
            return "Artikelnummer: " + Artikelnummer + ", Artikelbezeichnung: " + Artikelbezeichnung +
                ", Einheit: " + Mengeneinheit + ", Menge: " + Menge + ", Preis: " + Preis;
        }

        public bool Equals(Artikel other)
        {
            if (this.Artikelnummer.Equals(other.Artikelnummer, StringComparison.OrdinalIgnoreCase)) 
                return true;
            return false;
        }
    }
}
