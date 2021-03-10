using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortExperiment1.Model;

namespace SortExperiment1.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortAlgorithm<int> sortAlgorithm = new SortAlgorithm<int>(false);
            int[] array = { 1, 3, 1, 5, 2, 8, 12, 0 };
            int[] arrayS = sortAlgorithm.InsertionSort(array);
            for(int i = 0; i< arrayS.Length; i++)
            {
                Console.WriteLine(arrayS[i]);
            }
            Console.ReadKey();
        }
    }
}
