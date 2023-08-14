using AutoMapper;
using Contracts;
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
