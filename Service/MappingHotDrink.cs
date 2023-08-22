using AutoMapper;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.UpdateObject;
using Domain;

namespace Service
{
    public class MappingHotDrink : Profile
    {
        public MappingHotDrink()
        {
            CreateMap<UpdateHotDrinkDto, HotDrink>().ReverseMap();
            CreateMap<CreateHotDrinkDto, HotDrink>().ReverseMap();
            CreateMap<HotDrink, HotDrinkDto>().ReverseMap();
        }
    }
}
