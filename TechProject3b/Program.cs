// Kevin Fee
// 09/24/2020
using System;

namespace TechProject3b
{
	class Program
	{
		static void Main(string[] args)
		{
			// A manually populated array
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
			// Accessing array elements using for loop
			for (int i = 0; i < numbers.Length; i++)
				Console.WriteLine("Element Value " + numbers[i]);
			Console.WriteLine("");
			Console.ReadKey(true);
		}
	}
}
