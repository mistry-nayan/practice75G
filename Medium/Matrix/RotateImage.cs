public class RotateImage
{
    //Approach 1
    public void Rotate90(int[][] matrix) {
        if(matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
        {
            return;
        }  
        int rows = matrix.Length, cols = matrix[0].Length; 
        for (int I = 0; I < rows / 2; I++) //runs the layers, hence we take row /2;
        {
            //cols since n * n matrix, rows == cols
            for (int J = I; J < rows - I - 1; J++) //access the components for that layer
            {
                //top element
                int temp = matrix[I][J];

                //move left to top
                //total cols - current col - 1(since we are taking length)
                matrix[I][J] = matrix[rows - J - 1][I];

                //move bottom to left
                matrix[rows - J - 1][I] = matrix[rows - I - 1][rows - J - 1];

                //move right to bottom
                matrix[rows - I - 1][rows - J - 1] = matrix[J][rows - I - 1];

                // Assign temp to right
                matrix[J][rows - I - 1] = temp;
            }
        }
        var res = "";
    }

    //Approach 2
    /*
    step 1 - Transpose the matrix
    step 2 rotate the rows
    */
    public void Rotate90V2(int[][] matrix)
    {
        int n = matrix.Length;

        for (int I = 0; I < n; I++)
        {
            for (int II = I + 1; II < n; II++)
            {
                int temp = matrix[I][II];
                matrix[I][II] = matrix[II][I];
                matrix[II][I] = temp;
            }            
        }

        for (int I = 0; I < n; I++)
        {
            Array.Reverse(matrix[I]);
        }
        var res = "";
    }

    public void Rotate180(int[][] matrix)
    {
        int n = matrix.Length;

        for (int I = 0; I < n / 2; I++)
        {
            for (int II = 0; II < n; II++)
            {
                int temp = matrix[I][II];
                matrix[I][II] = matrix[n - 1 - I][n - 1 - II];
                matrix[n - 1 - I][n - 1 - II] = temp;
            }
        }

        if(n % 2 != 0)
        {
            int mid = n / 2;
            for (int I = 0; I < n / 2; I++)
            {
                int temp = matrix[mid][I];
                matrix[mid][I] = matrix[mid][n - 1 - I];
                matrix[mid][n - 1 - I] = temp; 
            }
        }
        
        var res = "";
    }
}