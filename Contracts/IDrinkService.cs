using Contracts.Dtos;

namespace Contracts.InterFaces
{
    public interface IDrinkService
    {
        public List<DrinksDto> GetDrinks();
    }
}
