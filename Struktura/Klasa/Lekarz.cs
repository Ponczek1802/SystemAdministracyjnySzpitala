using Struktura.Enum;

namespace Struktura.Klasa
{
    public class Lekarz : Pielegniarka
    {
        public Specjalizacja Specjalizacja { get; }

        public uint PWZ { get; }

        public Lekarz(Specjalizacja a_Specjalizacja, uint a_PWZ, string a_Imie, string a_Nazwisko, uint a_PESEL, string a_NazwaUzytkownika, string a_Haslo)
            : base(a_Imie, a_Nazwisko, a_PESEL, a_NazwaUzytkownika, a_Haslo)
        {
            Specjalizacja = a_Specjalizacja;
            PWZ = a_PWZ;
        }
    }
}
