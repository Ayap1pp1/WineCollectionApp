using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WineCollectionApp.Data;
using WineCollectionApp.Models;


namespace WineCollectionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        private DatabaseContext db1 = new DatabaseContext();

        [HttpGet("GetAll")]
        public IEnumerable<Producer> GetProducers()
        {
            return db1.GetAllProducers();
        }

        [HttpPost("Add")]
        public IActionResult AddProducer(Producer prod)
        {
            try
            {
                db1.AddProducer(prod);
            }
            catch
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet("{id}/GetBottles")]
        public IEnumerable<Bottle> GetAllBottlesFromProducerById(int id)
        {
            return db1.GetAllBottlesFromProducerById(id);
        }

        [HttpPost("AddBottle")]
        public IActionResult AddBottle(Bottle bot)
        {
            try
            {
                db1.AddBottle(bot);
            }
            catch
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("DeleteBottle/{id}")]
        public IActionResult DeleteBottleById(int id)
        {
            try
            {
                db1.DeleteBottle(id);
            }
            catch
            {
                return BadRequest();
            }
            return Ok();

        }
    }
}
