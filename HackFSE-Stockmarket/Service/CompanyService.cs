using HackFSE_Stockmarket.Interfaces;
using HackFSE_Stockmarket.Models;
using HackFSE_Stockmarket.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFSE_Stockmarket.Service
{
    public class CompanyService : ICompanyService
    {
        public readonly ICompanyRepo companyRepoObj;

        public CompanyService(ICompanyRepo companyRepoObj)
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

        public Company GetCompanyInfo(string companyCode)
        {
            try
            {
                var result = this.companyRepoObj.GetCompanyInfo(companyCode);
                if (result == null)
                {
                    //throw new HttpResponseException(Request.CreateErrorResponse(HttpRequest.)) 
                   throw new Exception("Invalid Company Code");
                }
                return result;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Company> GetAllCompany()
        {
            try
            {
                var result = this.companyRepoObj.GetAllCompany();
                if (result == null)
                {
                    //throw new HttpResponseException(Request.CreateErrorResponse(HttpRequest.)) 
                    throw new Exception("Invalid Company Code");
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string DeleteCompany(string companycode)
        {
            try
            {

                bool result = this.companyRepoObj.DeleteCompany(companycode);

                return result ? "Company deleted Successfully" : "Company deletion Unsuccessfully";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
