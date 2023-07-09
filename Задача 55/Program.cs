/*
** Задача 55. Задайте двумерный массив.
** Напишите программу, которая заменяет строчки на столбцы.
** В случае, если это не возможно, сообщить пользователю
*/

int[,] GetArray() {
    int[,] Array = new int[5, 5];
    for (int j = 0; j < 5; j++)
    {
        for (int i = 0; i < 5; i++)
        {
            Array[j, i] = new Random().Next(1, 11);
            System.Console.Write(Array[j, i] + " ");
        }
        System.Console.WriteLine();
    } 
    return Array;
}

int[,] SwapLine(int[,] Array) {
    int[,] TempArray = new int[Array.GetLength(0), Array.GetLength(1)];
    for (int j = 0; j < 5; j++)
    {
        for (int i = 0; i < 5; i++)
        {
            TempArray[j, i] = Array[i, j];

        }
    } 
    return TempArray;
}

void PrintArray(int[,] Array) {
    for (int j = 0; j < 5; j++)
    {
        for (int i = 0; i < 5; i++)
        {
            System.Console.Write(Array[j, i] + " ");
        }
        System.Console.WriteLine();
    } 
}

void Main() {
    int[,] Array = GetArray();
    int[,] Swap = SwapLine(Array);
    System.Console.WriteLine();
    PrintArray(Swap);
}

Main();