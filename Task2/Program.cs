// В двухмерном массиве целых чисел удалить строку и столбец на пересечении которых расположен наименьший элемент


void Fillarray(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1,10);
        }
    }
}

void Printarray(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.Write("]");
    Console.WriteLine(" ");
    }
}

Console.WriteLine("m");
int m = int.Parse(Console.ReadLine()); 
Console.WriteLine("n");
int n = int.Parse(Console.ReadLine());
int[,] mtrx = new int [m,n];


Fillarray(mtrx);
Console.Write(" ");
Printarray( mtrx);
Console.Write(" ");

int x = 0;
int y = 0;
int min = mtrx[0, 0];

for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if(mtrx[i,j]< min ) 
            {
                min = mtrx[i,j];
                x = i;
                y = j;
                
            } 
                       
        }
    }
Console.WriteLine($"Наименьший элемент : {min} ");

Console.WriteLine($"Your new array ");
for (int i = 0; i < mtrx.GetLength(0); i++)
   {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            {
            if ((i == x) || (j == y))
            
                continue;
            else
                Console.Write(mtrx[i, j] + " ");
            }
        }  
        Console.WriteLine();          
    }   
   





