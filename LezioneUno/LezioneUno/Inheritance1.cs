using System;

namespace LezioneUno
{

    // sealed non ammette eredarietà, lo blocca
    sealed class Parent0
    {

    }

    // superclass / parent / base
    class Parent
    {
        public int budget = 1200;
        public Parent(int a)
        {
            Console.WriteLine("Constructor Parent");
            budget += a;
        }


        private void m0()
        {
            Console.WriteLine("in M0() - parent");
        }
        public void m1()
        {
            Console.WriteLine("in M1() - parent");
        }

        // dichiaro virtual per dare accesso al figlio di fare override
        public virtual void m2()
        {
            //..
            Console.WriteLine("in M2() - parent");
        }
    }

    // subclass / child

    // is-a
    // Mono inheritance
    class Child : Parent
    {
        public Child(int a) : base(a) // base manda input al costruttore di Parent
        {
            Console.WriteLine("Constructor Child");
        }
        // override
        public override sealed void m2()
        {
            // base.m2(); // permette di ereditare le proprieta e methodi dal m2 di Parent
            Console.WriteLine("in M2() - child");
        }

        public void m3()
        {
            Console.WriteLine("in M3() - child " + budget);
        }

        public override string ToString()
        {
            return "Budget " + budget;
        }
    }

    //class Nipote : Child
    //{
    //    // non può essere override perchè è sigillato.
    //    //public override void m2(){  }
    //}

    abstract class Vehicle
    {

    }

    class Truck : Vehicle { }

    internal class Inheritance1
    {
        static void Main1000(string[] args)
        {
            Child c1 = new Child(20); // Quando istanzi una classe figlia viene eredaritato tutta la gerarchia di class Padre
            c1.m1();
            c1.m2();
            c1.m3();

            Console.WriteLine(c1);


            /*
             *              Object
             *                ^
             *                |
             *              Parent
             *                ^
             *           <____|____>
             *      Child1         Child2
             *        ^
             *        |
             *     SubChild
             */

        }
    }
}
