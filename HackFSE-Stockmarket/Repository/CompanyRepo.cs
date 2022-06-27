using HackFSE_Stockmarket.Models;
using HackFSE_Stockmarket.StockMarket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFSE_Stockmarket.Repository
{
    public class CompanyRepo
    {
        public readonly StockMarketContext stockMarketContext;

        public CompanyRepo(StockMarketContext stockMarketContext)
        {
            this.stockMarketContext = stockMarketContext;
        }
        public bool RegisterCompany(Company company)
        {
            try
            {
                using (var obj = this.stockMarketContext.Database.BeginTransaction())
                {
                    var companyExists = this.stockMarketContext.Company.SingleOrDefault(c => c.CompanyCode == company.CompanyCode);
                    if (companyExists == null)
                    {
                        this.stockMarketContext.Company.Add(company);
                        this.stockMarketContext.SaveChanges();
                        obj.Commit();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
