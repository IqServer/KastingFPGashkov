using Microsoft.EntityFrameworkCore;
using Models;
using testnet;

namespace Services;

public class FirmService
{
    readonly DataContext _context;
    public FirmService(DataContext context)
    {
        _context = context;
    }

    public List<Firm> GetFirms()
    {
        var Firm = _context.Firms.Include(x => x.Members).ToList();
        return Firm;
    }
    public void GenerateFirm()
    {
        Firm Test = new Firm();

        Test.Number = 1;
        Test.AverAge = 14;
        Test.Amount = 15;
        Test.AveragePoints = 159;
        Test.PercentNew = 60;
        _context.Firms.Add(Test);
        Firm Test2 = new Firm();

        Test2.Number = 2;
        Test2.AverAge = 12;
        Test2.Amount = 12;
        Test2.AveragePoints = 157;
        Test2.PercentNew = 29.73;
        _context.Firms.Add(Test2);
        Firm Test3 = new Firm();

        Test3.Number = 3;
        Test3.AverAge = 16;
        Test3.Amount = 16;
        Test3.AveragePoints = 170;
        Test3.PercentNew = 50.34;
        _context.Firms.Add(Test3);
    }

    public Firm GetFirmById(int id)
    {

        var firm = _context.Firms.Where(x => x.Id == id).FirstOrDefault();
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

    public void RandomFirmGenerate(int countFirm)
    {
        List<Member> members = _context.Members.ToList();
        List<Firm> firms = new List<Firm>();

        for (int i = 0; i < countFirm; i++)
        {
            Firm test = new Firm();

            test.Number = 1;

            firms.Add(test);
        }

        int k = 0;


        foreach (var item in members)
        {
            if (k >= countFirm)
            {
                k = 0;
            }
            firms[k].Members.Add(item);
            k++;
        }
        // TODO вычислить значения в каждой фирме

        _context.Firms.AddRange(firms);
        _context.SaveChanges();

    }
    public void FirmListGenerate(int countFirm)
    {
        List<Member> members = _context.Members
                                        .Include(x => x.User)
                                        .Include(x => x.Result)
                                        .ToList();

        List<Firm> firms = new List<Firm>();

        for (int i = 0; i < countFirm; i++)
        {
            Firm test = new Firm();

            test.Number = i + 1;

            firms.Add(test);
        }

        int k = 0;
        //Выборка дедов
        List<Member> membersOldOriginal = members.Where(x => x.User.IsOld == true).ToList();

        int countOld = membersOldOriginal.Count;
        while (membersOldOriginal.Count > 0)
        {
            var membersOld = membersOldOriginal
                        .OrderBy(x => x.User.Age)
                        .OrderBy(x => x.Result.Programmer).ToList();

            int countIteration = 0;
            foreach (var item in membersOld)
            {
                if (k >= countFirm)
                {
                    k = 0;
                    countIteration++;
                    if (countIteration == 2)
                    {
                        break;
                    }
                }
                firms[k].Members.Add(item);
                membersOldOriginal.Remove(item);
                k++;
            }

            membersOld = membersOldOriginal
                        .OrderBy(x => x.User.Age)
                        .OrderBy(x => x.Result.Designer).ToList();

            countIteration = 0;
            foreach (var item in membersOld)
            {
                if (k >= countFirm)
                {
                    k = 0;
                    countIteration++;
                    if (countIteration == 2)
                    {
                        break;
                    }
                }
                firms[k].Members.Add(item);
                membersOldOriginal.Remove(item);
                k++;
            }

            membersOld = membersOldOriginal
                        .OrderBy(x => x.User.Age)
                        .OrderBy(x => x.Result.Reklamist).ToList();

            countIteration = 0;
            foreach (var item in membersOld)
            {
                if (k >= countFirm)
                {
                    k = 0;
                    countIteration++;
                    if (countIteration == 1)
                    {
                        break;
                    }
                }
                firms[k].Members.Add(item);
                membersOldOriginal.Remove(item);
                k++;
            }
        }

        k = 0;
        //Выборка новеньких
        List<Member> membersNewOriginal = members.Where(x => x.User.IsOld == false).ToList();

        int countNew = membersNewOriginal.Count;
        while (membersNewOriginal.Count > 0)
        {
            var membersNew = membersNewOriginal
                        .OrderBy(x => x.User.Age)
                        .OrderBy(x => x.Result.Programmer).ToList();

            int countIteration = 0;
            foreach (var item in membersNew)
            {
                if (k >= countFirm)
                {
                    k = 0;
                    countIteration++;
                    if (countIteration == 2)
                    {
                        break;
                    }
                }
                item.ProffessionId = 1;
                firms[k].Members.Add(item);
                membersNewOriginal.Remove(item);
                k++;
            }

            membersNew = membersNewOriginal
                        .OrderBy(x => x.User.Age)
                        .OrderBy(x => x.Result.Designer).ToList();

            countIteration = 0;
            foreach (var item in membersNew)
            {
                if (k >= countFirm)
                {
                    k = 0;
                    countIteration++;
                    if (countIteration == 2)
                    {
                        break;
                    }
                }
                item.ProffessionId = 2;
                firms[k].Members.Add(item);
                membersNewOriginal.Remove(item);
                k++;
            }

            membersNew = membersNewOriginal
                        .OrderBy(x => x.User.Age)
                        .OrderBy(x => x.Result.Reklamist).ToList();

            countIteration = 0;
            foreach (var item in membersNew)
            {
                if (k >= countFirm)
                {
                    k = 0;
                    countIteration++;
                    if (countIteration == 1)
                    {
                        break;
                    }
                }
                item.ProffessionId = 3;
                firms[k].Members.Add(item);
                membersNewOriginal.Remove(item);
                k++;
            }
        }

       
        foreach (var firm in firms)
        { 
            double? ageSum = 0;
            double? pointSum = 0;

            foreach (var member in firm.Members)
            {
                ageSum += member.User?.Age;
                if(member.ProffessionId == 1)
                pointSum += member.Result.Programmer;
                if(member.ProffessionId == 2)
                pointSum += member.Result.Designer;
                if(member.ProffessionId == 3)
                pointSum += member.Result.Reklamist;

            }

            int woman = firm.Members.Where(x => x.User.Gender == "д").ToList().Count;
            int man = firm.Members.Where(x => x.User.Gender == "м").ToList().Count; 
            int old = firm.Members.Where(x => x.User.IsOld == true).ToList().Count; 
            double newbie = firm.Members.Where(x => x.User.IsOld == false).ToList().Count;
            // мужского и женского пола человек отдельно
            
            firm.AverAge = ageSum / firm.Members.Count;
            firm.AveragePoints = pointSum / firm.Members.Count;
            firm.Amount = firm.Members.Count;
            firm.GenderMan = man;
            firm.GenderWoman = woman;
            double AllMembers = firm.Members.Count;
            firm.PercentNew = newbie / AllMembers * 100;
        }
        _context.Firms.AddRange(firms);
        _context.SaveChanges();

    }
}