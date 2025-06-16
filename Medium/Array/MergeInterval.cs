using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class MergeINterval
{
    public int[][] Merge1(int[][] intervals) {
        if(intervals == null || intervals.Length == 0){
            return new int[][]{};
        }

        List<int[]> ints = new List<int[]>();
        int[] prevInterval = new int[]{};
        for (int I = 0; I < intervals.Length; I++)
        {
            if(I == 0)
            {
                prevInterval = intervals[I];
                ints.Add(prevInterval);
                continue;
            }

            // var start = prevInterval[0];
            // var end = prevInterval[1];

            var newInterval = intervals[I];

            if(newInterval[0] <= prevInterval[0]) 
            {
                ints.RemoveAt(ints.Count - 1);
                prevInterval[0] = newInterval[0];
                ints.Add(prevInterval);
            }     

            if(newInterval[1] <= prevInterval[0])
            {
                ints.RemoveAt(ints.Count - 1);
                prevInterval[0] = newInterval[1];
                ints.Add(prevInterval);
            }

            // if(newInterval[1] <= end)
            // {
            //     ints.RemoveAt(ints.Count - 1);
            //     prevInterval[1] = newInterval[1];
            //     ints.Add(prevInterval);
            //     //continue;
            // }

            if(newInterval[0] <= prevInterval[1])
            {
                ints.RemoveAt(ints.Count - 1);
                if(newInterval[1] > prevInterval[1]){
                    prevInterval[1] = newInterval[1];
                }    
                ints.Add(prevInterval);
                continue;
            }            


            if(newInterval[0] > prevInterval[1])
            {
                prevInterval = newInterval; 
                ints.Add(prevInterval);               
            }
        }

        return ints.ToArray();
    }

    //return an array of the non-overlapping intervals that cover all the intervals in the input.
    //sort based on start time
    //there are 2 possible cases:
    //Case 1: If the current interval can be merged with the last inserted interval of the answer list:
    //If loop
    //Case 2:  If the current interval cannot be merged with the last inserted interval of the answer list:
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (x,y) => x[0] - y[0]); //sort based on start time
        int i = 0, j = 1;
        while (j < intervals.Length) {
            var first = intervals[i];
            var second = intervals[j];
            if (first[1] >= second[0]) {
                first[1] = Math.Max(first[1], second[1]);
            }
            else {
                intervals[i+1] = intervals[j];
                i++;
            }
            j++;
        }
        return intervals[..(i+1)];//return array from 0 to i, doesn't include i + 1 index
    }

    public int[][] Merge3(int[][] intervals) {
        Array.Sort(intervals, (x,y) => x[0] - y[0]);

        int i = 0, j = 1;
        while(j < intervals.Length)
        {
            var first = intervals[i];
            var second = intervals[j];
            if(first[1] >= second[0]){
                first[1] = Math.Max(first[1], second[1]);
            }
            else{
                intervals[i + 1] = intervals[j];
                i++;
            }
            j++;
        }
        return intervals[..(i+1)];
    }
}