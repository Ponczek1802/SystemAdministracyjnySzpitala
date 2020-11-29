namespace Struktura.Klasa
{
    public abstract class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public uint PESEL { get; set; }
        public string NazwaUzytkownika { get; set; }
        public string Haslo { get; set; }

        public Pracownik(string a_Imie, string a_Nazwisko, uint a_PESEL, string a_NazwaUzytkownika, string a_Haslo)
        {
            Imie = a_Imie;
            Nazwisko = a_Nazwisko;
            PESEL = a_PESEL;
            NazwaUzytkownika = a_NazwaUzytkownika;
            Haslo = a_Haslo;
        }
    }
}
