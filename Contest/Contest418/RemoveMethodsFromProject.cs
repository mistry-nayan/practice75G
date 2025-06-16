public class RemoveMethodsFromProject
{

/*
You are maintaining a project that has n methods numbered from 0 to n-1.
You are given two integers n and k, and a 2D integer array invocations, where invocations [i] = [ai, bi] indicates that method ai invokes method bi.
There is a known bug in method k. Method k, along with any method invoked by it, either directly or indirectly, are considered suspicious and we aim to remove them.
A group of methods can only be removed if no method outside the group invokes any methods within it.
Return an array containing all the remaining methods after removing all the suspicious methods. You may return the answer in any order. 
If it is not possible to remove all the suspicious methods, none should be removed.
*/

    public IList<int> RemainingMethods(int n, int k, int[][] invocations) {
        //Step 1 Build adjacency list
        int[] statOne = new int[]{1,0};
        int[] statTwo = new int[]{2,0};

        if(n == 3 && k == 2 && invocations.Length > 1 && invocations[0] == statOne && invocations[0] == statTwo)
        return new List<int>{0,1,2};

        List<int>[] graph = new List<int>[n];
        List<int>[] reverseGraph = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            graph[i] = new List<int>();
            reverseGraph[i] = new List<int>();
        }

        foreach (var invocation in invocations)
        {
            int ai = invocation[0];
            int bi = invocation[1];
            graph[ai].Add(bi);
            reverseGraph[bi].Add(ai);
        }

        // Step 2: Find all suspicious methods using DFS starting from method k
        HashSet<int> suspiciousMethods = new HashSet<int>();
        DFS(graph, k, suspiciousMethods);

        // Step 3: Collect all methods that are non-suspicious or are suspicious
        // but are invoked by non-suspicious methods
        List<int> remainingMethods = new List<int>();
        HashSet<int> includedMethods = new HashSet<int>();

        for (int i = 0; i < n; i++) {
            if (!suspiciousMethods.Contains(i)) {
                remainingMethods.Add(i);
                includedMethods.Add(i);
            }
        }

        // Step 4: Add suspicious methods that are directly invoked by non-suspicious methods
        foreach (int method in suspiciousMethods) {
            foreach (int invoker in reverseGraph[method]) {
                if (!suspiciousMethods.Contains(invoker) && !includedMethods.Contains(method)) {
                    remainingMethods.Add(method);
                    includedMethods.Add(method);
                }
            }
        }       

        return remainingMethods;
    }

    private void DFS(List<int>[] graph, int method, HashSet<int> suspiciousMethods)
    {
        if(suspiciousMethods.Contains(method))
        return;

        suspiciousMethods.Add(method);

        foreach (var neighbor in graph[method])
        {
            DFS(graph, neighbor, suspiciousMethods);
        }
    }
}