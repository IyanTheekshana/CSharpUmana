using System;

namespace LezioneUno
{
    public class TestArray1
    {
        static void SimpleArray()
        {
            int[] myInt = new int[3];

            //for (int i = 0; i < myInt.Length; i++)
            //{
            //    Console.WriteLine(myInt[i]);
            //}
            Console.WriteLine("------");
            foreach (int i in myInt)
            {
                //Console.WriteLine(i);
            }

            string[] strings = new string[20];
            string[] strings2 = new string[] { "Iyan", "a", "b", "c" };
            bool[] bools = { true, false, true };
            //Console.WriteLine(bools.Length);

            int input = 10;
            int[] myInt2 = new int[input];
            foreach (int i in myInt2)
            {
                //Console.WriteLine(i);
            }

            var a = new[] { 1, 2, 3, 4 };
            var b = new[] { 1, 1.2, 4, 5 };
            var c = new[] { "a", null, "b" };
            // var d = new[] { 1, "a", 3, false };

            object[] myObj = new object[4];
            Console.WriteLine(myObj[0]);
            myObj[0] = 10;
            myObj[1] = "a";
            myObj[2] = false;
            myObj[3] = 1.3;

            foreach (var i in myObj)
            {
                //Console.WriteLine($"Value: {i} - Type: {i.GetType()}");
                Console.WriteLine($"Value: {0} - Type: {0}", i, i.GetType());
            }

            // Multi dimentional array
            int[,] myMatrix = new int[3, 4]; // righe, colonne
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j]);
                }
                Console.WriteLine();
            }

            // Jagged array
            int[][] myJagArr = new int[4][];
            for (int i = 0; i < myJagArr.Length; i++)
            {
                myJagArr[i] = new int[i + 1];
            }

            for (int i = 0; i < myJagArr.Length; i++)
            {
                for (int j = 0; j < myJagArr[i].Length; j++)
                {
                    Console.Write(myJagArr[i][j]);
                }
                Console.WriteLine();
            }
        }

        static void ChangeArray(int[] a, int index)
        {
            a[index] = 1234;
        }

        static int[] getArray()
        {
            return null;
        }

        static void ArrFunc()
        {
            string[] mys = { "aa", "zz", "dd", "xx" };
            Array.Sort(mys);

            foreach (string s in mys)
            {
                Console.WriteLine(s);
            }

            Array.Reverse(mys);

            foreach (string s in mys)
            {
                Console.WriteLine(s);
            }

            Array.Clear(mys, 1, 2);
            foreach (string s in mys)
            {
                Console.WriteLine(s);
            }
        }

        static void Main123(string[] args)
        {
            //SimpleArray();

            int[] aa = { 1, 2, 3 }; // aa ------> |1,2,3| <------- a
            ChangeArray(aa, 2);

            //foreach (int i in aa)
            //{
            //    Console.WriteLine("{0}", i);
            //}

            ArrFunc();
        }
    }
}
