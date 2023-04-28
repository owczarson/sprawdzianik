using System;

class Program
{
    static void Main(string[] args)
    {

        string tekst = "Ala ma kota";
        int klucz = 3;

        string zaszyfrowany = Szyfrowanie.ZaszyfrujCezar(tekst, klucz);
        string odszyfrowany = Szyfrowanie.OdszyfrujCezar(zaszyfrowany, klucz);

        Console.WriteLine("Zadanie 1 wszystko śmiga pięknie");
        Console.WriteLine("Tekst: " + tekst);
        Console.WriteLine("Zaszyfrowany: " + zaszyfrowany);
        Console.WriteLine("Odszyfrowany: " + odszyfrowany);

        Console.ReadKey();

        Console.WriteLine();

        Console.WriteLine("Zadanie 2 trybi pięknie");

        Console.ReadKey();
        Console.WriteLine();

        Console.WriteLine("Zadanie 3");
        Student student = new Student("Piotras", "Toja", 2021);
        Console.WriteLine(student);
        student.UkryjLogin();
        student.UkryjHaslo();

        Console.WriteLine(" ");
        Console.ReadKey();
    }

}
