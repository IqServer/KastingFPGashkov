namespace controllers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using testnet;

[ApiController]
[Route("/api/[controller]/[action]")]
public class TestController : ControllerBase
{
    
    UserService _userService;
    StudentService _studentService;
    KuratorService _kuratorService;
    MemberService _memberService;
    DataContext _context;
    public TestController(UserService userService,     DataContext context,
    StudentService studentService, KuratorService kuratorService, MemberService memberService)
    {
        _userService = userService;
        _studentService = studentService;
        _kuratorService = kuratorService;
        _memberService = memberService;
        _context = context;
    }

    [HttpGet]
    public void Generate()
    {
      
        _userService.GenerateUser();

      
        _kuratorService.GenerateKurator();

        _memberService.GenerateMember();
    
    }
    [HttpGet]
        public void CreateDB(){
         _context.CreateBDNew();

         Job Proffesion = new Job();
         _context.Jobs.Add(Proffesion);
      }
}