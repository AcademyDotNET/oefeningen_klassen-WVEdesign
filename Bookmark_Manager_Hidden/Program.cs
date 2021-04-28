using System;
using System.Collections.Generic;

namespace Bookmark_Manager_Hidden
{
    class Program
    {
        enum Keuzes { List, Show, Edit, Delete }

        static void Main(string[] args)
        {
            List<HiddenBookMark> sites = VraagEnVulBookmarkList();
            Console.Clear();
            ToonHoofdMenu(sites);
        }

        private static void ToonHoofdMenu(List<HiddenBookMark> sites)
        {
            while (true)
            {
                Console.WriteLine("Wat wil je doen? 0=list,1=show, 2=edit, 3=remove");
                Keuzes inp = (Keuzes)Convert.ToInt32(Console.ReadLine());
                switch (inp)
                {
                    case Keuzes.List:
                        ShowAll(sites);
                        break;
                    case Keuzes.Show:
                        OpenSite(sites);
                        break;
                    case Keuzes.Edit:
                        EditSite(sites);
                        break;
                    case Keuzes.Delete:
                        RemoveSite(sites);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Druk op een toets om verder te gaan.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static List<HiddenBookMark> VraagEnVulBookmarkList()
        {
            Console.WriteLine("Geef je favoriete sites:");
            List<HiddenBookMark> sites = new List<HiddenBookMark>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Geef site {i} in:");
                Console.WriteLine("Naam?");
                string naam = Console.ReadLine();
                Console.WriteLine("URL?");
                string url = Console.ReadLine();

                HiddenBookMark siteToAdd = new HiddenBookMark()
                {
                    Naam = naam,
                    URL = url
                };
                sites.Add(siteToAdd);
            }

            return sites;
        }

        private static void RemoveSite(List<HiddenBookMark> sites)
        {
            int keuze = AskAction(sites, "verwijderen");
            sites.RemoveAt(keuze);
        }

        private static void EditSite(List<HiddenBookMark> sites)
        {
            int keuze = AskAction(sites, "editeren");
            Console.WriteLine("Geef nieuwe naam [leeglaten= niet veranderen]");
            string newna = Console.ReadLine();
            if (newna != "")
                sites[keuze].Naam = newna;

            Console.WriteLine("Geef nieuwe url [leeglaten= niet veranderen]");
            string newurl = Console.ReadLine();
            if (newurl != "")
                sites[keuze].URL = newurl;

        }

        private static void OpenSite(List<HiddenBookMark> sites)
        {
            int keuze = AskAction(sites, "openen");
            sites[keuze].OpenSite();
        }

        private static void ShowAll(List<HiddenBookMark> sites)
        {
            for (int i = 0; i < sites.Count; i++)
            {
                Console.WriteLine($"{i}.{sites[i].Naam} ({sites[i].URL})");
            }
        }

        private static int AskAction(List<HiddenBookMark> sites, string action)
        {
            Console.WriteLine($"Welke wil je {action}?");
            ShowAll(sites);
            int keuze = Convert.ToInt32(Console.ReadLine());
            return keuze;
        }
    }
}
