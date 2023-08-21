using Contracts.Dtos;

namespace Contracts.InterFaces
{
    public interface IMenu
    {
        public Task<MenuDto> GetMenu();
    }
}
