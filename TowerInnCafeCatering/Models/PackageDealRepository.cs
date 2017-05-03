using System;
using TowerInnCafeCatering.Models;
using System.Collections.Generic;
namespace TowerInnCafeCatering.Models
{
    public class PackageDealRepository : IPackageDealRepository
    {
        public List<PackageDeal> PackageDeals => new List<PackageDeal>
        {
            new PackageDeal { Name = "Chicken and Pasta", Description = "Choice one of Ritz Dijon Chicken, BBQ Chicken, or Chicken Piccata, and your choice of two Pastas with Sauce, and Fresh Baked Breadsticks.", Price = 10M, Image = "~/images/banner1.jpg"},
            new PackageDeal { Name = "Tower Inn’s Grand Buffet Package", Description = "Roast Beef, Ritz Dijon Chicken, Sun-dried Tomato Cavatappi Pasta, Rosemary Roasted Potatoes, Vegetable Medley, and Fresh Baked Bread.", Price = 19m, Image = "~/images/banner2.jpg"},
            new PackageDeal { Name = "Pasta Package", Description = "Your Choice of Three Pastas, Roasted Vegetables and Fresh Baked Breadsticks.", Price = 10M, Image = "~/images/banner3.jpg"},
            new PackageDeal { Name = "Breakfast Package", Description = "Spinach & Feta Quiche, Ham & Cheddar Quiche, American Potatoes, Pancakes, Bacon & Ham, and served with Fruit", Price = 10M,Image =""},
            new PackageDeal { Name = "Pizza and Pasta Buffet", Description = "Your choice of Gourmet Pizzas, Pastas with Sauce, Fresh Baked Breadsticks, and Cinnamon Sugar Twists.", Price = 9M,Image =""},
        };
    }
}
