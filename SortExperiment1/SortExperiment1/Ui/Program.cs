using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortExperiment1.Model;
using System.IO;
using System.Diagnostics;

namespace SortExperiment1.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            //Preparacion
            String dataPath = "../../../data/dataset/";
            string pathD = @"../../../data/tratamientos.csv";
            StreamWriter sw = new StreamWriter(pathD,true);
            StreamReader sr;
            string[] data;
            SortAlgorithm<int> algorithm = new SortAlgorithm<int>(true);
            //Read and save the datasets  in a int array.

            sr = new StreamReader(dataPath+"big.txt");
            data = sr.ReadLine().Split(',');
            int[] big = Array.ConvertAll(data, int.Parse);

            sr = new StreamReader(dataPath + "bigA.txt");
            data = sr.ReadLine().Split(',');
            int[] bigA = Array.ConvertAll(data, int.Parse);

            sr = new StreamReader(dataPath + "bigD.txt");
            data = sr.ReadLine().Split(',');
            int[] bigD = Array.ConvertAll(data, int.Parse);



            sr = new StreamReader(dataPath + "middle.txt");
            data = sr.ReadLine().Split(',');
            int[] middle = Array.ConvertAll(data, int.Parse);

            sr = new StreamReader(dataPath + "middleA.txt");
            data = sr.ReadLine().Split(',');
            int[] middleA = Array.ConvertAll(data, int.Parse);

            sr = new StreamReader(dataPath + "middleD.txt");
            data = sr.ReadLine().Split(',');
            int[] middleD = Array.ConvertAll(data, int.Parse);



            sr = new StreamReader(dataPath + "small.txt");
            data = sr.ReadLine().Split(',');
            int[] small = Array.ConvertAll(data, int.Parse);

            sr = new StreamReader(dataPath + "smallA.txt");
            data = sr.ReadLine().Split(',');
            int[] smallA = Array.ConvertAll(data, int.Parse);

            sr = new StreamReader(dataPath + "smallD.txt");
            data = sr.ReadLine().Split(',');
            int[] smallD = Array.ConvertAll(data, int.Parse);
            string value = "";
            for (int i = 1; i <=18; i++)
            {
                if (i != 18) value = value + "tratamiento#" + i + ',';
                else value = value + "tratamiento#" + i ;
            }
            sw.WriteLine(value);
            Stopwatch stopWatch = new Stopwatch();
            double time = 0;
            for (int i = 1; i <= 150; i++)
            {
                value = "";
                //Tratamiento #1
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.BubbleSort(smallA);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #2
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.BubbleSort(smallD);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #3
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.BubbleSort(small);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #4
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.BubbleSort(middleA);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #5
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.BubbleSort(middleD);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #6
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.BubbleSort(middle);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #7
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.BubbleSort(bigA);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #8
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.BubbleSort(bigD);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #9
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.BubbleSort(big);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #10
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.InsertionSort(smallA);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #11
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.InsertionSort(smallD);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";
                //Tratamiento #12
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.InsertionSort(small);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #13
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.InsertionSort(middleA);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #14
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.InsertionSort(middleD);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #15
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.InsertionSort(middle);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #16
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.InsertionSort(bigA);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #17
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.InsertionSort(bigD);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time + ",";

                //Tratamiento #18
                stopWatch = new Stopwatch();
                stopWatch.Start();
                algorithm.InsertionSort(big);
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                value = value + time;

                sw.WriteLine(value);
                Console.WriteLine("Current: " + i +"\n");
            }
            sr.Close();
            sw.Close();
            Console.ReadKey();
        }
    }
}
