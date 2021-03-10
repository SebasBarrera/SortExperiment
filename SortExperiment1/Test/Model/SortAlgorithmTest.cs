using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortExperiment1.Model;
using System;

namespace Test.Model
{
    [TestClass]
    public class SortAlgorithmTest
    {
        private SortAlgorithm<int> asc;
        private SortAlgorithm<int> des;
        public int[] testArray;

        [TestInitialize]
        public void Initialize()
        {
            asc = new SortAlgorithm<int>(true);
            des = new SortAlgorithm<int>(false);
        }

        private void SetUp1()
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            testArray = A;
        }

        private void SetUp2()
        {
            int[] A = new int[10000];
            Random aleatorio = new Random();
            for (int i = 0; i < 10000; i++)
            {
                A[i] = aleatorio.Next(-50000, 50000);
            }
            testArray = A;
        }

        private void SetUp3()
        {
            int[] A = new int[50000];
            Random aleatorio = new Random();
            for (int i = 0; i < 50000; i++)
            {
                A[i] = aleatorio.Next(-5000000, 5000000);
            }
            testArray = A;
        }

        private void SetUp4()
        {
            int[] A = { 5, 9, 8, 7, 6, 10, 11, 12, 13, 19, 20, 21, 22, 23, 24, 13, 14, 16, 15, 18, 17, 25 };
            testArray = A;
        }

        private void SetUp5()
        {
            int[] A = { -3, -9, -7, -8, -1, 0, 1, 5, 8, 3, 9, 10, 11, 14, 15, 13, 12 };
            testArray = A;
        }

        private void SetUp6()
        {
            int[] A = { };
            testArray = A;
        }

        private void SetUp7()
        {
            int[] A = { 4 };
            testArray = A;
        }

        private void SetUp8()
        {
            int[] A = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            testArray = A;
        }

        [TestMethod]
        public void BubbleSortTest1()
        {
            SetUp1();
            int[] resultado = asc.BubbleSort(testArray);
            int[] esperado = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(esperado[i], resultado[i]);
            }

        }

        [TestMethod]
        public void BubbleSortTest2()
        {
            SetUp2();
            int[] resultado = asc.BubbleSort(testArray);
            for (int i = 0; i < resultado.Length - 1; i++)
            {
                Console.WriteLine("i");
                Assert.IsTrue(resultado[i] <= resultado[i + 1]);
            }
            Assert.IsTrue(resultado[resultado.Length - 2] <= resultado[resultado.Length - 1]);
        }

        [TestMethod]
        public void BubbleSortTest3()
        {
            SetUp3();
            int[] resultado = asc.BubbleSort(testArray);
            for (int i = 0; i < resultado.Length - 1; i++)
            {
                Assert.IsTrue(resultado[i] <= resultado[i + 1]);
            }
            Assert.IsTrue(resultado[resultado.Length - 2] <= resultado[resultado.Length - 1]);
        }

        [TestMethod]
        public void BubbleSortTest4()
        {
            SetUp2();
            int[] resultado = des.BubbleSort(testArray);
            for (int i = 0; i < resultado.Length - 1; i++)
            {
                Console.WriteLine("i");
                Assert.IsTrue(resultado[i] >= resultado[i + 1]);
            }
            Assert.IsTrue(resultado[resultado.Length - 2] >= resultado[resultado.Length - 1]);
        }

        [TestMethod]
        public void BubbleSortTest5()
        {
            SetUp3();
            int[] resultado = des.BubbleSort(testArray);
            for (int i = 0; i < resultado.Length - 1; i++)
            {
                Assert.IsTrue(resultado[i] >= resultado[i + 1]);
            }
            Assert.IsTrue(resultado[resultado.Length - 2] >= resultado[resultado.Length - 1]);
        }

        [TestMethod]
        public void BubbleSortTest6()
        {
            SetUp1();
            int[] resultado = des.BubbleSort(testArray);
            int[] esperado = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(esperado[i], resultado[i]);
            }
        }

        [TestMethod]
        public void BubbleSortTest7()
        {
            SetUp2();
        }

        [TestMethod]
        public void BubbleSortTest8()
        {
            SetUp3();
        }

        [TestMethod]
        public void BubbleSortTest9()
        {
            SetUp2();
        }

        [TestMethod]
        public void BubbleSortTest10()
        {
            SetUp3();
        }

        [TestMethod]
        public void BubbleSortTest11()
        {
            SetUp4();
        }

        [TestMethod]
        public void BubbleSortTest12()
        {
            SetUp5();
        }

        [TestMethod]
        public void BubbleSortTest13()
        {
            SetUp6();
        }

        [TestMethod]
        public void BubbleSortTest14()
        {
            SetUp7();
        }

        [TestMethod]
        public void BubbleSortTest15()
        {
            SetUp8();
        }

        [TestMethod]
        public void InsertionSortTest1()
        {
            SetUp1();
            int[] resultado = asc.InsertionSort(testArray);
            int[] esperado = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("" + i);
                Assert.AreEqual(esperado[i], resultado[i]);
            }
        }

        [TestMethod]
        public void InsertionSortTest2()
        { 
            SetUp2();
            int[] resultado = asc.InsertionSort(testArray);
            for (int i = 0; i < resultado.Length - 1; i++)
            {
                Assert.IsTrue(resultado[i] <= resultado[i + 1]);
            }
            Assert.IsTrue(resultado[resultado.Length - 2] <= resultado[resultado.Length - 1]);
        }

        [TestMethod]
        public void InsertionSortTest3()
        {
            SetUp3();
            int[] resultado = asc.InsertionSort(testArray);
            for (int i = 0; i < resultado.Length - 1; i++)
            {
                Assert.IsTrue(resultado[i] <= resultado[i + 1]);
            }
            Assert.IsTrue(resultado[resultado.Length - 2] <= resultado[resultado.Length - 1]);
        }

        [TestMethod]
        public void InsertionSortTest4()
        {
            SetUp2();
            int[] resultado = des.InsertionSort(testArray);
            for (int i = 0; i < resultado.Length - 1; i++)
            {
                Console.WriteLine("i");
                Assert.IsTrue(resultado[i] >= resultado[i + 1]);
            }
            Assert.IsTrue(resultado[resultado.Length - 2] >= resultado[resultado.Length - 1]);
        }

        [TestMethod]
        public void InsertionSortTest5()
        {
            SetUp3();
            int[] resultado = asc.InsertionSort(testArray);
            for (int i = 0; i < resultado.Length - 1; i++)
            {
                Assert.IsTrue(resultado[i] >= resultado[i + 1]);
            }
            Assert.IsTrue(resultado[resultado.Length - 2] >= resultado[resultado.Length - 1]);
        }

        [TestMethod]
        public void InsertionSortTest6()
        {
            SetUp3();
            int[] resultado = asc.InsertionSort(testArray);
            for (int i = 0; i < resultado.Length - 1; i++)
            {
                Assert.IsTrue(resultado[i] >= resultado[i + 1]);
            }
            Assert.IsTrue(resultado[resultado.Length - 2] >= resultado[resultado.Length - 1]);
        }

        [TestMethod]
        public void InsertionSortTest7()
        {
            SetUp2();
        }

        [TestMethod]
        public void InsertionSortTest8()
        {
            SetUp3();
        }

        [TestMethod]
        public void InsertionSortTest9()
        {
            SetUp2();
        }

        [TestMethod]
        public void InsertionSortTest10()
        {
            SetUp3();
        }

        [TestMethod]
        public void InsertionSortTest11()
        {
            SetUp4();
        }

        [TestMethod]
        public void InsertionSortTest12()
        {
            SetUp5();
        }

        [TestMethod]
        public void InsertionSortTest13()
        {
            SetUp6();
        }

        [TestMethod]
        public void InsertionSortTest14()
        {
            SetUp7();
        }

        [TestMethod]
        public void InsertionSortTest15()
        {
            SetUp8();
        }



    }
}
