using System.Text.Json.Serialization;

namespace Models
{   
    public class Season
    {
        [JsonIgnore]
        public int Id {get;init;}
        public string Title {get;set;}
        public string Start {get;set;}
        public string End {get;set;}   
        public int Amount {get;set;}
        public string KuratorList {get;set;}
        public string Description {get;set;}

    }
}