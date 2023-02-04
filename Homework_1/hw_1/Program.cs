//Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
//----------------------------------------------------------------
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if(a > b)
// {
//     Console.WriteLine("Наибольшее число: " + a);
//     Console.WriteLine("Наименьшее число: " + b);
// }
// else if(b > a)
// {
//     Console.WriteLine("Наибольшее Число: " + b);
//     Console.WriteLine("Наименьшее число: " + a);
// }
// else if(b == a)
//     Console.WriteLine("Введённые числа равны");
//
//--------------------------------------------------------
// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.
// -------------------------------------------------------
// Console.Write("Введите первое число: ");
// int FirstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int SecondNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int ThirdNum = Convert.ToInt32(Console.ReadLine());
// bool Equality = (FirstNum == SecondNum) && (ThirdNum == SecondNum);
// int max = FirstNum;
// if (SecondNum > FirstNum)
//     max = SecondNum;
// if (ThirdNum > max)
//     max = ThirdNum;
// if (Equality == true)
//     Console.WriteLine("Введённые вами числа равны между собой");
// else
//     Console.WriteLine("Наибольшее число: " + max);
// 
//------------------------------------------------------------------
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//-------------------------------------------------------------------
// Console.Write("Введите ваше число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int mod = num % 2;
// if (mod == 0)
// Console.WriteLine("Число чётное");
// else
// Console.WriteLine("Число нечётное");
//-------------------------------------------------------------------
//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//-------------------------------------------------------------------
// Console.Write("Input your number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int curr = 1;
//
// while (curr <= n)
// {
//     if ((curr % 2) == 0)
//         Console.Write(curr + " ");
//     curr++;
// }