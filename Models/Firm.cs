using System.Text.Json.Serialization;

namespace Models
{   
    public class Firm
    {
        public Firm()
        {
            Members = new List<Member>();
          //  Season = new Season();
        }
        public int Id {get;init;}
        public int? Number {get;set;}
        public int? SeasonId {get;init;}
        public Season? Season {get;set;}
        public int? Amount {get;set;}
        public double? AverAge {get;set;}
        public double? AveragePoints {get;set;}
        public int? GenderMan {get;set;}
        public int? GenderWoman {get;set;}
        public double? PercentNew{get;set;}
        public List<Member>? Members {get;set;}

    }
}