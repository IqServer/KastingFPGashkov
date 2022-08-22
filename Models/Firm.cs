using System.Text.Json.Serialization;

namespace Models
{   
    public class Firm
    {
        public int Id {get;init;}
        public string Number {get;set;}
        public Season Season {get;set;}
        public string Amount {get;set;}
        public int AverAge {get;set;}
        public string AveragePoints {get;set;}
        public int GenderRatio {get;set;}
        public int PercentNew{get;set;}


    }
}