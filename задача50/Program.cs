//напишите программу которая на вход пинимает позиции
//элемента в двухмерном массиве и возвращает значение этого элемента или же указание
//что такого элемента нет
//1 4 7 2
//5 9 2 3 
//8 4 2 4 -> 17 такого элемента нет


// Random r = new Random();
// r.Next(1,20);
// Random.Shared.Next();

int[,] CreateDoubleArrayTypeInt(int m, int n)
{
    int[,] doubleArray = new int[m,n];
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
    
            doubleArray[i,j] = Random.Shared.Next(0,10); 
    }
    return doubleArray;
}
void PrintDoubleArrayTypeInt(int[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j= 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write(doubleArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateDoubleArrayTypeInt(3,4);
PrintDoubleArrayTypeInt(matrix);

int[] GetResult(int[,] matrix, int row, int col)
{
    int[] result = new int[2];
    if(row>=matrix.GetLength(0) || col>=matrix.GetLength(1))
    {
        return new int[]{-1,0};
    }
else
{
    return new int[] {1,matrix[row,col]};
}
    
    return result;
}

int[] res = GetResult(matrix,2,1);
Console.WriteLine(res[0]);
if(res[0] == -1)
{
    Console.WriteLine("элемента нет");
}
else
{
   Console.WriteLine("элемент есть"); 
   Console.WriteLine(res[1]);
}