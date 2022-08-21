using Models;
using testnet;

namespace Services;

public class UserService{  
    readonly DataContext _context; 
    public UserService(DataContext context)
    {
        _context = context;
    }

    public List<User> GetUsers(){    
        var user = _context.Users.ToList();

            return user;
    }
     public void GenerateUser(){
          User Test = new User();

        Test.FullName ="1";
        Test.Login = "<3";
        Test.Password = "KrutoiPassword";
        Test.Firm = 2;
        _context.Users.Add(Test);
          User Test2 = new User();

        Test2.FullName ="2";
        Test2.Login = "GGlol";
        Test2.Password = "Love_kurators";
        Test2.Firm = 1;
        _context.Users.Add(Test2);
        User Test3 = new User();

        Test3.FullName ="3";
        Test3.Login = "FP top";
        Test3.Password = "Firma2Top";
        Test3.Firm = 2;
        _context.Users.Add(Test3);
        _context.SaveChanges();
    }
}