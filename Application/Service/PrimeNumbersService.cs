using Application.Interface;
using Domain.DTO;
using Domain.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Service;

public class PrimeNumbersService : IPrimeNumbersService
{
    private readonly IPrimeNumbersRepository primeNumbersRepository;

    public PrimeNumbersService()
    {
    }

    public PrimeNumbersService(IPrimeNumbersRepository primeNumbersRepository) 
    { 
        this.primeNumbersRepository = primeNumbersRepository;
    }

    public PrimeNumbersResponse FindPrimeNumbers(PrimeNumbersRequest request)
    {
        PrimeNumbersResponse response = new PrimeNumbersResponse();
        int contador = 0;
        int number = request.InitialNumber;
        var primeNumbers = new List<int>();
        try
        {
            while (contador < request.TotalNumbers)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                    contador++;
                }
                number++;
            }

            response.PrimeNumbers = primeNumbers;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            response.Message = "Transacción exitosa";

            TransactionEntity transactionEntity = new TransactionEntity();
            transactionEntity.JsonRequest = JsonConvert.SerializeObject(request);
            transactionEntity.JsonResponse = JsonConvert.SerializeObject(response);
            transactionEntity.Usuario = request.Usuario;
            transactionEntity.DateRequest = request.Date;
            transactionEntity.DateResponse = DateTime.Now;

            primeNumbersRepository?.SaveTransaction(transactionEntity);
        }
        catch (Exception ex)
        {
            response.Message = ex.Message;
            response.StatusCode = System.Net.HttpStatusCode.InternalServerError;
            response.PrimeNumbers = null;
        }

        return response;
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
