int a = 0;
int b = 0;

Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Escribe un número y pulsa ENTER:");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribre otro número y pulsa Enter");
b = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Elige una opción de la lista:");
Console.WriteLine("\ts - Sumar");
Console.WriteLine("\tr - Restar");
Console.WriteLine("\tm - Multiplicar");
Console.WriteLine("\td - Dividir");

switch (Console.ReadLine())
{
    case "s":
        Console.WriteLine($"Resultado opeación {a} + {b} = " + (a+b));
        break;
    case "r":
        Console.WriteLine($"Resultado opeación {a} - {b} = " + (a - b));
        break;
    case "m":
        Console.WriteLine($"Resultado opeación {a} * {b} = " + (a * b));
        break;
    case "d":
        Console.WriteLine($"Resultado opeación {a} / {b} = " + (a / b));
        break;
}
Console.WriteLine("Pulsa una tecla para salir...");
Console.ReadKey();
