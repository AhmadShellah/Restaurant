using AutoMapper;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Domain;
using Entity;

namespace Service
{

    public class FoodService : IFoodService
    {

        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _Context;

        public FoodService(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _Context = context;
        }



        public async Task<List<FoodDto>> GetFoods()
        {
            //var foods = new List<Food>
            //{
            //    new Food { Id = 1, Name = "orange", Price = 1.99 },
            //    new Food { Id = 2, Name = "burger", Price = 2.49 },

            //};


            //var mapping = _mapper.Map<List<Food>, List<FoodDto>>(foods);

            //return mapping;
            var matchedFood = _Context.Foods;
            var foodDto = _mapper.Map<List<FoodDto>>(matchedFood);
           
            return foodDto;




        }

        public async Task CreateFood(CreateFoodDto createFoodDto)
        {
            var mapping = _mapper?.Map<CreateFoodDto, Food>(createFoodDto);
            mapping.CreatedDate = DateTime.Now;
            var food = _Context.Add(mapping);
            await _Context.SaveChangesAsync();
        }


        public async Task UpdateFood(UpdateFoodDto updateFoodDto)
        {
           
            var matchedFood = _Context.Foods.FirstOrDefault(food => food.Id == updateFoodDto.Id);
            if (matchedFood != null)
            {
                var mapping = _mapper.Map(matchedFood,updateFoodDto);

             
                matchedFood.UpdateDate = DateTime.Now;
                
                _Context.Foods.Update(matchedFood);
                await _Context.SaveChangesAsync();

            }


        }


        public async Task<FoodDto> GetFoodById(int id)
        {
            var matchedFood = _Context.Foods.FirstOrDefault(food => food.Id == id);

            if (matchedFood != null)
            {
                var foodDto = _mapper.Map<FoodDto>(matchedFood);
                return foodDto;
            }

            return null; 
        }

        public async Task DeleteFoodById(int id)
        {
            var matchedFood = _Context.Foods.FirstOrDefault(food => food.Id == id);
            if (matchedFood != null)
            {
                matchedFood.DeletedDate = DateTime.Now;
                matchedFood.Deleted = true;
                _Context.Foods.Update(matchedFood);
                await _Context.SaveChangesAsync();

            }

        }
    }
}
