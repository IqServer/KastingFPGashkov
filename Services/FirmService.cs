using Models;
using testnet;

namespace Services;

public class FirmService{  
    readonly DataContext _context; 
    public FirmService(DataContext context)
    {
        _context = context;
    }

    public List<Firm> GetFirms(){    
        var Firm = _context.Firms.ToList();
            return Firm;
    }
     public void GenerateFirm(){
          Firm Test = new Firm();

        Test.Number = 1;
        Test.AverAge = 14;
        Test.Amount = 15;
        Test.AveragePoints = 159;
        Test.GenderRatio = 1;
        Test.PercentNew = 60;
        _context.Firms.Add(Test);
          Firm Test2 = new Firm();

        Test2.Number = 2;
        Test2.AverAge = 12;
        Test2.Amount = 12;
        Test2.AveragePoints = 157;
        Test2.GenderRatio = 1.05;
        Test2.PercentNew = 29.73;
        _context.Firms.Add(Test2);
          Firm Test3 = new Firm();

        Test3.Number = 3;
        Test3.AverAge = 16;
        Test3.Amount = 16;
        Test3.AveragePoints = 170;
        Test3.GenderRatio = 1.64;
        Test3.PercentNew = 50.34;
        _context.Firms.Add(Test3);
    }
    
    public Firm GetFirmById(int id)
    {

       var firm =  _context.Firms.Where(x => x.Id == id ).FirstOrDefault();
       return firm;
    }
    public void AddFirm(Firm newFirm)
    {
        
        _context.Add(newFirm);
        _context.SaveChanges();
        
    }
    public void DeleteFirm(int id)
    {   
        Firm? firm = _context.Firms.FirstOrDefault(x => x.Id == id);
        _context.Firms.Remove(firm);
        _context.SaveChanges();
    }
    public void UpdateFirm(Firm firm)
    {
        
        _context.Update(firm);
        _context.SaveChanges();
        
    }
}