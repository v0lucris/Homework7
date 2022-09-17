// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.WriteLine("Введите количество строк треугольника Паскаля:");
int n = int.Parse(Console.ReadLine());

int[,] FillArrayrTiangle(int n)
{
    int row = n;
    int colums = row + 2;
    int[,] triangle = new int[row,colums];
    triangle[0,0] = 0;
    triangle[0,1] = 1;
    triangle[0,2] = 0;
for (int i = 1; i < triangle.GetLength(0); i++)
{
    for (int j = 1; j < triangle.GetLength(1); j++)
    {
       triangle[i,j]= triangle[i-1,j-1]+triangle[i-1,j];
    }
}
return triangle;
}

void PrintArrayrTiangle(int[,] triangle )
{
for (int i = 0; i < triangle.GetLength(0); i++)
{
    for (int  k = triangle.GetLength(0);k>i; k--)
    {
        Console.Write("  ");
    }
    for (int j = 0; j < triangle.GetLength(1); j++)
    {
        Console.Write("{0,5}", triangle[i,j]);
    }
    Console.WriteLine();
}
}

int[,] triangle = FillArrayrTiangle(n);
Console.WriteLine();
PrintArrayrTiangle(triangle );
