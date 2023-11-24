using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface;

public interface IPrimeNumbersService
{
    PrimeNumbersResponse FindPrimeNumbers(PrimeNumbersRequest request);
}
