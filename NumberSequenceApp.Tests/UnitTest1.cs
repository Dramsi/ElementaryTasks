using NUnit.Framework;
using NumberSequenceApp;

namespace NumberSequenceApp.Tests
{
    [TestFixture]
    public class Tests
    {
        Controller controller;
        View view;

        [SetUp]
        public void Setup()
        {
            controller = new Controller();
            view = new View();
        }

        [Test]
        [Category("Controller")]
        [TestCase(5, 6, new int[] { 2, 3, 4, 5, 6 })]
        [TestCase(8, 10, new int[] { 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(3, 20, new int[] { 4, 5, 6})]
        public void Calculations_Test_Positive(int n, int m, int[] expected)
        {
            // Arrange
            NumberSequence numberSequence = new NumberSequence(n, m);

            // Act
            int[] actual = controller.Calculations(numberSequence);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("Controller")]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, "Results: 2 3 4 5 6 ")]
        [TestCase(new int[] { 3, 4, 5, 6, 7, 8, 9, 10 }, "Results: 3 4 5 6 7 8 9 10 ")]
        [TestCase(new int[] { 4, 5, 6 }, "Results: 4 5 6 ")]
        public void ConversionToString_Test_Positive(int[] numbers, string expected)
        {
            // Arrange


            // Act
            string actual = controller.ConversionToString(numbers);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("Controller")]
        [Ignore("Тест пока ничего не содержит")]
        public void Run_Test_Negative()
        {
            // Arrange


            // Act


            // Assert
            //Assert.Throws
        }

        [Test]
        [Category("View")]
        [Ignore("Тест пока ничего не содержит")]
        public void SetArg_Test_Negative()
        {
            // Arrange


            // Act


            // Assert

        }

        [TearDown]
        public void TearDown()
        {
            controller = null;
        }
    }
}