using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Artikelverwaltung
{
    class Artikelverwaltung
    {
        private List<Artikel> ArtikelListe { get; set; }
        private string file = Directory.GetCurrentDirectory() + "\artikel.json";


        public Artikelverwaltung() {
            ArtikelListe = new List<Artikel>();
        }

        public void add(Artikel art) {
            ArtikelListe.Add(art);
        }

        public void del(Artikel art) { 
        
        }

        public void updatePreis(double neuerPreis, Artikel art) { 
        }

        public void updateMenge(int neueMenge, Artikel art){

        }

        public void save(List<Artikel> alist) {
            if (!File.Exists(file)) {
                File.Create(file);
            }
        }

        public List<Artikel> load(){
            if (!File.Exists(file)){
            }
                return null;
        }
    }
}
