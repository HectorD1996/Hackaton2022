// See https://aka.ms/new-console-template for more information

do
{
    string val;
    string val2;
    Console.Write("Enter string: ");
    val = Console.ReadLine();

    Console.Write("Enter string: ");
    val2 = Console.ReadLine();
    if (val.Length == val2.Length)
    {
        bool result = !(val.Except(val2).Any());
        Console.WriteLine(result.ToString());
    }
    else
    {
        Console.WriteLine("Las cadenas no coiciden en tamaño");
    }
    Console.WriteLine("Escriba exit para terminar, Cualquier tecla para continuar");
} while (Console.ReadLine() != "exit");
    


