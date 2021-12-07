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
        [TestCase((ulong)1, "����")]
        [TestCase((ulong)1000, "���� ������ ")]
        [TestCase((ulong)1000000, "���� ������� ")]
        [TestCase((ulong)11000, "���������� ����� ")]
        [TestCase((ulong)21000, "�������� ���� ������ ")]
        [TestCase((ulong)20000, "�������� ����� ")]
        [TestCase((ulong)2, "���")]
        [TestCase((ulong)12000, "���������� ����� ")]
        [TestCase((ulong)22000, "�������� ��� ������ ")]
        [TestCase((ulong)2000, "��� ������ ")]
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