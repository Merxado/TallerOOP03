using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese ubicación de los caballos: ");
        string entrada = Console.ReadLine();

        string[] caballos = entrada.Split(',');

        for (int i = 0; i < caballos.Length; i++)
        {
            string actual = caballos[i].Trim();
            if (actual.Length < 2) continue;

            int x1 = actual[0] - 'A' + 1;
            int y1 = int.Parse(actual[1].ToString());

            Console.Write($"Analizando Caballo en {actual[1]}{actual[0]} => ");

            for (int j = 0; j < caballos.Length; j++)
            {
                if (i == j) continue;

                string otro = caballos[j].Trim();
                int x2 = otro[0] - 'A' + 1;
                int y2 = int.Parse(otro[1].ToString());

                int dx = Math.Abs(x1 - x2);
                int dy = Math.Abs(y1 - y2);

                if ((dx == 2 && dy == 1) || (dx == 1 && dy == 2))
                {
                    Console.Write($"Conflicto con {otro[1]}{otro[0]}      ");
                }
            }

            Console.WriteLine();
        }
    }
}