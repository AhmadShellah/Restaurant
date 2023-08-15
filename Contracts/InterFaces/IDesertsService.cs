using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.UpdateObject;

namespace Contracts.InterFaces
{
    public interface IDesertsService
    {
        public List<DesertsDto> GetDeserts();
        public List<DesertsDto> CreateDeserts(CreateDesertsDto inputFromUser);
        public List<DesertsDto> UpdateDeserts(UpdateDesertsDto inputFromUser);



    }
}
