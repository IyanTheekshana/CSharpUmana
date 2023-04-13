using System;

namespace LezioneUno
{
    class Manager
    {
        public virtual void m0()
        {
            Console.WriteLine("m0 chiamato");
        }
    }

    class Emp : Manager
    {
        public int a;
        public void m1()
        {
            Console.WriteLine("m1 chiamato");
        }
    }

    class Emp1 : Manager
    {
        public int b;
        public void m2()
        {
            Console.WriteLine("m2 chiamato");
        }

        public override void m0()
        {
            Console.WriteLine("m0 override");
        }
    }

    class General
    {

    }
    internal class Inheritance2
    {
        // test before cast
        static void mPolim(Manager obj)
        {
            obj.m0();

            /*
            // is
            if (obj is Emp e)
            {
                Console.WriteLine("o is Emp");
                Emp tmp = (Emp)o;
                tmo.m1();

                //((Emp)obj).m1(); // explicit cast
              
            }
            else
            {
                Console.WriteLine("o is Emp1");
                ((Emp1)obj).m2(); // explicit cast
            }
            */

            Emp k = obj as Emp;
            if (k == null)
            {
                Console.WriteLine("Not an EMP");
            }
            else
            {
                Console.WriteLine("An EMP");
                k.m0();
            }
        }

        static void Main12(string[] args)
        {
            Emp e = new Emp();
            e.a = 1;


            // narrow cast - non si può
            // Emp e1 = new Object();

            // wide cast
            object o = new Emp();
            // mPolim(e);

            Emp ee = new Emp();
            Emp1 ee1 = new Emp1();

            mPolim(ee);
            mPolim(ee1);
        }
    }
}
