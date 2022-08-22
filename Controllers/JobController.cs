namespace controllers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using testnet;

[ApiController]
[Route("/api/[controller]/[action]")]
public class JobController : ControllerBase
{
    JobService _jobService;
    public JobController(JobService jobService)
    {
        _jobService = jobService;
    }
    [HttpGet]
    public void GenerateJob()
    {
        
        _jobService.GenerateJob();
    }
    [HttpGet("GetAllJobs")]
    public List<Models.Job> GetAllJobs()
    {
        return _jobService.GetJobs();
    }
    [HttpGet("GetJobById")]
    public Job GetJobById(int id)
    {
        return _jobService.GetJobById(id);
    }

    [HttpPost("AddJob")]
    public void AddJob(Job newJob)
    {

        _jobService.AddJob(newJob);
    
        
    }
    
    [HttpDelete("DeleteJob")]
    public void DeleteJob(int id)
    {   
        _jobService.DeleteJob(id);
    }

    [HttpPost("UpdateJob")]
    public void UpdateJob(Job job)
    {

        _jobService.UpdateJob(job);
    
        
    }   
}