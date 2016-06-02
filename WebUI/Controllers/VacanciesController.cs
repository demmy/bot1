using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using DAL.DTO;
using DAL.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WebUI.Controllers
{
    [RoutePrefix("api/vacancies")]
    public class VacanciesController : ApiController
    {
        protected static JsonSerializerSettings BOT_SERIALIZER_SETTINGS = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        private readonly VacancyService service = new VacancyService();

        // GET api/<controller>
        [HttpGet]
        [Route]
        public JsonResult<IEnumerable<VacancyDTO>> Get()
        {
            var list = service.Get(1, 20);


            return Json(list, BOT_SERIALIZER_SETTINGS);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}