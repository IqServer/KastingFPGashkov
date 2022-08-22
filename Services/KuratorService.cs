using Models;
using testnet;

namespace Services;

public class KuratorService{  
    readonly DataContext _context; 
    public KuratorService(DataContext context)
    {
        _context = context;
    }

    public List<Kurator> GetKurators(){    
        var Kurator = _context.Kurators.ToList();

            return Kurator;
    }
     public void GenerateKurator(){
            Kurator Test = new Kurator();

        Test.UserId = 1;
        Test.Project = "тяжелый проект";
        Test.ProffessionId = 2;
        _context.Kurators.Add(Test);
            Kurator Test2 = new Kurator();

        Test.UserId = 2;
        Test.Project = "Куда нажимать?";
        Test.ProffessionId = 4;
        _context.Kurators.Add(Test);
            Kurator Test3 = new Kurator();

        Test.UserId = 3;
        Test.Project = "8 фирма топ";
        Test.ProffessionId = 3;
        _context.Kurators.Add(Test);
        _context.SaveChanges();
    }
    public Kurator GetKuratorById(int id)
    {

       var kurator =  _context.Kurators.Where(x => x.Id == id ).FirstOrDefault();
       return kurator;
    }
    public void Add(Kurator newKurator)
    {
        
        _context.Add(newKurator);
        _context.SaveChanges();
        
    }
    public void Delete(int id)
    {   
        Kurator? kurator = _context.Kurators.FirstOrDefault(x => x.Id == id);
        _context.Kurators.Remove(kurator);
        _context.SaveChanges();
    }
    public void Update(Kurator kurator)
    {
        
        _context.Update(kurator);
        _context.SaveChanges();
        
    }
}