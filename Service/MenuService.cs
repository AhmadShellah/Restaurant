using Contracts.Dtos;
using Contracts.InterFaces;

namespace Service
{
    public class MenuService : IMenu
    {
        private readonly IDrinkService _drinkService;
        private readonly IFoodService _foodService;
        private readonly ICocktailService _cocktailService;

        public MenuService(IDrinkService drinkService, IFoodService foodService, ICocktailService cocktailService)
        {
            _drinkService = drinkService;
            _foodService = foodService;
            _cocktailService = cocktailService;
        }

        public async Task<MenuDto> GetMenu()
        {
            var menu = new MenuDto();

            var drinkDto = _drinkService.GetDrinks();
            var foodDto = await _foodService.GetFoods();
            var cocktailDto = await _cocktailService.GetCocktails();

            menu.Drinks = drinkDto;
            menu.Foods = foodDto;
            menu.Cocktails = cocktailDto;

            return menu;
        }

    }
}
