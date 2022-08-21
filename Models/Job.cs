using System.Text.Json.Serialization;

namespace Models
{   
    public class Job
    {
        [JsonIgnore]
        public int Id {get;init;}
        public string Proffession {get;set;}
        


    }
}