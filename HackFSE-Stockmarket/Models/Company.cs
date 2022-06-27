using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic ;
using System.Linq ;
using System.Threading.Tasks ;
using System.ComponentModel.DataAnnotations;

namespace HackFSE_Stockmarket.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [Required]
        public string CompanyCode { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyCEO { get; set; }
        [Required]
        public int CompanyTurnOver { get; set; }
        [Required]
        public string CompanyWebsite { get; set; }
        [Required]
        public string StockExchange { get; set; }

        [NotMapped]
        public List<Stock> StockPrice { get; set; }

    }
}
