using Microsoft.AspNetCore.Mvc;
using Pets.API.Entities;
using Pets.API.Interfaces.Services;

namespace Pets.API.Controllers;

public class UserController : BaseController
{
    
    
    private readonly IUserService _userService;
    
    public UserController(
        IUserService userService
    )
    {
        _userService = userService;
    }
    [HttpPost("CreateUser")]
    public IActionResult CreateUser([FromBody] User user)
    {
        try
        {
            var result = _userService.CreateUser(user);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}