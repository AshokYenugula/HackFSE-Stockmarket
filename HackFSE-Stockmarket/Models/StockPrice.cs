using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFSE_Stockmarket.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public decimal StockPrice { get; set; }
        public string CompanyCode { get; set; }
        public DateTime StockDate { get; set; }

    }
}
