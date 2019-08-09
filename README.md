# Add Days to Date Program with Unit Testing - C#, NUnit

This is a simple program which adds number of days to the given date and displays the new date with the days added. 
The idea came to me when I had to add 240 days to a date for calucating my eligibility to received one award.

Using [Test] attribute we can write our test cases to be executed by the Test runner.

### Example of a test method:
<pre>
            //Arrange
            var givenDate = Convert.ToDateTime("05-01-2019");
            var numberOfDays = 240;

            //Act
            var result = Program.NumberOfDays(numberOfDays, givenDate);

            //Assert
            Assert.AreEqual(Convert.ToDateTime("02-09-2019"),result);
</pre>
