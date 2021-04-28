using System;

namespace Wouter_test01
{
    public class Reken
    {
        public void Vermenigvuldig(int factor1, int factor2)
        {
            Console.WriteLine($"{factor1} * {factor2} = {factor1 * factor2}");
        }
        public void TelOp(int factor1, int factor2)
        {
            Console.WriteLine($"{factor1} + {factor2} = {factor1 + factor2}");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            int factor1 = 10;
            int factor2 = 6;

            Reken oef1 = new Reken();
            oef1.Vermenigvuldig(factor1, factor2);
            oef1.TelOp(factor1, factor2);

            Reken oef2 = new Reken();
            oef2.TelOp(156, factor1);
            oef2.Vermenigvuldig(1240, factor2);
        }
    }
}
