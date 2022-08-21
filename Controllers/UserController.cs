namespace Zachem.Controllers;
using Microsoft.AspNetCore.Mvc;
using Services;

[ApiController]
[Route("/api/[controller]/[action]")]
public class UserController : ControllerBase
{
    UserService _userService;
    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public void GenerateUser()
    {
        
        _userService.GenerateUser();
    }
}