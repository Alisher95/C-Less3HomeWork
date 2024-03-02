//Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
int number = new Random().Next(1, 100000);
Console.WriteLine(number);
int[] array = new int[number.ToString().Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = number % 10;
    number /= 10;
}
Console.WriteLine("[{0}]", string.Join(", ", array));
int temp;
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] < array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
Console.WriteLine("[{0}]", string.Join(", ", array));
