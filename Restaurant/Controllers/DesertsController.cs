using Contracts.Dtos;
using Contracts.InterFaces;
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

        [HttpGet]
        [Route("api/Deserts/GetDeserts")]
        public List<DesertsDto> GetDeserts()
        {
            var Des = _desertService.GetDeserts();

            return Des;
        }




    }
}
