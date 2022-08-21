using System.Text.Json.Serialization;

namespace Models
{   
    public class Anketa
    {
        [JsonIgnore]
        public int Id {get;init;}
        public string QuestionsList {get;set;}
        public string Proffession {get;set;}
        


    }
}