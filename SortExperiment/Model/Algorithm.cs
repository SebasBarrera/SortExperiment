using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortExperiment.Model
{
    class Algorithm
    {
        private int[] array;

        public Algorithm(int length)
        {
            array = new int[length];
        }

        public int[] BubbleSort()
        {
            // complejidad O (n)^2
            int n = array.Length;

            for (int i = 0; i < n - 1; i++) // for 1 (n-1)
            {
                for (int j = 0; j < n - i - 1; j++) // for 2 ( n-2)
                {
                    if (array[j] > array[j + 1]) //(n-3)
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public int[] InsertionSort()
        {
            // complejidad O (n)^2
            int n = array.Length;
            //TODO
            return array;
        }
    }
}
