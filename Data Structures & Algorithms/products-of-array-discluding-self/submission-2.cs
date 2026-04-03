public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        var leftArray = ComputeLeft(nums);
        var rightArray = ComputeRight(nums);
        var dotArray = DotProduct(leftArray, rightArray);
        return dotArray;
    }

    private static int[] DotProduct(int[] leftArray, int[] rightArray)
    {
        if (leftArray.Length != rightArray.Length)
        {
            throw new ArgumentException("leftArray and rightArray lengths do not match");
        }

        var resultArray = new int[leftArray.Length];
        for (var i = 0; i < leftArray.Length; i++)
        {
            resultArray[i] = leftArray[i] * rightArray[i];
        }

        return resultArray;

    }

    private static int[] ComputeRight(int[] nums)
    {
        var rightArr = new int[nums.Length];
        rightArr[nums.Length - 1] = 1;

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            rightArr[i] = rightArr[i + 1] * nums[i + 1];
        }

        return rightArr;

    }

    private static int[] ComputeLeft(int[] nums)
    {
        var leftArr = new int[nums.Length];
        leftArr[0] = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            leftArr[i] = nums[i-1] * leftArr[i - 1];
        }

        return leftArr;
    }

    
}
