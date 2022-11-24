using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
	public static class Algorithms
	{
		#region BubbleSort

		public static void BubbleSort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			for (int j = 0; j < array.Length - 1; j++)
				if (array[j] > array[j + 1])
					(array[j + 1], array[j]) = (array[j], array[j + 1]);
		}

		#endregion

		#region MergeSort

		public static void MergeSort(int[] array)
		{
			var temporaryArray = new int[array.Length];
			MergeSort(array, 0, array.Length - 1, temporaryArray);
		}

		private static void MergeSort(int[] array, int start, int end, int[] temporaryArray)
		{
			if (start == end) return;
			var middle = (start + end) / 2;
			MergeSort(array, start, middle, temporaryArray);
			MergeSort(array, middle + 1, end, temporaryArray);
			Merge(array, start, middle, end, temporaryArray);
		}

		private static void Merge(int[] array, int start, int middle, int end, int[] temporaryArray)
		{
			var leftPtr = start;
			var rightPtr = middle + 1;
			var length = end - start + 1;
			for (int i = 0; i < length; i++)
			{
				if (rightPtr > end || (leftPtr <= middle && array[leftPtr] < array[rightPtr]))
				{
					temporaryArray[i] = array[leftPtr];
					leftPtr++;
				}
				else
				{
					temporaryArray[i] = array[rightPtr];
					rightPtr++;
				}
			}
			for (int i = 0; i < length; i++)
				array[i + start] = temporaryArray[i];
		}

		#endregion

		#region HoareSort

		public static void HoareSort(int[] array)
		{
			HoareSort(array, 0, array.Length - 1);
		}

		private static void HoareSort(int[] array, int start, int end)
		{
			if (end == start) return;
			var pivot = array[end];
			var storeIndex = start;
			for (int i = start; i <= end - 1; i++)
				if (array[i] <= pivot)
				{
					(array[i], array[storeIndex]) = (array[storeIndex], array[i]);
					storeIndex++;
				}

			(array[storeIndex], array[end]) = (array[end], array[storeIndex]);
			if (storeIndex > start) HoareSort(array, start, storeIndex - 1);
			if (storeIndex < end) HoareSort(array, storeIndex + 1, end);
		}

		#endregion
	}
}