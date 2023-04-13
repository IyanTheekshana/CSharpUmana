using System;

namespace CsharpExec
{
    public class Person
    {
        public int id;
        public string name;

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return "Id: " + id + " Name: " + name;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (obj is Person p)
            {
                return this.id == p.id && this.name.Equals(p.name);
            }
            return false;
        }


    }
    abstract class Employee20 : Person
    {

        public float payh;
        public int numh;

        public Employee20(int id, string name, float payh, int numh) : base(id, name)
        {
            this.payh = payh;
            this.numh = numh;
        }

        public virtual double calcSal()
        {
            return payh * numh;
        }

    }

    sealed class EmpTD20 : Employee20
    {
        public EmpTD20(int id, string name, float payh, int numh) : base(id, name, payh, numh)
        {

        }
        public override double calcSal()
        {
            return base.calcSal();
        }

        public void impMethod()
        {
            Console.WriteLine("impMethod executed");
        }



        public override string ToString()
        {
            return "Salario mensile: " + calcSal();
        }


    }

    sealed class EmpTI20 : Employee20
    {
        private float rit;

        public EmpTI20(int id, string name, float payh, int numh, float rit) : base(id, name, payh, numh)
        {
            this.rit = rit;
        }
        public override double calcSal()
        {
            return base.calcSal() * rit;
        }

        public override string ToString()
        {
            return "Salario mensile: " + calcSal();
        }


    }

    internal class EmpolyeePayment
    {

        static void Main12(string[] args)
        {

            EmpTD20 etd1 = new EmpTD20(1, "iyan", 10, 4);
            EmpTD20 etd2 = new EmpTD20(2, "iyan", 10, 4);
            Console.WriteLine(etd1);

            EmpTI20 eti1 = new EmpTI20(2, "silva", 11, 6, 1);

            Console.WriteLine(eti1);

            Console.WriteLine(etd1.Equals(etd2));

            Person p1 = new Person(1, "a");
            Console.WriteLine(p1);

            Person p2 = new Person(1, "a");
            Console.WriteLine(p2);

            Console.WriteLine(p1.Equals(p2));

        }
    }
}
