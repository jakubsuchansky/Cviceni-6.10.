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

    }
}


