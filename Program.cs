// Задача 1. Определить, какое из двух чисел максимальное
Console.WriteLine("Введите первое число");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2=int.Parse(Console.ReadLine());
if(num1>num2) Console.WriteLine($"Число {num1} больше");
else if(num1<num2) Console.WriteLine($"Число {num2} больше");
    else Console.WriteLine($"Числа равны");
