using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortExperiment1.Model
{
    public class SortAlgorithm<T> where T: IComparable
    {
       
        private bool ascendencing { get; set; }
        public SortAlgorithm(bool ascendencing) 
        {
            this.ascendencing = ascendencing;
        }

        public T[] BubbleSort(T[] array)
        {
            int size = array.Length;
            T[] Bubble = array;

            for (int i = 0; i < size - 1; i++) 
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    bool change = ascendencing ? Bubble[j].CompareTo(Bubble[j + 1]) > 0 : Bubble[j].CompareTo(Bubble[j + 1]) < 0;
                    if (change) 
                    {
                        T temp = Bubble[j];
                        Bubble[j] = Bubble[j + 1];
                        Bubble[j + 1] = temp;
                    }
                }
            }
            return Bubble;
        }

        public T[] InsertionSort(T[] array)
        {
            int size = array.Length;
            T[] Insert = array;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    bool change = ascendencing ? Insert[j].CompareTo(Insert[j - 1]) < 0 : Insert[j].CompareTo(Insert[j - 1]) > 0;
                    if (change)
                    {
                        T temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return Insert;
        }
    }
}
