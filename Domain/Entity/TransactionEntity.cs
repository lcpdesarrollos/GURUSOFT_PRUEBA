using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity;

public class TransactionEntity
{
    public int Id { get; set; }
    public string Usuario { get; set; }
    public DateTime DateRequest { get; set; }
    public DateTime DateResponse { get; set; }
    public string JsonRequest { get; set; }
    public string JsonResponse { get; set; }
}
