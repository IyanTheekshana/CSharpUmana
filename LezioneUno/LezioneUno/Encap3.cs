using System;

namespace LezioneUno
{
    // properties
    public class Book
    {
        //field data
        private int numberOfPages;

        // Accessor methods


        // 1. Getter/Setter java style
        public int GetNumP()
        {
            return numberOfPages;
        }

        public void SetNumP(int p)
        {
            if (p <= 0 || p >= 300)
            {
                return;
            }
            numberOfPages = p;
        }



    }


    class Employee
    {
        private string _empname;
        private int _empId;

        //2. Getter/Setter c# style
        public string Name
        {
            get
            {
                //Console.WriteLine("In get");
                return _empname;
            }
            set
            {
                //Console.WriteLine("In set");
                if (value.Length > 15)
                {
                    Console.WriteLine("Non può contenere più di 15 caratteri");
                }
                else
                {
                    _empname = value;
                }
            }
        }

        // readonly
        public int Id
        {
            get
            {
                return _empId;
            }
        }

    }

    class SavingAccount
    {

        public string Oname { get; set; } // Automatic property

        // read-only automatic property
        public int MyV { get; }

        // write-only automatic property - ERROR on AUTOMATIC PROPERTY
        //public int MyV2 { set; }

        //..
        private static double _currentInterestRate = 0.04;

        //static property
        public static double InterstRate
        {
            get { return _currentInterestRate; }
            set { _currentInterestRate = value; }
        }
    }


    class Garage
    {
        // Assegnare il valore per Automatic property
        public int NumOfCars { get; set; } = 1;

        // has-a
        public Car MyAuto { get; set; } = new Car();


        public Garage()
        {

        }
        public Garage(Car c, int number)
        {
            MyAuto = c;
            NumOfCars = number;
        }


    }

    class Test3
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.SetNumP(20);
            Console.WriteLine(b.GetNumP());

            Employee e = new Employee();
            e.Name = "Iyan";
            Console.WriteLine(e.Name);

            SavingAccount.InterstRate = 2;
            SavingAccount s1 = new SavingAccount();
            s1.Oname = "aaa";
            Console.WriteLine(s1.Oname);
        }
    }

}
