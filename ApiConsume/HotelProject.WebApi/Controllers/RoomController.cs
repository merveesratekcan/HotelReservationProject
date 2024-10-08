using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        [HttpGet]
        public IActionResult RoomList()
        {
            return Ok("Room List");
        }

        [HttpPost]
        public IActionResult AddRoom()
        {
            return Ok("Room Added");
        }

        [HttpDelete]
        public IActionResult DeleteRoom()
        {
            return Ok("Room Deleted");
        }

        [HttpPut]
        public IActionResult UpdateRoom()
        {
            return Ok("Room Updated");
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom()
        {
            return Ok("Room by Id");
        }
    }
}
