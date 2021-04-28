using System;

namespace Bookmark_Manager_Hidden
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maak een "bookmark manager".Deze tool zal in de console aan de gebruiker 5 favoriete sites vragen: naam en url.
            //Vervolgens zal de tool alle sites in een lijst tonen met een nummer voor.De gebruiker kan dan de nummer intypen en 
            //de tool zal automatisch de site in de browser openen.

            //Je opdracht:  (https://apwt.gitbook.io/ziescherp-oefeningen/zie-scherper-oefeningen-semester-2/h4-arrays-en-klassen/opl_practica3 )

            //Maak een array waarin je 5 bookmark objecten kan plaatsen.
            //Vul de applicatie aan zodat de gebruiker: een bestaand bookmark kan verwijderen en een bestaand bookmark kan aanpassen


            BookMark u = new BookMark();
            u.Naam = "Windows";
            u.URL = "www.ontknoping.be";
            u.OpenSite();
        }
    }
}
