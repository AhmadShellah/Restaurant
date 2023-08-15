using AutoMapper;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Contracts.Dtos;

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
