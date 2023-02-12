// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.


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

// Метод для создания нового массива из произведений чисел старого массива
int[] NewMultArray(int[] array)
{
    if (array.Length % 2 == 0)      // создаем новый массив, если количество элементов старого массива чётное
    { 
        int[] newarray = new int[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            newarray[i] = array[i] * array[array.Length - 1 - i];   // перемножаем пары чисел
        }
        return newarray;
    }
    else        // создаем новый массив, если количество элементов старого массива нечётное
    {
        int[] newarray = new int[array.Length / 2 + 1];
        for (int i = 0; i < array.Length / 2; i++)
        {
            newarray[i] = array[i] * array[array.Length - 1 - i];   // перемножаем пары чисел
        }
        newarray[newarray.Length - 1] = array[array.Length / 2];    // добавляем средний элемент из старого массива
        return newarray;
    }
}

Console.Clear();

int[] arrayold = GetArray(5, 1, 10);    // Задаем массив, передаем длину массива, начало и конец диапазона элементов

Console.WriteLine(String.Join(", ", arrayold));      // Вывод массива на экран

int[] arraynew = NewMultArray(arrayold);    // Задаем новый массив из произведений чисел старого массива

Console.WriteLine(String.Join(", ", arraynew));      // Вывод нового массива на экран