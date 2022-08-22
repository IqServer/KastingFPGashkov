namespace controllers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using testnet;

[ApiController]
[Route("/api/[controller]/[action]")]
public class KuratorController : ControllerBase
{
    KuratorService _kuratorService;
    public KuratorController(KuratorService kuratorService)
    {
        _kuratorService = kuratorService;
    }
    [HttpGet]
    public void GenerateKurator()
    {
        
        _kuratorService.GenerateKurator();
    }
    [HttpGet("GetAllKurators")]
    public List<Models.Kurator> GetAllKurators()
    {
        return _kuratorService.GetKurators();
    }
    [HttpGet("GetKuratorsById")]
    public Kurator GetKuratorById(int id)
    {
        return _kuratorService.GetKuratorById(id);
    }

    [HttpPost("AddKurator")]
    public void AddKurator(Kurator newKurator)
    {

        _kuratorService.Add(newKurator);
    
        
    }
    
    [HttpDelete("DeleteKurator")]
    public void DeleteKurator(int id)
    {   
        _kuratorService.Delete(id);
    }

    [HttpPost("UpdateKurator")]
    public void UpdateKurator(Kurator kurator)
    {

        _kuratorService.Update(kurator);
    
        
    }   
}