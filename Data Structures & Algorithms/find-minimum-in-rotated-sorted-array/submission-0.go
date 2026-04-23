func findMin(nums []int) int {
    low := 0
    high := len(nums) - 1

    // If the array is not rotated (or only one element)
    if nums[low] <= nums[high] {
        return nums[low]
    }

    for low <= high {
        mid := low + (high-low)/2

        // If mid element is greater than its next element, 
        // then mid+1 is the smallest
        if mid < len(nums)-1 && nums[mid] > nums[mid+1] {
            return nums[mid+1]
        }

        // If mid element is smaller than its previous element, 
        // then mid is the smallest
        if mid > 0 && nums[mid] < nums[mid-1] {
            return nums[mid]
        }

        // Decide whether to go left or right
        if nums[mid] > nums[high] {
            // Minimum must be in the right half
            low = mid + 1
        } else {
            // Minimum must be in the left half
            high = mid - 1
        }
    }

    return nums[low]
}