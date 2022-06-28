using HackFSE_Stockmarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFSE_Stockmarket
{
   public  interface ICompanyService
    {
        public string RegisterCompany(Company company);

        public Company GetCompanyInfo(string companyCode);

        public List<Company> GetAllCompany();
    }
}
