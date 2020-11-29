using Struktura.Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktura
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik pracownik = new Lekarz(Enum.Specjalizacja.Neurolog, 123, "dsad", "asdas", 1, "da", "dsad");
            
            Console.ReadKey();
        }
    }
}
