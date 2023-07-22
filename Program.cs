/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

using System;

class Program
{
    static void Main()
    {
        // Создаем генератор случайных чисел
        Random random = new Random();

        // Создаем массив случайных положительных трехзначных чисел
        int[] array = new int[4];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // Счетчик четных чисел
        int count = 0;

        // Перебираем элементы массива
        foreach (int num in array)
        {
            // Если число четное (остаток от деления на 2 равен 0), увеличиваем счетчик
            if (num % 2 == 0)
            {
                count++;
            }
        }

        // Выводим результат
        Console.WriteLine("Количество четных чисел в массиве: " + count);
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        // Создаем генератор случайных чисел
        Random random = new Random();

        // Создаем одномерный массив случайных чисел
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100);
        }

        // Переменная для хранения суммы элементов на нечетных позициях
        int sum = 0;

        // Перебираем элементы массива на нечетных позициях и суммируем их
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        // Выводим результат
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    }
}
*/

using System;


class Program
{
    static void Main()
    {
        // Создаем массив вещественных чисел
        double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };

        // Находим минимальный элемент
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        // Находим максимальный элемент
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        // Находим разницу между максимальным и минимальным элементами
        double difference = max - min;

        // Выводим результат
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }
}