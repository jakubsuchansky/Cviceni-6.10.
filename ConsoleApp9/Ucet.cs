namespace ConsoleApp9;

public class Ucet(int penizeNaUcte, bool stav)
{
    public int PenizeNaUcte
    {
        get;
        protected set => field = value > 0 ? value : throw new ArgumentException();
    } = penizeNaUcte;

    public bool Stav
    {
        get;
        set;
    } = stav;

    public void vklad(int castka)
    {
        PenizeNaUcte += castka;
    }

    public void vyber(int castka)
    {
        PenizeNaUcte -= castka;
    }
    
}