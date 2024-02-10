
namespace MediaCalculations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<double> numeros = [10.5, 20.3, 15.7, 18.2, 12.9];

            double mediaAritmetica = CalcularMediaAritmetica(numeros);
            double mediaArmonica = CalcularMediaArmonica(numeros);
            double mediana = CalcularMediana(numeros);

            Console.WriteLine($"Media Aritmética: {mediaAritmetica}");
            Console.WriteLine($"Media Armónica: {mediaArmonica}");
            Console.WriteLine($"Mediana: {mediana}");
        }

        public static double CalcularMediaAritmetica(List<double> numeros)
        {
            return numeros.Average();
        }

        public static double CalcularMediaArmonica(List<double> numeros)
        {
            double sumaInversos = numeros.Sum(x => 1 / x);
            return numeros.Count / sumaInversos;
        }

        public static double CalcularMediana(List<double> numeros)
        {
            var numerosOrdenados = numeros.OrderBy(x => x).ToList();
            int n = numerosOrdenados.Count;

            if (n % 2 == 0)
            {
                int indiceMedio1 = n / 2 - 1;
                int indiceMedio2 = n / 2;
                return (numerosOrdenados[indiceMedio1] + numerosOrdenados[indiceMedio2]) / 2;
            }
            else
            {
                int indiceMedio = n / 2;
                return numerosOrdenados[indiceMedio];
            }
        }
    }
}
