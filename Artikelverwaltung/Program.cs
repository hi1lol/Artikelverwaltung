using System;

namespace Artikelverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Artikelverwaltung av = new Artikelverwaltung();
            /*Artikel art1 = new Artikel("1", "Banane", "kg", 1, 1.0);
            Artikel art2 = new Artikel("2", "Apfel", "kg", 15, 1.50);
            Artikel art3 = new Artikel("3", "Birne", "kg", 100, 1.11);
            Artikel art4 = new Artikel("4", "Ananas", "kg", 169, 10.10);
            Artikel art5 = new Artikel("5", "Tomaten", "kg", 181, 1.20);
            av.add(art1);
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
                                if (av.getArtikel(tmp) != null) {
                                    Console.WriteLine("Artikelnummer ist bereits vorhanden!");
                                    continue;
                                }

                                artAdd.Artikelnummer = tmp;
                                break;
                            }catch (Exception)
                            {
                                Console.WriteLine("Artikelnummer darf nur aus Zahlen bestehen und nicht leer sein!");
                            }
                        }
                        Console.Write("Artikelbezeichnung eingeben: ");
                        artAdd.Artikelbezeichnung = Console.ReadLine();
                        Console.Write("Mengeneinheit eingeben: ");
                        artAdd.Mengeneinheit = Console.ReadLine();
                        while (true)
                        {
                            Console.Write("Menge eingeben: ");
                            string tmp = Console.ReadLine();
                            try
                            {
                                artAdd.Menge = int.Parse(tmp);
                                if (tmp == "")
                                    throw new Exception();
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Menge darf nur aus Zahlen bestehen und nicht leer sein!");
                            }
                        }
                        while (true)
                        {
                            Console.Write("Preis eingeben: ");
                            string tmp = Console.ReadLine();
                            try
                            {
                                artAdd.Preis = double.Parse(tmp);
                                if (tmp == "")
                                    throw new Exception();
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Preis darf nur aus Zahlen bestehen und nicht leer sein!");
                            }
                        }
                        av.add(artAdd);


                        break;
                    case 2:
                        while (true)
                        {
                            Console.Write("Artikelnummer eingeben: ");
                            string tmp = Console.ReadLine();
                            try
                            {
                                int.Parse(tmp);
                                if (tmp == "")
                                    throw new Exception();
                                

                                av.del(tmp);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Artikelnummer darf nur aus Zahlen bestehen und nicht leer sein!");
                            }
                        }

                        break;
                    case 3:
                        Artikel artmp = new Artikel();
                        while (true)
                        {
                            Console.Write("Artikelnummer eingeben: ");
                            string tmp = Console.ReadLine();
                            try
                            {
                                int.Parse(tmp);
                                if (tmp == "")
                                    throw new Exception();
                                artmp = av.getArtikel(tmp);
                                if (artmp == null)
                                {
                                    Console.WriteLine("Der Artikel existiert nicht!");
                                    continue;
                                }

                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Artikelnummer darf nur aus Zahlen bestehen und nicht leer sein!");
                            }
                        }

                        while (true)
                        {
                            Console.Write("Neue Menge eingeben: ");
                            string tmp = Console.ReadLine();
                            try
                            {
                                artmp.Menge = int.Parse(tmp);
                                if (tmp == "")
                                    throw new Exception();
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Menge darf nur aus Zahlen bestehen und nicht leer sein!");
                            }
                        }

                        av.update(artmp);

                        break;
                    case 4:
                        while (true)
                        {
                            Console.Write("Artikelnummer eingeben: ");
                            string tmp = Console.ReadLine();
                            try
                            {
                                int.Parse(tmp);
                                if (tmp == "")
                                    throw new Exception();
                                artmp = av.getArtikel(tmp);
                                if (artmp == null)
                                {
                                    Console.WriteLine("Der Artikel existiert nicht!");
                                    continue;
                                }

                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Artikelnummer darf nur aus Zahlen bestehen und nicht leer sein!");
                            }
                        }

                        while (true)
                        {
                            Console.Write("Neuer Preis eingeben: ");
                            string tmp = Console.ReadLine();
                            try
                            {
                                artmp.Preis = double.Parse(tmp);
                                if (tmp == "")
                                    throw new Exception();
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Preis darf nur aus Zahlen bestehen und nicht leer sein!");
                            }
                        }

                        av.update(artmp);
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
