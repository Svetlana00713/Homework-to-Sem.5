//Задача 34: 
//Задайте массив, заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int [length];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
}
return arr;
}
System.Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArrayWithRandomNumbers(length);
int count = 0;
Console.WriteLine($"[{string.Join(",", arr)}]");
for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
Console.Write($"Количество четных чисел: {count}");

