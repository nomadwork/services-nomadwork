using Microsoft.AspNetCore.Mvc;
using Nomadwork.Infra;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Repository;
using Nomadwork.ViewObject;
using Nomadwork.ViewObject.Business;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.Controllers
{
    [Route("api/establishmment")]
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


        //  [HttpGet("{id}")]
        [HttpGet("{id:long}")]
        public Json Get(long id)
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);

            var select = repositoy.GetById(id);

            if (select != null)
            {

                return Json.Ok("Estabelecimento Selecionado", select.ToEstablishmmentById());
            }

            return Json.NotFound("Não existe estabelecimento com este Id", select);

        }


        [HttpGet("{term}")]
        public Json Get(string term)
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);
            var list = repositoy.GetByFilter(term);

            if (list.Any())
            {
                return Json.Ok(string.Format("{0} Estabelecimentos encontrados", list.Count()), list.ToEstablishmmentNameLocationIdList());
            }

            return Json.NotFound("Nenhum Estabelecimento encontrados!", list);

        }

        [HttpGet("details/{id:long}")]
        public Json GetDetails(long id)
        {
            var t = new Teste
            {
                Id = id,
                Sex = new List<Sexs>
{                   new Sexs{ Name = "Female", Value = 60},
                    new Sexs{ Name = "Male", Value = 50},
                    new Sexs{ Name = "Others", Value = 40}

                },
                Age = new List<Ages>
                {
                    new Ages{Name = 1999, Value = 30},
                    new Ages{Name = 1988, Value = 20},
                    new Ages{Name = 2000, Value = 10}

                }

            };


            return Json.Ok("teste", t);
        }

        class Teste
        {
            public long Id { get; set; }
            public List<Sexs> Sex { get; set; }
            public List<Ages> Age { get; set; }
        }
        class Sexs
        {
            public string Name { get; set; }
            public int Value { get; set; }

        }
        class Ages
        {
            public int Name { get; set; }
            public int Value { get; set; }
        }



        [HttpPost]
        public async Task<Json> Post([FromBody]EstablishmmentToCreate establishmment)
        {
            var establishmmentValidate = establishmment.ToEstablishmment();

            if (establishmmentValidate.Erro)
            {
                return Json.BadRequest(establishmmentValidate.Erros, establishmment);
            }

            var repository = SugestionRepository.GetInstance(_context);

            var statusSave = await repository.CreateSingle(establishmmentValidate.ToEstablishmmentSugestion());

            if (statusSave.Erro)
            {
                return Json.BadRequest(statusSave.Description, establishmment);
            }

            return Json.Ok(statusSave.Description, establishmment);
        }


        [HttpPut]
        public async Task<Json> Put([FromBody] BusinessToAdmin business)
        {
            if (business.EstablishmmentId <= 0 || business.UserId <= 0)
            {
                return Json.BadRequest("Selecione um estabelecioemnto e um usuário válidos", business);
            }

            var repositoryUser = UserRepository.GetInstance(_context);

            var user = await repositoryUser.GetById(business.UserId);

            if (user == null)
            {
                return Json.BadRequest("Selecione  um usuário válido", business);
            }

            var repositoryEstablishmment = EstablishmmentRepository.GetInstance(_context);
            var establishmmnet = repositoryEstablishmment.GetById(business.EstablishmmentId);

            if (establishmmnet == null)
            {
                return Json.BadRequest("Selecione um estabelecioemnto válido", business);
            }

            if (!user.Admin)
            {
                _ = await repositoryUser.TurnUserAdminById(user.Id);
            }

            var status = await repositoryEstablishmment.TurnUserAdminToEstablishmmnet(establishmmnet.Id, user.Id);

            if (status.Erro)
            {
                return Json.BadRequest(status.Description, business);
            }

            return Json.Ok(status.Description, business);
        }

    }
}
