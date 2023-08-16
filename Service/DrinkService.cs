using AutoMapper;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Domain;

namespace Service
{
    public class DrinkService : IDrinkService
    {
        private readonly IMapper _mapper;

        public DrinkService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<DrinksDto> GetDrinks()
        {
            var drinks = new List<Drinks>
            {
                new Drinks { Id = 1, Name = "Cola", Price = 1.99 },
                new Drinks { Id = 2, Name = "Orange Juice", Price = 2.49 },

            };


            var mapping = _mapper.Map<List<Drinks>, List<DrinksDto>>(drinks);

            return mapping;
        }

        public List<DrinksDto> CreateDrink(CreateDrinkDto createDrinkDto)
        {
            var ListDrinks = GetDrinks();
            var mapping = _mapper.Map<CreateDrinkDto, Drinks>(createDrinkDto);
            var mapping2 = _mapper.Map<Drinks, DrinksDto>(mapping);

            ListDrinks.Add(mapping2);


            return ListDrinks;

        }

        public List<DrinksDto> UpdateDrink(UpdateDrinkDto updateDrinkDto)
        {
            var listDrinks = GetDrinks();

            var mapping = _mapper.Map<UpdateDrinkDto, Drinks>(updateDrinkDto);
            var mapping2 = _mapper.Map<Drinks, DrinksDto>(mapping);
            var matchedDrink = listDrinks.FirstOrDefault(drink => drink.Id == mapping2.Id);
            if (matchedDrink != null)
            {
                matchedDrink.Name = mapping2.Name;
                matchedDrink.Price = mapping2.Price;
            }

            return listDrinks;

        }


    }
}
