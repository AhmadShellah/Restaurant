using AutoMapper;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.UpdateObject;
using Domain;

namespace Service
{
    public class AutoMapperAPI : Profile
    {
        public AutoMapperAPI()
        {

            CreateMap<CreateDesertsDto, Deserts>().ReverseMap();
            
            
            //CreateMap<CreateDesertsDto, DesertsDto>().ReverseMap();
            CreateMap<UpdateDesertsDto, DesertsDto>().ReverseMap();
            CreateMap<Deserts, DesertsDto>().ReverseMap();

        }
    }
}
