using AutoMapper;
using Contracts.Dtos;
using Domain;

namespace Service
{
    internal class MappingCocktail : Profile
    {
        public MappingCocktail() 
        {
            CreateMap<Cocktail,CocktailDto>().ReverseMap();
        }
    }
}
