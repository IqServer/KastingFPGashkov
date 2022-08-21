namespace controllers;
using Microsoft.AspNetCore.Mvc;
using Services;

class KuratorController : ControllerBase
{
    KuratorService _kuratorService;
    public KuratorController(KuratorService kuratorService)
    {
        _kuratorService = kuratorService;
    }

    
}