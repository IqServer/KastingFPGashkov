using System.Text.Json.Serialization;

namespace Models

{   
    public class Member
    {
        public int Id {get;init;}
        public int? UserId {get;set;}
        public User? User {get;set;}
        public string? City {get;set;}
        public int? ResultId {get;set;}
        public Result? Result {get;set;}
        public int? ProffessionId {get;set;}
        public Job? Proffession {get;set;}


    }
}