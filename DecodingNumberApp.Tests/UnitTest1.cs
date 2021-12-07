using NUnit.Framework;
using DecodingNumberApp;
using System;

namespace DecodingNumberApp.Tests
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
        [TestCase(ulong.MinValue, "ноль")]
        [TestCase((ulong)1, "один")]
        [TestCase((ulong)1000, "одна тыс€ча ")]
        [TestCase((ulong)1000000, "один миллион ")]
        [TestCase((ulong)11000, "одинадцать тыс€ч ")]
        [TestCase((ulong)21000, "двадцать одна тыс€ча ")]
        [TestCase((ulong)20000, "двадцать тыс€ч ")]
        [TestCase((ulong)2, "два")]
        [TestCase((ulong)12000, "двенадцать тыс€ч ")]
        [TestCase((ulong)22000, "двадцать две тыс€чи ")]
        [TestCase((ulong)2000, "две тыс€чи ")]
        [TestCase((ulong)1234, "одна тыс€ча двести тридцать четыре")]
        [TestCase((ulong)987654321, "дев€тьсот восемьдес€т семь миллионов шестьсот п€тьдес€т четыре тыс€чи триста двадцать один")]
        [TestCase(ulong.MaxValue, "восемнадцать триллионов четыреста сорок шесть биллиардов семьсот сорок четыре биллиона семьдес€т три миллиарда семьсот дев€ть миллионов п€тьсот п€тьдес€т одна тыс€ча шестьсот п€тнадцать")]
        public void ConvertAllNumbers_Test_Positive(ulong number, string expected)
        {
            // Arrange
            

            // Act
            string actual = calculation.ConvertAllNumbers(number);

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