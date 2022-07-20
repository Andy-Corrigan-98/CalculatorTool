using System.Collections;

namespace CalculatorTestTests
{
    public class DivisionTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, 1, 3 };
            yield return new object[] { 6, -2, -3 };
            yield return new object[] { -8, -2, 4 };
            yield return new object[] { 33, 11, 3 };
            yield return new object[] {  169, 13, 13 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
