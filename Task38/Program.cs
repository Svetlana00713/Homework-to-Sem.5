//Задача 38: 
//Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] FillArrayWithRandomNumbers(int length)
{
    Random rnd = new Random();
    double[] AD = new double[10];
    System.Console.Write("Введите число, означающее нижнюю границу массива: ");
    double start = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите число, означающее верхнюю границу массива: ");
    double end = Convert.ToDouble(Console.ReadLine());
    double value = 0;

    for (int i=0; i<10; i++) 
    {
        value = rnd.NextDouble();
        AD[i] = Math.Round(start + value * (end - start), 2);
    }
return AD;
}
double[] AD = FillArrayWithRandomNumbers(10);
double min = AD[0];
double max = AD[0];
double diff = 0;
for (int i=0; i<10; i++)
    {
        if (AD[i] < min)
            min = AD[i];
        if (AD[i] > max)
            max = AD[i];
            diff = Math.Round((max - min), 2);
    }
Console.WriteLine($"\nAD[{string.Join(";", AD)}]");
System.Console.WriteLine(diff);


