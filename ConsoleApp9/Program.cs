namespace ConsoleApp9;

class Program
{
    static void Main(string[] args)
    {
        Clovek clovek = new Clovek();
        Politik politik = new Politik();
        Svetec svetec = new Svetec();
        Console.WriteLine(clovek.Lie());
        Console.WriteLine(svetec.Lie());
        Console.WriteLine(politik.Lie());

        Auto auto = new Auto("A1234",100);
        NakladniAuto nakladniAuto = new NakladniAuto("B1234", 80, 330);
        Console.WriteLine(auto);
        Console.WriteLine(nakladniAuto);

        Ucet ucet = new Ucet(100, true);
        Console.WriteLine(ucet.PenizeNaUcte);

        Slon slon = new Slon("Slon1");
        Console.WriteLine(slon.Jist());
        Console.WriteLine(slon.VydatZvuk());
        Console.WriteLine(slon.Pohyb());

        Lev lev = new Lev("lev1");
        Console.WriteLine(lev.Jist());
        Console.WriteLine(lev.VydatZvuk());
        Console.WriteLine(lev.Pohyb());

        Papousek papousek = new Papousek("Papousek1");
        Console.WriteLine(papousek.Jist());
        Console.WriteLine(papousek.VydatZvuk());
        Console.WriteLine(papousek.Pohyb());


    }
}


