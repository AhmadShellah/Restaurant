using AutoMapper;
using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DesertsService : IDesertsService
    {
        private readonly IMapper _mapper;

        public DesertsService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<Contracts.DesertsDto> GetDeserts()
        {
            var deserts = new List<Deserts>()
            {
                new Deserts { Id = 1 , Name ="Baqlawa" , Price = 200},
                new Deserts { Id =2 , Name ="Red Velvet" , Price=200}
            };

            var mapping = _mapper.Map<List<Deserts>,List<DesertsDto>>(deserts);

            return mapping;
        }

    }
}
