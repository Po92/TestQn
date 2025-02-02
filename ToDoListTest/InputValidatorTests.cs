using System;
using Xunit;
using ToDoList;

namespace ToDoListTests
{
    public class InputValidatorTests
    {
        [Fact]
        public void ReadNonEmptyString_ShouldReturnValidInput()
        {
            // Arrange
            string nullInput = "";
            string input = "Test Input";

            // Simulating Console input
            using var sw = new System.IO.StringWriter();
            using var sr = new System.IO.StringReader(nullInput + Environment.NewLine + input);
            Console.SetOut(sw);
            Console.SetIn(sr);

            // Act Test input validator with simulated input
            var result = InputValidator.ReadNonEmptyString();

            // Assert check results
            Assert.Equal(input, result);
            Assert.Contains("Invalid Input.Please try again: ", sw.ToString());
        }

        [Fact]
        public void ReadDateTime_ShouldReturnValidDate()
        {
            // Arrange
            string nullInput = ""; //test null
            string invalidDateInput = "13/13/2065"; // test out of bounds date
            string invalidFormatInput = "test"; // test invalid format
            string input = "02/02/2025"; // This is the input we want to simulate the user entering.

            // Simulating Console input
            using var sw = new System.IO.StringWriter();
            using var sr = new System.IO.StringReader(nullInput  + Environment.NewLine + invalidDateInput + Environment.NewLine + invalidFormatInput + Environment.NewLine + input);
            Console.SetOut(sw);
            Console.SetIn(sr);

            // Act
            DateTime result = InputValidator.ReadDateTime();

            // Assert
            Assert.Equal(DateTime.Parse(input), result); // Verify that the result matches the expected date.
            Assert.Contains("Invalid date format. Please try again using format MM/dd/yyyy: ", sw.ToString());
        }

        [Fact]
        public void ReadInt_ShouldReturnValidInteger()
        {
            // Arrange
            string nullInput = "";
            string invalidInput = "abc";
            string input = "123"; 
            int expectedResult = 123;

            // Simulating Console input
            using var sw = new System.IO.StringWriter();
            using var sr = new System.IO.StringReader(nullInput + Environment.NewLine + invalidInput + Environment.NewLine + input);
            Console.SetOut(sw);
            Console.SetIn(sr);

            // Act
            var result = InputValidator.ReadInt(); 

            // Assert
            Assert.Equal(expectedResult, result); // Verify that the result matches the expected integer.
            Assert.Contains("Invalid input. Please enter a valid integer: ", sw.ToString()); //Verify that prompts are working
        }
    }
}
