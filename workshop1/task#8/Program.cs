﻿//Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2; // т.к. в задании сказано показать все четные числа, а 1 нечетное число, то сразу пишу 2.

Console.WriteLine($"Четные числа от 0 до {number} включительно:"); 
while (count <= number) // знак = для того, чтобы вывести и само число, если оно четное.
{
    Console.Write(count + " "); 
    count = count + 2;   
}
