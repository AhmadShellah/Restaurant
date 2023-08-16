using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.UpdateObject;

namespace Contracts.InterFaces
{
    public interface IDrinkService
    {
        public List<DrinksDto> GetDrinks();
        List<DrinksDto> CreateDrink(CreateDrinkDto createDrinkDto);
        List<DrinksDto> UpdateDrink(UpdateDrinkDto updateDrinkDto);

        DrinksDto GetDrinkById(int id);


    }
}
