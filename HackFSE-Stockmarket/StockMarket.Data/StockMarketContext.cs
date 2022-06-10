using HackFSE_Stockmarket.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFSE_Stockmarket.StockMarket.Data
{
    public class StockMarketContext :DbContext
    {
        public StockMarketContext(DbContextOptions<StockMarketContext> options) : base(options)
        {

        }

        public DbSet<Company> Company { get; set; }

        public DbSet<Stock> Stock { get; set; }

    }
}
