// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Multiplication (int[,] array, int[,] secondArray)
{             
    int[,] r = new int[array.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
        {    
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                r[i, j] = 0;
                for (int k = 0; k < secondArray.GetLength(0); k++)
                    {
                        r[i, j] += array[i, k] * secondArray[k, j];
                    }
            }
        }
        return r;
}
                 
Console.WriteLine();
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();
FillArrayRandom(secondArray);
PrintArray(secondArray);
Console.WriteLine();
if (array.GetLength(1) == secondArray.GetLength(0))
    {
        int[,] resultArray = Multiplication(array, secondArray);
        Console.WriteLine("Результирующая матрица: ");
        PrintArray(resultArray);
    }
else
    {
        Console.WriteLine("Матрицы нельзя перемножить.");
     }

