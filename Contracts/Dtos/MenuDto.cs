
namespace Contracts.Dtos
{
    public class MenuDto
    {
        public List<DrinksDto> Drinks { get; set; }
        public List<FoodDto> Foods { get; set; }

        public List<CocktailDto> Cocktails { get; set; }
    }

}
