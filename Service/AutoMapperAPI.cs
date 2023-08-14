using AutoMapper;
using Contracts.Dtos;
using Domain;

namespace Service
{
    public class AutoMapperAPI : Profile
    {
        public AutoMapperAPI()
        {
            CreateMap<Drinks, DrinksDto>();
            CreateMap<Food, FoodDto>();
        }
    }
}
