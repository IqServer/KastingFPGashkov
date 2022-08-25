using Models;
using testnet;

namespace Services;

public class JobService
{
    readonly DataContext _context;
    public JobService(DataContext context)
    {
        _context = context;
    }

    public List<Job> GetJobs()
    {
        var Job = _context.Jobs.ToList();
        return Job;
    }

    public Job GetJobById(int id)
    {
        var job = _context.Jobs.Where(x => x.Id == id).FirstOrDefault();
        return job;
    }
    public void AddJob(Job newJob)
    {

        _context.Add(newJob);
        _context.SaveChanges();

    }
    public void DeleteJob(int id)
    {
        Job? job = _context.Jobs.FirstOrDefault(x => x.Id == id);
        _context.Jobs.Remove(job);
        _context.SaveChanges();
    }
    public void UpdateJob(Job job)
    {

        _context.Update(job);
        _context.SaveChanges();

    }
}