/*
    Задача 53. Задайте двумерный массив. Напишите программу, которая меняет первую и последнюю строку менстами
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

int[,] SwapArray(int[,] Array) {
    int First = Array[0, 0];
    int Last = Array[4, 4];
    Array[0, 0] = Last;
    Array[4, 4] = First;
    return Array;
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
    int[,] Swap = SwapArray(Array);
    System.Console.WriteLine();
    PrintArray(Swap);
}

Main();