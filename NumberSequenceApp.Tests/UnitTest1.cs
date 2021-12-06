using NUnit.Framework;
using NumberSequenceApp;
using System;

namespace NumberSequenceApp.Tests
{
    [TestFixture]
    public class Tests
    {
        View view;

        [SetUp]
        public void Setup()
        {
            view = new View();
        }

        [Test]
        [Category("View")]
        [TestCase(new int[] { 4, 5, 6 }, "Results: 4 5 6")]
        public void SetLengthArray_Test_Positive(int[] numbers, string expected)
        {
            // Arrange


            // Act
            //string actual = controller.TranslationToString(numbers);

            // Assert
            //Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            view = null;
        }
    }
}