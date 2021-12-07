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
        [TestCase(ulong.MinValue, "����")]
        [TestCase((ulong)1234, "���� ������ ������ �������� ������")]
        [TestCase((ulong)987654321, "��������� ����������� ���� ��������� �������� ��������� ������ ������ ������ �������� ����")]
        [TestCase(ulong.MaxValue, "������������ ���������� ��������� ����� ����� ���������� ������� ����� ������ �������� ��������� ��� ��������� ������� ������ ��������� ������� ��������� ���� ������ �������� ����������")]
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