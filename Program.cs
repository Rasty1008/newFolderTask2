/* Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
using static System.Console;
Clear();
WriteLine("введите количество строк");
int n = Convert.ToInt32(ReadLine());
WriteLine("введите количество столбцов");
int m = Convert.ToInt32(ReadLine());
int[,] numbers = new int[n,m];
GetArrayRandomNumbers(numbers);
GetArrayAvarage(numbers);
PrintArray(numbers);


void GetArrayAvarage(int[,] parameters) {
    for(int i = 0; i < parameters.GetLength(0); i++) {
        double avarage = 0;
        for(int j = 0; j < parameters.GetLength(1); j++) {
            avarage = (avarage + parameters[i,j]);
        }

        avarage /= parameters.GetLength(0);
        Write(avarage + "; ");
          
    }
    WriteLine();  
    
}

void GetArrayRandomNumbers(int[,] parameters) {
    for(int i = 0; i < parameters.GetLength(0); i++) {
        for(int j = 0; j < parameters.GetLength(1); j++) {
            parameters[i,j] = new Random().Next(0 ,10);
        }
    }
}

void PrintArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++) {
            Write(array[i, j] + " ");
        }
        Write("]");
        WriteLine("");
    }
}