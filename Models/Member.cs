namespace Models

{   
    public class Member
    {
        public int Id {get;set;}
        public int UserId {get;set;}
        public User? User {get;set;}
        public string City {get;set;}
        public int Result {get;set;}
        public int ProffessionId {get;set;}
        public Job? Proffession {get;set;}


    }
}