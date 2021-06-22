using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesManagementApplication.Models
{
    public class Sale
    {
        public int Id { get; set; }
        [Display(Name ="Transcaction Amount")]
        public decimal TransactionAmount { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Sale")]
        public DateTime DateOfSale { get; set; }

        public virtual int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
    }
}