using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Artikelverwaltung
{
    class Artikelverwaltung
    {
        private List<Artikel> ArtikelListe { get; set; }
        private string file = Directory.GetCurrentDirectory() + "\\artikel.json";


        public Artikelverwaltung() {
            ArtikelListe = new List<Artikel>();
        }

       

        public void add(Artikel art) {
            if (ArtikelListe.Contains(art))
            {
                Console.WriteLine("Der Artikel existiert schon!");
            }else
            {
                ArtikelListe.Add(art);
            }
            
        }

        public void del(Artikel art) {
            if (ArtikelListe.Remove(art))
            {
                Console.WriteLine("Artikel erfolgreich gelöscht!");
            }
            else 
            {
                Console.WriteLine("Artikel konnte nicht gelöscht werden!");
            }
        }

        public void update(Artikel art) {
            for (int i = 0; i<ArtikelListe.Count;i++)
            {
                if (ArtikelListe[i].Equals(art))
                {
                    ArtikelListe[i] = art;
                }
            }
        }
        public Artikel getArtikel(string artikelname, bool isName)
        {
            foreach (Artikel artikel in ArtikelListe) 
            {
                if (isName)
                {
                    if(artikel.Artikelbezeichnung.Equals(artikelname,StringComparison.OrdinalIgnoreCase))
                        return artikel;
                }
                else
                {
                    if (artikel.Artikelnummer.Equals(artikelname, StringComparison.OrdinalIgnoreCase))
                        return artikel;
                }
            }
            Console.WriteLine("Artikel nicht gefunden!");
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


        public void save()
        {
            if (File.Exists(file))
            {
                Console.WriteLine("Datei existiert bereits! Überscheiben? (J/n)");
                while (true) {
                    string tmp = Console.ReadLine();
                    if (tmp.Equals("J", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else if(tmp.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("j/n eingeben!");
                    }
                }
            }
            File.WriteAllText(file, JsonSerializer.Serialize(ArtikelListe));
            Console.WriteLine("Lager wurde erfolgreich gespeichert!");

        }

        public void load()
        {
            if (File.Exists(file))
            {
                ArtikelListe =  JsonSerializer.Deserialize<List<Artikel>>(File.ReadAllText(file));
                Console.WriteLine("Lager wurde erfolgreich geladen!");
            }
            else 
            { 
                Console.WriteLine("Lager konnte nicht geladen werden!");
                Console.WriteLine("Die Datei: " + file + " existiert nicht!");
            }

        }
    }
}
