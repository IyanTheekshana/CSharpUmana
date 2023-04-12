using System;

namespace CsharpExec.management
{
    public class Invoice
    {

        public int id;
        private static long internalRatio;
        public string description;
        public float amount;

        public Invoice(int id, string description, float amount)
        {
            this.id = id;
            this.description = description;
            this.amount = amount;
            internalRatio++;
        }

        public void print()
        {
            Console.WriteLine(id + "/" + internalRatio + "/" + description + "/" + amount);
        }
    }
}
