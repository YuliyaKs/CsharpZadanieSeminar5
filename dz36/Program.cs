// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


// Метод для создания массива из случайных чисел
int[] GetArray(int size, int start, int finish)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

// Метод для подсчета суммы элементов, стоящих на нечётных позициях
int SumElementsOddIdx(int[] array)
{
    int oddidxsum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        oddidxsum += i % 2 == 1 ? array[i] : 0;     // складываем элементы с нечетными индексами
    }
    return oddidxsum;
}

Console.Clear();

int[] arrayrondom = GetArray(10, -10, 10);    // Задаем массив, передаем длину массива, начало и конец диапазона элементов

Console.WriteLine(String.Join(", ", arrayrondom));      // Вывод массива на экран

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumElementsOddIdx(arrayrondom)}");