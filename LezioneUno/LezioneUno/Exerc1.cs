using System;

namespace LezioneUno
{
    public class Invoice2
    {
        public int id;
        private static long internalRatio;
        private string description;
        private float amount;
        private static int internalId;


        public Invoice2(int id, string description, float amount)
        {
            this.id = id;
            this.description = description;
            this.amount = amount;
            internalRatio++;
        }


        public static int genId()
        {
            return internalId++;
        }


        public void print()
        {
            Console.WriteLine(id + "/" + internalRatio + "/" + description + "/" + amount);
        }
    }
}
