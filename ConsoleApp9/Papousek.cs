namespace ConsoleApp9;

public class Papousek(string jmeno) : Zvire(jmeno), IPohybujeSe
{
    public override string VydatZvuk()
    {
        return "pipí";
    }
    
    public string Pohyb()
    {
        return "Papoušek létá vysoko v oblacích a občas poskakuje.";
    }

    public override string Jist()
    {
        return $"Papousek ji semena.";
    }

   
}