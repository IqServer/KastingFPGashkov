namespace controllers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using testnet;

[ApiController]
[Route("/api/[controller]/[action]")]
public class FirmController : ControllerBase
{
    FirmService _firmService;
    public FirmController(FirmService firmService)
    {
        _firmService = firmService;
    }
    [HttpGet]
    public void GenerateFirm()
    {
        
        _firmService.GenerateFirm();
    }
    [HttpGet("GetAllFirms")]
    public List<Models.Firm> GetAllFirms()
    {
        return _firmService.GetFirms();
    }
    [HttpGet("GetFirmById")]
    public Firm GetFirmById(int id)
    {
        return _firmService.GetFirmById(id);
    }

    [HttpPost("AddFirm")]
    public void AddFirm(Firm newFirm)
    {

        _firmService.AddFirm(newFirm);
    
        
    }
    
    [HttpDelete("DeleteFirm")]
    public void DeleteFirm(int id)
    {   
        _firmService.DeleteFirm(id);
    }

    [HttpPost("UpdateFirm")]
    public void UpdateFirm(Firm firm)
    {

        _firmService.UpdateFirm(firm);
    
        
    }   
    [HttpPost("RandomFirmGenerate")]
    public void RandomFirmGenerate(int countFirm)
    {   
        _firmService.RandomFirmGenerate(countFirm);
    }

}