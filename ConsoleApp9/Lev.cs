namespace ConsoleApp9;

public class Lev(string jmeno) : Zvire(jmeno), IPohybujeSe
{
    public override string VydatZvuk()
    {
        return "tu-tu";
    }

    public string Pohyb()
    {
        return "Lev rychle běhá po savaně.";
    }

    public override string Jist()
    {
        return "Lev ji zebry.";
    }
    
}