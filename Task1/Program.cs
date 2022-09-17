// Найти произведение 2-х матриц
void Fillmass1(int[,]mass1)
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            mass1[i,j] = new Random().Next(1,10);
        }
    }
}
void Printmass1(int[,]mass1)
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            Console.Write($"{mass1[i, j]} ");
        }
        Console.Write("]");
    Console.WriteLine(" ");
    }
}

void Fillmass2(int[,]mass2)
{
    for (int m = 0; m < mass2.GetLength(0); m++)
    {
        for (int n = 0; n < mass2.GetLength(1); n++)
        {
            mass2[m,n] = new Random().Next(1,10);
        }
    }
}
void Printmass2(int[,]mass2)
{
    for (int m = 0; m < mass2.GetLength(0); m++)
    {
        Console.Write("[");
        for (int n = 0; n < mass2.GetLength(1); n++)
        {
            Console.Write($"{mass2[m, n]} ");
        }
        Console.Write("]");
    Console.WriteLine(" ");
    }
}

Console.WriteLine("i");
int i = int.Parse(Console.ReadLine()); 
Console.WriteLine("j");
int j = int.Parse(Console.ReadLine());
Console.WriteLine("n");
int n = int.Parse(Console.ReadLine());
int[,] mass1 = new int [i,j]; 
int[,] mass2 = new int [j,n];
int[,] mass3 = new int [i,n];
void Multiplication(int[,]mass1, int[,]mass2, int[,]mass3)
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            for (int n = 0; n < mass2.GetLength(1); n++)
            {
               mass3[i,n] +=mass1[i,j]*mass2[j,n]; 
            }
                                   
        }
    }

}
void PrintMultiplication(int [,] mass3)
{
    for (int s = 0; s < mass3.GetLength(0); s++)
    {
        Console.Write("[");
        for (int k = 0; k < mass3.GetLength(1); k++)
        {
             Console.Write($"{mass3[s, k]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }     
}



Console.WriteLine();
Fillmass1(mass1);
Printmass1(mass1);
Console.WriteLine();
Console.WriteLine();
Fillmass2(mass2);
Printmass2(mass2);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Произведение матриц равно");
Multiplication(mass1, mass2, mass3);
PrintMultiplication(mass3);
Console.WriteLine();