using Microsoft.AspNetCore.Mvc;
using Nomadwork.Domain.Business;
using Nomadwork.Infra;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Repository;
using Nomadwork.ViewObject;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.Controllers
{
    [Route("api/establishmment")]
    [ApiController]
    public class EstablishmmentController : ControllerBase
    {
        private readonly NomadworkDbContext _context;

        public EstablishmmentController(NomadworkDbContext context)
        {
            _context = context;
        }

        [HttpGet("{latitude},{longitude}")]
        public ActionResult<Json> Get(decimal latitude, decimal longitude)
        {
            var geolocation = Geolocation.Create(latitude, longitude);

            if (geolocation.Latitude == 0 && geolocation.Longitude == 0)
            {
                return NotFound(Json.Create("Geolocalização inválida!", null));
            }

            var repositoy = EstablishmmentRepository.GetInstance(_context);
            var list = repositoy.GetByLocation(geolocation.Latitude, geolocation.Longitude);

            var listEstablishment = new List<EstablishmmentNameLocationId>();


            list.ToList().ForEach(x =>
            {
                listEstablishment.Add(EstablishmmentNameLocationId.Create(x.Id.ToString(), x.Name, x.Address.Latitude, x.Address.Longitude));
            });

            if (list.Count().Equals(0))
            {
                return NotFound(Json.Create(string.Format("{0} Estabelecimentos encontrados", listEstablishment.Count), null));
            }

            return Ok(Json.Create(string.Format("{0} Estabelecimentos encontrados", listEstablishment.Count), listEstablishment));
        }


        [HttpGet("{id}")]
        public ActionResult<Json> Get(string id)
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);

            var select = repositoy.GetById(long.Parse(id));

            var establishmment = Convert.To(select);

            return Ok(Json.Create("Estabelecimento Selecionado", establishmment));
        }


        [HttpPost]
        public async Task<ActionResult<Json>> Post([FromBody]EstablishmmentCreate establishmment)
        {
            var validate = Establishment.Create(establishmment.Name, establishmment.Email, establishmment.Phone, establishmment.Schedule.Open, establishmment.Schedule.Close,establishmment.Wifi.Rate,establishmment.Noise.Rate,establishmment.Plug.Rate);

            if (validate.Erro)
            {
                return BadRequest(Json.Create(string.Join("\n", validate.Erros.ToArray()), establishmment));
            }

            var repository = EstablishmmentRepository.GetInstance(_context);

            var validateToModel = Convert.To(establishmment);

            var statusSave = await repository.CreateSingle(validateToModel);

            return Ok(Json.Create(statusSave, establishmment));
        }

        //put e delete
        //[HttpPut("{id}")]
        //public ActionResult<Json> Put(string id, [FromBody] EstablishmmentCreate establishmment)
        //{
        //    return Json.Create("Não existem estabelecimentos", establishmment);
        //}


        [HttpDelete("{id}")]
        public async Task Go()
        {
            var establishments = new EstablishmmentMockup().Init();

            var repository = EstablishmmentRepository.GetInstance(_context);

            await repository.CreateMok(establishments);
        }

    }
}
