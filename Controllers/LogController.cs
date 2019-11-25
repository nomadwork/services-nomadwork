using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.Infra.Data.ObjectData.Schemes;
using Nomadwork.Repository;
using Nomadwork.ViewObject;

namespace Nomadwork.Controllers
{
    [AllowAnonymous, Route("api/log")]
    public class LogController : ControllerBase
    {
        private readonly LogRepository _logRepository;

        public LogController(LogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        // GET: api/Game
        [HttpGet("establishmments")]
        public async Task<IActionResult> Get()
        {
            var establishmments = await _logRepository.GetAllEstablishmmentDetails();

            


            return Json.Ok("Todos os Detalhamentos", establishmments);


           
        }

        // GET: api/Game/name
        [HttpGet("establishmments/{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var establishmments = await _logRepository.GetEstablishmmentDetail(id);

            if (establishmments == null)
                return new NotFoundResult();



            return Json.Ok("Detalhes do Estabelecimento", establishmments);
            
        }

        // POST: api/Game
        [HttpPost("establishmments/logcreate")]
        public async Task<IActionResult> Post([FromBody]List<EstablishmmentDetailsScheme> establishmment)
        {
            await _logRepository.CreateEstablishimmentLog(establishmment);
            return new OkObjectResult(establishmment);
        }

    }
}
