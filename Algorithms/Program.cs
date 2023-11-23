// See https://aka.ms/new-console-template for more information
using Application;

Console.WriteLine("Menu");
Console.WriteLine("1. Patron");
Console.WriteLine("2. Numeros Primos");
Console.WriteLine("3. Cara Humana");
Console.WriteLine("Digite una opcion");
int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        FindMiddleWord();
        break;
    case 2:
        PrintPrimerNumbers();
        break;
    case 3:
        break;
    default:
        Console.WriteLine("Digite un opcion valida");
        break;
}

void PrintPrimerNumbers()
{
    Console.WriteLine("Digite el numero de inicio");
    int initialNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite la cantidad de primos a imprimir");
    int totalNumber = Convert.ToInt32(Console.ReadLine());

    PrimeNumbersService primeNumbers = new PrimeNumbersService();
    var list = primeNumbers.FindPrimeNumbers(initialNumber, totalNumber);
    string strPrimeNumbers = string.Empty;

    foreach (var prime in list)
        if (string.IsNullOrEmpty(strPrimeNumbers))
            strPrimeNumbers = prime.ToString();
        else
            strPrimeNumbers = $"{strPrimeNumbers}, {prime}";
    
    Console.WriteLine($"Resultado: {strPrimeNumbers}");
}

void FindMiddleWord()
{
    Console.WriteLine("Escibra una palabra");
    string word = Console.ReadLine().ToString();

    PatronService patron = new PatronService();
    string result = patron.FindMiddleWord(word);
    Console.WriteLine($"Resultado: {result}");
}

void BuildFace()
{

}