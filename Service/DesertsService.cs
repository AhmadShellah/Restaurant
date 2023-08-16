
using System;
using AutoMapper;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Domain;

namespace Service
{
    public class DesertsService : IDesertsService
    {
        private readonly IMapper _mapper;
      //  private readonly IMapper _newdesertmapper;

        public DesertsService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<DesertsDto> CreateDeserts(CreateDesertsDto inputFromUser)
        {

            var AllDeserts = GetDeserts();

            var mapping = _mapper?.Map<CreateDesertsDto, Deserts >(inputFromUser);
            var mapping2 = _mapper.Map<Deserts, DesertsDto>(mapping);
            AllDeserts.Add(mapping2);

            return AllDeserts;

        }

        public List<DesertsDto> GetDeserts()
        {
            var deserts = new List<Deserts>()
            {
                new Deserts { Id = 1 , Name ="Baqlawa" , Price = 200},
                new Deserts { Id =2 , Name ="Red Velvet" , Price=200}
            };

            var mapping = _mapper.Map<List<Deserts>,List<DesertsDto>>(deserts);

            return mapping;
        }

        public List<DesertsDto> UpdateDeserts(UpdateDesertsDto inputFromUser)
        {
           
            var AllDeserts = GetDeserts();
            var matchingDesert = AllDeserts.FirstOrDefault(desert => desert.Id == inputFromUser.Id);
            if (matchingDesert != null)
            {
                matchingDesert.Id = inputFromUser.Id;
                matchingDesert.Name = inputFromUser.Name;
                matchingDesert.Price = inputFromUser.Price;
            }
            var mapping = _mapper.Map<DesertsDto, Deserts>(matchingDesert);

            var mapping2 = _mapper.Map<Deserts, DesertsDto>(mapping);

            //AllDeserts=GetDeserts();
            return AllDeserts; 

        }

    

       
    }
}
