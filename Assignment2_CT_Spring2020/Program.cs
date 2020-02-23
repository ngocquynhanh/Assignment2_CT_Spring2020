using System;

namespace Assignment2_CT_Spring2020
{

	class Program
	{
		public static int max_value = 1, temp_value = 1;
		static void Main(string[] args)
		{
			//Console.WriteLine("Question 1");
			//int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 }; int target = 9;
			//int[] r = TargetRange(l1, target);
			//// Write your code to print range r here

			//Console.WriteLine("Question 2");
			//string s = "University of South Florida"; string rs = StringReverse(s); Console.WriteLine(rs);

			//Console.WriteLine("Question 3");
			//int[] l2 = new int[] { 2, 2, 3, 5, 6 }; int sum = MinimumSum(l2); Console.WriteLine(sum);

			//Console.WriteLine("Question 4"); string s2 = "Dell";
			//string sortedString = FreqSort(s2); Console.WriteLine(sortedString);

			//Console.WriteLine("Question 5-Part 1");
			//int[] nums1 = { 1, 2, 2, 1 };
			//int[] nums2 = { 2, 2 };
			//int[] intersect1 = Intersect1(nums1, nums2); Console.WriteLine("Part 1- Intersection of two arrays is: "); DisplayArray(intersect1);
			//Console.WriteLine("\n"); Console.WriteLine("Question 5-Part 2"); int[] intersect2 = Intersect2(nums1, nums2);
			//Console.WriteLine("Part 2- Intersection of two arrays is: "); DisplayArray(intersect2);
			//Console.WriteLine("\n");

			//Console.WriteLine("Question 6");
			//char[] arr = new char[] { 'a', 'g', 'h', 'a' }; int k = 3; Console.WriteLine(ContainsDuplicate(arr, k));

			Console.WriteLine("Question 7"); int rodLength = 15;
			int priceProduct = GoldRod(rodLength); Console.WriteLine(priceProduct);

			//Console.WriteLine("Question 8");
			//string[] userDict = new string[] { "rocky", "usf", "hello", "apple" }; string keyword = "hhllo";

			//Console.WriteLine(DictSearch(userDict, keyword));

			//Console.WriteLine("Question 8"); SolvePuzzle();

		}
	
		static void findCombo(int[] arr, int index,
										int num, int reducedNum)
		{
			if (reducedNum < 0)
				return;

			if (reducedNum == 0)
			{
				for (int i = 0; i < index; i++)
				{
					temp_value = temp_value * arr[i];
				}
				if (temp_value > max_value)
				{
					max_value = temp_value;
				}
				temp_value = 1;
				
				return;
			}

			int prev = (index == 0) ?
								1 : arr[index - 1];

			for (int k = prev; k <= num; k++)
			{
				arr[index] = k;


				findCombo(arr, index + 1, num,
										reducedNum - k);
			}
		}

		static int GoldRod(int n)
		{ 
			int[] arr = new int[n];


			findCombo(arr, 0, n, n);
			return max_value;
		}
	}
}
