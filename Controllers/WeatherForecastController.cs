using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace Zachem.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    readonly StudentService _StudentService;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, StudentService studentService)
    {
        _StudentService = studentService;
        _logger = logger;
    }

    [HttpGet(Name = "GetAllStudents")]
    public List<Member> GetAllStudents(){
        var student =  _StudentService.GetStudents();
        return student;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    [HttpGet(Name = "WaW")]
    public string WaW()
    {   
        _logger.LogInformation("Что по погоде?");
        return "Ща узнаем!";
    }
}
