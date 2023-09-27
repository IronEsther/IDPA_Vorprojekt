using Microsoft.VisualStudio.TestPlatform.TestHost;
using IDPA_Vorprojekt_SAND;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ProgramTests
    {

        public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ZinsertragFormel_CalculatesBonusCorrectly()
        {
            // Arrange
            Program.Kapital = 1000;
            Program.Geburtstag = 30;
            Program.Zinssatz = 5;

            // Act
            Program.ZinsertragFormel();

            // Assert
            Assert.AreEqual(1500, Program.Bonus); // Stellen Sie sicher, dass der Bonus korrekt berechnet wurde.
        }
    }
}