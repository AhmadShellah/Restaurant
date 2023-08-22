using AutoMapper;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Domain;

namespace Service
{
    public class HotDrinkService : IHotDrinkService
    {
        private readonly IMapper _mapper;

        public HotDrinkService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<HotDrinkDto> GetHotDrink()
        {
            var hotDrink = new List<HotDrink>
            {
                new HotDrink { Id = 1, Name = "Hot Tea", Price = 1.49 },
                new HotDrink { Id = 2, Name = "Hot Coffee", Price = 1.99 },
            };

            var mapping = _mapper.Map<List<HotDrink>, List<HotDrinkDto>>(hotDrink);

            return mapping;
        }

        public List<HotDrinkDto> CreateHotDrink(CreateHotDrinkDto createHotDrinkDto)
        {
            var listHotDrink = GetHotDrink();

            var mapping = _mapper.Map<CreateHotDrinkDto, HotDrink>(createHotDrinkDto);
            var mapping2 = _mapper.Map<HotDrink, HotDrinkDto>(mapping);

            listHotDrink.Add(mapping2);

            return listHotDrink;
        }

        public List<HotDrinkDto> UpdateHotDrink(UpdateHotDrinkDto updateHotDrinkDto)
        {
            var listHotDrinks = GetHotDrink();

            var mapping = _mapper.Map<UpdateHotDrinkDto, HotDrink>(updateHotDrinkDto);
            var mapping2 = _mapper.Map<HotDrink, HotDrinkDto>(mapping);

            var matchedHotDrink = listHotDrinks.FirstOrDefault(hotDrink => hotDrink.Id == mapping2.Id);
            if (matchedHotDrink != null)
            {
                matchedHotDrink.Name = mapping2.Name;
                matchedHotDrink.Price = mapping2.Price;
               
            }

            return listHotDrinks;
        }

        public HotDrinkDto GetHotDrinkById(int id)
        {
            var listHotDrink = GetHotDrink();

            var matchedHotDrink = listHotDrink.FirstOrDefault(hotDrink => hotDrink.Id == id);

            var mapping = _mapper.Map<HotDrinkDto, HotDrink>(matchedHotDrink);
            var mapping2 = _mapper.Map<HotDrink, HotDrinkDto>(mapping);

            return mapping2;
        }

        public List<HotDrinkDto> GetHotDrinks()
        {
            throw new NotImplementedException(); 
        }
    }
}
