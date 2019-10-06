using Microsoft.AspNetCore.Mvc;
using Nomadwork.Infra;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Repository;
using Nomadwork.ViewObject;
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

            var listEstablishment = Convert.To(list);

            if (list.Count().Equals(0))
            {
                return NotFound(Json.Create(string.Format("{0} Estabelecimentos encontrados", listEstablishment.Count()), null));
            }

            return Ok(Json.Create(string.Format("{0} Estabelecimentos encontrados", listEstablishment.Count()), listEstablishment));
        }
            
      

        [HttpGet("{id}")]
        public ActionResult<Json> Get(string id)
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);

            var select = repositoy.GetById(long.Parse(id));

            var establishmment = Convert.To(select);

            return Ok(Json.Create("Estabelecimento Selecionado", establishmment));
        }


        [HttpGet("v1")]
        public ActionResult<Json> GetAll()
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);
            var list = repositoy.GetAll();
            return Ok(Json.Create("Todas as sugestões", list));

        }

        [HttpGet("v1/{id:long}")]
        public ActionResult<Json> Get2(long id)
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);

            var select = repositoy.GetById(id);

            var establishmment = Convert.To(select);

            return Ok(Json.Create("Estabelecimento Selecionado", establishmment));
        }

        [HttpGet("v1/{term}")]
        public ActionResult<Json> Get2(string term)
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);
            var list = repositoy.GetByFilter(term);

            var listEstablishment = Convert.To(list);

            if (list.Count().Equals(0))
            {
                return NotFound(Json.Create(string.Format("{0} Estabelecimentos encontrados", listEstablishment.Count()), null));
            }

            return Ok(Json.Create(string.Format("{0} Estabelecimentos encontrados", listEstablishment.Count()), listEstablishment));
        }


        [HttpPost]
        public async Task<ActionResult<Json>> Post([FromBody]EstablishmmentCreate establishmment)
        {
            var establishmmentValidate = Convert.To(establishmment);

            if (establishmmentValidate.Erro)
            {
                return BadRequest(Json.Create(string.Join("\n", establishmmentValidate.Erros.ToArray()), establishmment));
            }

            var repository = EstablishmmentRepository.GetInstance(_context);

            var establishmmentSugestion = Convert.To(establishmmentValidate);

            var statusSave = await repository.CreateSingle(establishmmentSugestion);

            if (statusSave.Erro)
            {
                return BadRequest(Json.Create(statusSave.Description, establishmment));
            }

            return Ok(Json.Create(statusSave.Description, establishmment));
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
