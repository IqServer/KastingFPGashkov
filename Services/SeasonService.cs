using Models;
using testnet;

namespace Services;

public class SeasonService{  
    readonly DataContext _context; 
    public SeasonService(DataContext context)
    {
        _context = context;
    }

    public List<Season> GetSeasons(){    
        List<Season> season = _context.Seasons.ToList();
        return season;
    }
     public void GenerateSeason(){
          Season Test = new Season();

        Test.Title ="1";
        Test.Start = "<3";
        Test.End = "KrutoiPassword";
        Test.Amount = 2;
        Test.KuratorList = "Woman";
        Test.Description = "";
        _context.Seasons.Add(Test);
          Season Test2 = new Season();

        Test2.Title ="1";
        Test2.Start = "<3";
        Test2.End = "KrutoiPassword";
        Test2.Amount = 2;
        Test2.KuratorList = "Woman";
        Test2.Description = "";
        _context.Seasons.Add(Test2);
          Season Test3 = new Season();

        Test3.Title ="1";
        Test3.Start = "<3";
        Test3.End = "KrutoiPassword";
        Test3.Amount = 2;
        Test3.KuratorList = "Woman";
        Test3.Description = "";
        _context.Seasons.Add(Test3);
    }
    
    public Season GetSeasonById(int id)
    {

       var season =  _context.Seasons.Where(x => x.Id == id ).FirstOrDefault();
       return season;
    }
    public void AddSeason(Season newSeason)
    {
        
        _context.Add(newSeason);
        _context.SaveChanges();
        
    }
    public void DeleteSeason(int id)
    {   
        Season? season = _context.Seasons.FirstOrDefault(x => x.Id == id);
        _context.Seasons.Remove(season);
        _context.SaveChanges();
    }
    public void UpdateSeason(Season season)
    {
        
        _context.Update(season);
        _context.SaveChanges();
        
    }
}