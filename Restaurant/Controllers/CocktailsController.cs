using Contracts;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    [ApiController]
    public class CocktailsController : ControllerBase, ICocktailService
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
