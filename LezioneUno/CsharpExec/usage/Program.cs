using LezioneUno;

namespace CsharpExec.Usage
{

    // 1. Implementare utilizzando progetti differenti(1 singolo progetti), la classe Invoice e testarla utilizzando il metodo main.

    // namespace exercises.com.management
    // Invoice
    //  id - int
    //  internalRatio - long
    //  description - string
    //  amount - float
    //  print()

    // namespace exercises.com.usage
    // Program
    //  main()
    //   i1.print()
    //   ..

    //Effettuare il test creando 3 istanze differenti di Invoice, configurandole utilizzando id/description/amount differenti.Il valore di internalRatio non deve essere accessibile e deve essere generato automaticamente (monotonically increment) (utilizzare una funzione random - no) durante l'invocazione del metodo print(). Effettuare la stampa degli attributi id/internalRatio/description/amount fornendo il codice ad un metodo print.

    internal class Program
    {
        static void Main2(string[] args)
        {
            //Invoice i1 = new Invoice(1, "Description 1", 23.4f);
            //i1.print();
            //Invoice i2 = new Invoice(2, "Description 2", 25.2f);
            //i2.print();
            //Invoice i3 = new Invoice(3, "Description 3", 40.3f);
            //i3.print();

            Invoice2 i1 = new Invoice2(1, "Description 1", 23.4f);
            i1.id = Invoice2.genId();
            i1.print();
            Invoice2 i2 = new Invoice2(2, "Description 2", 25.2f);
            i2.id = Invoice2.genId();
            i2.print();
            Invoice2 i3 = new Invoice2(3, "Description 3", 40.3f);
            i3.id = Invoice2.genId();
            i3.print();

        }
    }
}