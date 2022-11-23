using System;
using BenchmarkDotNet.Attributes;
using SortingAlgorithms;

namespace SortingAlgorithmsBenchmark
{
	[MemoryDiagnoser]
	[DisassemblyDiagnoser]
	public class AlgorithmsBenchmark
	{
		private int[] randomArray;

		[IterationSetup]
		public void SetUp()
		{
			var arrayLength = 20000;
			var random = new Random();
			randomArray = new int[arrayLength];
			for (int i = 0; i < randomArray.Length; i++)
			{
				randomArray[i] = random.Next(0, arrayLength);
			}
		}

		[Benchmark]
		public void BubbleSortBenchmark()
		{
			Algorithms.BubbleSort(randomArray);
		}

		[Benchmark]
		public void MergeSortBenchmark()
		{
			Algorithms.MergeSort(randomArray);
		}

		[Benchmark]
		public void HoareSort()
		{
			Algorithms.HoareSort(randomArray);
		}

		[Benchmark]
		public void DefaultSort()
		{
			Array.Sort(randomArray);
		}
	}
}