using System.Text.Json.Serialization;

namespace Models
{   
    public class Kurator
    {
        public int Id {get;init;}
        public int? UserId {get;set;}
        public User? User {get;set;}
        public string? Project {get;set;}
        public int? ProffessionId {get;set;}
        public Job? Proffession {get;set;}

    }
}