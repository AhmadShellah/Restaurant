using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CocktailService : ICocktailService
    {
        

        public List<CocktailDto> GetCocktails()
        {
            List<CocktailDto> listOfCocktailDto = new()
            {
                new CocktailDto { Id = 1, Price = 10, Name = "Test Cocktail 1"},
                new CocktailDto { Id = 2, Price = 20, Name = "Test Cocktail 2"},
                new CocktailDto { Id = 3, Price = 30, Name = "Test Cocktail 3"}
            };
            return listOfCocktailDto;
        }
    }
}
