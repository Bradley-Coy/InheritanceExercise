using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public string areVertebrates { get; set; } = "vertebrates";
        public string haveScales { get; set; } = "scales";
        public string coldBlood { get; set; } = "cold blood";
        public string atLeastOneLung { get; set; } = "at least one lung";


        public Reptile()
        {
            
            Console.WriteLine($"All reptiles are {areVertebrates}, have {haveScales}, {coldBlood}, and {atLeastOneLung}.");
        }
       //public class allReptiles(string)
//{
         //    var allReptile = new allReptiles(Console.WriteLine($"All reptiles are {areVertebrates}, have {haveScales}, {coldBlood}, and {atLeastOneLung}"));
        //}
    }
}

