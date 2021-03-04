using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace spletnaSPIV
{
    public class UporabikContext : dbContext
    {
        public DbSet<UserTbl> Users { get; set; }
        public DbSet<WalletTbl> Users { get; set; }
        public DbSet<TransactionTbl> Users { get; set; }

    }
}
