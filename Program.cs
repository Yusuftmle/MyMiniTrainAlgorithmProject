using System;

namespace AlgorithmExamples
{
    /// <summary>
    /// A collection of common algorithms and their implementations
    /// </summary>
    public class AlgorithmExamples
    {
        /// <summary>
        /// Main method demonstrating various algorithms
        /// </summary>
        public static void Main(string[] args)
        {
            DemonstrateTwoSum();
            DemonstrateClimbStairs();
            DemonstrateArrayStatistics();
            DemonstrateFizzBuzz();
            DemonstrateArrayMinMax();
            DemonstrateStringReverse();
            DemonstratePrimeCheck();
            DemonstrateFibonacci();
            DemonstrateDuplicateElements();
            DemonstrateBubbleSort();
            DemonstrateBinarySearch();
            DemonstrateCompleteExample();
            DemonstrateSortAndSearch();





        }

        #region Algorithm Demonstrations

        /// <summary>
        /// Demonstrates the Two Sum algorithm using brute force approach
        /// </summary>
        private static void DemonstrateTwoSum()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int target = 3;
            int[] result = TwoSum(nums, target);

            Console.WriteLine($"=== Two Sum Algorithm ===");
            Console.WriteLine($"Array: [{string.Join(", ", nums)}]");
            Console.WriteLine($"Target: {target}");
            Console.WriteLine($"Indices that sum to target: [{string.Join(", ", result)}]");
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates the Climb Stairs dynamic programming solution
        /// </summary>
        private static void DemonstrateClimbStairs()
        {
            Console.WriteLine($"=== Climb Stairs Algorithm ===");
            Console.WriteLine($"Ways to climb 5 steps: {ClimbStairs(5)}");
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates array statistics calculation
        /// </summary>
        private static void DemonstrateArrayStatistics()
        {
            int[] numbers = { 3, 7, 2, 9, 4 };
            var stats = CalculateArrayStatistics(numbers);

            Console.WriteLine($"=== Array Statistics ===");
            Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Max: {stats.Max}, Min: {stats.Min}, Difference: {stats.Difference}");
            Console.WriteLine($"Sum: {stats.Sum}, Average: {stats.Average:F2}");
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates the FizzBuzz algorithm
        /// </summary>
        private static void DemonstrateFizzBuzz()
        {
            Console.WriteLine($"=== FizzBuzz Algorithm ===");
            FizzBuzz(15);
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates finding minimum and maximum values in an array
        /// </summary>
        private static void DemonstrateArrayMinMax()
        {
            int[] numbers = { 12, 5, 23, 8, 16, 3, 41 };
            var result = FindMinMax(numbers);

            Console.WriteLine($"=== Find Min/Max ===");
            Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Minimum: {result.Min}, Maximum: {result.Max}");
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates string reversal
        /// </summary>
        private static void DemonstrateStringReverse()
        {
            string text = "algoritma";
            string reversed = ReverseString(text);

            Console.WriteLine($"=== String Reversal ===");
            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Reversed: {reversed}");
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates prime number checking
        /// </summary>
        private static void DemonstratePrimeCheck()
        {
            Console.WriteLine($"=== Prime Number Check ===");
            CheckPrimeNumber(17);
            CheckPrimeNumber(15);
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates Fibonacci sequence generation
        /// </summary>
        private static void DemonstrateFibonacci()
        {
            Console.WriteLine($"=== Fibonacci Sequence ===");
            GenerateFibonacci(10);
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates finding duplicate elements in an array
        /// </summary>
        private static void DemonstrateDuplicateElements()
        {
            int[] nums = { 1, 2, 3, 2, 4, 1, 5, 3, 2 };

            Console.WriteLine($"=== Duplicate Elements ===");
            Console.WriteLine($"Array: [{string.Join(", ", nums)}]");
            FindDuplicateElements(nums);
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates Bubble Sort algorithm
        /// </summary>
        private static void DemonstrateBubbleSort()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine($"=== Bubble Sort ===");
            Console.WriteLine($"Original array: [{string.Join(", ", arr)}]");
            BubbleSort(arr);
            Console.WriteLine($"Sorted array: [{string.Join(", ", arr)}]");
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates Binary Search algorithm
        /// </summary>
        private static void DemonstrateBinarySearch()
        {
            int[] sortedArr = { 2, 5, 8, 12, 16, 23, 38, 45, 67, 78, 89, 99 };
            int target = 23;

            Console.WriteLine($"=== Binary Search ===");
            Console.WriteLine($"Array: [{string.Join(", ", sortedArr)}]");
            Console.WriteLine($"Target: {target}");
            int result = BinarySearch(sortedArr, target);
            Console.WriteLine(result != -1 ? $"Element found at index: {result}" : "Element not found.");
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates complete example with sorting and searching
        /// </summary>
        private static void DemonstrateCompleteExample()
        {
            int[] messyArray = { 78, 23, 45, 12, 89, 34, 67, 5, 91, 56, 19, 83 };
            int target = 67;

            Console.WriteLine($"=== Complete Example: Sort and Search ===");

            // Step 1: Print original array
            Console.WriteLine($"Original Array: [{string.Join(", ", messyArray)}]");

            // Step 2: Sort using Bubble Sort
            BubbleSort(messyArray);
            Console.WriteLine($"Sorted Array: [{string.Join(", ", messyArray)}]");

            // Step 3: Search using Binary Search
            int foundIndex = BinarySearch(messyArray, target);

            // Step 4: Print result
            Console.WriteLine(foundIndex != -1
                ? $"Element {target} found at index: {foundIndex}"
                : $"Element {target} not found in the array.");
        }

        #endregion

        #region Algorithm Implementations

        /// <summary>
        /// Finds two indices where the elements sum to the target value
        /// Time Complexity: O(n²)
        /// </summary>
        /// <param name="numbers">Input array of integers</param>
        /// <param name="target">Target sum value</param>
        /// <returns>Array containing the two indices, or null if not found</returns>
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Calculates distinct ways to climb stairs (1 or 2 steps at a time)
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="n">Number of steps</param>
        /// <returns>Number of distinct ways to climb</returns>
        public static int ClimbStairs(int n)
        {
            if (n <= 2) return n;

            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
                dp[i] = dp[i - 1] + dp[i - 2];

            return dp[n];
        }

        /// <summary>
        /// Calculates various statistics for an integer array
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns>Tuple containing max, min, difference, sum, and average</returns>
        public static (int Max, int Min, int Difference, int Sum, double Average) CalculateArrayStatistics(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");

            int sum = 0, max = array[0], min = array[0];

            foreach (int num in array)
            {
                sum += num;
                if (num > max) max = num;
                if (num < min) min = num;
            }

            int difference = max - min;
            double average = (double)sum / array.Length;

            return (max, min, difference, sum, average);
        }

        /// <summary>
        /// Implements the FizzBuzz algorithm for numbers 1 to n
        /// </summary>
        /// <param name="n">Upper limit</param>
        public static void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Finds minimum and maximum values in an array
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns>Tuple containing min and max values</returns>
        public static (int Min, int Max) FindMinMax(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");

            int min = array[0], max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            return (min, max);
        }

        /// <summary>
        /// Reverses a string
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>Reversed string</returns>
        public static string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Checks if a number is prime
        /// Time Complexity: O(√n)
        /// </summary>
        /// <param name="number">Number to check</param>
        public static void CheckPrimeNumber(int number)
        {
            if (number <= 1)
            {
                Console.WriteLine($"{number} is not a prime number.");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine($"{number} is {(isPrime ? "" : "not ")}a prime number.");
        }

        /// <summary>
        /// Generates first n Fibonacci numbers
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="n">Number of Fibonacci numbers to generate</param>
        public static void GenerateFibonacci(int n)
        {
            if (n <= 0) return;

            int a = 0, b = 1;

            if (n >= 1) Console.Write($"{a} ");
            if (n >= 2) Console.Write($"{b} ");

            for (int i = 3; i <= n; i++)
            {
                int next = a + b;
                Console.Write($"{next} ");
                a = b;
                b = next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Finds and counts duplicate elements in an array
        /// Time Complexity: O(n²)
        /// </summary>
        /// <param name="array">Input array</param>
        public static void FindDuplicateElements(int[] array)
        {
            var counted = new System.Collections.Generic.HashSet<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (counted.Contains(array[i])) continue;

                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j]) count++;
                }

                if (count > 1)
                {
                    Console.WriteLine($"{array[i]} appears {count} times");
                    counted.Add(array[i]);
                }
            }
        }

        /// <summary>
        /// Sorts an array using Bubble Sort algorithm
        /// Time Complexity: O(n²)
        /// </summary>
        /// <param name="array">Array to sort</param>
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap elements
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Searches for an element in a sorted array using Binary Search
        /// Time Complexity: O(log n)
        /// </summary>
        /// <param name="array">Sorted array to search</param>
        /// <param name="target">Target value to find</param>
        /// <returns>Index of the target element, or -1 if not found</returns>
        public static int BinarySearchh(int[] array, int target)
        {
            int left = 0, right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        #endregion

        /// <summary>
        /// Demonstrates sorting a messy array using Bubble Sort and finding a target value using Binary Search
        /// </summary>
        private static void DemonstrateSortAndSearch()
        {
            int[] messyArray = { 78, 23, 45, 12, 89, 34, 67, 5, 91, 56, 19, 83 };
            int target = 67;

            // Step 1: Print original array
            Console.WriteLine($"Original Array: [{string.Join(", ", messyArray)}]");

            // Step 2: Sort the array using Bubble Sort
            BubbleSort(messyArray);

            // Step 3: Print sorted array
            Console.WriteLine($"Sorted Array: [{string.Join(", ", messyArray)}]");

            // Step 4: Search for target using Binary Search
            int foundIndex = BinarySearch(messyArray, target);

            // Step 5: Print result
            Console.WriteLine(foundIndex != -1
                ? $"Element {target} found at index: {foundIndex}"
                : $"Element {target} not found in the array.");
        }

        /// <summary>
        /// Sorts an array in ascending order using the Bubble Sort algorithm
        /// Time Complexity: O(n²)
        /// </summary>
        /// <param name="array">Array to sort</param>
        public static void BubbleSortt(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Searches for an element in a sorted array using the Binary Search algorithm
        /// Time Complexity: O(log n)
        /// </summary>
        /// <param name="array">Sorted array to search</param>
        /// <param name="target">Target value to find</param>
        /// <returns>Index of the target element, or -1 if not found</returns>
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0, right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }


    }

}
