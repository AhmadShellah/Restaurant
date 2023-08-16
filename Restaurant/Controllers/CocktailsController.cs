using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    [ApiController]
    public class CocktailsController : Controller, ICocktailService
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

        [HttpPost]
        [Route("api/Cocktails/CreateCocktail")]
        public List<CocktailDto> CreateCocktail(CreateCocktailDto createCocktailDto)
        {
            return _cocktailService.CreateCocktail(createCocktailDto);
        }

        [HttpPut]
        [Route("api/Cocktails/UpdateCocktail")]
        public List<CocktailDto> UpdateCocktail([FromBody]UpdateCocktailDto updateCocktailDto)
        {
            return _cocktailService.UpdateCocktail(updateCocktailDto);
        }

        [HttpGet]
        [Route("api/Cocktails/GetCocktailById")]
        public CocktailDto GetCocktailById(int id)
        {
            return _cocktailService.GetCocktailById(id);
        }
    }
}
