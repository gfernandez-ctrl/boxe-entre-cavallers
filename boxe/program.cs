using System;
using boxe;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nombre del contrincante 1:");
        string nombre1 = Console.ReadLine();
        Console.WriteLine("Cuanta vida tiene el competidor 1:");
        int vida1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Nombre del contrincante 2:");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("Cuanta vida tiene el competidor 2:");
        int vida2 = int.Parse(Console.ReadLine());

        
        boxegador boxeador1 = new boxegador(nombre1, vida1);
        boxegador boxeador2 = new boxegador(nombre2, vida2);

        
        Combat combat = new Combat(boxeador1, boxeador2);

        while (boxeador1.Resistencia > 0 && boxeador2.Resistencia > 0)
        {
            Combat.Ronda(boxeador1, boxeador2);
            Combat.Ronda(boxeador2, boxeador1);
        }

        if (boxeador1.Resistencia > 0)
        {
            Console.WriteLine($"{boxeador1.Nombre} gana el combate!");
        }
        else
        {
            Console.WriteLine($"{boxeador2.Nombre} gana el combate!");
        }
    }
}
