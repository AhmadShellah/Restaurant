using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    [ApiController]
    public class DesertsController : ControllerBase, IDesertsService
    {
        private readonly IDesertsService _desertService;
        public DesertsController(IDesertsService DesertsService)
        {
            _desertService = DesertsService;
        }
        [HttpPost]
        [Route("api/CreateDesertDTO/CreateDeserts")]
        public List<DesertsDto> CreateDeserts(CreateDesertsDto inputFromUser)
        {
            var NewDes = _desertService.CreateDeserts(inputFromUser);
            return NewDes;
        }

        //public DesertsDto UpdateDeserts(CreateDesertsDto inputFromUser)
        //{
        //    var NewDes = _desertService.CreateDeserts(inputFromUser);
        //    return NewDes;
        //}

        [HttpGet]
        [Route("api/Deserts/GetDeserts")]
        public List<DesertsDto> GetDeserts()
        {
            var Des = _desertService.GetDeserts();

            return Des;
        }

        [HttpPost]
        [Route("api/UpdateDesertsDto/UpdateDeserts")]
        public List<DesertsDto> UpdateDeserts(UpdateDesertsDto inputFromUser)
        {
            var UpdatedDeserts = _desertService.UpdateDeserts(inputFromUser);
            return UpdatedDeserts;
            
        }
    }
}
