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
            var matchedFood = listFoods.FirstOrDefault(food => food.Id == mapping2.Id);
            if (matchedFood != null)
            {
                matchedFood.Name = mapping2.Name;
                matchedFood.Price = mapping2.Price;
            }

            return listFoods;

        }


        public FoodDto GetFoodById(int id)
        {
            var listFoods = GetFoods();


            var matchedFood = listFoods.FirstOrDefault(food => food.Id == id);

            var mapping = _mapper.Map<FoodDto, Food>(matchedFood);
            var mapping2= _mapper.Map<Food, FoodDto>(mapping);

            return mapping2;


        }


    }
}
