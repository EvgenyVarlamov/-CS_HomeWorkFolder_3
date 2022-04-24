/* Задача 27. Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 => 11
82 => 10
9012 => 12*/

// Способ первый без метода/функции

/*Console.Write("Введите число: ");                  
string? number = Console.ReadLine();
int result = 0;S

for(int i = 0; i < number.Length; i++)
{
    result += Convert.ToInt32(number[i]) - 48;
}

Console.WriteLine($"Сумма цифр числа {number} равна: {result}");*/

// Способ второй с методом/функцией

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());    

int digitSumOfNumber = DigitSumFunction(number);
Console.WriteLine($"Сумма цифр числа {number} равна: {digitSumOfNumber}");

int DigitSumFunction(int digit)     // Метод/функция вывода суммы цифр введённого числа
{
    int index = 0;
    int sum = 0;
    while(digit != 0)
    {
        sum += digit % 10;          // Суммируются остатки деления на 10
        digit = digit / 10;         // Сокращение разрядов до нуля
        index++;
    }
    return sum;    
}