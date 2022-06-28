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
    [Route("api/market/")]
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

        [HttpPost("company/Register")]
        public IActionResult RegisterCompany(Company companyObj)
        {
            var result = this.companyServiceObj.RegisterCompany(companyObj);
            return Content(result);
        }

        [HttpGet("company/Info/{companyCode}")]
        public Company GetCompanyInfo(string companyCode)
        {
            var result = this.companyServiceObj.GetCompanyInfo(companyCode);
            return result;
        }

        [HttpGet("company/getAll")]
        public List<Company> GetAllCompany()
        {
            var result = this.companyServiceObj.GetAllCompany();
            return result;
        }

        [HttpGet("company/delete/{companyCode}")]
        public Company DeleteCompanyDeatils(string companyCode)
        {
            var result = this.companyServiceObj.GetCompanyInfo(companyCode);
            return result;
        }

        [HttpPost("stock/add/{companycode}")]
        public string AddStock([FromBody]Stock stock,string companycode)
        {
            return this.companyServiceObj.AddStock(stock);
        }

        [HttpGet("stock/get/{companycode}/{startdate}/{enddate}")]
        public List<Stock> GetAllStocks(string companycode, DateTime startdate, DateTime enddate)
        {
            return this.companyServiceObj.GetAllStocks(companycode,startdate,enddate);
           
        }
    }
}
