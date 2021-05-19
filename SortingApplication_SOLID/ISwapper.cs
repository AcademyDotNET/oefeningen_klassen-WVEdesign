using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    public interface ISwapper
    {
        int Swapped { get; set; }
        void Swap(int index1, int index2, int[] array);
    }
}
