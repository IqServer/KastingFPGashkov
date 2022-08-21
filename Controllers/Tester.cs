namespace controllers;
using Microsoft.AspNetCore.Mvc;
using Services;


[ApiController]
[Route("/api/[controller]/[action]")]
class TestController : ControllerBase
{
    
    UserService _userService;
    StudentService _studentService;
    KuratorService _kuratorService;
    MemberService _memberService;
    public TestController(UserService userService, StudentService studentService, KuratorService kuratorService, MemberService memberService)
    {
        _userService = userService;
        _studentService = studentService;
        _kuratorService = kuratorService;
        _memberService = memberService;
    }

    [HttpGet]
    public void Generate()
    {
      
        _userService.GenerateUser();

        _studentService.GenerateStudent();
      
        _kuratorService.GenerateKurator();

        _memberService.GenerateMember();
    
    }

}