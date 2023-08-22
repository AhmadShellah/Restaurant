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
        public async Task<List<CocktailDto>> GetCocktails()
        {
            return await _cocktailService.GetCocktails();
        }

        [HttpPost]
        [Route("api/Cocktails/CreateCocktail")]
        public async Task<bool> CreateCocktail([FromBody]CreateCocktailDto createCocktailDto)
        {
            return await _cocktailService.CreateCocktail(createCocktailDto);
        }

        [HttpPut]
        [Route("api/Cocktails/UpdateCocktail")]
        public async Task<bool> UpdateCocktail(UpdateCocktailDto updateCocktailDto)
        {
            return await _cocktailService.UpdateCocktail(updateCocktailDto);
        }

        [HttpGet]
        [Route("api/Cocktails/GetCocktailById")]
        public async Task<CocktailDto> GetCocktailById(int id)
        {
            return await _cocktailService.GetCocktailById(id);
        }

        [HttpDelete]
        [Route("api/Cocktails/DeleteCocktail")]
        public async Task<bool> DeleteCocktail(int id)
        {
            return await _cocktailService.DeleteCocktail(id);
        }
    }
}
