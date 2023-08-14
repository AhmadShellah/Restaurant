using AutoMapper;
using Contracts.Dtos;
using Domain;

namespace Service
{
    public class MappingFood : Profile
    {
        public MappingFood()
        {
            CreateMap<Food, FoodDto>().ReverseMap();
        }
    }
}
