using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kodinet.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kodinet.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpPost]
        public ActionResult RegisterPerson([FromBody] PersonMap personDto)
        {
            MapFields maps = new MapFields();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception)
            {
            }
            return Ok(maps.CreatePerson(personDto));
        }
        [HttpPost]
        public ActionResult GetAllPeople()
        {
            MapFields Filds = new MapFields();
            try
            {
                return Ok(Filds.FetchAllUsers());
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        [HttpPost]
        public ActionResult UserRegestration([FromBody] AppRegisterDto app)
        {
            try
            {

                MapFields mapFields = new MapFields();

                return Ok(mapFields.RegisterApp(app));

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public ActionResult Login([FromBody] Login login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            MapFields mapFields = new MapFields();

            return Ok(mapFields.LoginAccount(login));
        }

        [HttpPost]

        public ActionResult RegisterWorker([FromBody] WorkerDTO WorkerDTO)
        {
            var result = new WokerResult();
            MapFields maps = new MapFields();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                result = maps.RegisterWorker(WorkerDTO);
            }
            catch (Exception)
            {
            }
            return Ok(result);
        }
        //Get all the workers

        [HttpPost]
        public ActionResult GetWorkers()
        {
            MapFields maps = new MapFields();
            return Ok(maps.FetchAllWorkers());
        }

        [HttpPost]
        public ActionResult FilterPerson([FromBody] string Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            MapFields maps = new MapFields();
            return Ok(maps.GetPerson(Id));
        }
    }
}