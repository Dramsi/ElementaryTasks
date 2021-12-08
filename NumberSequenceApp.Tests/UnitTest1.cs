using NUnit.Framework;

namespace NumberSequenceApp.Tests
{
    [TestFixture]
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
        [TestCase(3, 1, new int[] { 1, 2, 3 })]
        [TestCase(4, 15, new int[] { 4, 5, 6, 7 })]
        [TestCase(5, 439.5, new int[] { 21, 22, 23, 24, 25 })]
        public void CalculationSequence_Test_Positive(int lengthArray, double squareNumber, int[] expected)
        {
            NumberSequence numberSequence = new NumberSequence(lengthArray, squareNumber);
            int[] actual = calculation.CalculationSequence(numberSequence);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("class Calculation")]
        [TestCase(null, null)]
        public void CalculationSequence_Test_Negative(NumberSequence numberSequence, int[] expected)
        {
            int[] actual = calculation.CalculationSequence(numberSequence);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("class Calculation")]
        [TestCase(new int[] { 1, 2, 3 }, "Results: 1 2 3")]
        [TestCase(new int[] { 4, 5, 6, 7 }, "Results: 4 5 6 7")]
        [TestCase(new int[] { 21, 22, 23, 24, 25 }, "Results: 21 22 23 24 25")]
        public void TranslationToString_Test_Positive(int[] numbers, string expected)
        {
            string actual = calculation.TranslationToString(numbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("class Calculation")]
        [TestCase(null, null)]
        public void TranslationToString_Test_Negative(int[] numbers, string expected)
        {
            string actual = calculation.TranslationToString(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            calculation = null;
        }
    }
}