//C. Наибольшее произведение(2)
/*
Дано N целых чисел. Требуется выбрать из них три таких числа, произведение которых максимально.

Входные данные
Вводится сначала число N - количество чисел в последовательности (3 <  = N <  = 100). 
Далее записана сама последовательность: N целых чисел, по модулю не превышающих 1000.

Выходные данные
Выведите три искомых числа в любом порядке. Если существует несколько различных троек чисел, 
дающих максимальное произведение, то выведите любую из них.
*/

Console.WriteLine("Введи кол-во чисел: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введи последовательность чисел: ");

int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
int max = arr[0] * arr[1] * arr[2];
int iMax1 = 0;
int iMax2 = 1;
int iMax3 = 2;

for (int i = 0; i < n - 2; i++)
{
	for (int j = i + 1; j < n - 1; j++)
	{
		for (int k = j + 1; k < n; k++)
		{
			if(arr[i] * arr[j] * arr[k] > max) 
			{
				max = arr[i] * arr[j] * arr[k];
				iMax1 = i;
				iMax2 = j;
				iMax3 = k;
			}			
		}			
	}
}	

Console.WriteLine(arr[iMax1] + " " + arr[iMax2] + " " + arr[iMax3]);
