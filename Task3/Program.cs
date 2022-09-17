// Сформировать трехмерный массив не повторяющимися двузначными числами. Показать его построчно на экран выводя индексы соответствующего элемента
void FillArray(int[, ,] mtrx, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            for (int k = 0; k <  mtrx.GetLength(2); k++)
            {
                while (mtrx[i,j,k] == 0)
                {
                    int number = rand.Next(min,max+1);
                    if (IsNumberInArray(mtrx, number) == false)
                    {
                        mtrx[i,j,k] = number;
                    }
                }
            }
        }
    }
}
bool IsNumberInArray(int[,,] mtrx, int number)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            for (int k = 0; k < mtrx.GetLength(2); k++)
            {
                if (mtrx[i, j, k] == number) return true;
            }
        }
    }

    return false;
}
void PrintArray(int[,,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            for (int k = 0; k < mtrx.GetLength(2); k++)
            {
               Console.Write($"{mtrx[i, j, k]} "); 
               Console.Write("({0},{1},{2})\t", i, j, k);
            }
            
        }
        Console.Write("]");
    Console.WriteLine(" ");
    }
}


int arraySizeX = 2;
int arraySizeY = 2;
int arraySizeZ = 2;
int min = 10;
int max = 99;
int[,,] testArray = new int[arraySizeX, arraySizeY, arraySizeZ];

Console.Clear();
FillArray(testArray, min, max);
PrintArray(testArray);