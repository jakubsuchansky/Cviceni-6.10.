namespace ConsoleApp9;

public class UrocenyUcet : Ucet
{
    public UrocenyUcet(int penizeNaUcte, bool stav, int urokovaSazba) : base(penizeNaUcte, stav)
    {
        UrokovaSazba = urokovaSazba;
    }

    public int UrokovaSazba { get;
        set => field = value > 0 ? value : throw new ArgumentException(); 
    }

    public virtual void PrictiUrok()
    {
        PenizeNaUcte += UrokovaSazba;
    }

}