using System;

namespace CsharpExec
{
    internal class SommaEMedia
    {

        public static double SommaMedia(out double media, params double[] ins)
        {
            double somma = 0;
            for (int i = 0; i < ins.Length; i++)
            {
                somma += ins[i];
            }
            media = somma / ins.Length;
            return somma;
        }

        public static void SommaMedia(out double media, out double somma, params double[] ins)
        {
            somma = 0;
            for (int i = 0; i < ins.Length; i++)
            {
                somma += ins[i];
            }
            media = somma / ins.Length;

        }

        static void Main(string[] args)
        {
            double media;
            Console.WriteLine("Somma: " + SommaEMedia.SommaMedia(out media, 1, 2, 3, 4, 5));
            Console.WriteLine(media);

            double media1, somma1;
            SommaEMedia.SommaMedia(out media1, out somma1, 1, 2, 3, 4, 5);
            Console.WriteLine("Media: " + media1);
            Console.WriteLine("Somma: " + somma1);

        }

    }
}
