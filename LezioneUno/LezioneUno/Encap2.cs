namespace LezioneUno
{
    public class Encap2
    {
        //public -> no access restrictions.
        public int a;

        //private -> accessed only by declaring class
        private int b;

        //protected -> accessible in case of inheritance (favorisce eredarieta)
        protected int c;

        //internal -> project level
        internal int d;

        //protected + internal ->  direct instance only in project ,  inheritance out project
        protected internal int e;


    }

    /* 
     * 4 casi di accessibilità:
     * instanza stesso progetto
     * eredarieta stesso progetto
     * instanza diverso progetto
     * eredarieta diverso progetto
     * 
     */

    class Test2 : Encap2
    {
        void m1()
        {
            a = 1;
            c = 2;
            e = 3;
        }
    }
    public class Test
    {
        static void Main2(string[] args)
        {
            Encap2 e2 = new Encap2();
            e2.a = 1;
            e2.d = 2;
            e2.e = 3;
        }
    }


    //default access modifiers
    class Text3 // implicitly internal
    {
        int a; // private
        void m1() { } // private
    }
}
