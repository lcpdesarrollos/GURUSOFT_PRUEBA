using Application.Interface;
using Domain.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PrimeNumbersController : ControllerBase
    {

        private readonly IPrimeNumbersService primeNumbersService;

        public PrimeNumbersController(IPrimeNumbersService primeNumbersService) 
        { 
            this.primeNumbersService = primeNumbersService;
        }

        [HttpPost]
        public PrimeNumbersResponse FindPrimeNumbers(PrimeNumbersRequest request)
        {
            return primeNumbersService.FindPrimeNumbers(request);
        }

    }
}
