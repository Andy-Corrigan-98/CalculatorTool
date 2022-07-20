using System.Collections;

namespace CalculatorTestTests
{
    public class MultiplicationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, 1, 3 };
            yield return new object[] { -3, -1, 3 };
            yield return new object[] { 0, -2, 0 };
            yield return new object[] { 3, 11, 33 };
            yield return new object[] { 13, 13, 169 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
