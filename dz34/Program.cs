// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// Метод для создания массива из случайных чисел
int[] GetArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

// Метод для подсчета чётных чисел в массиве
int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        count += el % 2 == 0 ? 1 : 0;   // складываем количество четных чисел
    }
    return count;
}

Console.Clear();

Console.WriteLine("Введите длину массива: ");

int arraylength = int.Parse(Console.ReadLine());    // Получаем от пользователя длину массива

int[] arraytriple = GetArray(arraylength);    // Задаем массив, передаем длину массива

Console.WriteLine(String.Join(", ", arraytriple));      // Вывод массива на экран

Console.WriteLine($"Количество чётных чисел в массиве равно {CountEvenNumbers(arraytriple)}");