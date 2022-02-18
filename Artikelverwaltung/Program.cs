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
            Artikel art = new Artikel("05477855","Banane","kg",1,1.0);
            av.add(art);
            Console.WriteLine(JsonSerializer.Serialize(av));
            

        }
    }
}
