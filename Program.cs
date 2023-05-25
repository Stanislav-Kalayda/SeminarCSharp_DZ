// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число");
// int num=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int num2=Convert.ToInt32(Console.ReadLine());
// int Max=num;
// int Min=num2;

// if (num>num2)
// {
//     Max=num;
//     Min=num2;
// }
// else
// {
//     Max=num2;
//     Min=num;
// }

// Console.Write("Максимальное число = ");
// Console.WriteLine(Max);
// Console.Write("Минимальное число = ");
// Console.WriteLine(Min);

// ---------------------------------------------------------------------------------------------------------------------------
// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// Console.WriteLine("Введите первое число");
// int num=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int num2=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число");
// int num3=Convert.ToInt32(Console.ReadLine());
// int Max=num;


// if (num2 > Max)
// {
// Max = num2;
// }

// if (num3 > Max)
// {
// Max = num3;
// }

// Console.Write("Максимальное число = ");
// Console.WriteLine(Max);

// ----------------------------------------------------------------------

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());

// if( num % 2 == 0)
// {
//     Console.WriteLine("Является четным");
// }
// else
// {
//     Console.WriteLine("Не является четным");
// }

// --------------------------------------------------------------------------------

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int negNumber = 2;

// if(num > 1)
// {
// while(negNumber <= num)
// {
// Console.WriteLine(negNumber + " ");
// negNumber = negNumber + 2;
// }
// }