using Contracts.Dtos;

namespace Contracts.InterFaces
{
    public interface ICocktailService
    {
        public List<CocktailDto> GetCocktails();
    }
}
