﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO;

public class BaseReponseDTO
{
    public HttpStatusCode StatusCode { get; set; }
    public string Message { get; set; }
}
