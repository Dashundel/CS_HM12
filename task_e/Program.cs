//E. Наибольшее число
/*
Дано N целых чисел. Требуется выбрать из них максимальное число.

Входные данные
Вводится сначала число N - количество чисел в последовательности (1 <  = N <  = 100). 
Далее записана сама последовательность: N целых чисел, по модулю не превышающих 1000.

Выходные данные
Выведите искомое число.
*/

Console.WriteLine("Введи кол-во чисел: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введи последовательность чисел: ");

int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
int max = arr[0];

for (int i = 1; i < n; i++)
	if(arr[i] > max) max = arr[i];		
	
System.Console.Write(max);
