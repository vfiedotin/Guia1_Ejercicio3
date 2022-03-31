ConsoleKeyInfo tecla;

do
{
    Console.WriteLine("Presione una tecla para visualizar el caracter y luego presione la tecla X para salir");

    while (Console.KeyAvailable == false) ;

    tecla = Console.ReadKey(true);
    Console.WriteLine("Usted presionó la tecla '{0}'", tecla.Key);
} while (tecla.Key != ConsoleKey.X);
