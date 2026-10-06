namespace ConsoleApp9;

public class UrocenyUcet : Ucet
{
    public UrocenyUcet(int penizeNaUcte, bool stav, int urokovaSazba) : base(penizeNaUcte, stav)
    {
        UrokovaSazba = urokovaSazba;
    }

    public int UrokovaSazba { get; set; }

}