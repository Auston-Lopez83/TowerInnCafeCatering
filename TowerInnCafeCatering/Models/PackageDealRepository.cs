using System;
using TowerInnCafeCatering.Models;
using System.Collections.Generic;
namespace TowerInnCafeCatering.Models
{
    public class PackageDealRepository : IPackageDealRepository
    {
        public List<PackageDeal> PackageDeals => new List<PackageDeal>
        {
            new PackageDeal { Name = "Chicken and Pasta", Description = "Choice one of Ritz Dijon Chicken, BBQ Chicken, or Chicken Piccata, and your choice of two Pastas with Sauce, and Fresh Baked Breadsticks.", Price = "$10.00", Image = "https://simplybeingmommy.com/wp-content/uploads/2011/07/peanut-butter-chicken-pasta.jpg"},
            new PackageDeal { Name = "Tower Inn’s Grand Buffet Package", Description = "Roast Beef, Ritz Dijon Chicken, Sun-dried Tomato Cavatappi Pasta, Rosemary Roasted Potatoes, Vegetable Medley, and Fresh Baked Bread.", Price = "$19.00", Image = "~/images/banner2.jpg"},
            new PackageDeal { Name = "Pasta Package", Description = "Your Choice of Three Pastas, Roasted Vegetables and Fresh Baked Breadsticks.", Price = "$10.00", Image = "https://fthmb.tqn.com/Q_AbPbVVl_Wn6ZH5JxblpbHuu3c=/5990x3994/filters:no_upscale()/about/Fresh-Tomato-Pasta-58addfe43df78c345be02f3f.jpg"},
            new PackageDeal { Name = "Breakfast Package", Description = "Spinach & Feta Quiche, Ham & Cheddar Quiche, American Potatoes, Pancakes, Bacon & Ham, and served with Fruit", Price = "$10.00",Image =""},
            new PackageDeal { Name = "Pizza and Pasta Buffet", Description = "Your choice of Gourmet Pizzas, Pastas with Sauce, Fresh Baked Breadsticks, and Cinnamon Sugar Twists.", Price = "$9.00",Image =""},
            new PackageDeal { Name = "The Exquisite Package", Description = "Your choice of two Appetizer Trays*, Choice of Chicken, Chef Carved Prime Rib, Choice of Pastas with Sauce, Rosemary Roasted Potatoes, Roasted Vegetables, and Fresh Baked Breadsticks", Price = "$22.00",Image =""},
            new PackageDeal { Name = "Outdoor Kebob Package", Description = "Grilled Fresh Beef Kebob,Chicken Kebob,Vegetable Kebob with a Buffet of Pasta with Sauce, Vegetable Medley, Garben Salad, and Fresh Baked Bread.", Price = "$19.00", Image = "~/images/banner2.jpg"},
            new PackageDeal { Name = "Custom Tower Inn’s Menu", Description = "Our Chef Will work with you to design a Menu", Price = "Price will vary", Image = "~/images/banner2.jpg"},
        };
    }
}
