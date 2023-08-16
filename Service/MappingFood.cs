using AutoMapper;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.UpdateObject;
using Domain;

namespace Service
{
    public class MappingFood : Profile
    {
        public MappingFood()
        {
            CreateMap<UpdateFoodDto, Food>().ReverseMap();
            CreateMap<CreateFoodDto,Food>().ReverseMap();
            CreateMap<Food, FoodDto>().ReverseMap();

        }


    }
}
