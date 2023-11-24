using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO;

public class BaseRequestDTO
{
    public DateTime Date { get; set; } = DateTime.Now;
    public string Usuario { get; set; }
}
