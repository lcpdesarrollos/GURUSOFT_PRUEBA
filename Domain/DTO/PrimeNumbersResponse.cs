using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO;

public class PrimeNumbersResponse : BaseReponseDTO
{
    public List<int>? PrimeNumbers { get; set; }
}
