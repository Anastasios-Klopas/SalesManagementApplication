namespace SalesManagementApplication.Migrations
{
    using SalesManagementApplication.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesManagementApplication.DAL.SalesTaskDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SalesManagementApplication.DAL.SalesTaskDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var sellers = new List<Seller>
            {
                new Seller
                {
                    Id=1,
                    FirstName="Kwstas",
                    LastName="Kwstakhs",
                    Sales= new List<Sale>
                    {
                        new Sale
                        {
                            Id=1,
                            TransactionAmount=100m,
                            DateOfSale=DateTime.Parse("2021-01-01"), // yyyy-mm-dd
                        },
                        new Sale
                        {
                            Id=2,
                            TransactionAmount=50m,
                            DateOfSale=DateTime.Parse("2021-01-15"),
                        },
                        new Sale
                        {
                            Id=3,
                            TransactionAmount=75m,
                            DateOfSale=DateTime.Parse("2021-01-30"),
                        },
                        new Sale
                        {
                            Id=4,
                            TransactionAmount=25m,
                            DateOfSale=DateTime.Parse("2021-02-15"),
                        }
                    }
                },
                new Seller
                {
                    Id=2,
                    FirstName="Elenh",
                    LastName="Elenitsa",
                    Sales= new List<Sale>
                    {
                        new Sale
                        {
                            Id=5,
                            TransactionAmount=110m,
                            DateOfSale=DateTime.Parse("2021-02-01"), // yyyy-mm-dd
                        },
                        new Sale
                        {
                            Id=6,
                            TransactionAmount=60m,
                            DateOfSale=DateTime.Parse("2021-02-15"),
                        },
                        new Sale
                        {
                            Id=7,
                            TransactionAmount=45m,
                            DateOfSale=DateTime.Parse("2021-03-30"),
                        },
                        new Sale
                        {
                            Id=8,
                            TransactionAmount=15m,
                            DateOfSale=DateTime.Parse("2021-03-15"),
                        }
                    }
                },
                new Seller
                {
                    Id=3,
                    FirstName="Basilhs",
                    LastName="Basilakhs",
                    Sales= new List<Sale>
                    {
                        new Sale
                        {
                            Id=9,
                            TransactionAmount=110m,
                            DateOfSale=DateTime.Parse("2021-01-09"), // yyyy-mm-dd
                        },
                        new Sale
                        {
                            Id=10,
                            TransactionAmount=60m,
                            DateOfSale=DateTime.Parse("2021-02-17"),
                        },
                        new Sale
                        {
                            Id=11,
                            TransactionAmount=45m,
                            DateOfSale=DateTime.Parse("2021-03-20"),
                        },
                        new Sale
                        {
                            Id=12,
                            TransactionAmount=15m,
                            DateOfSale=DateTime.Parse("2021-04-25"),
                        }
                    }
                },
                new Seller
                {
                    Id=4,
                    FirstName="Giwta",
                    LastName="Giwtoula",
                    Sales= new List<Sale>
                    {
                        new Sale
                        {
                            Id=13,
                            TransactionAmount=250m,
                            DateOfSale=DateTime.Parse("2021-01-05"), // yyyy-mm-dd
                        },
                        new Sale
                        {
                            Id=14,
                            TransactionAmount=200m,
                            DateOfSale=DateTime.Parse("2021-02-28"),
                        },
                        new Sale
                        {
                            Id=15,
                            TransactionAmount=175m,
                            DateOfSale=DateTime.Parse("2021-03-11"),
                        },
                        new Sale
                        {
                            Id=16,
                            TransactionAmount=155m,
                            DateOfSale=DateTime.Parse("2021-04-22"),
                        },
                        new Sale
                        {
                            Id=17,
                            TransactionAmount=125m,
                            DateOfSale=DateTime.Parse("2021-05-29"),
                        },
                        new Sale
                        {
                            Id=18,
                            TransactionAmount=115m,
                            DateOfSale=DateTime.Parse("2021-06-14"),
                        }
                    }
                },
                new Seller
                {
                    Id=5,
                    FirstName="Giannis",
                    LastName="Giannakis",
                    Sales= new List<Sale>
                    {
                        new Sale
                        {
                            Id=19,
                            TransactionAmount=10m,
                            DateOfSale=DateTime.Parse("2021-01-08"), // yyyy-mm-dd
                        },
                        new Sale
                        {
                            Id=20,
                            TransactionAmount=15m,
                            DateOfSale=DateTime.Parse("2021-01-28"),
                        },
                        new Sale
                        {
                            Id=21,
                            TransactionAmount=20m,
                            DateOfSale=DateTime.Parse("2021-02-18"),
                        },
                        new Sale
                        {
                            Id=22,
                            TransactionAmount=25m,
                            DateOfSale=DateTime.Parse("2021-02-19"),
                        },
                        new Sale
                        {
                            Id=23,
                            TransactionAmount=45m,
                            DateOfSale=DateTime.Parse("2021-03-12"),
                        },
                        new Sale
                        {
                            Id=24,
                            TransactionAmount=66m,
                            DateOfSale=DateTime.Parse("2021-03-13"),
                        }
                    }
                },
                new Seller
                {
                    Id=6,
                    FirstName="Maria",
                    LastName="Maraki",
                    Sales= new List<Sale>
                    {
                        new Sale
                        {
                            Id=25,
                            TransactionAmount=8m,
                            DateOfSale=DateTime.Parse("2021-01-08"), // yyyy-mm-dd
                        },
                        new Sale
                        {
                            Id=26,
                            TransactionAmount=18m,
                            DateOfSale=DateTime.Parse("2021-01-17"),
                        },
                        new Sale
                        {
                            Id=27,
                            TransactionAmount=38m,
                            DateOfSale=DateTime.Parse("2021-02-07"),
                        },
                        new Sale
                        {
                            Id=28,
                            TransactionAmount=58m,
                            DateOfSale=DateTime.Parse("2021-02-10"),
                        },
                        new Sale
                        {
                            Id=29,
                            TransactionAmount=28m,
                            DateOfSale=DateTime.Parse("2021-03-27"),
                        },
                        new Sale
                        {
                            Id=30,
                            TransactionAmount=48m,
                            DateOfSale=DateTime.Parse("2021-03-28"),
                        }
                    }
                },
                new Seller
                {
                    Id=7,
                    FirstName="Giwrgos",
                    LastName="Giwrgakhs",
                    Sales= new List<Sale>
                    {
                        new Sale
                        {
                            Id=31,
                            TransactionAmount=117m,
                            DateOfSale=DateTime.Parse("2021-02-08"), // yyyy-mm-dd
                        },
                        new Sale
                        {
                            Id=32,
                            TransactionAmount=217m,
                            DateOfSale=DateTime.Parse("2021-02-17"),
                        },
                        new Sale
                        {
                            Id=33,
                            TransactionAmount=312m,
                            DateOfSale=DateTime.Parse("2021-04-14"),
                        },
                        new Sale
                        {
                            Id=34,
                            TransactionAmount=322m,
                            DateOfSale=DateTime.Parse("2021-04-22"),
                        },
                        new Sale
                        {
                            Id=35,
                            TransactionAmount=99m,
                            DateOfSale=DateTime.Parse("2021-04-25"),
                        },
                        new Sale
                        {
                            Id=36,
                            TransactionAmount=79m,
                            DateOfSale=DateTime.Parse("2021-04-30"),
                        }
                    }
                },
                new Seller
                {
                    Id=8,
                    FirstName="Katerina",
                    LastName="Katerinaki",
                    Sales= new List<Sale>
                    {
                        new Sale
                        {
                            Id=37,
                            TransactionAmount=117m,
                            DateOfSale=DateTime.Parse("2020-02-11"), // yyyy-mm-dd
                        },
                        new Sale
                        {
                            Id=38,
                            TransactionAmount=217m,
                            DateOfSale=DateTime.Parse("2020-02-13"),
                        },
                        new Sale
                        {
                            Id=39,
                            TransactionAmount=312m,
                            DateOfSale=DateTime.Parse("2020-04-19"),
                        },
                        new Sale
                        {
                            Id=40,
                            TransactionAmount=322m,
                            DateOfSale=DateTime.Parse("2021-05-22"),
                        },
                        new Sale
                        {
                            Id=41,
                            TransactionAmount=99m,
                            DateOfSale=DateTime.Parse("2021-05-25"),
                        },
                        new Sale
                        {
                            Id=42,
                            TransactionAmount=79m,
                            DateOfSale=DateTime.Parse("2021-05-30"),
                        }
                    }
                }
            };
            sellers.ForEach(s => context.Seller.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
