using SalesManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SalesManagementApplication.DAL
{
    public class SalesTaskDbContext:DbContext
    {
        public SalesTaskDbContext() : base("SalesTaskDb") { }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Seller> Seller { get; set; } 
    }
}