using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Artikelverwaltung
{
    class Artikelverwaltung
    {
        public List<Artikel> ArtikelListe { get; set; }
        private string file = Directory.GetCurrentDirectory() + "\artikel.json";


        public Artikelverwaltung() {
            ArtikelListe = new List<Artikel>();
        }

       

        public void add(Artikel art) {
            ArtikelListe.Add(art);
        }

        public void del(Artikel art) { 
        
        }

        public void update(Artikel art) { 
        }
        public Artikel getArtikel(string artikelname, bool isName)
        {

            return null;
        }

        public List<Artikel> getAllArtikel()
        {
            
            return ArtikelListe;
        }

        public double getWert()
        {
            double d = 0.0;
            foreach (Artikel art in ArtikelListe)
            {
                d += art.Preis;
            }
            return d;
        }


        public void save(List<Artikel> alist)
        {
            if (!File.Exists(file))
            {
                File.Create(file);
            }
        }

        public List<Artikel> load()
        {
            if (!File.Exists(file))
            {
            }
            return null;
        }
    }
}
