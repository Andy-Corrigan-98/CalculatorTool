using System.Collections;

namespace CalculatorTestTests
{
    public class AdditionTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { -1,-2, -3 };
            yield return new object[] { -2, 2, 0 };
            yield return new object[] { 11, 22, 33 };
            yield return new object[] { int.MinValue, int.MaxValue, -1 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
