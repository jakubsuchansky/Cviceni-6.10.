namespace ConsoleApp9;

public class Slon(string jmeno) : Zvire(jmeno), IPohybujeSe
{
    public override string VydatZvuk()
    {
        return "roar";
    }

    public string Pohyb()
    {
        return "Slon kráčí pomalým a těžkým krokem.";
    }

    public override string Jist()
    {
        return $"Slon ji Větve.";
    }
}