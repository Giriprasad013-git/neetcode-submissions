public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] rowBP = new bool[9,10]; 
        bool[,] colBP = new bool[9,10]; 
        bool[,] boxBP = new bool[9,10]; 
        for(int r = 0; r<board.Length;r++){
            for(int c = 0; c<board.Length;c++){
                char val = board[r][c];
                if(val == '.') continue;
                int valInt = val - '0';
                int boxId = (r/3)*3+(c/3);

                if(rowBP[r,valInt] || colBP[c,valInt] || boxBP[boxId,valInt]){
                    return false;
                }

                rowBP[r,valInt] = true;
                colBP[c,valInt] = true;
                boxBP[boxId,valInt] = true;
            }
        }
        return true;
    }
}
