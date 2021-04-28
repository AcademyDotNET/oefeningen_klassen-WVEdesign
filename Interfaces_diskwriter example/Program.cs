using System;

namespace Interfaces_diskwriter_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Toch nog voorbeeld? Beeld je in dat je een complexe klasse DiskWriter hebt die je programma gebruikt om data van en 
            //    naar de harde schijf te schrijven.De klasse implementeert een interface IData die twee methoden heeft(ReadData() en WriteData). 
            //Als je later beslist om je data naar een online server te schrijven en niet naar de harde schijf, dan kan je gewoon die 
            //klasse schrijven(bv.InternetWriter) en vervolgens ook de IData interface laten implementeren.Al je andere code moet dan niet aangepast worden! 
            //Ze(je andere klassen) kunnen gewoon blijven zeggen ReadData en WriteData en weten misschien zelfs niet dat hun data niet meer naar de HD maar 
            //naar het internet wordt gestuurd.Mooi toch!

            //oude manier:
            diskwriter schrijverke1 = new diskwriter();
            InternetWriter schrijverke2 = new InternetWriter();

            //nieuwe & betere manier met 'I'nterfaces:
            IData schrijver1 = new diskwriter();
            IData schrijver2 = new InternetWriter();
        }
    }
}
