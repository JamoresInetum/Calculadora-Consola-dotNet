class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        // Título
        Console.WriteLine(" Calculadora de Consola en C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // Variables iniciales
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            // Entrada primer número
            Console.WriteLine("Escribe un número y pulsa ENTER:");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("No es una entrada válida. Introduce un valor numérico: ");
                numInput1 = Console.ReadLine();
            }

            // Entrada segundo número
            Console.WriteLine("Escribre otro número y pulsa Enter");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("No es una entrada válida. Introduce un valor numérico: ");
                numInput2 = Console.ReadLine();
            }

            // Menú de elección
            Console.WriteLine("Elige una opción de la lista:");
            Console.WriteLine("\ts - Sumar");
            Console.WriteLine("\tr - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Esta operación acabará en un error matemático.\n");
                }
                else Console.WriteLine("Tu resultado: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("¡Oh no! Ha ocurrido una excepción intentando hacer el cálculo.\n - Detalles: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

            // Pre-Cierre
            Console.Write("Pulsa 'n' y Enter para cerrar la app, o pulsa Enter para continuar: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); // Mejora la visibilidad.
        }
        return;
    }
}