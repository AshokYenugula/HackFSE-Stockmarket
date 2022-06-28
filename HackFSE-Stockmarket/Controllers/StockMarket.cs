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
        public readonly ICompanyService companyServiceObj;

        public StockMarket(StockMarketContext employeeDbContext, ICompanyService companyService)
        {
            stockMarketContext = employeeDbContext;
            this.companyServiceObj = companyService;
        }       

        [HttpPost("Register")]
        public IActionResult RegisterCompany(Company companyObj)
        {
            var result = this.companyServiceObj.RegisterCompany(companyObj);
            return Content(result);
        }

        [HttpGet("Info/{companyCode}")]
        public Company GetCompanyInfo(string companyCode)
        {
            var result = this.companyServiceObj.GetCompanyInfo(companyCode);
            return result;
        }

        [HttpGet("getAll")]
        public List<Company> GetAllCompany()
        {
            var result = this.companyServiceObj.GetAllCompany();
            return result;
        }
    }
}
