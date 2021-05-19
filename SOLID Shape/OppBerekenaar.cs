using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Shape
{
    public class OppBerekenaar 
    {
        List<Shape> lijst;
        public void NewOppBerekenaar()
        {
            lijst = new List<Shape>();
        }
        public void VoegToe(Shape s)
        {
            lijst.Add(s);
        }
        private double Sum()
        {
            double total = 0;
            foreach (Shape s in lijst)
            {
                total += s.Opp();
            }
            return total;
        }
        public string Output()
        {
            return "<h1> Totale som = " + Sum() + " </h1> ";
        }
    }
}
