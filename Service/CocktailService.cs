using AutoMapper;
using Contracts;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
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
        private readonly IMapper _mapper;

        public CocktailService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<CocktailDto> GetCocktails()
        {
            List<Cocktail> listOfCocktail = new()
            {
                new Cocktail { Id = 1, Price = 10, Name = "Test Cocktail 1"},
                new Cocktail { Id = 2, Price = 20, Name = "Test Cocktail 2"},
                new Cocktail { Id = 3, Price = 30, Name = "Test Cocktail 3"}
            };

            var mapping = _mapper.Map<List<Cocktail>, List<CocktailDto>>(listOfCocktail);

            return mapping;
        }
        public void CreateCocktail(int id, string name, double price)
        {
            CreateCocktailDto NewCocktail = new CreateCocktailDto
            {
                Id = id,
                Name = name,
                Price = price
            }; 
        }
        public List<CocktailDto> UpdateCocktail(int id, string name, double price)
        {
            List<CocktailDto> allCocktails = GetCocktails();
            foreach(CocktailDto cocktail in  allCocktails)
            {
                if(cocktail.Id == id)
                {
                    cocktail.Name = name;
                    cocktail.Price = price;
                    break;
                }
            }
            var mapping = _mapper.Map<List<CocktailDto>>(allCocktails);

            return mapping;
        }
    }
}
