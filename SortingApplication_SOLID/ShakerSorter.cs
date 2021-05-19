using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class ShakerSorter: BaseSorter
    {
        private ISwapper _swapper;
        public ShakerSorter(ISwapper swapper) : base(swapper)
        {
            _swapper = swapper;
        }
        public override void Sort(int[] array)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        _swapper.Swap(i, i + 1, array);
                    }
                }

                if (!swapped) break;

                for (int i = array.Length - 2; i >= 0; --i)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        _swapper.Swap(i, i + 1, array);
                    }
                }
            }
        }
    }
}
