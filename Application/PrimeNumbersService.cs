using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application;

public class PrimeNumbersService
{
    public List<int> FindPrimeNumbers(int number, int totalNumbers)
    {
        int contador = 0;
        var primeNumbers = new List<int>();
        while (contador < totalNumbers)
        {
            if (IsPrime(number))
            {
                primeNumbers.Add(number);
                contador++;
            }
            number++;
        }

        return primeNumbers;
    }

    private bool IsPrime(int number)
    {
        int result = 0;

        for (int i = 1; i <= number; i++)
            if (number % i == 0)
                result++;

        return result == 2 ? true : false;
    }
}
