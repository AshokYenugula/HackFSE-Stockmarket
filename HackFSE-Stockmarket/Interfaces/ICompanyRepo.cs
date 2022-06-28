﻿using HackFSE_Stockmarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFSE_Stockmarket.Interfaces
{
    public interface ICompanyRepo
    {
        public bool RegisterCompany(Company company);
        public Company GetCompanyInfo(string companyCode);
        public List<Company> GetAllCompany();
    }
}
