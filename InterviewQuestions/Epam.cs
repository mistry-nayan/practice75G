public class Epam : InterviewQuestion 
{
    //Given array of integers find the 3 largest int
    public int ThirdLargestInteger(int[] nums)
    {
        //int thirdLargestNum = 0;
        // PriorityQueue<int, int> priorityQueue = new ();
        // HashSet<int> ints = new ();
        // for(int i = 0; i < nums.Length; i++)
        // {
        //     int num = nums[i];
        //     if(!ints.Contains(num)){
        //         ints.Add(num);
        //         priorityQueue.Enqueue(nums[i], nums[i]);
        //     }

        //     if(priorityQueue.Count > 3){
        //         _ = priorityQueue.Dequeue();
        //     }
        // }

        // thirdLargestNum = priorityQueue.Peek();

        int max1 = 0, max2 = 0, max3 = 0;
        foreach (int num in nums)
        {
            if(max1 < num)
            {
                max3 = max2;
                max2 = max1;
                max1 = num;
            }
            else if (max2 < num && num < max1)
            {
                max3 = max2;
                max2 = num;
            }
            else if(max3 < num && num < max2)
            {
                max3 = num;
            }
        }

        return max3;
    }

}