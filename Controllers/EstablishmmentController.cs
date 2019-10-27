using Microsoft.AspNetCore.Authorization;
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
    [Authorize("Bearer")]
    public class EstablishmmentController : ControllerBase
    {
        private readonly NomadworkDbContext _context;

        public EstablishmmentController(NomadworkDbContext context)
        {
            _context = context;
        }


        [HttpGet("{latitude},{longitude}")]
        public Json Get(decimal latitude, decimal longitude)
        {
            var geolocation = Geolocation.Create(latitude, longitude);

            if (geolocation.Latitude == 0 && geolocation.Longitude == 0)
            {
                return Json.NotFound("Geolocalização inválida!", null);
            }

            var repositoy = EstablishmmentRepository.GetInstance(_context);
            var list = repositoy.GetByLocation(geolocation.Latitude, geolocation.Longitude);


            if (list.Any())
            {
                return Json.Ok(string.Format("{0} Estabelecimentos encontrados", list.Count()), list.ToEstablishmmentNameLocationIdList());
            }

            return Json.NotFound("Nenhum Estabelecimento encontrado próximo a você! Que tal fazer uma sugestão de estabelecimento?!", list);

        }



        [HttpGet("{id}")]
        public Json Get(string id)
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);

            var select = repositoy.GetById(long.Parse(id));


            if (select != null)
            {

                return Json.Ok("OBS:Por favor teste a rota v1{id}, Estabelecimento Selecionado", select.ToEstablishmmentById());
            }

            return Json.NotFound("OBS:Por favor teste a rota v1{id}, Não existe estabelecimento com este Id", select);

        }


        //[HttpGet("v1")]
        //public Json GetAll()
        //{
        //    var repositoy = EstablishmmentRepository.GetInstance(_context);
        //    var list = repositoy.GetAll();

        //    if (list.Any())
        //    {
        //        return Json.Ok("Todas as sugestões deste usuário", list);
        //    }

        //    return Json.NotFound("Nenhuma sugestão feita", list);

        //}


        [HttpGet("v1/{id:long}")]
        public Json Get2(long id)
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);

            var select = repositoy.GetById(id);

            if (select != null)
            {
               
                return Json.Ok("Estabelecimento Selecionado", select.ToEstablishmmentById());
            }

            return Json.NotFound("Não existe estabelecimento com este Id", select);

        }


        [HttpGet("v1/{term}")]
        public Json Get2(string term)
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);
            var list = repositoy.GetByFilter(term);

            if (list.Any())
            {              
                return Json.Ok(string.Format("{0} Estabelecimentos encontrados", list.Count()), list.ToEstablishmmentNameLocationIdList());
            }

            return Json.NotFound("Nenhum Estabelecimento encontrados!", list);

        }


        [HttpPost]
        public async Task<Json> Post([FromBody]EstablishmmentCreate establishmment)
        {
            var establishmmentValidate = establishmment.ToEstablishmment();

            if (establishmmentValidate.Erro)
            {
                return Json.BadRequest(establishmmentValidate.Erros, establishmment);
            }

            var repository = EstablishmmentRepository.GetInstance(_context);

            var statusSave = await repository.CreateSingle(establishmmentValidate.ToEstablishmmentSugestion());

            if (statusSave.Erro)
            {
                return Json.BadRequest(statusSave.Description, establishmment);
            }

            return Json.Ok(statusSave.Description, establishmment);
        }


    }
}
