using System;

namespace CsharpExec
{
    public class Singleton
    {

        private static Singleton instance = null;

        private Singleton()
        {

        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public void FaiQualcosa()
        {
            Console.WriteLine("fa qualcosa");
        }

    }
    internal class TerzoEsercizio
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            s1.FaiQualcosa();
            Singleton s2 = Singleton.Instance();
            s2.FaiQualcosa();
            Singleton s3 = Singleton.Instance();
            s3.FaiQualcosa();

        }
    }
}
