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
        var Member = _context.Members.ToList();

            return Member;
    }
     public void GenerateMember(){
            Member Test = new Member();

        Test.UserId = 1;
        Test.City = "тяжелый проект";
        Test.Result = 35;
        Test.ProffessionId = 2;
        _context.Members.Add(Test);
            Member Test2 = new Member();

        Test2.UserId = 2;
        Test2.City = "Устал делать проект";
        Test2.Result = 29;
        Test2.ProffessionId = 1;
        _context.Members.Add(Test2);
            Member Test3 = new Member();

        Test3.UserId = 3;
        Test3.City = "Плохойпарень";
        Test3.Result = 45;
        Test3.ProffessionId = 6;
        _context.Members.Add(Test3);
        _context.SaveChanges();
    }
}