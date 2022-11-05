using System.ComponentModel.DataAnnotations;

do
{
    string val;
    string val2;
    Console.Write("Enter string: ");
    val = Console.ReadLine();

    Console.Write("Enter string: ");
    val2 = Console.ReadLine();

    int mayor = Math.Max(val.Length, val.Length);
    string result = "";

    for (int i = 0; i < mayor; i++)
    {
        if (val[i] == val2[i])
        {
            result = result + val[i];
        }
    }

    
    Console.WriteLine(result);
   
    Console.WriteLine("Escriba exit para terminar, Cualquier tecla para continuar");
} while (Console.ReadLine() != "exit");