namespace boxe;

using System;

public class boxegador
{
    public string Nombre { get; private set; }
    public int Resistencia { get; private set; }
    private static readonly string[] Zonas = { "cap", "panxa", "esquerra", "dreta" };
    private Random random;

    public boxegador(string nombre, int resistencia)
    {
        Nombre = nombre;
        Resistencia = resistencia;
        random = new Random();
    }

    public string Picar()
    {
        return Zonas[random.Next(Zonas.Length)];
    }

    public string Protegir()
    {
        // Protege tres zonas aleatorias.
        var proteccions = new HashSet<string>();
        while (proteccions.Count < 3)
        {
            proteccions.Add(Zonas[random.Next(Zonas.Length)]);
        }
        return string.Join(", ", proteccions);
    }

    public bool RebreCop(string zona, string zonesProtegides)
    {
        if (zonesProtegides.Contains(zona))
        {
            return false; // Protegit
        }
        Resistencia--;
        return true; // Rep cop
    }

    public bool EstàFora()
    {
        return Resistencia <= 0;
    }
}
