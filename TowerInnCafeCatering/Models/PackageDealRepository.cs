using System;
using TowerInnCafeCatering.Models;
using System.Collections.Generic;
namespace TowerInnCafeCatering.Models
{
    public class PackageDealRepository : IPackageDealRepository
    {
        public List<PackageDeal> PackageDeals => new List<PackageDeal>
        {
            new PackageDeal { Name = "Chicken and Pasta", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = ""},
            new PackageDeal { Name = "Chicken and Beef", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = ""},
            new PackageDeal { Name = "Chicken and Fish", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = ""},

        };
    }
}
