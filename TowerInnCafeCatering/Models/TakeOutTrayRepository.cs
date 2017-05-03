using System;
using TowerInnCafeCatering.Models;
using System.Collections.Generic;
namespace TowerInnCafeCatering.Models
{
    public class TakeOutTrayRepository : ITakeOutTrayRepository
    {
        public List<TakeOutTray> TakeOutTrays => new List<TakeOutTray>
        {
            new TakeOutTray { Name = "Beef and Pasta", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = ""},
            new TakeOutTray { Name = "Fish and Beef", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = ""},
            new TakeOutTray { Name = "Beef and Fish", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = ""},

        };
    }
}
