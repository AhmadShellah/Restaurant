using AutoMapper;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            CreateMap<Cocktail,CreateCocktailDto>().ReverseMap();
            CreateMap<Cocktail,UpdateCocktailDto>().ReverseMap();
            CreateMap<CocktailDto, UpdateCocktailDto>().ReverseMap();
        }
    }
}
