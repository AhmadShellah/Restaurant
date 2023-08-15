using Contracts.Dtos;
using Contracts.InterFaces;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class CocktailsController : ICocktailService
    {
        private readonly ICocktailService _cocktailService;

        public CocktailsController(ICocktailService cocktailService)
        {
            _cocktailService = cocktailService;
        }

        [HttpGet]
        [Route("api/Cocktails/GetCocktails")]
        public List<CocktailDto> GetCocktails()
        {
            return _cocktailService.GetCocktails();
        }
    }
}
