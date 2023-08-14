using Contracts.Dtos;

namespace Contracts.InterFaces
{
    public interface IFoodService
    {
        public List<FoodDto> GetFoods();
    }
}
