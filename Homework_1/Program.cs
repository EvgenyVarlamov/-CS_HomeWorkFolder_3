/* Задача 25. Напишите цикл, который принимает на вход
   два числа (А и В) и вводит число А в степень В.*/

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int numberPow = Convert.ToInt32(Console.ReadLine());

int result = 1;

for(int i = 1; i <= numberPow; i++)
{
    result *= numberA;
}

Console.WriteLine($"{numberA}^{numberPow} = {result}");