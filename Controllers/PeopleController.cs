using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kodinet.Models;
using Kodinet.Logic;

namespace Kodinet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpPost]
        public ActionResult RegisterPerson([FromBody] PersonMap personDto )
        {
            MapFields maps = new MapFields();
            try{
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
            }
            catch(Exception){
            }
            return Ok( maps.CreatePerson(personDto));
        }
        [HttpPost]
        public ActionResult GetAllPeople()
        {
            MapFields Filds = new MapFields();
            try{
                return Ok(Filds.FetchAllUsers());
            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }
           
        }
    }
}