using HackFSE_Stockmarket.Models;
using HackFSE_Stockmarket.Service;
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
        public readonly CompanyService companyServiceObj;
        
        public StockMarket(StockMarketContext employeeDbContext, CompanyService companyService)
        {
            stockMarketContext = employeeDbContext;
            this.companyServiceObj = companyService;
        }

        [HttpGet("register")]
        public IEnumerable<Company> GetCompanie()
        {
            return stockMarketContext.Company.ToArray();
        }

        [HttpPost]
        public IActionResult RegisterCompany(Company companyObj)
        {
            var result = this.companyServiceObj.RegisterCompany(companyObj);
            return Content(result);
        }
    }
}
