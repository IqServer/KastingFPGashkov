using System.Text.Json.Serialization;

namespace Models
{   
    public class Firm
    {
        public int Id {get;init;}
        public int Number {get;set;}
        public Season Season {get;set;}
        public int Amount {get;set;}
        public double AverAge {get;set;}
        public double AveragePoints {get;set;}
        public double GenderRatio {get;set;}
        public double PercentNew{get;set;}
        public List<Member> Members {get;set;}

    }
}