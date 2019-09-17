using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nomadwork.Model_View;
using Nomadwork.Model_View.Establishmment_List;

namespace Nomadwork.Controllers
{
    [Route("api/establishmment")]
    [ApiController]
    public class EstablishmmentController : ControllerBase
    {
        //ResultListEstablishmmentNameLocationId establishmment;

        // GET api/values
        [HttpPost]
        [ResponseCache(Duration = 60)]
        // [Authorize]
        public ActionResult<Json> Get([FromBody]Geolocation geolocation)
        {
            var establishmment = ResultListEstablishmmentNameLocationId.GetInstance();

            establishmment.AddEstaBlishment("00001", "Teste", -8.999M, -10.33333M);
            establishmment.AddEstaBlishment("00002", "Test2", -8.990M, -10.33333M);
            establishmment.AddEstaBlishment("00003", "Test3", -8.989M, -10.33333M);

            var json = Json.Create("Messagem estática", establishmment.Establishmments);
            return json;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Json> Get(string id)
        {
            var establishmment = EstablishmmentById.Create("00001", "Teste", "08:00", "20:00");
            establishmment.AddServices(ServiceOffered.Internet(Quality.Good));
            establishmment.AddServices(ServiceOffered.Energy(Quantity.Little));
            establishmment.AddServices(ServiceOffered.Noise(Quantity.Much));

            var json = Json.Create("Messagem estática", establishmment);

            return json;
        }

        [Route("so_pra_ver_esse_schema_list_estab")]
        [HttpPost]
        public void Post([FromBody] ResultListEstablishmmentNameLocationId resultListEstablishmmentNameLocationId)
        {
        }

        [Route("so_pra_ver_esse_schema_estab_id")]
        [HttpPost]
        public void Post([FromBody] EstablishmmentById establishmmentById)
        {
        }

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
