using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Artikelverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Artikelverwaltung av = new Artikelverwaltung();
            Artikel art1 = new Artikel("05477855", "Banane", "kg", 1, 1.0);
            Artikel art2 = new Artikel("05477855", "Apfel", "kg", 1, 1.0);
            Artikel art3 = new Artikel("05477857", "Birne", "kg", 1, 1.0);
            Artikel art4 = new Artikel("05477858", "Ananas", "kg", 1, 1.0);
            Artikel art5 = new Artikel("05477859", "Tomaten", "kg", 1, 1.0);
            /*av.add(art1);
            av.add(art2);
            av.add(art3);
            av.add(art4);
            av.add(art5);*/
            while (true)
            {
                int inpt;
                while (true)
                {
                    Console.WriteLine("Artikelverwaltungs Menu:");
                    Console.WriteLine("1. Artikel hinzufügen");
                    Console.WriteLine("2. Artikel löschen");
                    Console.WriteLine("3. Artikel Menge ändern");
                    Console.WriteLine("4. Artikel Preis ändern");
                    Console.WriteLine("5. Lager anzeigen");
                    Console.WriteLine("6. Lager Gesammtwert anzeigen");
                    Console.WriteLine("7. Lager Speichern");
                    Console.WriteLine("8. Lager Laden");
                    Console.WriteLine("9. Beenden");
                    
                    try
                    {
                        inpt = int.Parse(Console.ReadLine());
                        if (inpt < 1 || inpt > 9)
                            throw new Exception();
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Bitte eine Zahl von 1-9 eingeben!");
                    }
                }
                switch (inpt)
                {
                    case 1:
                        Artikel artAdd = new Artikel();
                        while (true)
                        {
                            Console.Write("Artikelnummer eingeben: ");
                            string tmp = Console.ReadLine();
                            try
                            {
                                int.Parse(tmp);
                                if(tmp =="")
                                    throw new Exception();
                                artAdd.Artikelnummer = tmp;
                            }catch (Exception)
                            {
                                Console.WriteLine("Artikelnummer darf nur aus Zahlen bestehen und nicht leer sein!");
                            }
                        }

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Artikel:");
                        int i = 1;
                        foreach (Artikel art in av.getAllArtikel())
                        {
                            Console.WriteLine(i+": "+ art.ToString());
                            i++;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Der Lagerbestand ist: "+ av.getWert()+" Euro wert.");
                        break;
                    case 7:
                        av.save();
                        break;
                    case 8:
                        av.load();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;

                }
            }
        }
        
    }
}
