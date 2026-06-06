using System.Runtime.CompilerServices;

public class BinarySearch
{
    public int Search(int[] nums, int target) { 
     
        int low = 0;
        int high = nums.Length - 1;

        while(low <= high)
        {
            int mid = low + (high - low) /2;
            if(nums[mid] == target)
            {
                Console.WriteLine(mid);
                return mid;
            }
            else if(nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return -1;
    }


    public int binarySearch(int left, int right, int[] nums, int target) {

        if(left > right)
            return -1;    
        int middle = left + (right - left) / 2;    //aggregate to be selected properly    
        if(nums[middle] == target){ //check the middle elem first
            return middle;
        }
        else if(nums[middle] > target){
        return binarySearch(left, middle - 1, nums, target);    //if middle is greater then target, exclude middle one & further elements in next iteration.
        }
        else
        {
            return binarySearch(middle + 1, right, nums, target);
            //if middle elem is smaller than target, then update the low value with the elem after middle one.
        }
    }
}