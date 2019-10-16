using System;

namespace Sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Totale speso? ");
            double totale = double.Parse(Console.ReadLine());
            double sconto;
            double scontato;
            if (totale <= 500)
            {
                sconto = totale / 100 * 10;
                scontato = totale - sconto;
                Console.WriteLine($"Lo sconto è di {sconto} euro e l'importo da pagare è {scontato} euro");
            }
            else if (totale > 500)
            {
                sconto = totale / 100 * 20;
                scontato = totale - sconto;
                Console.WriteLine($"Lo sconto è di {sconto} euro e l'importo da pagare è {scontato} euro");
            }
            Console.ReadLine();
        }
    }
}
