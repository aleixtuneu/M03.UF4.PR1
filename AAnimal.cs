using System;

namespace M03.UF4.PR1
{
    public abstract class AAnimal
    {
        public string Family { get; set; }
        public double AG { get; set; }
        public string Location { get; set; }
        public string AnimalName { get; set; }
        public string Specie { get; set; }
        public double Weight { get; set; }
        public string Date { get; set; }
        public int RescueNumber { get; set; }
  
        public abstract string GetFamily();
        public abstract double GetAG();
        public abstract string GetLocation();
        public abstract string GetAnimalName();
        public abstract string GetSpecie();
        public abstract double GetWeight();
        public abstract string GetDate();
        public abstract int GetRescueNumber();
    }
}
