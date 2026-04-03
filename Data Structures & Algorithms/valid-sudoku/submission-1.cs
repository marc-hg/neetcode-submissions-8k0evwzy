public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        var boardSize = board.Length;
        var boxSize = (int)Math.Sqrt(boardSize);
        // Fill hashsets
        var rowsChecks = new HashSet<char>[boardSize];
        var colsChecks = new HashSet<char>[boardSize];
        var boxesChecks = new HashSet<char>[boardSize];
        for (var i = 0; i < boardSize; i++) // O(n)
        {
            rowsChecks[i] = [];
            colsChecks[i] = [];
            boxesChecks[i] = [];
        }

        for (var i = 0; i < boardSize; i++)
        {
            for (var j = 0; j < boardSize; j++) // O(n*n)
            {
                var cell = board[i][j];
                if (cell == '.') continue;

                // Check rows
                var rowsCheck = rowsChecks[i];
                if (!rowsCheck.Add(cell)) return false;

                // Check cols
                var colsCheck = colsChecks[j];
                if (!colsCheck.Add(cell)) return false;

                // Check boxes
                var index =  boxSize*(i / boxSize) + (j / boxSize);
                var boxesCheck = boxesChecks[index];
                if (!boxesCheck.Add(cell)) return false;
            }
        }

        return true;
    }


}
