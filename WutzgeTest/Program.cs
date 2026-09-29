using WutzgeTest;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hier, wie heißtn der Neyscher?");
string name = Console.ReadLine();
Console.WriteLine("Sprischt der e geiles Hessisch?");
bool geilesHessisch()
{
    if (Console.ReadLine() == "ja")
    {
        return true;
    }
    else
    {
        return false;
    }
}
Wutzge isserdes = new Wutzge(name, geilesHessisch());
isserdes.isserDes();