using System;
using System.Collections.Generic;

namespace GenericListTester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treintjes = new List<string>();
            treintjes.Add("Type 12 - Knapste stoom locomotief ever");
            treintjes.Add("37560 - Stoomlocomotief");
            treintjes.Add("37233 - Elektrische locomotief Serie 23");

            List<int> treintjesint = new List<int>();
            treintjesint.Add(1254);
            treintjesint.Add(258);
            treintjesint.Add(368);

            GenListEngin<int> m1 = new GenListEngin<int>(treintjesint);
            //Console.WriteLine(m1);

            GenListEngin<string> m2 = new GenListEngin<string>(treintjes);
            //Console.WriteLine(m2);

            m1.PrintList();
            m2.PrintList();

            m1.Add2List(58999);
            m2.Add2List("duikbril");

            m1.PrintList();
            m2.PrintList();

            m1.RemoveOfListIndex(2);
            m2.RemoveOfListIndex(1);

            m1.PrintList();
            m2.PrintList();


        }
    }
}
