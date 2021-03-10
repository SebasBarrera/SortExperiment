using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortExperiment1.Model
{
    public class SortAlgorithm
    {
        private int[] A;

        public SortAlgorithm(int length)
        {
            A = new int[length];
        }

        public int[] BubbleSort()
        {
            // complejidad O (n)^2
            int n = A.Length;
            int[] Bubble = A;
            for (int i = 0; i < n - 1; i++) // for 1 (n-1)
            {
                for (int j = 0; j < n - i - 1; j++) // for 2 (n-2)
                {
                    if (Bubble[j] > Bubble[j + 1]) // (n-3)
                    {
                        int temp = Bubble[j];
                        Bubble[j] = Bubble[j + 1];
                        Bubble[j + 1] = temp;
                    }
                }
            }
            return Bubble;
        }

        public int[] InsertionSort()
        {
            int n = A.Length;
            int[] Insert = A;


            return Insert;
        }
    }
}
