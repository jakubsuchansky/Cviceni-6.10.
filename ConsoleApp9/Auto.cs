namespace ConsoleApp9;

public class Auto
{
    public string SPZ { get; set; }
    public int Rychlost { get; set; }

    public Auto(string spz, int rychlost)
    {
        SPZ = spz;
        Rychlost = rychlost;
    }

    public override string ToString()
    {
        return $"SPZ: {SPZ}, Rychlost auta: {Rychlost}";
    }
    
    
    
}