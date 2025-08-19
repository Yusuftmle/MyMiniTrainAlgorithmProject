// ==============================
// TwoSum - Brute Force Solution
// ==============================
// Problem: Given an array of integers, find two numbers that add up to a target value
// Return the indices of the two numbers

int[] nums = { 1, 2, 3, 4, 5 };
int target = 3;

int[] result = twoSum(nums, target);

static int[] twoSum(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[i] + numbers[j] == target)
            {
                return new int[] { i, j }; // Return the indices when found
            }
        }
    }
    return null; // Return null if no solution exists
}

Console.WriteLine($"Indices of numbers that add up to {target}: {string.Join(", ", result)}");


// ========================================
// ClimbStairs - Dynamic Programming Solution
// ========================================
// Problem: You are climbing a staircase. Each time you can climb 1 or 2 steps.
// Calculate the number of distinct ways to reach the top.

public class Solution 
{
    public int ClimbStairs(int n) 
    {
        if (n <= 2) return n; // Base cases

        int[] dp = new int[n + 1]; // DP array to store intermediate results
        dp[1] = 1;
        dp[2] = 2;

        for (int i = 3; i <= n; i++)
            dp[i] = dp[i - 1] + dp[i - 2]; // Each step = sum of previous two steps

        return dp[n]; // Total ways to reach nth step
    }
}


// ====================================
// Array Statistics - Max, Min, Sum, Avg
// ====================================
// Problem: Compute the maximum, minimum, difference, sum, and average of an array

int[] numbers2 = { 3, 7, 2, 9, 4 };

int sum2 = 0, max2 = numbers2[0], min2 = numbers2[0];

for (int i = 0; i < numbers2.Length; i++)
{
    sum2 += numbers2[i]; // Add current number to sum
    if (numbers2[i] > max2) max2 = numbers2[i]; // Update max if current number is larger
    if (numbers2[i] < min2) min2 = numbers2[i]; // Update min if current number is smaller
}

int difference2 = max2 - min2; // Difference between max and min
double average2 = (double)sum2 / numbers2.Length; // Calculate average

Console.WriteLine($"Max: {max2}, Min: {min2}, Diff: {difference2}, Sum: {sum2}, Avg: {average2}");

// ==============================
// Previous Mini Examples
// ==============================
// Example 1: Sum of all numbers in an array
int[] numbers3 = { 1, 2, 3, 4, 5 };
int total = 0;
for (int i = 0; i < numbers3.Length; i++)
{
    total += numbers3[i];
}
Console.WriteLine($"Sum of numbers3: {total}");

// Example 2: Sum of even numbers in an array
int sumEven = 0;
for (int i = 0; i < numbers3.Length; i++)
{
    if (numbers3[i] % 2 == 0)
        sumEven += numbers3[i];
}
Console.WriteLine($"Sum of even numbers in numbers3: {sumEven}");
