do
{
    string val;
    string val2;
    string val3;
    int size = 0;
    
    Console.Write("Enter string: ");
    val = Console.ReadLine();

    Console.Write("Enter string 2: ");
    val2 = Console.ReadLine();

    Console.Write("Enter string 3: ");
    val3 = Console.ReadLine();

    string[] strArray = new string[] { val, val2, val3 };

    Console.Write("Enter legnht of string: ");
    size = int.Parse(Console.ReadLine());

    for (int i = 0; i < strArray.Length; i++)
    {
        if (i != strArray.Length - 1)
        {
            strArray[i] = strArray[i].PadLeft(size);
        }
        else
        {
            strArray[i] = strArray[i].PadRight(size);
        }
        Console.WriteLine(strArray[i]);
        
    }


    Console.WriteLine("Escriba exit para terminar, Cualquier tecla para continuar");
} while (Console.ReadLine() != "exit");