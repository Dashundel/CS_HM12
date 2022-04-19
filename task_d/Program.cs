//D. Наименьшее число
/*
Дана последовательность чисел. Найти в ней наименьшее число.

Входные данные
Сначала задано число N - количество чисел в последовательности, а затем N чисел (1 <  = N <  = 100).

Выходные данные
Выведите наименьшее число.
*/

Console.WriteLine("Введи кол-во чисел: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введи последовательность чисел: ");

int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
int min = arr[0];

for (int i = 1; i < n; i++)
	if(arr[i] < min) min = arr[i];		
	
System.Console.Write(min);
