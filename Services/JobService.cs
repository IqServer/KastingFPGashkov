using Models;
using testnet;

namespace Services;

public class JobService{  
    readonly DataContext _context; 
    public JobService(DataContext context)
    {
        _context = context;
    }

    public List<Job> GetJobs(){    
        var Job = _context.Jobs.ToList();
            return Job;
    }
     public void GenerateJob(){
          Job Test = new Job();

        Test.Proffession = "Программист";
        _context.Jobs.Add(Test);
            Job Test2 = new Job();

        Test2.Proffession = "Дизайнер";
        _context.Jobs.Add(Test2);
            Job Test3 = new Job();

        Test3.Proffession = "Рекламист";    
        _context.Jobs.Add(Test3);
    }
    
    public Job GetJobById(int id)
    {

       var job =  _context.Jobs.Where(x => x.Id == id ).FirstOrDefault();
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