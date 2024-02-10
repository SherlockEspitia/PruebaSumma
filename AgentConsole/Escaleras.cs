namespace Escaleras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el tamaño de la escalera (0 < n < 100): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0 && n < 100)
            {
                Console.WriteLine("\nEscalera con base y altura iguales a n (alineada a la derecha):");
                for (int i = 1; i <= n; i++)
                {
                    string espacios = new string(' ', n - i);
                    string escalones = new string('#', i);
                    Console.WriteLine(espacios + escalones);
                }

                Console.WriteLine("\nEscalera con cima y altura iguales a n (alineada a la derecha):");
                for (int i = 1; i <= n; i++)
                {
                    string escalones = new string('#', i);
                    Console.WriteLine(escalones.PadLeft(n));
                }

                Console.WriteLine("\nEscalera con base y cima iguales a n (alineada al centro):");
                for (int i = 1; i <= n; i++)
                {
                    string escalones = new string('#', i);
                    Console.WriteLine(escalones.PadLeft(n + i - 1));
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no cumple con las restricciones.");
            }
        }
    }
}
