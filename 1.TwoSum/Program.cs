using System;
using System.Collections.Generic;
namespace MyNameSpace{
	public class Solution{
		private int target;
		private List<int>  nums;
		public Solution(int target, List<int> nums){
			this.target = target;
			this.nums = nums;
		}
		public void TwoSum(){
			Dictionary<int, int> map= new Dictionary<int, int>();
			for(int i = 0; i < nums.Count; i++){
			int complement = target - nums[i];
				if(map.ContainsKey(complement)){
					Console.WriteLine($"{map[complement]} {i}");
				}
				if(!map.ContainsKey(nums[i])){
					map.Add(nums[i], i);
				}
			}
			
		}
	}
	public class Program{
		static void Main(string[] args){
			int target = int.Parse(Console.ReadLine());
			List<int> nums = new List<int>();
			string[] input = Console.ReadLine().Split(' ');
			for(int i = 0; i < nums.Count; i++){
				nums[i] = int.Parse(input[i]);
			}
			Solution solution = new Solution(target, nums);
		}
	}
}
