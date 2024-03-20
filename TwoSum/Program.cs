using System;
using System.Collections.Generic;
namespace MyNameSpace{
	public class Solution{
		public void TwoSum(){
			int target = int.Parse(Console.ReadLine());
			int n = int.Parse(Console.ReadLine());
			int[] nums = new int[n];
			string[] input = Console.ReadLine().Split(' ');
			for(int i = 0; i < n;i ++){
				nums[i] = int.Parse(input[i]);
			}
			Dictionary <int, int> map = new Dictionary<int, int>();
			for(int i =0; i< n; i++){
				int complement = target - nums[i];
				if(map.ContainsKey(complement)){
					Console.WriteLine($"{map[complement]}, {i}");
					break;
				}
				if(!map.ContainsKey(nums[i])){
					map.Add(nums[i], i);
				}
			}

		}
	}
	
	public class Program{
		public static void Main(string[]args){
			Solution solution = new Solution();
			solution.TwoSum();
		}
	}
}
