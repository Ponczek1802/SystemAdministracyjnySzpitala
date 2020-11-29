using Struktura.Interfejs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktura.Klasa
{
    public class Pielegniarka : Pracownik, IDyzur
    {
        public Pielegniarka(string a_Imie, string a_Nazwisko, uint a_PESEL, string a_NazwaUzytkownika, string a_Haslo)
            : base(a_Imie, a_Nazwisko, a_PESEL, a_NazwaUzytkownika, a_Haslo)
        {
        }

        public void ListaDyzurow()
        {
            throw new NotImplementedException();
        }
    }
}
