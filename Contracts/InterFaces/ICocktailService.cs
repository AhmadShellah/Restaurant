using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.UpdateObject;

namespace Contracts.InterFaces
{
    public interface ICocktailService
    {
        public Task<List<CocktailDto>> GetCocktails();

        public Task<bool> CreateCocktail(CreateCocktailDto createCocktailDto);

        public Task<bool> UpdateCocktail(UpdateCocktailDto updateCocktailDto);
        
        public Task<CocktailDto> GetCocktailById(int id);

        public Task<bool> DeleteCocktail(int id);
    }
}
