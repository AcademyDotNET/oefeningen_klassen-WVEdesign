using System;
using System.Collections.Generic;

namespace Het_dierenrijk
{

    ////https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance

    class Program
    {
        static void Main(string[] args)
        {
            //Plaats deze dieren nu in een List<Animal> en kijk wat er gebeurt als je deze met een foreach aanroept om alle ToonInfo-methoden van ieder dier te gebruiken.

            var dierenLijst = new List<Animal>();

            dierenLijst.Add(new Animal() { Name = "tarantula", Beweegvoort = true });
            dierenLijst.Add(new Reptile() { Name = "varaan", AantalSchubben = 8655 });
            dierenLijst.Add(new Mammel() { Name = "walvis", Vegetarisch = false });

            foreach (var diertje in dierenLijst)
            {
                diertje.ToonInfo();
            }


        }
    }
}
