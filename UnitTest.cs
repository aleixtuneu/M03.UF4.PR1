using NUnit.Framework;

namespace M03.UF4.PR1.Tests
{
    [TestClass]
    public class AuMarinaTests
    {
        [TestMethod]
        public void GetFamily_ReturnsCorrectValue()
        {
            // Arrange
            AuMarina auMarina = new AuMarina("Familia", 0, "", "", "", 0, "", 0);

            // Act
            string result = auMarina.GetFamily();

            // Assert
            Assert.AreEqual("Au Marina", result);
        }
        [TestMethod]
        public void GetAG_ReturnsValueBetween1And99()
        {
            // Arrange
            AuMarina auMarina = new AuMarina("", 0, "", "", "", 0, "", 0);

            // Act
            double result = auMarina.GetAG();

            // Assert
            Assert.GreaterOrEqual(result, 1);
            Assert.LessOrEqual(result, 99);
        }
        [TestMethod]
        public void GetLocation_ReturnsValidLocation()
        {
            // Arrange
            AuMarina auMarina = new AuMarina("", 0, "", "", "", 0, "", 0);

            // Act
            string result = auMarina.GetLocation();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }
        [TestMethod]
        public void GetAnimalName_ReturnsValidAnimalName()
        {
            // Arrange
            AuMarina auMarina = new AuMarina("", 0, "", "", "", 0, "", 0);

            // Act
            string result = auMarina.GetAnimalName();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }
        [TestMethod]
        public void GetSpecie_ReturnsValidSpecie()
        {
            // Arrange
            AuMarina auMarina = new AuMarina("", 0, "", "", "", 0, "", 0);

            // Act
            string result = auMarina.GetSpecie();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }
        [TestMethod]
        public void GetWeight_ReturnsValueBetween1And2()
        {
            // Arrange
            AuMarina auMarina = new AuMarina("", 0, "", "", "", 0, "", 0);

            // Act
            double result = auMarina.GetWeight();

            // Assert
            Assert.GreaterOrEqual(result, 1);
            Assert.LessOrEqual(result, 2);
        }
        [TestMethod]
        public void GetRescueNumber_ReturnsValueBetween0And999()
        {
            // Arrange
            AuMarina auMarina = new AuMarina("", 0, "", "", "", 0, "", 0);

            // Act
            int result = auMarina.GetRescueNumber();

            // Assert
            Assert.GreaterOrEqual(result, 0);
            Assert.LessOrEqual(result, 999);
        }
    }
    [TestClass]
    public class CetaciTests
    {
        [TestMethod]
        public void GetFamily_ReturnsCorrectValue()
        {
            // Arrange
            Cetaci cetaci = new Cetaci("Familia", 0, "", "", "", 0, "", 0);

            // Act
            string result = cetaci.GetFamily();

            // Assert
            Assert.AreEqual("Cetaci", result);
        }

        [TestMethod]
        public void GetAG_ReturnsValueBetween1And99()
        {
            // Arrange
            Cetaci cetaci = new Cetaci("", 0, "", "", "", 0, "", 0);

            // Act
            double result = cetaci.GetAG();

            // Assert
            Assert.GreaterOrEqual(result, 1);
            Assert.LessOrEqual(result, 99);
        }

        [TestMethod]
        public void GetLocation_ReturnsValidLocation()
        {
            // Arrange
            Cetaci cetaci = new Cetaci("", 0, "", "", "", 0, "", 0);

            // Act
            string result = cetaci.GetLocation();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [TestMethod]
        public void GetAnimalName_ReturnsValidAnimalName()
        {
            // Arrange
            Cetaci cetaci = new Cetaci("", 0, "", "", "", 0, "", 0);

            // Act
            string result = cetaci.GetAnimalName();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [TestMethod]
        public void GetSpecie_ReturnsValidSpecie()
        {
            // Arrange
            Cetaci cetaci = new Cetaci("", 0, "", "", "", 0, "", 0);

            // Act
            string result = cetaci.GetSpecie();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [TestMethod]
        public void GetWeight_ReturnsValueBetween1And2()
        {
            // Arrange
            Cetaci cetaci = new Cetaci("", 0, "", "", "", 0, "", 0);

            // Act
            double result = cetaci.GetWeight();

            // Assert
            Assert.GreaterOrEqual(result, 1);
            Assert.LessOrEqual(result, 2);
        }

        [TestMethod]
        public void GetDate_ReturnsValidDate()
        {
            // Arrange
            Cetaci cetaci = new Cetaci("", 0, "", "", "", 0, "", 0);

            // Act
            string result = cetaci.GetDate();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [TestMethod]
        public void GetRescueNumber_ReturnsValueBetween0And999()
        {
            // Arrange
            Cetaci cetaci = new Cetaci("", 0, "", "", "", 0, "", 0);

            // Act
            int result = cetaci.GetRescueNumber();

            // Assert
            Assert.GreaterOrEqual(result, 0);
            Assert.LessOrEqual(result, 999);
        }
    }
    [TestClass]
    public class TortugaMarinaTests
    {
        [TestMethod]
        public void GetFamily_ReturnsCorrectValue()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina("Familia", 0, "", "", "", 0, "", 0);

            // Act
            string result = tortuga.GetFamily();

            // Assert
            Assert.AreEqual("Tortuga Marina", result);
        }

        [TestMethod]
        public void GetAG_ReturnsValueBetween1And99()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina("", 0, "", "", "", 0, "", 0);

            // Act
            double result = tortuga.GetAG();

            // Assert
            Assert.GreaterOrEqual(result, 1);
            Assert.LessOrEqual(result, 99);
        }

        [TestMethod]
        public void GetLocation_ReturnsValidLocation()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina("", 0, "", "", "", 0, "", 0);

            // Act
            string result = tortuga.GetLocation();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [TestMethod]
        public void GetAnimalName_ReturnsValidAnimalName()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina("", 0, "", "", "", 0, "", 0);

            // Act
            string result = tortuga.GetAnimalName();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [TestMethod]
        public void GetSpecie_ReturnsValidSpecie()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina("", 0, "", "", "", 0, "", 0);

            // Act
            string result = tortuga.GetSpecie();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [TestMethod]
        public void GetWeight_ReturnsValueBetween60And150()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina("", 0, "", "", "", 0, "", 0);

            // Act
            double result = tortuga.GetWeight();

            // Assert
            Assert.GreaterOrEqual(result, 60);
            Assert.LessOrEqual(result, 150);
        }

        [TestMethod]
        public void GetDate_ReturnsValidDate()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina("", 0, "", "", "", 0, "", 0);

            // Act
            string result = tortuga.GetDate();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [TestMethod]
        public void GetRescueNumber_ReturnsValueBetween0And999()
        {
            // Arrange
            TortugaMarina tortuga = new TortugaMarina("", 0, "", "", "", 0, "", 0);

            // Act
            int result = tortuga.GetRescueNumber();

            // Assert
            Assert.GreaterOrEqual(result, 0);
            Assert.LessOrEqual(result, 999);
        }
    }
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ValidateCharacter_TecSelected_ReturnsTrue()
        {
            // Arrange
            int character = 1;
            bool expected = true;

            // Act
            bool result = Program.ValidateCharacter(character, false, "");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidateCharacter_VetSelected_ReturnsFalse()
        {
            // Arrange
            int character = 2;
            bool expected = false;

            // Act
            bool result = Program.ValidateCharacter(character, true, "");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNewAG_CureHere_ReturnsCorrectValue()
        {
            // Arrange
            var tortuga = new TortugaMarina("", 50, "", "", "", 0, "", 0);
            int decision = 1;

            // Act
            double result = Program.GetNewAG(decision, tortuga, "");

            // Assert
            Assert.GreaterOrEqual(result, 0);
            Assert.LessOrEqual(result, 50);
        }

        [TestMethod]
        public void GetNewAG_Transfer_ReturnsCorrectValue()
        {
            // Arrange
            var cetaci = new Cetaci("", 70, "", "", "", 0, "", 0);
            int decision = 2;

            // Act
            double result = Program.GetNewAG(decision, cetaci, "");

            // Assert
            Assert.GreaterOrEqual(result, 0);
            Assert.LessOrEqual(result, 70);
        }
    }
}
