using AutoMapper;
using Contracts.Dtos;
using Domain;

namespace Service
{
    public class MappingDrink : Profile
    {
        public MappingDrink()
        {
            CreateMap<Drinks, DrinksDto>().ReverseMap();
        }
    }
}
