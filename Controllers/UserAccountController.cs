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
    public class UserAccountController : ControllerBase
    {
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
        
    }
}