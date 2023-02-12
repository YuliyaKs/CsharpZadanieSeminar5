// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// Метод для создания массива из строки, которую введет пользователь
double[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = double.Parse(nums[i]);
    }
    return res;
}

// Метод для нахождения разницы между максимальным и минимальным элементом массива
double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach(double el in array)
    {
        max = el > max ? el : max;      // находим максимальный элемент
        min = el < min ? el : min;      // находим минимальный элемент
    }
    double difference = max - min;      // находим разницу между максимальным и минимальным элементом
    return difference;
}

Console.Clear();
Console.Write("Введите через пробел вещественные числа с десятичным разделителем - запятая: ");

string elements = Console.ReadLine();       // Получаем строку из вещественных чисел от пользователя

double[] arrayDouble = GetArrayFromString(elements);    // Задаем массив из строки, которую ввел пользователь

Console.WriteLine($"[{String.Join(", ", arrayDouble)}]");      // Вывод массива на экран

Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {DifferenceMaxMin(arrayDouble)}");