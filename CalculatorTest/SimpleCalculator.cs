namespace CalculatorTest
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public SimpleCalculator()
        {

        }
        /// <summary>
        /// Get a list of primes - the simple way (more efficient options are available
        /// </summary>
        /// <param name="n">number of primes to find</param>
        /// <returns>list of primes</returns>
        private List<int> GeneratePrimesNaive(int n)
        {
            List<int> primes = new()
            {
                2
            };
            int nextPrime = 3;

            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                //cycles through all primes already found that are less than or equal to the root of the current number being tested and checks for any even division (would produce an integer)
                for (int i = 0; primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }

            return primes;
        }
        public int GetPrimeNumber(int index)
        {
            var primes = GeneratePrimesNaive(index);
            return primes[index - 1];
        }

        public int Add(int start, int amount)
        {
            return (amount + start);
        }

        public float Divide(int start, int by)
        {
            return ((float)start / (float)by);
        }

        public int Multiply(int start, int by)
        {
            return (start * by);
        }

        public int Subtract(int start, int amount)
        {
            return (start - amount);
        }
    }
}
