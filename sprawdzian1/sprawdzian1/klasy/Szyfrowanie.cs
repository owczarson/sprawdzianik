public static class Szyfrowanie
{
    public static string ZaszyfrujCezar(string tekst, int klucz)
    {
        string zaszyfrowanyTekst = "";
        foreach (char c in tekst)
        {
            if (char.IsLetter(c))
            {
                char d = (char)(((char.ToUpper(c) - 'A') + klucz) % 26 + 'A');
                zaszyfrowanyTekst += d;
            }
            else
            {
                zaszyfrowanyTekst += c;
            }
        }
        return zaszyfrowanyTekst;
    }

    public static string OdszyfrujCezar(string szyfr, int klucz)
    {
        string odszyfrowanyTekst = "";
        foreach (char c in szyfr)
        {
            if (char.IsLetter(c))
            {
                char d = (char)(((char.ToUpper(c) - 'A') - klucz + 26) % 26 + 'A');
                odszyfrowanyTekst += d;
            }
            else
            {
                odszyfrowanyTekst += c;
            }
        }
        return odszyfrowanyTekst;
    }
}
