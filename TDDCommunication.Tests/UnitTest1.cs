
using FluentAssertions;

namespace TDDCommunication.Tests
{
    public class Tests
    {


        
        [TestCase(new int[] { 3, 1, 2 }, 2, TestName = "Test with 3 numbers")]
        [TestCase(new int[] { 3, 2 }, 0, TestName = "Test with 2 numbers")]
        [TestCase(new int[] { 3 }, 0, TestName = "Test with 1 number")]
        [TestCase(new int[] { 3,12, 1, 2,10 }, 15, TestName = "Test with more than 3 numbers")]

        public void SumMiddleNumbersTest(int[] inputNumbers, int expectedOutput)
        {
            //Arrange

            Kata1 kata1 = new Kata1();

            //Act
            int actualOutput = kata1.SumMiddleNumbers(inputNumbers);

            //Assert
            actualOutput.Should().Be(expectedOutput);
        }

        [TestCase(new int[] {6,5,4}, 5 , TestName = "Get mean of 3 numbers")]
        [TestCase(new int[] { 40, 16, 5, 8 }, 17.25, TestName = "Get mean of more than 3 numbers")]
        [TestCase(new int[] { 6,3,4 }, 4.33, TestName = "get mean of 3 numbers, rounded to decimal place")]




        public void GetMeanOfNumbersTest(int[] inputNumbers, double expectedOutput)
        {
            //Arrange

            Kata1 kata1 = new Kata1();

            //Act
            double actualOutput = kata1.GetMeanOfNumbers(inputNumbers);

            //Assert
            actualOutput.Should().Be(expectedOutput);

        }



        [TestCase("northcoders", 1195, TestName = "sum of ASCII value of chars of a string")]
        [TestCase("Northcoders", 1163, TestName = "sum of ASCII value of chars of a string")]
        [TestCase("a", 97, TestName = "sum of ASCII value of chars of a string")]



        public void GetMeanOfNumbersTest(string inputString, int expectedOutput)
        {
            //Arrange

            Kata1 kata1 = new Kata1();

            //Act
            int actualOutput = kata1.GetSumOfASCII(inputString);

            //Assert
            actualOutput.Should().Be(expectedOutput);

        }


    }
}