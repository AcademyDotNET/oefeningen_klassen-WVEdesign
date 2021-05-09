using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Bookmark_Manager_Hidden
{
    class BookMark
    {
        public string Naam { get; set; }
        public string URL { get; set; }
        public void OpenSite()
        {
            try
            {
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", URL);  //Voeg bovenaan using System.Diagnostics; toe


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
