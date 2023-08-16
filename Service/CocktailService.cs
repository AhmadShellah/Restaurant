using AutoMapper;
using Contracts.Dtos;
using Contracts.InterFaces;
using Domain;

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
    }
}
