using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalesManagementApplication.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public virtual List<Sale> Sales { get; set; }
        [NotMapped]
        [Display(Name="Full Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}"; 
            }
        }
        [NotMapped]
        public decimal Supply { get; set; }
        [NotMapped]
        public IEnumerable<IGrouping<int,Sale>> SalesPerYearPerSeller { get; set; }
        [NotMapped]
        public IEnumerable<IEnumerable<IGrouping<int,Sale>>> SalesPerYearPerMonthSeller { get; set; }
        //[NotMapped]
        //public IEnumerable<IEnumerable<decimal>> SupplyPerSeller { get; set; }
        //[NotMapped]
        //public IEnumerable<IEnumerable<int>> CountSalesPerSeller { get; set; }
        [NotMapped]
        public IEnumerable<decimal> SupplyPerSeller { get; set; }
        [NotMapped]
        public IEnumerable<int> CountSalesPerSeller { get; set; }
        [NotMapped]
        public Dictionary<int,string> MonthPerKey { get; set; }
    }
}