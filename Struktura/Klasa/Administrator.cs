using Struktura.Interfejs;

namespace Struktura.Klasa
{
    public class Administrator : Pracownik, IDyzur
    {
        public Administrator(string a_Imie, string a_Nazwisko, uint a_PESEL, string a_NazwaUzytkownika, string a_Haslo)
            : base(a_Imie, a_Nazwisko, a_PESEL, a_NazwaUzytkownika, a_Haslo)
        {
        }

        public void ListaDyzurow()
        {
            throw new System.NotImplementedException();
        }
    }
}
