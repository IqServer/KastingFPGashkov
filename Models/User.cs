using System.Text.Json.Serialization;

namespace Models
{   
    public class User
    {
        [JsonIgnore]
        public int Id {get;set;}
        public string FullName {get;set;}
        public string Login {get;set;}
        public string Password {get;set;}
        public int Firm {get;set;}
        public int Age {get;set;}
        public string Gender {get;set;}

    }
}