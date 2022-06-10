using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic ;
using System.Linq ;
using System.Threading.Tasks ;

namespace HackFSE_Stockmarket.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCEO { get; set; }
        public int CompanyTurnOver { get; set; }
        public string CompanyWebsite { get; set; }
        public string StockExchange { get; set; }

        [NotMapped]
        public List<Stock> StockPrice { get; set; }

    }
}
