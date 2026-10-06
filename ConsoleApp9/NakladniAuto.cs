namespace ConsoleApp9;

public class NakladniAuto : Auto
{
    public NakladniAuto(string spz, int rychlost, int hmotnost) : base(spz, rychlost)
    {
        Hmotnost = hmotnost;
    }
    public int Hmotnost { get; set; }

    public override string ToString()
    {
        return base.ToString()+$", Hmotnost: {Hmotnost}";
    }
    
    
    
}