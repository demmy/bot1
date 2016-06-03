using BaseOfTalents.DAL.Services;
using BaseOfTalents.WebUI.Models;
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
        [HttpGet]
        [Route("")]
        public IEnumerable<VacancyModel> Get([FromUri]int page=1, int size=3)
        {
            var resp = service.Get(page, size);
            var re = resp.Select(dto =>
                new VacancyModel
                {
                    DeadlineDate = dto.DeadlineDate,
                    DepartmentId = dto.Department.Id,
                    Description = dto.Description,
                    EndDate = dto.EndDate,
                    IndustryId = dto.Industry.Id,
                    LevelIds = dto.Levels.Select(x=>x.Id),
                    LocationIds = dto.Locations.Select(x=>x.Id),
                    ParentVacancyId = dto.ParentVacancy.Id,
                    ResponsibleId = dto.Responsible.Id,
                    RequiredSkillIds = dto.RequiredSkills.Select(x => x.Id)

                }
                );
            return re;
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