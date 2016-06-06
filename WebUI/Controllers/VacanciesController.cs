using BaseOfTalents.DAL.Services;
using BaseOfTalents.WebUI.Models;
using DAL.Services;
using Domain.DTO.DTOModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace BaseOfTalents.WebUI.Controllers
{
    [RoutePrefix("api/vacancy")]
    public class VacanciesController : ApiController
    {
        protected static JsonSerializerSettings BOT_SERIALIZER_SETTINGS = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        private readonly VacancyService service = new VacancyService();

        // GET api/<controller>
        [HttpPost]
        [Route("search")]
        public IHttpActionResult Get([FromBody]VacancySearchParameters vacancyParams)
        {
            if(ModelState.IsValid)
            {
                var searchResult = service.Get(
                    vacancyParams.UserId, 
                    vacancyParams.IndustryId, 
                    vacancyParams.Title, 
                    vacancyParams.VacancyState, 
                    vacancyParams.TypeOfEmployment, 
                    vacancyParams.LevelIds, 
                    vacancyParams.LocationIds, 
                    vacancyParams.Current, 
                    vacancyParams.Size).Select(x=> DTOService.ToViewModel<VacancyDTO, VacancySearchModel>(x));
                return Json(searchResult, BOT_SERIALIZER_SETTINGS);
            }
            return BadRequest();
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