//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива. 

double[] array = new double[10];
double[] array2 = new double[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * (10.00 - 0) + 0;
    array2[i] = Math.Round(array[i], 2);
    //Console.WriteLine(array[i]);
    //Console.WriteLine(array2);
}
Console.Write("[{0}]", string.Join(", ", array2));
Console.Write(" =>  ");
double min = array2[0];
double max = array2[0];
foreach (double item in array2)
{
    if (item < min)
        min = item;
    if (item > max) max = item;
}
Console.WriteLine($"min={min}, max={max}");
Console.WriteLine($"difference={max - min}");