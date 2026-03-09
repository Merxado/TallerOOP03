class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\n1. Probar viga: ");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "0")
            {
                Console.WriteLine("Programa finalizado.");
                break;
            }

            if (opcion == "1")
            {
                EvaluarViga();
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
    }

    static void EvaluarViga()
    {
        Console.Write("Ingrese la viga: ");
        string viga = Console.ReadLine();

        if (string.IsNullOrEmpty(viga))
        {
            Console.WriteLine("La viga está mal construida!");
            return;
        }

        int resistencia = 0;

        switch (viga[0])
        {
            case '%': resistencia = 10; break;
            case '&': resistencia = 30; break;
            case '#': resistencia = 90; break;
            default:
                Console.WriteLine("La viga está mal construida!");
                return;
        }

        int pesoTotal = CalcularPeso(viga);

        if (pesoTotal == -1)
            return;

        if (pesoTotal <= resistencia)
            Console.WriteLine("La viga soporta el peso!");
        else
            Console.WriteLine("la Viga NO soporta el peso!");
    }

    static int CalcularPeso(string viga)
    {
        int pesoTotal = 0;
        int secuencia = 0;

        for (int i = 1; i < viga.Length; i++)
        {
            char c = viga[i];

            if (c == '=')
            {
                secuencia++;
            }
            else if (c == '*')
            {
                if (viga[i - 1] == '*')
                {
                    Console.WriteLine("La viga está mal construida!");
                    return -1;
                }

                pesoTotal += secuencia * 2;
                secuencia = 0;
            }
            else
            {
                Console.WriteLine("La viga está mal construida!");
                return 999;
            }
        }

        pesoTotal += secuencia;
        return pesoTotal;
    }
}