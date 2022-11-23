using System;
using BenchmarkDotNet.Attributes;
using SortingAlgorithms;

namespace SortingAlgorithmsBenchmark
{
	[MemoryDiagnoser]
	[DisassemblyDiagnoser]
	public class AlgorithmsPowBenchmark
	{
		private const double number = 0.5e-10;
		private const int pow = 107;
		private const int iterationCount = 100000;

		[Benchmark]
		public void PowCycle()
		{
			for (int i = 0; i < iterationCount; i++)
			{
				Algorithms.Pow(number, pow);
			}
		}

		[Benchmark]
		public void PowRecursion()
		{
			for (int i = 0; i < iterationCount; i++)
			{
				Algorithms.PowRecursion(number, pow);
			}
		}

		[Benchmark]
		public void PowDefault()
		{
			for (int i = 0; i < iterationCount; i++)
			{
				Math.Pow(number, pow);
			}
		}
	}
}