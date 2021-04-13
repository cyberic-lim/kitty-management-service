using KittyManagementService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KittyManagementService.Controllers
{
    [ApiController]
    [Route("api/v1/kittens")]
    public class KittensController : ControllerBase
    {
        [HttpGet()]
        public KittenDto GetKittens()
        {
            // Create kittens
            KittenDto kittenDto = new KittenDto { KittenId = 2, Name = "Mango" };

            // TODO

            return kittenDto;
        }
    }
}
