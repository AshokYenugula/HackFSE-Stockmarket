using HackFSE_Stockmarket.Models;
using HackFSE_Stockmarket.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFSE_Stockmarket.Service
{
    public class CompanyService
    {
        public readonly CompanyRepo companyRepoObj;

        public CompanyService(CompanyRepo companyRepoObj)
        {
            this.companyRepoObj = companyRepoObj;
        }
        public string RegisterCompany(Company company)
        {
            try
            {
                if (company.CompanyTurnOver < 10000000)
                {
                    throw new Exception("Invalid Company TurnOver");
                }

                bool result = this.companyRepoObj.RegisterCompany(company);

                return result ? "Company Registered Successfully" : "Company Registeration Unsuccessfully";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
