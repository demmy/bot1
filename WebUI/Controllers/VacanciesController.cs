using BaseOfTalents.DAL.Services;
using BaseOfTalents.WebUI.Extensions;
using BaseOfTalents.WebUI.Infrastructure;
using BaseOfTalents.WebUI.Models;
using DAL.Exceptions;
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
                var tupleResult = service.Get(
                    vacancyParams.UserId,
                    vacancyParams.IndustryId,
                    vacancyParams.Title,
                    vacancyParams.VacancyState,
                    vacancyParams.TypeOfEmployment,
                    vacancyParams.LevelIds,
                    vacancyParams.LocationIds,
                    vacancyParams.Current,
                    vacancyParams.Size
                    );

                var vacanciesViewModel = tupleResult.Item1.Select(x=> DTOService.ToViewModel<VacancyDTO, VacancySearchModel>(x));
                var total = tupleResult.Item2;

                var ret = new { Vacancies = vacanciesViewModel, Current = vacancyParams.Current, Size = vacancyParams.Size, Total = total };
                return Json(ret, BOT_SERIALIZER_SETTINGS);
            }
            return BadRequest();
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var foundedEntity = service.Get(id);
            if(foundedEntity!=null)
            {
                return Json(foundedEntity, BOT_SERIALIZER_SETTINGS);
            }
            return BadRequest();
        }

        // POST api/<controller>
        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody]VacancyDTO vacancy)
        {
            if(!ModelState.IsValid)
            {
                return Json(ModelState.Errors(), BOT_SERIALIZER_SETTINGS);
            }
            var updatedVacancy = service.Add(vacancy);
            return Json(updatedVacancy, BOT_SERIALIZER_SETTINGS);
        }

        // PUT api/<controller>/5
        [HttpPut]
        [Route("")]
        public IHttpActionResult Put([FromBody]VacancyDTO vacancy)
        {
            if (!ModelState.IsValid)
            {
                return Json(ModelState.Errors(), BOT_SERIALIZER_SETTINGS);
            }

            var updatedVacancy = service.Update(vacancy);
            return Json(updatedVacancy, BOT_SERIALIZER_SETTINGS);
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            try
            { 
                service.Delete(id);
                return Ok();
            }
            catch (EntityNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}