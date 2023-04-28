public class Student : Uzytkownik
{
    private int rocznikStudiow;

    public Student(string imie, string nazwisko, int rocznikStudiow) : base(imie, nazwisko)
    {
        this.rocznikStudiow = rocznikStudiow;
        this.login = GenerujLogin();
        this.haslo = GenerujHaslo();
    }
    public override void UkryjLogin()
    {
        this.login = Szyfrowanie.ZaszyfrujCezar(this.login, 3);
    }

    public override void UkryjHaslo()
    {
        this.haslo = Szyfrowanie.ZaszyfrujCezar(this.haslo, 3);
    }

    public override void PokazLogin()
    {
        Console.WriteLine("Login: " + this.login);
    }

    public override void PokazHaslo()
    {
        Console.WriteLine("Hasło: " + this.haslo);
    }
    public override void ZmienLogin(string nowyLogin, string staryLoginOdUzytkownika)
    {
        if (staryLoginOdUzytkownika == this.login)
        {
            this.login = nowyLogin;
        }
        else
        {
            Console.WriteLine("Nie masz uprawnień do zmiany loginu.");
        }
    }

    public override void ZmienHaslo(string noweHaslo, string stareHasloOdUzytkownika)
    {
        if (stareHasloOdUzytkownika == this.haslo)
        {
            this.haslo = noweHaslo;
        }
        else
        {
            Console.WriteLine("Nie masz uprawnień do zmiany hasła.");
        }
    }

    public override string ToString()
    {
        return "Student: " + imie + " " + nazwisko + ", rocznik studiów: " + rocznikStudiow
        + "\nLogin: " + Szyfrowanie.OdszyfrujCezar(this.login, 3)
        + "\nHasło: " + Szyfrowanie.OdszyfrujCezar(this.haslo, 3);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Student other = (Student)obj;
        return this.login == other.login && this.haslo == other.haslo;
    }

    public string GenerujLogin()
    {
        string login = imie + "_" + nazwisko;
        return Szyfrowanie.ZaszyfrujCezar(login, 3);
    }

    public string GenerujHaslo()
    {
        string haslo = nazwisko.Substring(0, 3) + new Random().Next(100000, 999999).ToString();
        return Szyfrowanie.ZaszyfrujCezar(haslo, 3);
    }
}