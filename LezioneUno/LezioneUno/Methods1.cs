using System;

namespace LezioneUno
{
    public class Invoice
    {
        public int id;
        public string desc;

        public Invoice(int id, string desc)
        {
            this.id = id;
            this.desc = desc;
        }
    }
    internal class Methods1
    {
        //1. Pascal case
        //2. Signature(firma) : AddTwoNumber(int x, int y). non c'è ne tipo di ritorno e visibilità
        public int AddTwoNumber(int x, int y)
        {
            return x + y;
        }

        // DEVE ESSERE UN METODO DI SONO UNA RIGA
        public int SubTwoNumbers(int x, int y) => x - y;

        public static void ChangeInvoice(Invoice i) // Pass by reference, viene passato per indirizzo
        {
            i.desc = "New Description";
        }

        // 🛑 out modifier
        public static void AddTwoNumber2(int x, int y, out int res)
        {
            res = x + y;
        }

        public static bool AddTwoNumber3(int x, int y, out int res)
        {
            res = x + y;

            if ((x + y) < 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Fill(out int a, out string b, out bool c)
        {
            a = 9; b = "Da pagare"; c = false;
        }

        // 🛑 ref modifier: passare per copia
        public static int AddTwoNumber4(ref int x, ref int y)
        {
            x = 90;
            return x + y;
        }

        // 🛑 in modifier - (immutability)
        public static int AddTwoNumber5(in int x, in int y)
        {
            // x = 90; // Non permette di modificare , solo di lettura. (readonly)
            return x + y;
        }

        //  🛑 params modifier 
        public static int AddNumberUnk(int[] p)
        {
            int sum = 0;
            for (int i = 0; i < p.Length; i++)
            {
                sum += p[i];
            }
            return sum;
        }


        public static int AddNumberUnk2(params int[] p)
        {
            int sum = 0;
            for (int i = 0; i < p.Length; i++)
            {
                sum += p[i];
            }
            return sum;
        }

        public static int AddNumberUnk3(int a, params int[] p) // params deve essere l'ultimo 
        {
            int sum = 0;
            for (int i = 0; i < p.Length; i++)
            {
                sum += p[i];
            }
            return sum;
        }

        // 🛑 optional parameters
        public static void PrintValue(float salary, string owner = "Iyan", string company = "AAA")
        {
            Console.WriteLine($"{owner} has {salary}. Works for {company}");
        }


        // 🛑 Method overloading : numero e/o argomenti di input sono diversi (la firma deve essere diversa)
        public static int Multiply(int x, int y)
        {
            Console.WriteLine("In Int " + x * y);
            return x * y;
        }

        public static long Multiply(long x, long y)
        {
            Console.WriteLine("In Ling " + x * y);
            return x * y;
        }

        public static double Multiply(double x, double y) // overloaded con tipo di dati diversi
        {
            Console.WriteLine("In Double " + x * y);
            return x * y;
        }

        public static int Multiply(int x, int y, int z) // overloaded con parametri diversi di numero.
        {
            return x * y * z;
        }


        static void Main(string[] args)
        {
            //Methods1 m1 = new Methods1();
            //Console.WriteLine(m1.AddTwoNumber(1, 2));
            //Console.WriteLine(m1.SubTwoNumbers(3, 2));

            //Invoice i1 = new Invoice(1, "desc1");
            //Methods1.ChangeInvoice(i1);
            //Console.WriteLine(i1.id + " | " + i1.desc);


            //int ans;
            //Methods1.AddTwoNumber2(3, 5, out ans);
            //Console.WriteLine(ans);

            //int ans1;
            //Console.WriteLine(Methods1.AddTwoNumber3(30, 1, out ans1));
            //Console.WriteLine(ans1);

            //int a = 5, b = 4;
            //Console.WriteLine("Inizialment: " + a);
            //Methods1.AddTwoNumber4(ref a, ref b);
            //Console.WriteLine("Successivament: " + a);

            //int[] arrValue = { 1, 2, 3, 5 };
            //Console.WriteLine("Somma elimenti: " + Methods1.AddNumberUnk(arrValue));
            //Console.WriteLine("Somma elimenti 2: " + Methods1.AddNumberUnk2(1, 2, 3, 5));
            //Console.WriteLine("Somma elimenti 3: " + Methods1.AddNumberUnk3(1, 2, 3, 5));

            //Methods1.PrintValue(23.4f);
            //Methods1.PrintValue(23.4f, "Theekshana"); // positional notaion
            //Methods1.PrintValue(23.4f, company: "WWW"); // mixed notation
            //Methods1.PrintValue(salary: 23.4f, company: "WWW"); // mixed notation

            Methods1.Multiply(10, 10);
            Methods1.Multiply(10, 10L);
            Methods1.Multiply(10.0, 10L);

        }
    }
}
