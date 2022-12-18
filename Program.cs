// Задача 1. Определить, какое из двух чисел максимальное
// Console.WriteLine("Введите первое число");
// int num1=int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число");
// int num2=int.Parse(Console.ReadLine()!);
// if(num1>num2) Console.WriteLine($"Число {num1} больше");
// else if(num1<num2) Console.WriteLine($"Число {num2} больше");
//     else Console.WriteLine($"Числа равны");

//Задача 2. Определить максимальное из трех чисел
// Console.WriteLine("Введите первое число");
// int num21=int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число");
// int num22=int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число");
// int num23=int.Parse(Console.ReadLine()!);
// int max=num21;
// if (num22>max) max=num22;
// if (num23>max) max=num23;
// Console.WriteLine($"максимальное число: {max}");

//Задача 3. Проверка, является ли число четным
// Console.WriteLine("Введите число");
// int num31=int.Parse(Console.ReadLine()!);
// if(num31%2==0) Console.WriteLine($"Число {num31} четное");
// else Console.WriteLine($"Число {num31} нечетное");

// Задача 4. Вывод всех четных чисел от 1 до N
Console.WriteLine("Введите число");
int num41=int.Parse(Console.ReadLine()!);
int i=1;
if (num41>0){
    if(num41==1) Console.WriteLine($"Четных чисел в диапазоне от 1 до {num41} нет");
    else {
        i=2;
        while(i<=num41){
            Console.Write($"{i} ");
            i+=2;
        }
    }
}
else{
    i=0;
    while(i>=num41){
        Console.Write($"{i} ");
        i-=2;
        }
}
