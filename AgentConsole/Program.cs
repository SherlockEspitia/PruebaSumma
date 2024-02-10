
namespace AgenteConsola
{

    class Program
    {
        private static string[] OpcionesFuncionalidades=
        [
            "Funcionalidad 1: Medias.",
            "Funcionalidad 2: Escaleras.",
            "Terminar la Ejecucion"

        ];

        private static string [] Medias =
        [
            "Agente 1: Media Aritmetica.",
            "Agente 2: Media Armonica.",
            "Agente 3: Mediana.",
            "Volver a funcionalidades."
        ];

        private static string [] Escaleras =
        [
            "Agente 1: Subir.",
            "Agente 2: Bajar.",
            "Agente 3: Subir y Bajar.",
            "Volver a Funcionalidades."
        ];

        private static int x; //Propiedad CursorLeft
        private static int y; //Propiedad CursorTop
        static void Main(string[] args)
        {
            bool Loop = true;
            int counter = 0;
            ConsoleKeyInfo Tecla;

            Console.CursorVisible = false;
            Console.WriteLine("Seleccione una opción: \n");

            x = Console.CursorLeft;
            y = Console.CursorTop;

            string Resultado = Menu(OpcionesFuncionalidades, counter);
            Console.ReadKey();

            while(Loop)
            {
                while ((Tecla=Console.ReadKey(true)).Key != ConsoleKey.Enter)
                {
                    switch(Tecla.Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (counter == OpcionesFuncionalidades.Length - 1) continue;
                            counter++;
                            break;
                        case ConsoleKey.UpArrow:
                            if(counter == 0) continue;
                            counter--;
                            break;
                        default:
                            break;
                    }
                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Resultado = Menu(OpcionesFuncionalidades, counter);

                }
                switch (counter)
                {
                    case 0:
                        Resultado = Menu(Medias,counter);
                        continue;
                    case 1:
                        Resultado = Menu(Escaleras,counter);
                        continue;
                    case 2:
                        Loop = false;
                        Console.WriteLine("Hasta la Proxima");
                        break;
                }
            }
        }

        private static string Menu(string[] items, int option)
        {
            string CurrentSelect = string.Empty;
            int salient = 0;

            Array.ForEach (items, element =>
            {
                if (salient == option)
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.BackgroundColor= ConsoleColor.DarkRed;
                    Console.WriteLine($" > {element} < ");
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.BackgroundColor= ConsoleColor.Black;
                    CurrentSelect = element;
                }
                else{
                    Console.Write( new string(' ', Console.WindowWidth));
                    Console.CursorLeft = 0;
                    Console.WriteLine(element);
                }
                salient++;
            });

            return CurrentSelect;
        }
    }
}