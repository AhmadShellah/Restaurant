using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class Class1
    {

        public interface IFoodService
        {
            public List<FoodDto> GetDrinks();
            
        }

        public interface IDrinkService
        {
            public List<DrinksDto> GetDrinks();
        }


        public class FoodDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }

        }

        public class DrinksDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }

        }


    }
}
