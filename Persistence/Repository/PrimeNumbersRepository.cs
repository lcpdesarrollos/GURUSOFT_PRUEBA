using Application.Interface;
using Domain.Entity;
using Persistence.Context;

namespace Persistence.Repository;

public class PrimeNumbersRepository : IPrimeNumbersRepository
{
    private readonly SSQLContext context;
    public PrimeNumbersRepository(SSQLContext context)
    {
        this.context = context;
    }

    public async Task SaveTransaction(TransactionEntity transaction)
    {
        context.Transaction.Add(transaction);
        context.SaveChanges();
    }
}
