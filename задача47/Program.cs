//задайте двумерный массив размером m*n
//заполненнй случайными вещественными числами
// m=3, n=4
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8, 7,8 -7,1 9

Console.WriteLine("введите количество строк: ");
int m =Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("введите количество столбцов: ");
int n =Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"m={m}, n={n}");
double[,] array = new double[m,n];
CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().NextDouble()*10 -5;
        }
    }
}

void WriteArray (double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double number = Math.Round(array[i,j],1);
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}