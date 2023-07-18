namespace CtCI;
public static class Rotate_matrix{
    public static int[,] Method1(int[,] matrix) {
        // int tmp = matrix[0,0];
        int row = 0; 
        // int j = 0;
        int prev;
        int _this;        
        int length = matrix.GetLength(0);
        while (row < length/2) {
            int col = 0;
            while (row + col < length - (row + 1)) {
                prev = matrix[row,row + col];
                System.Console.WriteLine($"row = {0}, col = {1}, length = {2}", row, col, length);
                _this = matrix[row + col, (length - 1) - row];
                matrix[row + col, (length - 1) - row] = prev;
                prev = _this;


                _this = matrix[(length - 1) - row,(length - 1) - (row + col)];
                matrix[(length - 1) - row,(length - 1) - (row + col)] = prev;
                prev = _this;
                
                _this = matrix[(length - 1) - (col + row),row];
                matrix[(length - 1) - (col + row),row] = prev;
                prev = _this;
                
                matrix[row,row + col] = prev;
                
                col++;
            }

            // int _this;
            // for (int j = 1; j <= 4; j++) {
            //     _this = matrix[i,j % 4];
            //      matrix[i,j % 4] = prev;
            //      prev = _this;
            // }   
            row++;
        }

        foreach (int j in matrix)
            {
                System.Console.Write(j + " ");
            }
            System.Console.WriteLine("\n");
        return matrix;
    }
}