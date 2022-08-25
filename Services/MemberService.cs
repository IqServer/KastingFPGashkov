using Models;
using testnet;

namespace Services;

public class MemberService{  
    readonly DataContext _context; 
    public MemberService(DataContext context)
    {
        _context = context;
    }

    public List<Member> GetMembers(){    
        List<Member> member = _context.Members.ToList();
        return member;
    }
     public void GenerateMember(){




        
            Member Test = new Member();

        Test.UserId = 1;
        Test.City = "тяжелый проект";
        Test.ResultId = 2;
        Test.ProffessionId = 2;
        _context.Members.Add(Test);
            Member Test2 = new Member();

        Test2.UserId = 2;
        Test2.City = "Устал делать проект";
        Test2.ResultId = 1;
        Test2.ProffessionId = 1;
        _context.Members.Add(Test2);
            Member Test3 = new Member();

        Test3.UserId = 3;
        Test3.City = "Плохойпарень";
        Test3.ResultId = 3;
        Test3.ProffessionId = 3;
        _context.Members.Add(Test3);
        _context.SaveChanges();
    }
    public Member GetMemberById(int id)
    {

       var member =  _context.Members.Where(x => x.Id == id ).FirstOrDefault();
       return member;
    }
    public void Add(Member newMember)
    {
        
        _context.Add(newMember);
        _context.SaveChanges();
        
    }
    public void Delete(int id)
    {   
        Member? member = _context.Members.FirstOrDefault(x => x.Id == id);
        _context.Members.Remove(member);
        _context.SaveChanges();
    }
    public void Update(Member member)
    {
        
        _context.Update(member);
        _context.SaveChanges();
        
    }
}