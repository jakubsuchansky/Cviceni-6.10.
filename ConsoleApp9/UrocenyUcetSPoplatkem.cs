namespace ConsoleApp9;

public class UrocenyUcetSPoplatkem(int penizeNaUcte, bool stav, int urokovaSazba, int poplatek) 
    : UrocenyUcet(penizeNaUcte, stav, urokovaSazba)
{
    public override void PrictiUrok()
    {
        base.PrictiUrok();
        PenizeNaUcte -= Poplatek;
    }

    public int Poplatek { get; set; } = poplatek;
}