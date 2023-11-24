﻿using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context.EntityConfiguration;

public class TransactionEntityConfiguration
{
    public static void Configuration(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TransactionEntity>(entity =>
        {
            entity.HasKey(x => x.Id);
        });
    }
}
