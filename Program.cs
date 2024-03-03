using System;

namespace M03.UF4.PR1
{
    public class Program
    {
        public static void Main()
        {
            const string MsgHi = "Save the ocean!";
            const string Menu = "Què vols fer?\n1. Jugar!\n2. Sortir";
            const string MsgKo = "Siusplau, introdueix un valor vàlid.";
            const string MsgOk = "Perfecte! Què vols ser?";
            const string MsgBye = "Fins al proper rescat!";
            const string MsgName = "Genial! I el teu nom?";
            const string MsgRescue1 = "+-------------------------------------------------------------+\n|                       RESCAT                                |\n+-------------------------------------------------------------+\n| # Rescat | Data rescat | Superfamília   | GA | Localització |\n+-------------------------------------------------------------+";
            const string MsgRescue2 = "+-------------------------------------------------------------+\n\nAquí tens la seva fitxa, per a més informació:\n\n+-------------------------------------------------------------+\n|                       FITXA                                 |\n| # Nom | Superfamília | Espècie        | Pes aproximat       |\n+-------------------------------------------------------------+";
            const string MsgRescue3 = "+-------------------------------------------------------------+\n\n";
            
            int option;
            int character;
            int tecXp = 0;
            int vetXp = 0;
            string name;
            int decision;
            bool TecOn = false;

            // Instanciar Animal Random
            AAnimal animal;

            int randomAnimal = new Random().Next(3);

            switch (randomAnimal)
            {
                case 0:
                    // Instanciar un objecte de la clase Au Marina
                    animal = new AuMarina(family: "", Agrade: 0, location: "", animalName: "", specie: "", weight: 0, date: "", rescueNumber: 0);
                    // Establir atributs Au Marina
                    animal.GetFamily();
                    animal.GetAG();
                    animal.GetLocation();
                    animal.GetAnimalName();
                    animal.GetSpecie();
                    animal.GetWeight();
                    animal.GetDate();
                    animal.GetRescueNumber();
                    break;
                case 1:
                    // Instanciar un objecte de la clase Tortuga Marina
                    animal = new TortugaMarina(family: "", Agrade: 0, location: "", animalName: "", specie: "", weight: 0, date: "", rescueNumber: 0);
                    // Establir atributs per a Tortuga Marina
                    animal.GetFamily();
                    animal.GetAG();
                    animal.GetLocation();
                    animal.GetAnimalName();
                    animal.GetSpecie();
                    animal.GetWeight();
                    animal.GetDate();
                    animal.GetRescueNumber();
                    break;
                case 2:
                    // Instanciar un objecte de la clase Cetaci
                    animal = new Cetaci(family: "", Agrade: 0, location: "", animalName: "", specie: "", weight: 0, date: "", rescueNumber: 0);
                    // Establir atributs per a Cetaci
                    animal.GetFamily();
                    animal.GetAG();
                    animal.GetLocation();
                    animal.GetAnimalName();
                    animal.GetSpecie();
                    animal.GetWeight();
                    animal.GetDate();
                    animal.GetRescueNumber();
                    break;
                default:
                    // Instanciar Au Marina per defecte
                    animal = new AuMarina(family: "", Agrade: 0, location: "", animalName: "", specie: "", weight: 0, date: "", rescueNumber: 0);
                    // Establir atributs Au Marina
                    animal.GetFamily();
                    animal.GetAG();
                    animal.GetLocation();
                    animal.GetAnimalName();
                    animal.GetSpecie();
                    animal.GetWeight();
                    animal.GetDate();
                    animal.GetRescueNumber();
                    break;
            }

            Console.WriteLine(MsgHi);
            Console.WriteLine(Menu);
            Console.WriteLine();
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    // Opció Jugar
                    Console.WriteLine();
                    Console.WriteLine(MsgOk);
                    Console.WriteLine();
                    Console.WriteLine($"1. Tècnic ({tecXp}XP)");
                    Console.WriteLine($"2. Veterinari ({vetXp}XP)");
                    Console.WriteLine();

                    // Validar personatge
                    character = Convert.ToInt32(Console.ReadLine());
                    ValidateCharacter(character, TecOn, MsgKo);
                    Console.WriteLine();
                    Console.WriteLine(MsgName);
                    Console.WriteLine();
                    name = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine($"Hola, {name}! El 112 ha rebut una trucada d'avís d'un exemplar a rescatar.\nLes dades que ens han donat són les següents:");
                    Console.WriteLine();

                    // Mostrar Dades de rescat
                    GetRescueInfo(animal);
                    
                    // Decisió (1) Curar aquí o (2) Traslladar
                    decision = Convert.ToInt32(Console.ReadLine());

                    // Calcular nou AG
                    double newAG = GetNewAG(decision, animal, MsgKo);

                    // Mostrar resultat del tractament
                    GetTreatmentResult(newAG, TecOn, vetXp, tecXp);
                    Console.WriteLine();
                    Console.WriteLine(MsgBye);
                    break;
                case 2:
                    // Opció Sortir
                    Console.WriteLine();
                    Console.WriteLine(MsgBye);
                    break;
                default:
                    Console.WriteLine(MsgKo);
                    option = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        public static bool ValidateCharacter(int character, bool TecOn, string MsgKo)
        {
            switch (character)
            {
                case 1:
                    TecOn = true;
                    break;
                case 2:
                    TecOn = false;
                    break;
                default:
                    Console.WriteLine(MsgKo);
                    break;
            }
            return TecOn;
        }
        public static void GetRescueInfo(AAnimal animal/*int rescueNumber, string date, string family, double Agrade, string location, string animalName, string specie, double weight*/)
        {
            const string MsgRescue1 = "+-------------------------------------------------------------+\n|                       RESCAT                                |\n+-------------------------------------------------------------+\n| # Rescat | Data rescat | Superfamília   | GA | Localització |\n+-------------------------------------------------------------+";
            const string MsgRescue2 = "+-------------------------------------------------------------+\n\nAquí tens la seva fitxa, per a més informació:\n\n+-------------------------------------------------------------+\n|                       FITXA                                 |\n| # Nom | Superfamília | Espècie        | Pes aproximat       |\n+-------------------------------------------------------------+";
            const string MsgRescue3 = "+-------------------------------------------------------------+\n\n";

            Console.WriteLine(MsgRescue1);
            Console.WriteLine($"| RES{animal.GetRescueNumber()}   | {animal.GetDate()}  | {animal.GetFamily()}         | {animal.GetAG()} | {animal.GetLocation()}     |");
            Console.WriteLine(MsgRescue2);
            Console.WriteLine($"| {animal.GetAnimalName()} | {animal.GetFamily()}       | {animal.GetSpecie()}   | {animal.GetWeight()}              |");
            Console.WriteLine(MsgRescue3);
            Console.WriteLine($"L'animal {animal.GetSpecie()} té un grau d'afectació (GA) del {animal.GetAG()}%. Vols curar-la aquí (1)\no traslladar-la al centre (2) ?\n");     
        }
        public static void GetTreatmentResult(double newAG, bool OnTec, int vetXp, int tecXp)
        {
            if (newAG <= 5) // Exemplar curat amb un AG menor al 5%
            {
                Console.WriteLine();
                Console.WriteLine($"El tractament aplicat ha reduït el GA fins al {newAG}%. L'exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.");
                if (OnTec == true)
                {
                    tecXp = tecXp + 50;
                }
                else
                {
                    vetXp = vetXp + 50;
                }
            }
            else // Exemplar no curat amb un AG major al 5%
            {
                Console.WriteLine();
                Console.WriteLine($"El tractament aplicat ha reduït el GA fins al {newAG}%. No ha estat prou efectiu i cal traslladar l'exemplar al centre. La teva experiència s'ha reduït en -20XP.");
                if (OnTec == true)
                {
                    tecXp = tecXp - 20;
                }
                else
                {
                    vetXp = vetXp - 20;
                }
            }
        }
        public static double GetNewAG(int decision, AAnimal animal, string MsgKo)
        {
            int x;
            double newAG = 0;

            switch (decision)
            {
                case 1:         // Curar aquí
                    if (animal.GetFamily() == "Tortuga Marina")
                    {
                        x = 5;
                        // Càlcul nou AG
                        newAG = animal.GetAG() - ((animal.GetAG() - 2) * (2 * (animal.GetAG()) + 3)) - x;
                    }
                    else if (animal.GetFamily() == "Au Marina")
                    {
                        x = 5;
                        // Càlcul nou AG
                        newAG = animal.GetAG() - (((animal.GetAG()) * (animal.GetAG())) + x);
                    }
                    else if (animal.GetFamily() == "Cetaci") 
                    {
                        x = 25;
                        // Càlcul nou AG
                        newAG = animal.GetAG() - ((Math.Log10(animal.GetAG()) - x));
                    }
                        break;
                case 2:         // Traslladar
                    if (animal.GetFamily() == "Tortuga Marina")
                    {
                        x = 5;
                        // Càlcul nou AG
                        newAG = animal.GetAG() - ((animal.GetAG() - 2) * (2 * (animal.GetAG()) + 3)) - x;
                    }
                    else if (animal.GetFamily() == "Au Marina")
                    {
                        x = 0;
                        // Càlcul nou AG
                        newAG = animal.GetAG() - (((animal.GetAG()) * (animal.GetAG())) + x);
                    }
                    else if (animal.GetFamily() == "Cetaci")
                    {
                        x = 0;
                        newAG = animal.GetAG() - ((Math.Log10(animal.GetAG()) - x));
                    }
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine(MsgKo);
                    Console.WriteLine();
                    decision = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            return newAG;
        }
    }
}
