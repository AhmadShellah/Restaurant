using AutoMapper;
using Contracts.Dtos;
using Domain;

namespace Service
{
    public class AutoMapperAPI : Profile
    {
        public AutoMapperAPI()
        {
            CreateMap<Deserts, DesertsDto>();
        }
    }
}
