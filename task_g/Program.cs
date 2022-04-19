﻿//G. Линейный поиск
/*
Задана последовательность из N чисел и задано еще одно число, 
необходимо найти позицию этого числа в последовательности или выдать, что такого числа нет

Входные данные
на вход подается в первой строке число N - количество чисел в последовательности, 
в следующей строке написано N чисел - сама последовательность, 
а в последней строке входного файла написано число, которое нужно найти в последовательности

Выходные данные
в выходной поток необходимо выдать, номер этого числа в последовательности или -1 
если заданного числа в последовательности нет
*/

Console.WriteLine("Введи кол-во чисел: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введи последовательность чисел: ");
int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

Console.WriteLine("Введи искомое число: ");
int num = int.Parse(Console.ReadLine());
int iNum = -1;

for (int i = 0; i < n; i++) 
	if(arr[i] == num) iNum = i+1;	//i+1, т.к. в примере нумерация с 1, а не с 0		
	
System.Console.Write(iNum);
