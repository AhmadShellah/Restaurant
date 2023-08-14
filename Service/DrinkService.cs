using AutoMapper;
using Contracts.Dtos;
using Contracts.InterFaces;
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

    }
}
