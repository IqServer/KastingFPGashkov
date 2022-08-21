using Models;
using testnet;

namespace Services;

public class StudentService{  
    readonly DataContext _context; 
    public StudentService(DataContext context)
    {
        _context = context;
    }

    public List<Member> GetStudents(){    
        var Member = _context.Members.ToList();

            return Member;
    }
     public void GenerateStudent(){
          Member student = new Member();

        student.User.FullName ="1";
        _context.Members.Add(student);
          Member student2 = new Member();

        student2.User.FullName ="2";
        _context.Members.Add(student2);
        Member student3 = new Member();

        student3.User.FullName = "Я счастливый как никто";
        _context.Members.Add(student3);
        _context.SaveChanges();
    }
}