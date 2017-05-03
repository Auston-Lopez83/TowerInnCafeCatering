using System;
using TowerInnCafeCatering.Models;
using System.Collections.Generic;
namespace TowerInnCafeCatering.Models
{
    public class CreateYourOwnCateringRepository : ICreateYourOwnCateringRepository
    {
        public List<CreateYourOwnCatering> CreateYourOwnCaterings => new List<CreateYourOwnCatering>
        {
            new CreateYourOwnCatering { Name = "Chicken and Pasta", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = ""},
            new CreateYourOwnCatering { Name = "Chicken and Beef", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = ""},
            new CreateYourOwnCatering { Name = "Chicken and Fish", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = ""},

        };
    }
}
