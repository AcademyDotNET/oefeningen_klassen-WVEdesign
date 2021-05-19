using System;

namespace UML2code_car_boat_Compositie
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://learn.dotnetacademy.be/unit/view/id:6719
            // http://www.jot.fm/issues/issue_2004_11/column5/



            //Car ford = new Car();
            //ford.Name = "Mondeo";
            //ford.MyWheels.Aantal = 4;
            //ford.MyEngins.Aantal = 1;

            Boat blusboot = new Boat();
            blusboot.Name = "Smokey";
            blusboot.MyPropellers[0].Kleur = "black";
            blusboot.MyPropellers[1].Kleur = "red";

            Console.WriteLine($"{blusboot.Name} + {blusboot.MyPropellers[0].Kleur}");

            //Engine V8 = new Engine();
            //V8.Name = "Hemi SRT Hellcat";
            //V8.MyCrankshaft.Aantal = 1;
            //V8.MyPistons.Aantal = 8;

            //Engine V12 = new Engine();
            //V12.Name = "Craig-Dörwald";
            //V12.MyCrankshaft.Aantal = 1;
            //V12.MyPistons.Aantal = 12;




            Console.WriteLine("Hello World!");
        }
    }
}
