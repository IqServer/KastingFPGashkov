namespace Zachem.Controllers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using testnet;

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
    [HttpGet("GetAllUsers")]
    public List<Models.User> GetAllUsers()
    {
        return _userService.GetUsers();
    }
    [HttpGet("GetUserById")]
    public User GetUserById(int id)
    {
        return _userService.GetUserById(id);
    }

    [HttpPost("AddUser")]
    public void AddUser(User newUser)
    {

        _userService.Add(newUser);
    
        
    }
    
    [HttpDelete("DeleteUser")]
    public void DeleteUser(int id)
    {   
        _userService.Delete(id);
    }
}