public class FloodFil {

    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if (image[sr][sc] == color)
            return image;
            
        Traverse(image, sr, sc, image[sr][sc], color);
        return image;
    }

    public void Traverse(int[][] image, int i, int j, int value, int color){
        // first check the bounds of image,
        // then check if the current pixel is of the same color as the original color. If not, return.
        if (i >= image.Length || i < 0 || j >= image[0].Length || j < 0 || 
            image[i][j] != value)
            return;
        
        image[i][j] = color;

        Traverse(image, i + 1, j, value, color); //go to right
        Traverse(image, i - 1, j, value, color); //go to left
        Traverse(image, i, j + 1, value, color); //go up
        Traverse(image, i, j - 1, value, color); //go down
    }
//     private int m; 
//     private int n;
//     private int or_color;
//     bool[][] visited;

//     public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
//         m = image.Length;
//         n = image[0].Length;

//         or_color = image[sr][sc];         
//         visited = new bool[m][];

//         for(int i = 0; i < m; i++){
//             visited[i] = new bool[n];
//             for(int j = 0; j < n; j++){
//                 visited[i][j] = false;
//             }
//         }

//         Fill(image, sr, sc, color);
//         return image;
//     }

//     private void Fill(int[][] image, int i, int j, int color){
//         //conditions where we want to return.
//         if (i < 0 || i >= m || j < 0 || j >= n || visited[i][j] || image[i][j] != or_color) {
//             return;
//         }

//         image[i][j] = color;
//         visited[i][j] = true;

//         Fill(image, i, j + 1, color);
//         Fill(image, i, j - 1, color);
//         Fill(image, i + 1, j, color);
//         Fill(image, i - 1, j, color);
//     }

}