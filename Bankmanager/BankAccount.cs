using System;
using System.Collections.Generic;
using System.Text;

namespace Bankmanager
{
    class BankAccount
    {

        public int Naamveld { get; set; }

        public double Bedrag { get; set; }

        public int Rekeningnummer { get; set; }

        // bepaald bedrag wordt vn de rekening verwijderd
        public int WithdrawFunds(double bedragToExtract)
        {
            if (Bedrag > bedragToExtract)
            {
                Bedrag = bedragToExtract;
                //double result = Bedrag - bedragToExtract;
                return Convert.ToInt32(Math.Round(Bedrag));
            }
            else
            {
                //return schulden

                Console.WriteLine("niet al het geld kon worden afgehaald. ");
                double afgehaald = Bedrag;
                Console.WriteLine($"We hebben {afgehaald} van de rekening kunnen halen.");
                Bedrag = 0;
                return Convert.ToInt32(Math.Round(Bedrag));
            }

        }
        //Payinfunds
        public void PayInFunds(double bedrag)
        {

        }


    }
}
