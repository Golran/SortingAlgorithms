using System;
using BenchmarkDotNet.Running;
using SortingAlgorithms;

namespace SortingAlgorithmsBenchmark
{
	internal class Program
	{
		public static Random MyRandom = new Random();

		public static void Main(string[] args)
		{
			BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
			//Test
			// var randomArrSource = GenerateRandomArray(10);
			// var arr1 = new int[10];
			// randomArrSource.CopyTo(arr1, 0);
			// var arr2 = new int[10];
			// randomArrSource.CopyTo(arr2, 0);
			// var arr3 = new int[10];
			// randomArrSource.CopyTo(arr3, 0);
			// Algorithms.BubbleSort(arr1);
			// Algorithms.MergeSort(arr2);
			// Algorithms.HoareSort(arr3);
			// Console.WriteLine(string.Join(" " , arr1));
			// Console.WriteLine(string.Join(" " , arr2));
			// Console.WriteLine(string.Join(" " , arr3));
		}

		private static int[] GenerateRandomArray(int length)
		{
			var result = new int[length];
			for (int i = 0; i < length; i++)
			{
				result[i] = MyRandom.Next(0, length);
			}

			return result;
		}
	}
}