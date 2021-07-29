using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
	public static class LoopTypes
	{
		internal static int HighestForEachLoop(List<int> nums)
		{
			int highest = nums[0];
			foreach (int number in nums)
			{
				if (number > highest)
				{
					highest = number;
				}

			}
			return highest;
		}
		internal static int HighestForLoop(List<int> nums)
		{
			int highest = nums[0];
			for (int i = 0; i <nums.Count; i++)
			{
				if (nums[i] > highest)
				{
					highest =nums[i];
				}

			}
			return highest;
		}
		internal static int HighestWhileLoop(List<int> nums)
		{
			int highest = nums[0];
			int i = 0;
			while ( i < nums.Count)
			{ 
				
				if (nums[i] > highest)
				{
					highest = nums[i];
				}
				i++;

			}
			return highest;

		}
		internal static int HighestDoWhileLoop(List<int> nums)
		{
			int highest = nums[0];
			int count = 0;
			do
			{
				if (nums[count] > highest)
				{
					highest = nums[count];
				}
				count++;

			}
			while (count < nums.Count());
			return highest;
		}
	}
}
