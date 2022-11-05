// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int cantidad = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < cantidad; i++)
{
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Avellanas(numero));
}


static int Avellanas(int numero)
{
    int num1 = 0;
    int num2 = 0;
    int suma = -9999;
    int total = 0;
    for (int i = 0; i < numero; i++)
    {
        num1 = numero - i;
        num2 = i;
        total = retornaBinario(num1) + retornaBinario(num2);
        if (suma < total)
        {
            suma = total;
        }
    }
    return suma;
}


static int retornaBinario(int numero)
{
    int cantidad = 0;
    String numeroBinario = "";
    while (numero / 2 != 0)
    {
        numeroBinario += (numero % 2);
        numero = (numero / 2);
    }
    numeroBinario += numero;

    char[] caracter = numeroBinario.ToCharArray();
    for (int i = 0; i < numeroBinario.Length; i++)
    {
        if (caracter[i].Equals("1"))
        {
            cantidad++;
        }
    }
    return cantidad;
}
