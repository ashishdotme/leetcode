using NUnit.Framework;

namespace Problems.Easy.Arrays;

public class TwoSum
{

  public int[] TwoSumSolution( int[] nums, int target )
  {
    var dict = new Dictionary<int, int>();
    for ( int i = 0; i < nums.Length; i++ )
    {
      int val = 0;
      if ( dict.TryGetValue( target - nums[i], out val ) && val != i)
      {
        Console.WriteLine( $"{i}, {val}" );
        return [val, i];
      }
      dict.TryAdd(nums[i], i);
    }
    return [];
  }

  [TestCase( new int[] { 3, 2, 4 }, 6, ExpectedResult = new int[] { 1, 2 } )]
  [TestCase( new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 } )]
  public int[] TwoSumTest( int[] nums, int target ) => TwoSumSolution( nums, target );
}