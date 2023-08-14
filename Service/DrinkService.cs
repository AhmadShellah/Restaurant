using Contracts.Dtos;
using Contracts.InterFaces;


namespace Service
{
    public class DrinkService : IDrinkService
    {
        
        public List<DrinksDto> GetDrinks()
        {
            List<DrinksDto> drinks = new List<DrinksDto>
            {
                new DrinksDto { Id = 1, Name = "Cola", Price = 1.99 },
                new DrinksDto { Id = 2, Name = "Orange Juice", Price = 2.49 },

            };

            return drinks;
            

        }
    }
}
