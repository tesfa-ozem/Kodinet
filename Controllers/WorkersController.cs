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
    public class WorkersController : ControllerBase
    {
        [HttpPost]

        public ActionResult RegisterWorker([FromBody] WorkerDTO WorkerDTO)
        {
            var result = new  WokerResult();
            MapFields maps = new MapFields();
            try{
                if(!ModelState.IsValid){
                    return BadRequest(ModelState);
                }
                result = maps.RegisterWorker(WorkerDTO);
            }
            catch(Exception){
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

    }
}