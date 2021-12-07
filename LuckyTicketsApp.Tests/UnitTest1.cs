using NUnit.Framework;

namespace LuckyTicketsApp.Tests
{
    public class Tests
    {
        Calculation calculation;

        [SetUp]
        public void Setup()
        {
            calculation = new Calculation();
        }

        [Test]
        [Category("class Calculation")]
        [TestCase(0, 999999, 55252)]
        [TestCase(1, 100, 0)]
        [TestCase(100, 100000, 4839)]
        public void CountLuckyTicketsTheEasyWay_Test_Positive(int minTiketValue, int maxTiketValue, int expected)
        {
            // Arrange
            LuckyTickets luckyTickets = new LuckyTickets(minTiketValue, maxTiketValue);

            // Act
            int actual = calculation.CountLuckyTicketsTheEasyWay(luckyTickets);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("class Calculation")]
        [TestCase(0, 999999, 25081)]
        [TestCase(1, 100, 0)]
        [TestCase(100, 100000, 3725)]
        public void CountLuckyTicketsTheDifficulWay_Test_Positive(int minTiketValue, int maxTiketValue, int expected)
        {
            // Arrange
            LuckyTickets luckyTickets = new LuckyTickets(minTiketValue, maxTiketValue);

            // Act
            int actual = calculation.CountLuckyTicketsTheDifficulWay(luckyTickets);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            calculation = null;
        }
    }
}