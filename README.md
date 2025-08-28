# 🚀 My Mini Training Algorithm Project

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)

> A comprehensive collection of **algorithm implementations in C#** designed to sharpen programming skills and strengthen problem-solving fundamentals.

---

## 📋 Table of Contents
- [🎯 Overview](#-overview)
- [⚡ Algorithms Included](#-algorithms-included)
- [🛠️ Getting Started](#️-getting-started)
- [📊 Complexity Analysis](#-complexity-analysis)
- [🤝 Contributing](#-contributing)

---

## 🎯 Overview

This repository serves as a **practical learning playground** for algorithm implementation and optimization. Each solution includes detailed explanations, time/space complexity analysis, and multiple approaches where applicable.

**Perfect for:**
- 📚 Students learning algorithms and data structures
- 💻 Developers preparing for technical interviews
- 🧠 Anyone looking to improve problem-solving skills

---

## ⚡ Algorithms Included

### 🔍 **Two Sum - Brute Force**
```csharp
// Find two numbers that add up to target
int[] nums = {2, 7, 11, 15};
int target = 9;
// Returns: [0, 1] (indices of 2 and 7)
```
- **📝 Problem:** Given an array of integers, find two numbers that add up to a target value
- **💡 Approach:** Nested loop checking all possible pairs
- **⏱️ Complexity:** O(n²) time, O(1) space

### 🪜 **Climb Stairs - Dynamic Programming**
```csharp
// Calculate distinct ways to reach the top
ClimbStairs(5); // Returns: 8 ways
```
- **📝 Problem:** Count distinct ways to climb stairs (1 or 2 steps at a time)
- **💡 Approach:** Dynamic programming with memoization
- **⏱️ Complexity:** O(n) time, O(n) space
- **🧮 Formula:** `dp[i] = dp[i-1] + dp[i-2]`

### 📊 **Array Statistics Calculator**
```csharp
int[] data = {10, 5, 8, 20, 3};
// Computes: Max, Min, Sum, Average, Range
```
- **📝 Problem:** Compute comprehensive statistics for an array
- **💡 Features:**
  - ✅ Maximum value
  - ✅ Minimum value
  - ✅ Sum of elements
  - ✅ Average calculation
  - ✅ Range (Max - Min)
- **⏱️ Complexity:** O(n) time, O(1) space

### 🔢 **Array Operations Suite**
- **Sum Calculator:** Total of all array elements
- **Even Sum:** Sum of even numbers only
- **Custom Filters:** Extensible for various conditions

---

## 🛠️ Getting Started

### Prerequisites
- [.NET 6.0+](https://dotnet.microsoft.com/download)
- Visual Studio / VS Code (recommended)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Yusuftmle/MyMiniTrainAlgorithmProject.git
   cd MyMiniTrainAlgorithmProject
   ```

2. **Build the project**
   ```bash
   dotnet build
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

### 🎮 Usage Example
```csharp
// Two Sum Example
var solution = new TwoSum();
int[] result = solution.FindTwoSum([2, 7, 11, 15], 9);
Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");

// Climb Stairs Example
var climber = new ClimbStairs();
int ways = climber.CountWays(10);
Console.WriteLine($"Ways to climb 10 stairs: {ways}");
```
Binary Search
```csharp
int[] sortedArr = {2, 5, 8, 12, 16, 23, 38, 45, 67, 78, 89, 99};
int target = 23;
int index = BinarySearch(sortedArr, target); // Returns index of target

```
🔢 Bubble Sort
```csharp
int[] arr = {64, 34, 25, 12, 22, 11, 90};
BubbleSort(arr); // Sorts array in ascending order
```
---

## 📊 Complexity Analysis

| Algorithm             | Time Complexity | Space Complexity | Difficulty |
| --------------------- | --------------- | ---------------- | ---------- |
| Two Sum (Brute Force) | O(n²)           | O(1)             | 🟢 Easy    |
| Climb Stairs (DP)     | O(n)            | O(n)             | 🟡 Medium  |
| Array Statistics      | O(n)            | O(1)             | 🟢 Easy    |
| Bubble Sort           | O(n²)           | O(1)             | 🟢 Easy    |
| Binary Search         | O(log n)        | O(1)             | 🟢 Easy    |


---

## 🚀 Future Enhancements

- [ ] **Hash Map approach** for Two Sum (O(n) time)
- [ ] **Space-optimized** Climb Stairs (O(1) space)
- [ ] **Sorting algorithms** implementation
- [ ] **Binary search** variations
- [ ] **Graph algorithms** basics
- [ ] **Unit tests** for all algorithms

---

## 🤝 Contributing

Contributions are welcome! Feel free to:

1. 🍴 Fork the repository
2. 🌿 Create a feature branch (`git checkout -b feature/new-algorithm`)
3. 💾 Commit your changes (`git commit -m 'Add new sorting algorithm'`)
4. 📤 Push to the branch (`git push origin feature/new-algorithm`)
5. 🔄 Open a Pull Request

---

## 📧 Contact & Support

- **Author:** Yusuf
- **GitHub:** [@Yusuftmle](https://github.com/Yusuftmle)
- **Issues:** [Report bugs or request features](https://github.com/Yusuftmle/MyMiniTrainAlgorithmProject/issues)

---

<div align="center">

### ⭐ Star this repo if it helped you learn something new!

**Happy Coding!** 💻✨

</div>
