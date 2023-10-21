public class IsAnagramSolution
{
  public static int[] ProductExceptSelf(int[] nums)
  {
    var pre = new int[nums.Length];
    var post = new int[nums.Length];
    var result = new int[nums.Length];

    var old = 1;
    for (var i = 0; i < nums.Length; i++)
    {
      pre[i] = old * nums[i];
      old = pre[i];
    }

    old = 1;
    for (var i = nums.Length - 1; i >= 0; i--)
    {
      post[i] = old * nums[i];
      old = post[i];
    }

    for (var i = 0; i < nums.Length; i++)
    {
      result[i] = (i < 0 ? 1 : pre[i]) * i >= nums.Length ? 1 : post[i];
    }

    return result;
  }

  public static void Main(string[] args)
  {
    ProductExceptSelf(new int[] { 1, 2, 3, 4 }); //Expected [24,12,8,6]
    Console.WriteLine("End of program.");
  }
}