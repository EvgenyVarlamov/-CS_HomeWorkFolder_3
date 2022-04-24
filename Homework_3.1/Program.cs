
/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] array = new int[8];                             // Массив

void FillArray(int[] arr)                             // Метод/функция заполнения массива 
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    
}

void PrintAray(int[] arrayInner)                      // Метод/функция вывода массива 
{ 
    int count = arrayInner.Length;
    Console.Write("int[] array = {");
    for(int i = 0; i < count - 1; i++)
    {
        Console.Write($"{arrayInner[i]}, ");          // Вывод элементов массива с запятой
    }
    Console.WriteLine(arrayInner[count - 1] + "}");  // Вывод последнего элемента массива без запятой
    Console.WriteLine();                              // Новая строка
}

Console.WriteLine();                                  // Новая строка
FillArray(array);
Console.Write("Вывод исходного массива: ");
PrintAray(array);