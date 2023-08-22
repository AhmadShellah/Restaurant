using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.UpdateObject;

namespace Contracts.InterFaces
{
    public interface IHotDrinkService
    {
        public List<HotDrinkDto> GetHotDrink();
        List<HotDrinkDto> CreateHotDrink(CreateHotDrinkDto createHotDrinkDto);
        List<HotDrinkDto> UpdateHotDrink(UpdateHotDrinkDto updateHotDrinkDto);

        HotDrinkDto GetHotDrinkById(int id);
    }
}
