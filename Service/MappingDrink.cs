using AutoMapper;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.UpdateObject;
using Domain;

namespace Service
{
    public class MappingDrink : Profile
    {
        public MappingDrink()
        {
            CreateMap<UpdateDrinkDto, Drinks>().ReverseMap();
            CreateMap<CreateDrinkDto, Drinks>().ReverseMap();
            CreateMap<Drinks, DrinksDto>().ReverseMap();
        }
    }
}
