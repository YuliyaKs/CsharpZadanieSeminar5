// Задача 35: Задайте одномерный массив из 123 случайных чисел [0: 1000]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


// Метод для создания массива из случайных чисел
int [] GetArray(int size, int start, int finish)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

// Метод для подсчета элементов массива со значениями из заданного отрезка
int ElementsCount(int[] array, int begin, int end)
{
    int elcount = 0;
    foreach(int el in array)
    {
        elcount += el >= begin && el <= end ? 1 : 0;
    }
    return elcount;
}

Console.Clear();

int[] arraybig = GetArray(123, 0, 1000);    // Задаем массив

Console.WriteLine(String.Join(", ", arraybig));      // Вывод массива на экран

Console.WriteLine($"Количество элементов из отрезка [10, 99] равно {ElementsCount(arraybig, 10, 99)}");
