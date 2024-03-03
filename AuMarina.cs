using System;

namespace M03.UF4.PR1
{
    public class AuMarina : AAnimal
    {
        public AuMarina(string family, double Agrade, string location, string animalName, string specie, double weight, string date, int rescueNumber)
        {
            this.Family = family;
            this.AG = Agrade;
            this.Location = location;
            this.AnimalName = animalName;
            this.Specie = specie;
            this.Weight = weight;
            this.Date = date;
            this.RescueNumber = rescueNumber;
        }
        public override string GetFamily()
        {
            // Retornar el nom de la superfamília
            return Family = "Au Marina";
        }
        public override double GetAG()
        {
            // Generar un valor de AG entre 1 i 99
            Random randomAG = new Random();
            this.AG = randomAG.Next(1, 100);
            return AG;
        }
        public override string GetLocation()
        {
            string[] locations =
            {
                // Llista de locations
                "Cadaqués",
                "Palamós",
                "Salou",
                "Begur",
                "Tarragona",
                "Barcelona",
                "Tamariu",
                "Cap de creus",
                "Tossa de Mar"
            };
            // Generar un nombre aleatori entre 0 i la longitud de Locations
            Random randomLocation = new Random();
            int randomLocationIndex = randomLocation.Next(0, locations.Length);
            // Seleccionar el nombre aleatori
            this.Location = locations[randomLocationIndex];
            return Location;
        }
        public override string GetAnimalName()
        {
            // Llista de animalNames
            string[] animalNames =
            {
                "Aleta",
                "Piquet",
                "Blanquet",
                "Charlie"
            };
            // Generar un nombre aleatori entre 0 i la longitud de animalNames
            Random randomAnimalName = new Random();
            int randomAnimalNameIndex = randomAnimalName.Next(0, animalNames.Length);
            // Seleccionar el nombre aleatori
            this.AnimalName = animalNames[randomAnimalNameIndex];
            return AnimalName;
        }
        public override string GetSpecie()
        {
            // Llista de species
            string[] species =
            {
                "Gavina Corsa",
                "Corb Marí",
                "Baldriga Cendrosa",
                "Xatrac Comú",
                "Alcatraz"
            };
            // Generar un nombre aleatori entre 0 i la longitud de species
            Random randomSpecie = new Random();
            int randomSpecieIndex = randomSpecie.Next(0, species.Length);
            // Seleccionar el nombre aleatori
            this.Specie = species[randomSpecieIndex];
            return Specie;
        }
        public override double GetWeight()
        {
            // Generar un valor de Weight aleatori entre 1 i 2
            Random randomWeight = new Random();
            this.Weight = randomWeight.Next(1, 2);
            return Weight;
        }
        public override string GetDate()
        {
            // Generar la data actual per a Date
            DateTime actualDate = DateTime.Now;
            // Convertir la data a string
            this.Date = actualDate.ToString();
            return Date;
        }
        public override int GetRescueNumber()
        {
            // Generar un valor de RescueNumber aleatori entre 0 i 999 inclosos
            Random randomRescueNumber = new Random();
            this.RescueNumber = randomRescueNumber.Next(0, 1000);
            return RescueNumber;
        }
    }
}

