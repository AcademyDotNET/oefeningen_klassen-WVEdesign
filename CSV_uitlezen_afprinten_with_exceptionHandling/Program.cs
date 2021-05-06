using System;
using System.Diagnostics;

namespace CSV_uitlezen_afprinten_with_exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = "https://bit.ly/2tE4CB0"; //juiste URL: "https://bit.ly/2tE4CB0"
            string csv = " ";


            System.Net.WebClient wc = new System.Net.WebClient();
            try
            {
                 csv = wc.DownloadString(URL);
            }
            catch (Exception errorDownloadstring)
            {
                Debug.WriteLine(errorDownloadstring.Message);
                Console.WriteLine(errorDownloadstring.Message);
            }
               
            string[] splitted = csv.Split('\n');

            for (int i = 1; i < splitted.Length - 1; i++)
            {
                string[] lijnsplit = splitted[i].Split(',');
                Console.WriteLine("Data 1=" + lijnsplit[0]);
                Console.WriteLine("Data 2=" + lijnsplit[1]);
            }

            Console.WriteLine("Hello World!");
            try
            {
                CsvWriter.writeCsvNoStreamWriter();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Debug.WriteLine(error.Message);
            }
            
            try
            {
                CsvWriter.writeCsvStreamWriter();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Debug.WriteLine(error.Message);
            }
            
        }
    }

}
