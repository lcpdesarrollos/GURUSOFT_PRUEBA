// See https://aka.ms/new-console-template for more information
using Application.Interface;
using Application.Service;
using Domain.DTO;
using Domain.Entity;

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
        BuildFace();
        break;
    default:
        Console.WriteLine("Digite un opcion valida");
        break;
}


void PrintPrimerNumbers()
{
    PrimeNumbersRequest request = new PrimeNumbersRequest();

    Console.WriteLine("Digite el numero de inicio");
    request.InitialNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite la cantidad de primos a imprimir");
    request.TotalNumbers = Convert.ToInt32(Console.ReadLine());

    PrimeNumbersService primeNumbers = new PrimeNumbersService();
    var response = primeNumbers.FindPrimeNumbers(request);
    string strPrimeNumbers = string.Empty;

    if (response.PrimeNumbers != null)
        foreach (var prime in response.PrimeNumbers)
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
    FaceEntity entity = new FaceEntity();
    Console.WriteLine("Digite un caracter para el cabello ");
    entity.Cabello = Console.ReadLine().ToString();
    Console.WriteLine("Digite un caracter para delimitar la cara ");
    entity.DelinearFace = Console.ReadLine().ToString();
    Console.WriteLine("Digite primer caracter para la ceja ");
    entity.Ceja1 = Console.ReadLine().ToString();
    Console.WriteLine("Digite segundo caracter para la ceja ");
    entity.Ceja2 = Console.ReadLine().ToString();
    Console.WriteLine("Digite primer caracter para la oreja ");
    entity.Oreja1 = Console.ReadLine().ToString();
    Console.WriteLine("Digite segundo caracter para la oreja ");
    entity.Oreja2 = Console.ReadLine().ToString();
    Console.WriteLine("Digite un caracter para los ojos ");
    entity.Ojos = Console.ReadLine().ToString();
    Console.WriteLine("Digite un caracter para la nariz ");
    entity.Nariz = Console.ReadLine().ToString();
    Console.WriteLine("Digite primer caracter para la boca ");
    entity.Boca1 = Console.ReadLine().ToString();
    Console.WriteLine("Digite segundo caracter para la boca ");
    entity.Boca2 = Console.ReadLine().ToString();
    Console.WriteLine("Digite tercer caracter para la boca ");
    entity.Boca3 = Console.ReadLine().ToString();
    Console.WriteLine("Digite primer caracter para la menton ");
    entity.Menton1 = Console.ReadLine().ToString();
    Console.WriteLine("Digite segundo caracter para la menton ");
    entity.Menton2 = Console.ReadLine().ToString();
    Console.WriteLine("Digite tercer caracter para la menton ");
    entity.Menton3 = Console.ReadLine().ToString();

    Console.WriteLine("\n\n\n");
    FaceService face = new FaceService();
    var resultFace = face.BuildFace(entity);

    Console.WriteLine(resultFace);
}