using AutoMapper;
using Contracts.Dtos;
using Domain;
using Contracts.Dtos;
using Contracts.CreateObject;
using Contracts.UpdateObject;

namespace Service
{
    internal class MappingCocktail : Profile
    {
        public MappingCocktail() 
        {
            CreateMap<Cocktail,CocktailDto>().ReverseMap();
            CreateMap<CocktailDto,CreateCocktailDto>().ReverseMap();
            CreateMap<CocktailDto, UpdateCocktailDto>().ReverseMap();
        }
    }
}
