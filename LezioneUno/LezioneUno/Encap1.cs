using System;

namespace LezioneUno
{

    // Encapsulation

    // 1. Class declaration
    class Car
    {
        // state
        public string oname;
        public int currSpeed;

        public static int counter = 0; // per tenere traccia di informazioni condivise, appartiene alla classe ,non all'oggetto.

        /*
         * c1 ------> [ currSpeed = 1234 ] 
         * c2 ------> [ currSpeed = 1234 ] counter
         */

        // A CUSTOM DEFAULT CONSTRUCTOR
        public Car() : this("Sandras", 100) // DRY violation : constructor chaining
        {
            Console.WriteLine("In constructor 1");
            //oname = "Sandras";
            //currSpeed = 100;

        }

        // CONSTRUCTOR OVERLOADING
        public Car(string oname, int currSpeed)
        {
            Console.WriteLine("In constructor 2");
            this.oname = oname;
            this.currSpeed = currSpeed;
            counter++;
            //Console.WriteLine("Istanze: " + counter);
        }

        // STATIC CONSTRUCTOR
        static Car()
        {
            counter = 6000;
        }

        // functionality: methodi per alterare i metodi.
        public void SpeedUp(int delta)
        {
            currSpeed += delta; //scoping
            //m1(); //OK
        }

        //Lambda method
        public void PrintState() => Console.WriteLine(oname + " " + currSpeed);

        public static void m1()
        {
            counter = 1234;
            Console.WriteLine("in M1");
            //SpeedUp(12); // KO
            //currSpeed = 12; // KO
        }
    }


    // optional arguments
    class MotoCycle
    {
        public MotoCycle(int intensity = 0, string name = "")
        {
            Console.WriteLine($"{intensity}, {name}");
        }
    }


    internal class Encap1
    {
        // C# managed language ==> Garbage Collector: fa in modo che non va in memory leak.
        // entrypoint
        static void Main1(string[] args)
        {
            // 2. Class usage
            //                         stack          heap
            Car c = new Car();      // c =======> [ oname | currSpeed | -- / -- ]
            // c variable referente
            // new operatore forte
            c.PrintState();
            c.oname = "Ford";
            c.currSpeed = 100;
            c.PrintState();
            c.SpeedUp(50);
            c.PrintState();

            // Chiamare un methodo statico


            Car c1 = new Car("Iyan", 200);
            c1.PrintState();

            Console.WriteLine(Car.counter);
            Car.m1();
            Console.WriteLine(Car.counter);

            //Optional arguments test
            MotoCycle mc = new MotoCycle();
            MotoCycle mc1 = new MotoCycle(name: "John", intensity: 250); // names notation
            MotoCycle mc2 = new MotoCycle(300, "John"); // positional notation

        }
    }
}