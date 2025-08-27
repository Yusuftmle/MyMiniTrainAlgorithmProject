//// ==============================
//// TwoSum - Brute Force Solution
//// ==============================
//// Problem: Given an array of integers, find two numbers that add up to a target value
//// Return the indices of the two numbers

//int[] nums = { 1, 2, 3, 4, 5 };
//int target = 3;

//int[] result = twoSum(nums, target);

//static int[] twoSum(int[] numbers, int target)
//{
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        for (int j = i + 1; j < numbers.Length; j++)
//        {
//            if (numbers[i] + numbers[j] == target)
//            {
//                return new int[] { i, j }; // Return the indices when found
//            }
//        }
//    }
//    return null; // Return null if no solution exists
//}

//Console.WriteLine($"Indices of numbers that add up to {target}: {string.Join(", ", result)}");


//// ========================================
//// ClimbStairs - Dynamic Programming Solution
//// ========================================
//// Problem: You are climbing a staircase. Each time you can climb 1 or 2 steps.
//// Calculate the number of distinct ways to reach the top.

//public class Solution 
//{
//    public int ClimbStairs(int n) 
//    {
//        if (n <= 2) return n; // Base cases

//        int[] dp = new int[n + 1]; // DP array to store intermediate results
//        dp[1] = 1;
//        dp[2] = 2;

//        for (int i = 3; i <= n; i++)
//            dp[i] = dp[i - 1] + dp[i - 2]; // Each step = sum of previous two steps

//        return dp[n]; // Total ways to reach nth step
//    }
//}


//// ====================================
//// Array Statistics - Max, Min, Sum, Avg
//// ====================================
//// Problem: Compute the maximum, minimum, difference, sum, and average of an array

//int[] numbers2 = { 3, 7, 2, 9, 4 };

//int sum2 = 0, max2 = numbers2[0], min2 = numbers2[0];

//for (int i = 0; i < numbers2.Length; i++)
//{
//    sum2 += numbers2[i]; // Add current number to sum
//    if (numbers2[i] > max2) max2 = numbers2[i]; // Update max if current number is larger
//    if (numbers2[i] < min2) min2 = numbers2[i]; // Update min if current number is smaller
//}

//int difference2 = max2 - min2; // Difference between max and min
//double average2 = (double)sum2 / numbers2.Length; // Calculate average

//Console.WriteLine($"Max: {max2}, Min: {min2}, Diff: {difference2}, Sum: {sum2}, Avg: {average2}");

//// ==============================
//// Previous Mini Examples
//// ==============================
//// Example 1: Sum of all numbers in an array
//int[] numbers3 = { 1, 2, 3, 4, 5 };
//int total = 0;
//for (int i = 0; i < numbers3.Length; i++)
//{
//    total += numbers3[i];
//}
//Console.WriteLine($"Sum of numbers3: {total}");

//// Example 2: Sum of even numbers in an array
//int sumEven = 0;
//for (int i = 0; i < numbers3.Length; i++)
//{
//    if (numbers3[i] % 2 == 0)
//        sumEven += numbers3[i];
//}
//Console.WriteLine($"Sum of even numbers in numbers3: {sumEven}");


//# 1-100 arası sayıları yazdır
//# Ama 3'e bölünenlerde "Fizz", 5'e bölünenlerde "Buzz", 
//# hem 3 hem 5'e bölünenlerde "FizzBuzz" yazdır

for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)                    // Hem 3'e hem 5'e bölünüyor
        Console.WriteLine("FizzBuzz");
    else if (i % 3 == 0)                // Sadece 3'e bölünüyor
        Console.WriteLine("Fizz");
    else if (i % 5 == 0)                // Sadece 5'e bölünüyor
        Console.WriteLine("Buzz");
    else
        Console.WriteLine(i);           // Hiçbirine bölünmüyor
    Console.WriteLine(i);
}
//# Bir sayı listesi ver: [12, 5, 23, 8, 16, 3, 41]
//# En büyük ve en küçük sayıyı bul (hazır fonksiyon kullanmadan)

int[] numbers = { 1, 2, 3, 4, 5 };
int biggest = numbers[0];
int smallest = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > biggest)
        biggest = numbers[i];
    if (numbers[i] < smallest)
        smallest = numbers[i];
}
Console.WriteLine($"Biggest: {biggest}");
Console.WriteLine($"Smallest: {smallest}");

//# Bir kelimeyi ters çeviren fonksiyon yaz
//# Örnek: "algoritma" -> "amtirogla"
string text ="algoritma";
string reversedText = "";
for (int i = 0; i < text.Length; i++)
{
   
}
for (int j = text.Length - 1; j >= 0; j--)
{
    reversedText += text[j];
}
Console.WriteLine(reversedText);


//fizbuz algorithm
// 1-100 arası için:
// 3'e bölünen → "Fizz"
// 5'e bölünen → "Buzz" 
// Hem 3 hem 5'e bölünen → "FizzBuzz"
// Diğerleri → sayının kendisi

for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)                    // Hem 3'e hem 5'e bölünüyor
        Console.WriteLine("FizzBuzz");
    else if (i % 3 == 0)                // Sadece 3'e bölünüyor
        Console.WriteLine("Fizz");
    else if (i % 5 == 0)                // Sadece 5'e bölünüyor
        Console.WriteLine("Buzz");
    else
        Console.WriteLine(i);           // Hiçbirine bölünmüyor
  
}


//// Bir sayının asal olup olmadığını kontrol eden fonksiyon
//// Örnek: IsPrime(17) → true, IsPrime(15) → false
//Console.WriteLine("Enter a number to check if it's prime:");
//var enterNumber = Console.ReadLine();
//int numberToCheck = int.Parse(enterNumber);

//bool isPrime = true;

//if (numberToCheck <= 1)
//    isPrime = false;
//else
//{
//    for (int i = 2; i < numberToCheck; i++)
//    {
//        if (numberToCheck % i == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }
//}

//if (isPrime)
//    Console.WriteLine($"{numberToCheck} is a prime number.");
//else
//    Console.WriteLine($"{numberToCheck} is not a prime number.");



// İlk n adet Fibonacci sayısını yazdır
// 0, 1, 1, 2, 3, 5, 8, 13, 21...

int n = 10;
int previous = 0;  // Önceki sayı
int current = 1;   // Şimdiki sayı

Console.WriteLine(previous); // 0
Console.WriteLine(current);  // 1

for (int i = 2; i < n; i++)
{
    int next = previous + current; // Yeni sayıyı hesapla
    Console.WriteLine(next);       // Yazdır

    // Değişkenleri güncelle
    previous = current;  // Şimdiki → önceki olur
    current = next;      // Yeni → şimdiki olur
}








