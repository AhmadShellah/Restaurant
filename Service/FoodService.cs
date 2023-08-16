using AutoMapper;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
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

        public List<FoodDto> CreateFood(CreateFoodDto createFoodDto)
        {

            var ListFood = GetFoods();
            var mapping = _mapper.Map<CreateFoodDto, Food>(createFoodDto);
            var mapping2 = _mapper.Map<Food, FoodDto>(mapping);
            ListFood.Add(mapping2);

            return ListFood;

        }


        public List<FoodDto> UpdateFood(UpdateFoodDto updateFoodDto)
        {
            var listFoods = GetFoods();

            var mapping = _mapper.Map<UpdateFoodDto, Food>(updateFoodDto);
            var mapping2 = _mapper.Map<Food, FoodDto>(mapping);
            var matchedDrink = listFoods.FirstOrDefault(drink => drink.Id == mapping2.Id);
            if (matchedDrink != null)
            {
                matchedDrink.Name = mapping2.Name;
                matchedDrink.Price = mapping2.Price;
            }

            return listFoods;

        }
    }
}
