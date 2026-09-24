namespace CalculadoraColaborativa
{
    public static class OperacionesBasicas
    {
        public static double Sumar(double a, double b)
        {
            System.Console.WriteLine($"[CALCULADORA] Resultado = {a + b}");
            return a + b;
        }

        public static double Restar(double a, double b) => a - b;
    }
}