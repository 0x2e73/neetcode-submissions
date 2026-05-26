public class Solution {
 public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];
        
        //nul ref attention
        for (int k = 0; k < 9; k++)
        {
            rows[k] = [];
            cols[k] = [];
            boxes[k] = [];
        }

        //parcours les lignes
        for(int i = 0; i < 9; i++)
        {
            //parcours les col
            for(int j = 0; j < 9; j++)
            {
                if(board[i][j] != '.')
                {
                    var valueChar = board[i][j];
                    if(
                        rows[i].Contains(valueChar) || 
                        cols[j].Contains(valueChar) || 
                        boxes[(i / 3) * 3 + (j/ 3)].Contains(valueChar)
                        )
                        return false;

                    rows[i].Add(valueChar);
                    cols[j].Add(valueChar);
                    boxes[(i / 3) * 3 + (j / 3)].Add(valueChar);
                }
            }
        }
        return true;
    }
}
