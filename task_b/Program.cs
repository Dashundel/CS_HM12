﻿//Наибольшее произведение
/*
Дано N целых чисел. Требуется выбрать из них два таких числа, произведение которых максимально.

Входные данные
Вводится сначала число N - количество чисел в последовательности (2 <  = N <  = 100). 
Далее записана сама последовательность: N целых чисел, по модулю не превышающих 1000.

Выходные данные
Выведите два искомых числа в любом порядке. Если существует несколько различных пар чисел, 
дающих максимальное произведение, то выведите любую из них.
*/

Console.WriteLine("Введи кол-во чисел: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введи последовательность чисел: ");

int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
int max = arr[0] * arr[1];
int iMax1 = 0;
int iMax2 = 1;

for (int i = 0; i < n - 1; i++)
{
	for (int j = i + 1; j < n; j++)
	{
		if(arr[i] * arr[j] > max) 
		{
			max = arr[i] * arr[j];
			iMax1 = i;
			iMax2 = j;
		}			
	}
}	

//System.Console.Write(iMax1, iMax2);
Console.WriteLine(arr[iMax1] + " " + arr[iMax2]);
