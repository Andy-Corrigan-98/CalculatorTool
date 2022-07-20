using System.Collections;

namespace CalculatorTestTests
{
    public class SubtractionTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, 1, 2  };
            yield return new object[] { -3, -1, -2 };
            yield return new object[] { 0, -2, 2 };
            yield return new object[] { 33, 11, 22 };
            yield return new object[] { -1, int.MinValue, int.MaxValue };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
