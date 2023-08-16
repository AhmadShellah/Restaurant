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
        public List<CocktailDto> GetCocktails();

        public List<CocktailDto> CreateCocktail(CreateCocktailDto createCocktailDto);

        public List<CocktailDto> UpdateCocktail(UpdateCocktailDto updateCocktailDto);
        
        public CocktailDto GetCocktailById(int id);
    }
}
