using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
   
    
    abstract class BaseSorter
    {
        private ISwapper _swapper;
        public BaseSorter(ISwapper swapper)
        {
            _swapper = swapper;
        }


        public abstract void Sort(int[] array);

        public void printResult(SortingAlgorithm algorithm)
        {
            Console.WriteLine($"sorting done using {algorithm}, needed {_swapper.Swapped} swaps to sort the array");//interface maken
        }
    }
   
}
