using CalculatorTest;
using Xunit;

namespace CalculatorTestTests
{
    public class SimpleCalculatorTest
    {
        [Fact]
        public void Task_Add_TwoNumbers()
        {
            int start = 3;
            int amount = 4;

            int expectedVal = 7;

            SimpleCalculator calc = new();
            int output = calc.Add(start, amount);

            Assert.Equal(expectedVal, output);
        }
        
        [Theory]
        [ClassData(typeof(AdditionTestData))]
        public void Task_Add_Theory(int start, int amount, int expectedVal)
        {

            SimpleCalculator calc = new();
            int output = calc.Add(start, amount);

            Assert.Equal(expectedVal, output);
        }

        [Fact]
        public void Task_Subtract_TwoNumbers()
        {
            int start = 7;
            int amount = 4;

            int expectedVal = 3;

            SimpleCalculator calc = new();
            int output = calc.Subtract(start, amount);

            Assert.Equal(expectedVal, output);
        }

        [Theory]
        [ClassData(typeof(SubtractionTestData))]
        public void Task_Subtract_Theory(int start, int amount, int expectedVal)
        {
 
            SimpleCalculator calc = new();
            int output = calc.Subtract(start, amount);

            Assert.Equal(expectedVal, output);
        }

        [Fact]
        public void Task_Divide_TwoNumbers()
        {
            int start = 12;
            int amount = 4;

            float expectedVal = 3;

            SimpleCalculator calc = new();
            float output = calc.Divide(start, amount);

            Assert.Equal(expectedVal, output);
        }

        [Fact]
        public void Task_Multiply_TwoNumbers()
        {
            int start = 7;
            int amount = 3;

            int expectedVal = 21;

            SimpleCalculator calc = new();
            int output = calc.Multiply(start, amount);

            Assert.Equal(expectedVal, output);
        }
        
        [Theory]
        [ClassData(typeof(MultiplicationTestData))]
        public void Task_Multiply_Theory(int start, int amount, int expectedVal)
        {
            SimpleCalculator calc = new();
            int output = calc.Multiply(start, amount);

            Assert.Equal(expectedVal, output);
        }

    }
}