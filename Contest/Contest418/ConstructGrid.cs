public class ConstructGrid
{
    
    public int[][] ConstructGridLayout(int n, int[][] edges) {
        
        //step 1: Build adjacency list
        List<int>[] graph = new List<int>[n];

        for (int i = 0; i < n; i++)
        {
            graph[i] = new List<int>();
        }

        //An undirected graph is a graph where the edges between nodes are not oriented. 
        //This means that if there is an edge between nodes A and B, 
        //it is considered the same as an edge between nodes B and A. 
        //In other words, the direction of the edge does not matter.
        foreach (var edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            graph[u].Add(v);
            graph[v].Add(u);
        }

        // Step 2: Determine the grid size (approximately square)
        int size = (int)Math.Ceiling(Math.Sqrt(n));
        int[][] grid = new int[size][];
        for (int i = 0; i < size; i++) {
            grid[i] = new int[size];
        }

        //step 3: fill the grid, BFS 
        HashSet<int> visited = new HashSet<int>();
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(0); // Start from node 0
        visited.Add(0);

        int x = 0, y = 0;
        while(queue.Count > 0)
        {
            int current = queue.Dequeue();
            grid[x][y] = current;

            y++;
            if (y >= size) {
                y = 0;
                x++;
            }

            // Step 4: Add adjacent nodes to the queue
            foreach (int neighbor in graph[current]) {
                if (!visited.Contains(neighbor)) {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }

        return grid;
    }
}