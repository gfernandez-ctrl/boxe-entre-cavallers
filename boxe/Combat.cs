namespace boxe;

using System;

public class Combat
{
    private boxegador boxeador1;
    private boxegador boxeador2;

    public Combat(boxegador b1, boxegador b2)
    {
        boxeador1 = b1;
        boxeador2 = b2;
    }
    
    public void Iniciar()
    {
        Console.WriteLine($"Combat entre {boxeador1.Nombre} i {boxeador2.Nombre}");
        Console.WriteLine(new string('-', 40));

        while (!boxeador1.EstàFora() && !boxeador2.EstàFora())
        {
            Ronda(boxeador1, boxeador2);
            if (boxeador2.EstàFora()) break;
            Ronda(boxeador2, boxeador1);
        }

        AnunciarGuanyador();
    }

    public static void Ronda(boxegador atacante, boxegador defensor)
    {
        string zonaAtac = atacante.Picar();
        string proteccions = defensor.Protegir();
        bool repCop = defensor.RebreCop(zonaAtac, proteccions);

        Console.WriteLine($"{atacante.Nombre} pica: {(repCop ? $"Cop a {zonaAtac}" : "Protegit")}");
    }

    private void AnunciarGuanyador()
    {
        boxegador guanyador = boxeador1.EstàFora() ? boxeador2 : boxeador1;
        Console.WriteLine($"{guanyador.Nombre} GUANYA!");
    }
}
