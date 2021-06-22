using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesManagementApplication.Models
{
    public class SellerSalesViewModel
    {
        public Seller Seller { get; set; }
        public List<Sale> Sales { get; set; }
    }
}