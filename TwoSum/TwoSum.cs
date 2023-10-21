public class TwoSumSolution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        int[] results = { 0, 0 };
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    results[0] = i;
                    results[1] = j;
                }
            }
        }
        return results;
    }

    public static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum(nums, target);
        Console.Write($"the two indices of numbers that amout to the desired target are is {result[0]} and {result[1]}");

    }
}