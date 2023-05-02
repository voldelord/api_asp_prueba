using apiaprendizaje_api.Data;
using apiaprendizaje_api.Models;
using apiaprendizaje_api.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace apiaprendizaje_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
      
        public ActionResult <IEnumerable<UserDto>> GetUsers()
        {
            return Ok(UserStore.userList);
        }
        [HttpGet("id: int")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult <UserDto> GetUser(int id) 
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var user = UserStore.userList.FirstOrDefault(v => v.Id == id);
            if (user == null) 
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UserDto> CreateUser([FromBody] UserDto userDto) 
        {
            if (userDto == null)
            {
                return BadRequest(userDto);
            }
            if (userDto.Id>0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            userDto.Id = userDto.Id;
        }
    }
}
