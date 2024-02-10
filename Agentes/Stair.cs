using System;

class Stair
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño de la escalera (0 < n < 100): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0 && n < 100)
        {
            PrintStaircase(n);
        }
        else
        {
            Console.WriteLine("El valor ingresado no cumple con las restricciones.");
        }
    }

    static void PrintStaircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            // Imprime espacios en blanco
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }

            // Imprime símbolos #
            for (int k = 0; k < i; k++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}
