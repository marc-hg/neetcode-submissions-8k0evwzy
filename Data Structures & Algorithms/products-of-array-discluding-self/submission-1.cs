public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        var productArr = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            var leftProduct = LeftProduct(nums, i);
            var rightProduct = RightProduct(nums, i);
            productArr[i] = leftProduct * rightProduct; 
        }

        return productArr;
    }


    private static int LeftProduct(int[] ints, int i1)
    {
        var totalProduct = 1;
        for (var i = 0; i < i1; i++)
        {
            totalProduct *= ints[i];
        }

        return totalProduct;
    }

        private static int RightProduct(int[] ints, int i1)
    {
        var totalProduct = 1;
        for (var i = i1+1; i < ints.Length; i++)
        {
            totalProduct *= ints[i];
        }

        return totalProduct;
    }
    
}
