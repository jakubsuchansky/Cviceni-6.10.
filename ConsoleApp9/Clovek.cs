namespace ConsoleApp9;

public class Clovek
{

    public string Jmeno { get; set;}

    public virtual bool Lie()
    {
        return Random.Shared.Next(2) == 0;
    }
    
    
}