using System;

namespace SOLID_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            int straalMaan = 1737;
            int straalAarde = 6371;
            
            Shape maan = new Circle(straalMaan);
            Shape aarde = new Circle(straalAarde);
            Shape blokhut = new Square(8);
            
            OppBerekenaar opb = new OppBerekenaar();
            opb.NewOppBerekenaar();

            opb.VoegToe(blokhut);
            Console.WriteLine(opb.Output());
            opb.VoegToe(maan);
            Console.WriteLine(opb.Output());
            opb.VoegToe(aarde);
            Console.WriteLine(opb.Output());
        }
    }
}
