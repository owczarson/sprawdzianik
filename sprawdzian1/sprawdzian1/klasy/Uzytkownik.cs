public abstract class Uzytkownik
{
    public string imie;
    public string nazwisko;
    public string login;
    public string haslo;



    public Uzytkownik(string imie, string nazwisko)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.login = GenerateLogin(imie, nazwisko);
        this.haslo = GeneratePassword(nazwisko);
    }



    private string GenerateLogin(string imie, string nazwisko)
    {
        return Szyfrowanie.ZaszyfrujCezar(imie.ToLower() + "_" + nazwisko.ToLower(), 3);
    }



    private string GeneratePassword(string nazwisko)
    {
        string losowaLiczba = new Random().Next(100000, 999999).ToString();
        string pierwszeLiteryNazwiska = nazwisko.Substring(0, 3).ToLower();
        return Szyfrowanie.ZaszyfrujCezar(pierwszeLiteryNazwiska + losowaLiczba, 3);
    }



    virtual public void UkryjLogin()
    {
        Console.WriteLine("Ukryty Login: " + Szyfrowanie.ZaszyfrujCezar(login, 3));
    }



    virtual public void UkryjHaslo()
    {
        Console.WriteLine("Ukryte Hasło: " + Szyfrowanie.ZaszyfrujCezar(haslo, 3));
    }



    virtual public void PokazLogin()
    {
        Console.WriteLine("Login: " + login);
    }



    virtual public void PokazHaslo()
    {
        Console.WriteLine("Hasło: " + haslo);
    }



    public abstract void ZmienLogin(string nowyLogin, string staryLoginOdUzytkownika);



    public abstract void ZmienHaslo(string noweHaslo, string stareHasloOdUzytkownika);
}
