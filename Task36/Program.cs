//Задача 36: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int [length];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-100, 100);
}
return arr;
}
System.Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArrayWithRandomNumbers(length);
int sum = 0;
Console.WriteLine($"[{string.Join(",", arr)}]");
for(int i = 1; i < arr.Length; i+=2)
{
    sum+= arr[i];
}
Console.Write($"Сумма чисел, стоящих на нечетных позициях: {sum}");