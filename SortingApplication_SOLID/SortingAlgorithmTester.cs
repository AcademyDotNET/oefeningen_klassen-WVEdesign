using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    public enum SortingAlgorithm
    {
        BubbleSort,
        ShakerSort,
        QuickSort
    }
    class SortingAlgorithmTester
    {

        public void Test()
        {
            SortingFactory sortingFactory = new SortingFactory();
            ISwapper swapper = new Swapper();
            var values = (SortingAlgorithm[])Enum.GetValues(typeof(SortingAlgorithm));
            foreach (var algorithm in values)
            {
                //swapped = 0;
                int[] array = { 88, 12, 55, 105, 48, 84, 66, 35, 57, 89, 74, 106, 200, 541, 1, 9, 7, 55, 405, 13 };
                BaseSorter sorter = sortingFactory.Create(algorithm, swapper);
                sorter.Sort(array);//sort+print nok
                sorter.printResult(algorithm);
            }

            Console.ReadKey();
        }
    }
}
