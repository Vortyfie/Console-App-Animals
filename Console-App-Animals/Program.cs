using Console_App_Animals;

class Program
{
    static void Main(string[] args)
    {
        Animal chien = new Animal();
        Animal chat = new Animal("TOTO");

        chien.Sleep();
        chat.Sleep();

        Console.WriteLine();
        Console.ReadLine();

    }
}