using System.Diagnostics;
using System.Numerics;
using System.Text;
// namespace CandidateCodingTest
// {
    

    // class Program
    // {
    //     static void Main(string[] args)
    //     {

    //     }
    // }

    public static class CodingTestMethods
    {
        /// <summary>
        /// Implement this method. You may add additional methods.
        /// Write a method that prints the numbers from 1 to 100 to the console.
        /// But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
        /// For numbers which are multiples of both three and five print “FizzBuzz”.
        /// </summary>
        public static void FizzBuzz()
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 1; i <= 100; i++)
                {
                    if(i % 3 == 0 && i % 5 == 0)
                        stringBuilder.AppendLine("FizzBuzz");
                    else if(i % 5 == 0)
                        stringBuilder.AppendLine("Buzz");
                    else if(i % 3 == 0)
                        stringBuilder.AppendLine("Fizz");
                    else
                        stringBuilder.AppendLine(i.ToString());
                }

                Console.WriteLine(stringBuilder.ToString());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Implement this method. You may add additional methods.
        /// Write a method that iterates 1,000,000 times and generates random numbers between 1-1,000,000 and returns the distinct list of these numbers.
        /// Do so without using LINQ.
        /// The method must complete in under a second.
        /// </summary>
        /// <returns>A list of distinct numbers between 1-1,000,000.</returns>
        public static List<int> GetDistinctRandom()
        {
            try
            {
                int maxIterationValue = 1000000;

                int[] nums = new int[maxIterationValue];

                for (int i = 0; i < nums.Length; i++)
                    nums[i] = i + 1;

                Shuffle(nums);
                
                return new List<int>(nums);   
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
        }

        private static void Shuffle(int[] numArray)
        {
            try
            {
                Random rand = new Random();
                for (int i = numArray.Length - 1; i > 0; i--)
                {
                    int j = rand.Next(i + 1);
                    int temp = numArray[i];
                    numArray[i] = numArray[j];
                    numArray[j] = temp;
                }   
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
        }

        private static int[] list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static int[] list2 = new int[] { 4, 9, 2, 3, 10, 5, 6, 9, 2, 3, 5, 2, 0 };

        /// <summary>
        /// Implement this method using linq.
        /// Outputs the distinct, common numbers in list1 and list2.
        /// </summary>
        public static IEnumerable<int> GetCommonNumbersInList1And2()
        {
            try
            {
               return list1.Intersect(list2);
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
        }

        /// <summary>
        /// Implement this method using linq.
        /// Outputs the first occurance of 10 in list2.
        /// </summary>
        public static int GetFirstOccuranceOf10InList2()
        {
            try
            {
                return list2.First(x => x == 10);
            }
            catch (System.Exception ex)
            {
                
                throw ex; 
            }
        }

        /// <summary>
        /// Implement this method using linq.
        /// Outputs the single occurance of 2 in list2.
        /// Throw error if more than one exists.
        /// </summary>
        public static int GetSingleOccuranceOf2InList2()
        {
            try
            {
                return list2.First(x => x == 10);   
            }
            catch (System.Exception ex)
            {                
                throw ex;
            }
        }

        /// <summary>
        /// Implement this method.
        /// Gets the sum of digits for the specified integer.
        /// ie. 1010 returns 2, 1024 returns 7, 200000 returns 2, etc.
        /// </summary>
        /// <param name="n">The integer to sum.</param>
        /// <returns>A sum of the digits in the specified integer.</returns>
        public static int GetSumOfDigits(int n)
        {
            try
            {
                long num = Math.Abs((long)n);
                int sum = 0;
                while (num > 0)
                {
                    sum += (int)(num % 10);
                    num /= 10;
                }
                return sum;
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
        }
       
        static Dictionary<int, long> factorialMap = new Dictionary<int, long>();
        /// <summary>
        /// Implement this method. You may add additional methods.
        /// Calculates factorial to the nth position.
        /// if n == 0, n! = 1
        /// if n > 0, n! = (n - 1)! * n
        /// ie. 1, 1, 2, 6, 24, 120, 720, 5040...
        /// </summary>
        /// <param name="n">The nth position to calculate.</param>
        /// <returns>The cacluated nth Factorial.</returns>
        public static long Factorial(int n)
        {
            try
            {
                if(factorialMap.ContainsKey(n))
                   return factorialMap[n];

                if (n == 0)
                    return 1; 

                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }

                //Saving result for future use
                factorialMap[n] = result;

                return result;
            }
            catch (System.Exception ex)
            {                
                throw ex;
            }
        }

        /// <summary>
        /// Implement this method. You may add additional methods.
        /// Calculates Fibonaccis to the nth position.
        /// F(n) = F(n - 1) + F(n - 2)
        /// ie. 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89...
        /// </summary>
        /// <param name="n">The nth position to calculate.</param>
        /// <returns>The calculated nth Fibonacci</returns>
        public static long Fibonacci(int n)
        {
            try
            {
                if (n <= 0) return 0; 
                if (n == 1) return 1; 

                //F(1)
                long prev1 = 1; 
                //F(0)
                long prev2 = 0;
                long result = 0;

                for (int i = 2; i <= n; i++)
                {
                    //F(n) = F(n-1) + F(n-2)
                    result = prev1 + prev2; 
                    prev2 = prev1;
                    prev1 = result;
                }

                return result;
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
        }
    }

// }