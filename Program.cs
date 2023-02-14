// 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка







Console.Write("Введите размер m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n:  ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0; 
int control = 1000000;
int lost = 0; 


int[,] arr = new int[m, n];                           // Создание массива
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10);
    }
}



for (int i = 0; i < arr.GetLength(0); i++)               //Вывод массива
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 5}");
        }
        Console.WriteLine();
    }




    for (int i = 0; i < arr.GetLength(0); i++)           // Нахождение минимальной суммы элементов строки
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum+=arr[i, j];
        }
            if (sum < control) 
            {
                control = sum;
            }
        sum =0;
        Console.Write(control);
        Console.WriteLine();
    }


for (int i = 0; i < arr.GetLength(0); i++)                 // Нахождение строки с наименьшей суммой элементов черех известный минимум
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum+=arr[i, j];
            lost = i+1;
        }
        if (sum == control) 
        {
            Console.Write("Строка имеющая наименьшую суммой элементов находится под № " + lost);
        }
        sum = 0;
    }


// Вывод настроенн под обычных смертных, счет сток идет от еденицы )

