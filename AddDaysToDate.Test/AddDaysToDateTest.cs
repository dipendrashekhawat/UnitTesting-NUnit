using NUnit.Framework;
using AddDaysToDate;
using System;

namespace Tests
{
    public class AddDaysToDateTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NumberOfDays_WhenNumberOfDaysAre240_ReturnNewDate()
        {
            //Arrange
            var givenDate = Convert.ToDateTime("05-01-2019");
            var numberOfDays = 240;

            //Act
            var result = Program.NumberOfDays(numberOfDays, givenDate);

            //Assert
            Assert.AreEqual(Convert.ToDateTime("02-09-2019"),result);
        }

        [Test]
        public void NumberOfDays_WhenNumberOfDaysAreLessThanZero_ShouldReturnDateLessThanGivenDate()
        {
            //Arrange
            var givenDate = Convert.ToDateTime("05-01-2019");
            var numberOfDays = -7;

            //Act
            var result = Program.NumberOfDays(numberOfDays, givenDate);

            //Assert
            Assert.That(result, Is.LessThan(givenDate));
        }
    }
}