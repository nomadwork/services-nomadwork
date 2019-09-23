using Microsoft.AspNetCore.Mvc;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Repository;
using Nomadwork.Model_View;
using Nomadwork.Model_View.Establishmment_List;
using Nomadwork.Shared;
using System.Collections.Generic;
using System.Linq;

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


        // GET api/values
        [HttpPost]
        public ActionResult<Json> Post([FromBody]Geolocation geolocation)
        {
            if (geolocation.Latitude == 0 && geolocation.Longitude == 0)
            {
                return NotFound(Json.Create("Geolocalização inválida!", null));
            }

            var repositoy = EstablishmmentRepository.GetInstance(_context);
            var list = repositoy.GetAllEstablishmentsByLocation(geolocation.Latitude, geolocation.Longitude);

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


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Json> Get(string id)
        {
            var repositoy = EstablishmmentRepository.GetInstance(_context);
            var select = repositoy.GetEstablishmentById(long.Parse(id));

            var establishmment = EstablishmmentById.Create(select.Id.ToString()
                , select.Name
                , string.Join(", ", select.Address.Street, select.Address.Number, select.Address.State, select.Address.Coutry, select.Address.Zipcode)
                , select.TimeOpen.ToString("hh:MM")
                , select.TimeClose.ToString("hh:MM"));

            select.Characteristics.ForEach(x =>
            {
                switch (x.Service)
                {
                    case Service.Internet:
                        establishmment.AddServices(ServiceOffered.Internet(x.Quality));
                        break;
                    case Service.Energy:
                        establishmment.AddServices(ServiceOffered.Energy(x.Quantity));
                        break;
                    case Service.Noise:
                        establishmment.AddServices(ServiceOffered.Noise(x.Quantity));
                        break;
                    default:
                        break;
                }
            });

            select.Photos.ForEach(x => establishmment.AddPhoto(x.UrlPhoto));

            return Ok(Json.Create("Estabelecimento Selecionado", establishmment));
        }

        //[HttpDelete("{id}")]
        //public async Task Go()
        //{
        //    var establishments = new EstablishmmentMockup().Init();

        //    var repository = EstablishmmentRepository.GetInstance(_context);

        //    await repository.CreateEstablishment(establishments);
        //}


        //[HttpPut]
        //public ActionResult<Json> Put([FromBody] EstablishmmentNameLocationId establishmment)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var repository = EstablishmmentRepository.GetInstance(_context);

        //        var establishmmentModel = new EstablishmentModelData
        //        {
        //          Id = establishmment.Id
        //        }; 

        //    }
        //    var list = SelectLocations(establishmment.Geolocation);

        //    return Json.Create("Não existem estabelecimentos", list);
        //}


        [Route("so_pra_ver_enum")]
        [HttpGet]
        public string Enums()
        {

            return @"

        public enum Quantity
        {
            None = 0,
            Has = 1,
            Little = 2,
            Much = 3,
        }

        public enum Quality
        {
            Bad = 0,
            Regular = 1,
            Good = 2,
            Great = 3

        }
        public enum Service
        {
            Internet = 1,
            Energy = 2,
            Noise = 3
        }";
        }
    }
}
