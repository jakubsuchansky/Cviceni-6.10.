namespace ConsoleApp9;

public abstract class Zvire(string jmeno)
{
    public string Jmeno { get; set; } = jmeno;
    public abstract string VydatZvuk();

    public virtual string Jist()
    {
        return $"{Jmeno} ji x.";
    }
    
}