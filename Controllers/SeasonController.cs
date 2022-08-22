namespace Zachem.Controllers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using testnet;

[ApiController]
[Route("/api/[controller]/[action]")]
public class SeasonController : ControllerBase
{
    SeasonService _seasonService;
    public SeasonController(SeasonService seasonService)
    {
        _seasonService = seasonService;
    }

    [HttpGet]
    public void GenerateSeason()
    {
        
        _seasonService.GenerateSeason();
    }
    [HttpGet("GetAllSeasons")]
    public List<Models.Season> GetAllSeasons()
    {
        return _seasonService.GetSeasons();
    }
    [HttpGet("GetSeasonById")]
    public Season GetSeasonById(int id)
    {
        return _seasonService.GetSeasonById(id);
    }

    [HttpPost("AddSeason")]
    public void AddSeason(Season newSeason)
    {

        _seasonService.AddSeason(newSeason);
    
        
    }
    
    [HttpDelete("DeleteSeason")]
    public void DeleteSeason(int id)
    {   
        _seasonService.DeleteSeason(id);
    }

    [HttpPost("UpdateSeason")]
    public void UpdateSeason(Season season)
    {

        _seasonService.UpdateSeason(season);
    
        
    }
}