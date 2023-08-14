using AutoMapper;
using Contracts.Dtos;
using Contracts.InterFaces;
using Domain;

namespace Service
{

    public class FoodService : IFoodService
    {

        private readonly IMapper _mapper;


        public FoodService(IMapper mapper)
        {
            _mapper = mapper;

        }


        public List<FoodDto> GetFoods()
        {
            var foods = new List<Food>
            {
                new Food { Id = 1, Name = "orange", Price = 1.99 },
                new Food { Id = 2, Name = "burger", Price = 2.49 },

            };
            var mapping = _mapper.Map<List<Food>, List<FoodDto>>(foods);

            return mapping;
        }
    }
}
