/*Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/



int[,] spiralMatrix = new int[4, 4];            
int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = 4;
int l =  spiralMatrix.Length;
    for(int i = 0; i < l; i++) {
        spiralMatrix[row, col] = i + 1;
            if(--gran == 0) {
                gran = 4 * (dirChanges % 2) + 4 * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                int temp = dy;
                dy = -dx;
                dx = temp;
                dirChanges++;
            }
                col += dx;
                row += dy;
    }                           
        for(int k = 0; k < l; k++)
        Console.Write("{0}{1,3}", k % 4 == 0 ? "\n" : "", spiralMatrix[k / 4, k % 4]);
        Console.ReadLine();
    