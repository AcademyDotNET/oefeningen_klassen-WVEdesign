﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class Swapper:ISwapper
    {
        private int swapped = 0;

        public int Swapped { get => swapped; set => swapped=value; }

        public void Swap(int index1, int index2, int[] array)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            swapped++;
        }

    }
}
