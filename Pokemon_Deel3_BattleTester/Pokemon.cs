using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Deel1_3_BattleTester
{
    class Pokemon
    {
        //HP_Base
        //Attack_Base
        //Defense_Base
        //SpecialAttack_Base
        //SpecialDefense_Base
        //Speed_Base

        //z’n naam (string), type (string, bv. "grass & poison") en nummer (int), maak hiervoor auto properties aan.
        //Auto properties (prop-tab-tab)
        public string Naam { get; set; }
        public string Type { get; set; }
        public int Nummer { get; set; }

        private int hitPoints;
        private int attack;
        private int defence;
        private int specialAttack;
        private int specialDefense;
        private int speed;

        private int level;
        //Voeg 2 read-only properties toe(enkel get, géén set) genaamd "Average" en "Total":
        //De Average-property geeft het gemiddelde van de 6 base-stats terug, dus (HP_Base + Attack_Base + Defense_Base + SpAttack_Base + S
        //    pDefense_Base + Speed_Base)/6.

        //De Total-property geeft de som terug van de 6 basestats.Daar de base stats niet evolueren met het level veranderen dus Average en 
        //    Total ook niet van zodra de base-stats werden ingesteld, toch mag je beide statistieken steeds herberekenen in de get.

        public double Average
        {
            get
            {
                return (HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base) / 6;
                // == return Total /6;
            }

        }
        public int Total
        {
            get
            {
                return HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base;
            }
        }


        public int HP_Base
        {
            get
            {
                return hitPoints;
            }
            set
            {
                hitPoints = value;
            }
        }
        public int Attack_Base
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }
        public int Defense_Base
        {
            get
            {
                return defence;
            }
            set
            {
                defence = value;
            }
        }
        public int SpecialAttack_Base
        {
            get
            {
                return specialAttack;
            }
            set
            {
                specialAttack = value;
            }
        }
        public int SpecialDefense_Base
        {
            get
            {
                return specialDefense;
            }
            set
            {
                specialDefense = value;
            }
        }
        public int Speed_Base
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        //Voeg een fullproperty Level toe(type int). Deze heeft een public get, maar een private setter.
        public int Level
        {
            get
            {
                return level;
            }
            private set
            {
                level = value;
            }
        }
        //Voeg een read-only property HP_Full toe om de maximum health voor te stellen.
        //    Deze wordt berekend als volgt: (((HP_Base + 50) * Level) / 50) + 10 wanneer de get wordt aangeroepen.
        public double HP_FULL
        {
            get
            {
                return (((HP_Base + 50) * Level) / 50) + 10;
            }
        }
        //Voeg voor iedere base-stat een XX_Full readonly property toe(int). Dus Defense_Full, Speed_Full, etc. Ook deze properties zijn readonly. 
        // Deze stats worden berekend als volgt: ((stat_Base* Level) / 50 ) + 5. 
        //    Attack_Full bijvoorbeeld wordt dus berekend als: ((Attack_Base* Level) / 50) + 5
        public int Attack_Full
        {
            get
            {
                return ((Attack_Base * Level) / 50) + 5;
            }
        }
        public int Defence_Full
        {
            get
            {
                return ((Defense_Base * Level) / 50) + 5;
            }
        }
        public int SpecialAttack_Full
        {
            get
            {
                return ((SpecialAttack_Base * Level) / 50) + 5;
            }
        }
        public int SpecialDefence_Full
        {
            get
            {
                return ((SpecialDefense_Base * Level) / 50) + 5;
            }
        }
        public int Speed_Full
        {
            get
            {
                return ((Speed_Base * Level) / 50) + 5;
            }
        }


        public void VerhoogLevel()
        {
            //level ++;   dit is de rechtsstreekse variabelen, niet veilig om rechtsstreeks aan te spreken, daarom Level met een hoofdletter
            Level++;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Naam} (level {Level})");
            Console.WriteLine("Base stats:");
            Console.WriteLine($"* Health = {HP_Base}");
            Console.WriteLine($"* Speed = {Speed_Base}");
            Console.WriteLine("Full stats:");
            Console.WriteLine($"* Health = {HP_FULL}");
        }
    }
}
