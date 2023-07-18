namespace CtCI;

public static class Zero_matrix {
    public static int[,] Method1(int[,] matrix) {
        bool[] rows = new bool[matrix.GetLength(0)];
        bool[] cols = new bool[matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1) ; j++) {
                if (matrix[i,j] == 0) {
                    cols[j] = true;
                    rows[i] = true;
                }
            }
        }

        for (int i = 0; i < rows.Length;i++) {
            if (rows[i]) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    matrix[i,j] = 0;
                }
            }
        }
        for (int i = 0; i < cols.Length;i++) {
            if (cols[i]) {
                for (int j = 0; j < matrix.GetLength(0); j++) {
                    matrix[j,i] = 0;
                }
            }
        }
        foreach (int j in matrix)
            {
                System.Console.Write(j + " ");
            }
        System.Console.WriteLine("\n");
        return matrix;
    }
}