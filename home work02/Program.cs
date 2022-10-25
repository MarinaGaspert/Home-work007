/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int rows = GetNumber("Введите индекс строки: ");
int colums = GetNumber("Введите индекс столбца: ");
int[,] numbers = new int[6, 5];
FillArray(numbers);
PrintMatrix(numbers);


if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1))
{
    Console.WriteLine(numbers[rows, colums]);
}
else
{
    Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
}
// Заполнение массива рандомными числами от 1 до 9
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
//  Функция вывода массива в терминал
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Функция ввода 
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

