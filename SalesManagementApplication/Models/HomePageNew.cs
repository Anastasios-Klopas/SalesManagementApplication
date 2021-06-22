using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalesManagementApplication.Models
{
    [NotMapped]
    public class HomePageNew
    {
        [Display(Name ="Total Sellers")]
        public int TotalSellers { get; set; }
        [Display(Name = "Total Sales")]
        public int TotalSales { get; set; }
    }
}