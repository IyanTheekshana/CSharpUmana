using System;

namespace CsharpExec
{
    public class Singleton
    {

        private static Singleton _instance = null;
        public static int maxInstances = 1;
        private static int _counter = 0;

        private Singleton()
        {

        }

        public static Singleton Instance()
        {
            if (_counter++ < maxInstances)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public void FaiQualcosa()
        {
            Console.WriteLine("fa qualcosa");
        }

    }
    internal class TerzoEsercizio
    {
        static void Main3(string[] args)
        {
            Singleton.maxInstances = 2;
            Singleton s1 = Singleton.Instance();
            s1.FaiQualcosa();
            Singleton s2 = Singleton.Instance();
            s2.FaiQualcosa();
            Singleton s3 = Singleton.Instance();
            s3.FaiQualcosa();


            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 == s3);
            Console.WriteLine(s2 == s3);
        }
    }
}
