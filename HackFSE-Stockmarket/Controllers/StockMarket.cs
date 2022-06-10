using HackFSE_Stockmarket.Models;
using HackFSE_Stockmarket.StockMarket.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFSE_Stockmarket.Controllers
{
    [Route("api/market/company")]
    [ApiController]
    public class StockMarket : ControllerBase
    {

        public StockMarketContext stockMarketContext;
        public StockMarket(StockMarketContext employeeDbContext)
        {
            stockMarketContext = employeeDbContext;
        }

        [HttpGet("register")]
        public IEnumerable<Company> GetCompanie()
        {
            return stockMarketContext.Company.ToArray();
        }
    }
}
