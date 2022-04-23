using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Artikelverwaltung
{
    class Artikelverwaltung
    {
        public List<Artikel> ArtikelListe { get; set; }
        private string file = Directory.GetCurrentDirectory() + "\\artikel.json";


        public Artikelverwaltung() {
            ArtikelListe = new List<Artikel>();
        }

       

        public void add(Artikel art) {
           
                ArtikelListe.Add(art);
            
            
        }

        public void del(string artikelnummer) {
            if (ArtikelListe.Remove(getArtikel(artikelnummer)))
            {
                Console.WriteLine("Artikel erfolgreich gelöscht!");
            }
            else 
            {
                Console.WriteLine("Artikel nicht vorhanden!");
            }
        }

        public void update(Artikel art) {
            for (int i = 0; i<ArtikelListe.Count;i++)
            {
                if (ArtikelListe[i].Artikelnummer.Equals(art.Artikelnummer, StringComparison.OrdinalIgnoreCase))
                {
                    ArtikelListe[i] = art;
                }
            }
        }
        public Artikel getArtikel(string artikelnummer)
        {
            foreach (Artikel artikel in ArtikelListe) 
            {
                
                if (artikel.Artikelnummer.Equals(artikelnummer, StringComparison.OrdinalIgnoreCase))
                    return artikel;
                
            }
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
            string json = JsonSerializer.Serialize(ArtikelListe);
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
