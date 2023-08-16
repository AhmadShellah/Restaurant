using AutoMapper;
using Contracts;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
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
        public List<CocktailDto> CreateCocktail(CreateCocktailDto createCocktailDto)
        {
            var allCocktails = GetCocktails();

            var mappedCocktail = _mapper.Map<Cocktail>(createCocktailDto);
            
            var mappedCocktailDto = _mapper.Map<CocktailDto>(mappedCocktail);
            
            allCocktails.Add(mappedCocktailDto);

            return allCocktails;
            
        }
        public List<CocktailDto> UpdateCocktail(UpdateCocktailDto updateCocktailDto)
        {
            var allCocktails = GetCocktails();

            if(updateCocktailDto == null)
            {
                return GetCocktails();
            }

            var matchingCocktailDto = allCocktails.FirstOrDefault(cocktailDto => cocktailDto.Id == updateCocktailDto.Id);

            if (matchingCocktailDto != null)
            {
                matchingCocktailDto.Price = updateCocktailDto.Price;
                matchingCocktailDto.Name = updateCocktailDto.Name;
            }

            var mappedCocktail = _mapper.Map<Cocktail>(matchingCocktailDto);
            
            //There is supposed to be a line to send the original object to the database

            var mappedCocktailDto = _mapper.Map<CocktailDto>(mappedCocktail);

            return allCocktails;
        }
        public CocktailDto GetCocktailById(int id)
        {
            var allCocktails = GetCocktails();

            var matchingCocktailWithSameId = allCocktails.FirstOrDefault(cocktail => cocktail.Id == id);

            var returnedCocktail = _mapper.Map<Cocktail>(matchingCocktailWithSameId);

            var returnedCocktailDto = _mapper.Map<CocktailDto>(returnedCocktail);

            return returnedCocktailDto;
        }

    }
}
