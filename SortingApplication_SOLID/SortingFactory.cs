using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class SortingFactory
    {

        public BaseSorter Create(SortingAlgorithm algorithm, ISwapper swapper)
        {
            try
            {
                switch (algorithm)
                {
                    case SortingAlgorithm.BubbleSort:
                        return new BubbleSorter(swapper);
                        
                    case SortingAlgorithm.ShakerSort:
                        return new ShakerSorter(swapper);
                        
                    case SortingAlgorithm.QuickSort:
                        return new QuickSorter(swapper);
                        
                    default:
                        return null;
                }
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
