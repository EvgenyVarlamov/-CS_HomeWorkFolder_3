/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Поправка: на семинаре дал добро на заволнение массива рандомными числами. 
В оригинале нужно пользователю ввести строку - ряд чисел через запятую, 
а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)
*/

Console.Write("Введите ряд из восьми чисел через запятую: ");
string? row = Console.ReadLine();                                        // Ввод строки

RowInterpretationToArray(row, ',');                                      // Вызов метода/функции для вывода массива

void RowInterpretationToArray(string text, char symbol)                  // Метод/функция ввода строки и вывода массива
{
    string updateText = String.Empty;                                    // Переменная для обработки введенной строки
    int count = 0;                                                       // Переменная для нескольких операций

    if(text[text.Length - 1] != symbol) text = text + $"{symbol}";       // Добавление запятой в конце строки, если она не добавлена
    
    for(int с = 0; с < text.Length; с++) if(text[с] == symbol) count++;  // Подсчёт размера массива
       
    int[] array = new int[count];                                        // Объявление массива

    count = 0;
    
    Console.Write("int[] array = {");

    for(int i = 0; i < text.Length; i++)                                 // Цикл обработки введенной строки в целочисленный массив и его вывод
    {
        if(text[i] != symbol)
        {
            updateText = updateText + text[i];                           // Склейка символов между запятыми в будущий элемент массива
        }
        else
        {
            int valueTemporary = Convert.ToInt32(updateText);
            array[count] = valueTemporary;                               // Заполнение массива элементами
            updateText = String.Empty;            
            Console.Write(array[count]);
            if(count < array.Length - 1) Console.Write(", ");
            count++;
        } 
    }
    Console.WriteLine("}");
}