using HackFSE_Stockmarket.Interfaces;
using HackFSE_Stockmarket.Models;
using HackFSE_Stockmarket.StockMarket.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFSE_Stockmarket.Repository
{
    public class CompanyRepo : ICompanyRepo
    {
        public readonly StockMarketContext stockMarketContext;

        public CompanyRepo(StockMarketContext stockMarketContext)
        {
            this.stockMarketContext = stockMarketContext;
        }
        public bool RegisterCompany(Company company)
        {
            var strategy = stockMarketContext.Database.CreateExecutionStrategy();
            strategy.Execute(() =>
            {

                //BeginTransaction
                using (var transaction = stockMarketContext.Database.BeginTransaction())
                {

                    var companyExists = this.stockMarketContext.Company.FirstOrDefault(c => c.CompanyCode == company.CompanyCode);
                    if (companyExists == null)
                    {
                        this.stockMarketContext.Company.Add(company);
                        this.stockMarketContext.SaveChanges();
                    }

                    //End Transaction 
                    transaction.Commit();
                }

            });
            return true;
        }

        public Company GetCompanyInfo(string companyCode)
        {
            var companyInfo = this.stockMarketContext.Company.FirstOrDefault(c => c.CompanyCode == companyCode);
            return companyInfo;
        }

        public List<Company> GetAllCompany()
        {
            var companyInfo = this.stockMarketContext.Company.ToList();
            return companyInfo;
        }

        public bool DeleteCompany(string companycode)
        {
            var strategy = stockMarketContext.Database.CreateExecutionStrategy();
            strategy.Execute(() =>
            {

                //BeginTransaction
                using (var transaction = stockMarketContext.Database.BeginTransaction())
                {

                    var companyExists = this.stockMarketContext.Company.FirstOrDefault(c => c.CompanyCode == companycode);
                    if (companyExists != null)
                    {
                        this.stockMarketContext.Company.Remove(companyExists);
                        this.stockMarketContext.SaveChanges();
                    }

                    //End Transaction 
                    transaction.Commit();
                }

            });
            return true;
        }

    }
}
